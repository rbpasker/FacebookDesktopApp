using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    /// <summary>
    /// Delagate PostStatusHandler to handle album downloads
    /// </summary>
    /// <param name="statusToPost">Status to post to friends</param>
    /// <param name="friendsToPostTo">Friends to post the status to</param>
    /// <param name="choosedFriendToPostTo">Specific chosen friend to post tp</param>
    public delegate void PostStatusHandler(string statusToPost, string friendsToPostTo, int choosedFriendToPostTo);

    /// <summary>    
    /// Friends Manager Form
    /// </summary>
    public partial class FormFriendsManager : Form
    {
        #region Constants

        /// <summary>
        /// Const to represetns the combo box selection - "All Friends"
        /// </summary>
        public const string k_PostToAll = "All Friends";

        /// <summary>
        /// Const to represetns the combo box selection - "Selected Friend"
        /// </summary>
        public const string k_PostToSelected = "Selected Friend";

        /// <summary>
        /// Const to represetns the combo box selection - "Friends With Birthday"
        /// </summary>
        public const string k_PostToBirthday = "Friends With Birthday";

        #endregion

        #region Data Members

        private const int k_null = -1;
        private bool m_IsInitialized = false;
        private User m_LoggedInUser;
        private List<User> m_LoggedInUserFriends;

        #endregion

        #region Properties

        /// <summary>
        /// Is the Friends Manager alraedy been initialized
        /// </summary>
        /// <returns>True - Friends Manager is initialized
        /// False - Friends Manager is not initialized</returns>
        public bool IsInitialized
        {
            get { return m_IsInitialized; }
            set { m_IsInitialized = value; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Friends Manager form constructor
        /// </summary>
        public FormFriendsManager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialization of the FormFriendsManager form
        /// </summary>
        /// <param name="i_LoggedInUser">The user logged in to Facebook</param>
        /// <param name="i_LoggedInUserFriends">The friends of the user that is currently logged in to Facebook</param>
        public void Init(User i_LoggedInUser, List<User> i_LoggedInUserFriends)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_LoggedInUserFriends = i_LoggedInUserFriends;
            loadFriendsProfiePictures();
            this.m_IsInitialized = true;
        }

        private void loadFriendsProfiePictures()
        {
            WebClient webClient = new WebClient();

            foreach (User friend in m_LoggedInUserFriends)
            {
                if (!(friend.PictureNormalURL == null))
                {
                    imageListFriends.Images.Add(friend.Name, Image.FromStream(new MemoryStream(webClient.DownloadData(friend.PictureNormalURL))));
                }
            }

            this.listViewFriendsList.View = View.LargeIcon;
            this.imageListFriends.ImageSize = new Size(40, 40);
            this.listViewFriendsList.LargeImageList = this.imageListFriends;

            for (int j = 0; j < this.imageListFriends.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                this.listViewFriendsList.Items.Add(item);
            }
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            FacebookAppLogic appLogic = FacebookAppLogic.GetFacebookAppLogicInstance;
            if (isAllDataOK())
            {
                bool result; 
                switch (comboBoxPostTo.SelectedItem.ToString())
                {
                    case k_PostToAll:
                        result = appLogic.PostStatus(this.textBoxInputStatus.Text, new PostToAllStrategy());                        
                        break;
                    case k_PostToBirthday:
                        result = appLogic.PostStatus(this.textBoxInputStatus.Text, new PostToBirthdayStrategy());                        
                        break;
                    case k_PostToSelected:
                        result = appLogic.PostStatus(this.textBoxInputStatus.Text, new PostToSelectedStrategy() { FriendToPostTo = listViewFriendsList.SelectedIndices[0] });                        
                        break;    
                    default: 
                        result = false;
                        break;
                }

                if (result)
                {
                    MessageBox.Show("Post completed successfully");
                }
                else
                {
                    MessageBox.Show("Post completed with errors");
                }
            }
            else
            {
                MessageBox.Show("Missing details in order to complete the post");
            }
        }

        private bool isAllDataOK()
        {
            bool valueToReturn = true;
            if (textBoxInputStatus.Text.Equals(string.Empty) || comboBoxPostTo.SelectedItem == null)
            {
                valueToReturn = false;
            }

            return valueToReturn;
        }

        /// <summary>
        /// Event PostStatusHandler to post statuses on users wall
        /// </summary>
        public event PostStatusHandler PostStatus;

        private void postStatus(string i_StatusToPost, string i_FriendsToPostTo, int i_FriendstoPostToList)
        {
            PostStatus(i_StatusToPost, i_FriendsToPostTo, i_FriendstoPostToList);
        }
    }

    #endregion
}
