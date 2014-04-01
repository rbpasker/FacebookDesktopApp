using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    /// <summary>
    /// Delagate DownloadHandler to handle album downloads
    /// </summary>
    /// <param name="albumIndexToDownload">Index of the album to download</param>
    /// <param name="pathToSaveAlbumIn">Destination path for the downloaded album</param>
    public delegate void DownloadHandler(int albumIndexToDownload, string pathToSaveAlbumIn);

    /// <summary>
    /// Album Manager Form
    /// </summary>
    public partial class FormAlbumManager : Form
    {     
        #region Data Members

        private bool m_IsInitialized = false;     
        private User m_LoggedInUser;

        #endregion

        #region Properties

        /// <summary>
        /// Is the Album Manager alraedy been initialized
        /// </summary>
        /// <returns>True - Album Manager is initialized
        /// False - Album Manager is not initialized</returns>
        public bool IsInitialized
        {
            get { return m_IsInitialized; }
            set { m_IsInitialized = value; }
        }
        
        #endregion

        #region Methods

        /// <summary>
        /// Album Manager form constructor
        /// </summary>
        public FormAlbumManager()
        {
            Application.EnableVisualStyles();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            InitializeComponent();
        }

        /// <summary>
        /// Initialization of the FormAlbumManager form
        /// </summary>
        /// <param name="i_LoggedInUser">The user logged in to Facebook</param>
        public void Init(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            loadAlbums();
            this.m_IsInitialized = true;
        }
        
        /// <summary>
        /// Event DownloadHandler to download album
        /// </summary>
        public event DownloadHandler DownloadAlbum;

        private void downloadAlbum(int i_SelectedAlbumToDownload, string i_PathToSaveAlbumIn)
        {
            DownloadAlbum(i_SelectedAlbumToDownload, i_PathToSaveAlbumIn);  
        }

        private void listViewAlbumList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewAlbumList.SelectedItems.Count > 0)
            {
                this.labelAlbumNameToDownload.Text = m_LoggedInUser.Albums[this.listViewAlbumList.SelectedIndices[0]].Name;
            }
        }

        private void loadAlbums()
        {
            WebClient webClient = new WebClient();

            foreach (var album in m_LoggedInUser.Albums)
            {
                if (!(album.CoverPhotoThumbURL == null))
                {
                    imageListAlbumImages.Images.Add(album.Name, Image.FromStream(new MemoryStream(webClient.DownloadData(album.CoverPhotoThumbURL))));
                }
            }
                      
            this.listViewAlbumList.View = View.LargeIcon;
            this.imageListAlbumImages.ImageSize = new Size(75, 75);
            this.listViewAlbumList.LargeImageList = this.imageListAlbumImages;

            for (int j = 0; j < this.imageListAlbumImages.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                this.listViewAlbumList.Items.Add(item);
            }
        }       

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();

            folderDlg.ShowNewFolderButton = true;

            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBoxDownloadPath.Text = folderDlg.SelectedPath;
                this.buttonDownload.Enabled = true;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
            else
            {
                this.buttonDownload.Enabled = false;
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if (this.listViewAlbumList.SelectedItems.Count > 0)
            {   
                downloadAlbum(this.listViewAlbumList.SelectedIndices[0], this.textBoxDownloadPath.Text);
            }
        }

        #endregion 
    }
}
