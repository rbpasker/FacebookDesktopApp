using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Net;
using System.IO;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FacebookApp;
using Facebook;

namespace FacebookApp
{
    /// <summary>
    /// Facebook Application Logic class.
    /// Being used as a singleton.
    /// </summary>
    public sealed class FacebookAppLogic
    {
        #region Enums and Constants

        private const string k_AppID = ""; //AppID removed

        #endregion

        #region Data mambers

        private static FacebookAppLogic s_FacebookAppLogicInstance = null;
        private static object s_LockObject = new object();
        private string[] m_Permissions = new string[] 
        {
            "user_about_me",
            "user_birthday",
            "user_hometown",
            "user_photos",
            "user_relationships",
            "user_status",
            "email",
            "friends_status",
            "friends_about_me",
            "publish_stream",
            "friends_relationship_details",
            "friends_relationships",
            "offline_access"
        };

        private User m_LoggedInUser;
        private LoginResult m_LoginResult;
        private List<User> m_LoggedInUserFriends;
        private bool m_LoggedIn = false;                
                   
        #endregion

        #region Properties and Events

        /// <summary>
        /// FacebookAppLogic property. Enables us to control the number of instances that are being created. 
        /// Enables us to use this object as a singleton. 
        /// </summary>
        /// <returs>FacebookAppLogin instance</returs>
        public static FacebookAppLogic GetFacebookAppLogicInstance
        {
            get
            {
                if (s_FacebookAppLogicInstance == null)
                {
                    lock (s_LockObject)
                    {
                        if (s_FacebookAppLogicInstance == null)
                        {
                            s_FacebookAppLogicInstance = new FacebookAppLogic();
                        }
                    }
                }

                return s_FacebookAppLogicInstance;
            }
        }

        /// <summary>
        /// Logged in user friends
        /// </summary>
        /// <returns>List of the logged in user friends</returns>
        public List<User> LoggedInUserFriends
        {
            get { return m_LoggedInUserFriends; }
            set { m_LoggedInUserFriends = value; }
        }

        /// <summary>
        /// Application ID property
        /// </summary>
        /// <returns>String of Application ID</returns>
        public string K_AppID
        {
            get { return k_AppID; }
        }

        /// <summary>
        /// Permissions array property 
        /// </summary>
        /// <returns>string[] of required permissions</returns>
        public string[] Permissions
        {
            get { return m_Permissions; }
        }

        /// <summary>
        /// LoggedIn User property
        /// </summary>
        /// <returns>User type of the logged in user</returns>
        public User LoggedInUser
        {
            get { return m_LoggedInUser; }
        }

        /// <summary>
        /// Propety of the user is logged in or not
        /// </summary>
        public bool LoggedIn
        {
            get { return m_LoggedIn; }
        }       

        /// <summary>
        /// Delegate of LoginChanged
        /// </summary>
        /// <param name="state">State of login to Facebook</param>
        public delegate void LoginChanged(bool state);
        
        /// <summary>
        /// Event of OnLoginChanged - Envokes when login to Facebook state changes
        /// </summary>
        public event LoginChanged OnLoginChanged;

        #endregion

        #region Methods

        /// <summary>
        /// Private FacebookAppLogic constructor 
        /// </summary>
        private FacebookAppLogic()
        {
        }

        /// <summary>
        /// Login To Facebook
        /// Also saves the logged in user friends
        /// </summary>
        /// <returns>True - The user was successfully logged in
        /// False - The login failed</returns>
        internal bool LoginToFacebook()
        {
            if (m_LoggedIn == true)
            {
                return m_LoggedIn;
            }

            m_LoginResult = FacebookService.Login(k_AppID, m_Permissions);

            if (isLoggedIn(m_LoginResult)) 
            {
                LoggedInUserFriends = new List<User>(FacebookService.GetCollection<UserWithBirthday>("Friends", "me", "name, birthday, gender, relationship_status", 25));
                m_LoggedIn = true;

                if (OnLoginChanged != null)
                {
                    OnLoginChanged(this.LoggedIn);
                }
            }

            return m_LoggedIn;
        }

        /// <summary>
        /// Logout the user from Facebook
        /// </summary>
        internal void LogoutFromFacebook()
        {            
            m_LoggedInUser = null;
            m_LoggedIn = false;

            if (OnLoginChanged != null)
            {
                OnLoginChanged(this.LoggedIn);
            }
        }

        private bool isLoggedIn(LoginResult i_LoginResult)
        {
 	        bool loggedIn = false;

            if (!string.IsNullOrEmpty(i_LoginResult.AccessToken) && string.IsNullOrEmpty(i_LoginResult.ErrorMessage))
            {
                loggedIn = true;
                m_LoggedInUser = i_LoginResult.LoggedInUser;
            }

            return loggedIn;
        }
               
        /// <summary>
        /// Downloading an album from Facebook
        /// </summary>
        /// <param name="i_AlbumIndexToDownload">Index of requested album to download</param>
        /// <param name="i_PathToSaveAlbumIn">Desired path for saved album</param>
        /// <param name="i_AlbumName">Album Name</param>
        /// <returns>True - Album was successfully downloaded
        /// False - Album download failed</returns>
        public bool DownloadAlbum(int i_AlbumIndexToDownload, string i_PathToSaveAlbumIn, string i_AlbumName)
        {
            bool valueToReturn = true;

            for (int i = 0; i < m_LoggedInUser.Albums[i_AlbumIndexToDownload].Photos.Count; i++)
			{                
                try
                {
                    Image imageToDownload = Image.FromStream((new MemoryStream(new WebClient().DownloadData(m_LoggedInUser.Albums[i_AlbumIndexToDownload].Photos[i].Images[0].Source))));                    
                    imageToDownload.Save(i_PathToSaveAlbumIn + "\\photo" + i + ".jpg");
                }
                catch (ArgumentNullException)
                {
                    valueToReturn = false;
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    valueToReturn = false;
                }
			}

            return valueToReturn;   
        }

        /// <summary>
        /// Returns the album name by index
        /// </summary>
        /// <param name="i_AlbumIndex">Album Index</param>
        /// <returns>string - Album name</returns>
        internal string getAlbumNameByIndex(int i_AlbumIndex)
        {
            return m_LoggedInUser.Albums[i_AlbumIndex].Name;
        }

        /// <summary>
        /// Post Status method using the Strategy pattern
        /// </summary>
        /// <param name="i_StatusToPost">Status to post</param>
        /// <param name="i_PostStrategy">Posting Strategy</param>
        /// <returns></returns>
        internal bool PostStatus(string i_StatusToPost, IPostStrategy i_PostStrategy)
        {
            // Executing the strategy method
            return i_PostStrategy.excecute(m_LoggedInUserFriends, i_StatusToPost);
        }

        /// <summary>
        /// Post Status method to post on specific User
        /// </summary>
        /// <param name="i_StatusToPost">Status to post</param>
        /// <param name="i_UserToPostIn">User to post in</param>
        /// <returns>success or failure</returns>
        public bool PostStatusOnUser(string i_StatusToPost, User i_UserToPostIn)
        {
            bool valueToReturn = true;
            try
            {
                i_UserToPostIn.PostStatus(i_StatusToPost);
            }
            catch (FacebookOAuthException OAuthException)
            {
                MessageBox.Show(OAuthException.Source + ": " + OAuthException.Message);
                valueToReturn = false;
            }

            return valueToReturn;
        }

        #endregion
    }
}
