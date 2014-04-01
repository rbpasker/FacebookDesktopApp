using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    /// <summary>
    /// Facebook application Status Manager form
    /// </summary>
    public partial class FormStatusManager : Form
    {
        #region Data Members

        private bool m_IsInitialized = false;
        private FormStatus m_FormStatus = new FormStatus();

        #endregion

        #region Properties

        /// <summary>
        /// Is the Status Manager alraedy been initialized
        /// </summary>
        /// <returns>True - Status Manager is initialized
        /// False - Status Manager is not initialized</returns>
        public bool IsInitialized
        {
            get { return m_IsInitialized; }
            set { m_IsInitialized = value; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Status Manager form constructor
        /// </summary>
        public FormStatusManager()
        {
            Application.EnableVisualStyles();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            InitializeComponent();
        }

        /// <summary>
        /// Initializtion of the Status Manager form
        /// </summary>
        /// <param name="i_LoggedInUser">The facebook logged in user</param>
        internal void Init(User i_LoggedInUser)
        {
            listBoxFriendsList.DisplayMember = "Name";
            listBoxStatusSearchResult.DisplayMember = "Message";
            
            Thread initFriendsList = new Thread(new ThreadStart(() => 
            {
                // The following line will make the friends list fetch
                int FriendsCount = i_LoggedInUser.Friends.Count;                                                                                                     
            
                listBoxFriendsList.Invoke(new Action(() =>                     
                {
                    foreach (User friend in i_LoggedInUser.Friends)
                    {
                        listBoxFriendsList.Items.Add(friend);
                    }
                }));
            }));
            initFriendsList.SetApartmentState(ApartmentState.STA);
            initFriendsList.Start();                

            this.m_IsInitialized = true;
        }

        private void buttonSearchAll_Click(object sender, EventArgs e)
        {
            listBoxStatusSearchResult.Items.Clear();

            if (string.IsNullOrEmpty(textBoxStatusSearch.Text))
            {
                MessageBox.Show("Status search is empty");
            }
            else
            {
                foreach (User friend in listBoxFriendsList.Items)
                {
                    searchInDifferentThread(friend);
                }
            }
        }

        private void buttonSearchSelected_Click(object sender, EventArgs e)
        {
            listBoxStatusSearchResult.Items.Clear();

            if (string.IsNullOrEmpty(textBoxStatusSearch.Text))
            {
                MessageBox.Show("Status search is empty");
            }
            else
            {
                foreach (User friend in listBoxFriendsList.SelectedItems)
                {
                    searchInDifferentThread(friend);
                }
            }
        }

        private void searchInDifferentThread(User i_friend)
        {
            Thread StatusSeachThread = new Thread(new ThreadStart(() =>
            {
                foreach (Status status in i_friend.Statuses)
                {
                    if (!string.IsNullOrEmpty(status.Message))
                    {
                        if (status.Message.Contains(textBoxStatusSearch.Text))
                        {
                            listBoxFriendsList.Invoke(new Action(() =>
                            {
                                listBoxStatusSearchResult.Items.Add(status);
                            }));
                        }
                    }
                }
            }));
            StatusSeachThread.SetApartmentState(ApartmentState.STA);
            StatusSeachThread.Start();
        }

        private void listBoxStatusSearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayStatusInfo();
        }

        private void displayStatusInfo()
        {
            if (listBoxStatusSearchResult.SelectedItems.Count == 1)
            {
                Status selectedStatus = listBoxStatusSearchResult.SelectedItem as Status;
                User statusUser = selectedStatus.From;
                m_FormStatus.Init(selectedStatus, statusUser);
                m_FormStatus.ShowDialog();           
            }
        }

        #endregion
    }
}
