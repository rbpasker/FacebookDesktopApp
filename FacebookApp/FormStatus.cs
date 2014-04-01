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
    /// Facebook application status form
    /// </summary>
    public partial class FormStatus : Form
    {
        #region Methods

        /// <summary>
        /// Status form constructor
        /// </summary>
        public FormStatus()
        {
            Application.EnableVisualStyles();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            InitializeComponent();
        }

        /// <summary>
        /// Initizalization of the status form
        /// </summary>
        /// <param name="i_Status">Status type object</param>
        /// <param name="i_FromUser">The user who posted the status</param>
        public void Init(Status i_Status, User i_FromUser)
        {
            this.pictureBoxUserPicture.LoadAsync(i_FromUser.PictureNormalURL);
            this.labelUsername.Text = i_FromUser.Name;
            this.labelDate.Text = "Date: " + i_Status.UpdateTime.Value.ToString();
            this.textBoxStatusMessage.Text = i_Status.Message;
            this.labelLikes.Text = "Likes: " + i_Status.LikedBy.Count;
        }

        #endregion
    }
}