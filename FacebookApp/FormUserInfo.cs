using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Facebook;

namespace FacebookApp
{
    /// <summary>
    /// Facebook user info form
    /// </summary>
    public partial class FormUserInfo : Form
    {
        #region Data Members

        private bool m_IsInitialized = false;
        private User m_LoggedUser;

        #endregion

        #region Properties

        /// <summary>
        /// Is the User Info form initialized
        /// </summary>
        /// <returns>True - Form initialized
        /// False - Form was not initialized</returns>
        public bool IsInitialized
        {
            get { return m_IsInitialized; }
            set { m_IsInitialized = value; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// User Info constructor
        /// </summary>
        public FormUserInfo()
        {
            Application.EnableVisualStyles();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            InitializeComponent();
        }

        /// <summary>
        /// Initialization of the User Info form
        /// </summary>
        /// <param name="i_LoggedInUser">Facebook logged in User</param>
        internal void Init(User i_LoggedInUser)
        {
            this.m_LoggedUser = i_LoggedInUser;
            this.Text = m_LoggedUser.Name;
            this.picture_UserPicture.LoadAsync(m_LoggedUser.PictureNormalURL);                  
            this.labelUserName.Text = m_LoggedUser.Name;
            this.labelBirthdayResult.Text = m_LoggedUser.Birthday;
            this.labelHometownResult.Text = m_LoggedUser.Hometown.Name;
            this.labelEmailResult.Text = m_LoggedUser.Email;
            this.labelSexResult.Text = m_LoggedUser.Gender.Value.ToString();
            this.labelReligionResult.Text = m_LoggedUser.Religion;                        

            if (m_LoggedUser.RelationshipStatus.HasValue)
            {
                User.eRelationshipStatus RelationshipStatus = m_LoggedUser.RelationshipStatus.Value;
                this.labelRelationshipResult.Text = RelationshipStatus.ToString();
            }  
            
            this.m_IsInitialized = true;
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty(textBoxStatus.Text))
            {
                MessageBox.Show("Status is empty");
            }
            else
            {
                if (postStatus(textBoxStatus.Text, m_LoggedUser))
                {
                    textBoxStatus.Clear();
                }
            }
        }

        /// <summary>
        /// The method is being used in order to post status on a specific user wall
        /// </summary>
        /// <param name="i_StatusToPost">The status text to post</param>
        /// <param name="i_UserToPostIn">The user to post the status to</param>
        /// <returns></returns>
        public bool postStatus(string i_StatusToPost, User i_UserToPostIn)
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
