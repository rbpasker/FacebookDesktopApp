using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    /// <summary>
    /// Facebook Application Fashboard form
    /// </summary>
     public partial class FormDashboard : Form
    {
        #region Enums and Constants

        private const bool k_Enable = true;
        private const bool k_Disable = false;        

        #endregion

        #region Data Members

        private FacebookAppLogic m_FacebookLogic = FacebookAppLogic.GetFacebookAppLogicInstance;
        private FormUserInfo m_FormUserInfo = new FormUserInfo();
        private FormStatusManager m_FormStatusManager = new FormStatusManager();
        private FormAlbumManager m_FormAlbumManager = new FormAlbumManager();
        private FormAbout m_FormAbout = new FormAbout();
        private FormFriendsManager m_FormFriendsManager = new FormFriendsManager();
        private FacebookSmartLogin m_smartLogin = new FacebookSmartLogin();

        #endregion

        #region Methods
        
        /// <summary>
        /// Facebook Application Dashboard constructor
        /// </summary>
        public FormDashboard()
        {
            Application.EnableVisualStyles();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            InitializeComponent();
            init();
        }            
        
        private void init()
        {
            toolTip1.SetToolTip(buttonAlbum, "Album Manager");
            toolTip2.SetToolTip(buttonLogin, "Login");
            toolTip3.SetToolTip(buttonStatus, "Status Manager");
            toolTip4.SetToolTip(buttonInfo, "Info Manager");
            toolTip5.SetToolTip(buttonLogout, "Logout");
            toolTip6.SetToolTip(buttonAbout, "About");
            toolTip7.SetToolTip(buttonFriends, "Friends Manager");
            
            // ButtonObserver
            this.m_FacebookLogic.OnLoginChanged += this.buttonAlbum.notify;
            this.m_FacebookLogic.OnLoginChanged += this.buttonFriends.notify;
            this.m_FacebookLogic.OnLoginChanged += this.buttonInfo.notify;
            this.m_FacebookLogic.OnLoginChanged += this.buttonLogout.notify;
            this.m_FacebookLogic.OnLoginChanged += this.buttonStatus.notify;
            
            // SmartLogin
            this.m_FacebookLogic.OnLoginChanged += this.m_smartLogin.notify;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (m_FacebookLogic.LoginToFacebook())
            {
                buttonLogin.Enabled = false;                          
            }
        }              

        private void buttonAlbum_Click(object sender, EventArgs e)
        {
            if (!m_FormAlbumManager.IsInitialized)
            {
                m_FormAlbumManager.Init(m_FacebookLogic.LoggedInUser);
            }

            m_FormAlbumManager.DownloadAlbum += new DownloadHandler(downloadAlbum);
            this.m_FormAlbumManager.ShowDialog();
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            if (!m_FormFriendsManager.IsInitialized)
            {
                m_FormFriendsManager.Init(m_FacebookLogic.LoggedInUser, m_FacebookLogic.LoggedInUserFriends);
            }

            m_FormFriendsManager.PostStatus += new PostStatusHandler(postStatus);
            this.m_FormFriendsManager.ShowDialog();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (!m_FormUserInfo.IsInitialized)
            {
                m_FormUserInfo.Init(m_FacebookLogic.LoggedInUser);
            }

            m_FormUserInfo.ShowDialog();            
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            if (!m_FormStatusManager.IsInitialized)
            {
                m_FormStatusManager.Init(m_FacebookLogic.LoggedInUser);
            }
            
            m_FormStatusManager.ShowDialog();              
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            m_FormAbout.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_FacebookLogic.LogoutFromFacebook();
            buttonLogin.Enabled = true;           
        }

        private void downloadAlbum(int i_AlbumIndexToDownload, string i_PathToSaveAlbumIn)
        {
            bool albumDownloadResult = true;
            string albumToDownloadName = m_FacebookLogic.getAlbumNameByIndex(i_AlbumIndexToDownload);
            albumDownloadResult = m_FacebookLogic.DownloadAlbum(i_AlbumIndexToDownload, i_PathToSaveAlbumIn, albumToDownloadName);
            if (albumDownloadResult)
            {
                MessageBox.Show("Download completed succefully");
            }
            else
            {
                MessageBox.Show("Failed to download album " + albumToDownloadName);
            }
        }

        private void postStatus(string i_StatusToPost, string i_FriendsToPostTo, int i_FriendstoPostTo)
        {
            bool postStatusResult; 
            m_FormFriendsManager.PostStatus  += new PostStatusHandler(postStatus);
            postStatusResult = m_FacebookLogic.PostStatus(i_StatusToPost, new PostToSelectedStrategy { FriendToPostTo = i_FriendstoPostTo });
            if (postStatusResult)
            {
                MessageBox.Show("Post status completed");
            }
            else
            {
                MessageBox.Show("Post status failed");
            }
        }

        #endregion
    }
}
