namespace FacebookApp
{
    public partial class FormAlbumManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlbumManager));
            this.labelAlbums = new System.Windows.Forms.Label();
            this.listViewAlbumList = new System.Windows.Forms.ListView();
            this.imageListAlbumImages = new System.Windows.Forms.ImageList(this.components);
            this.buttonDownload = new System.Windows.Forms.Button();
            this.textBoxDownloadPath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelDownloadTo = new System.Windows.Forms.Label();
            this.labelAlbumNameToDownload = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAlbums
            // 
            this.labelAlbums.AutoSize = true;
            this.labelAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAlbums.Location = new System.Drawing.Point(13, 13);
            this.labelAlbums.Name = "labelAlbums";
            this.labelAlbums.Size = new System.Drawing.Size(59, 16);
            this.labelAlbums.TabIndex = 0;
            this.labelAlbums.Text = "Albums";
            // 
            // listViewAlbumList
            // 
            this.listViewAlbumList.Location = new System.Drawing.Point(12, 44);
            this.listViewAlbumList.Name = "listViewAlbumList";
            this.listViewAlbumList.Size = new System.Drawing.Size(577, 273);
            this.listViewAlbumList.TabIndex = 1;
            this.listViewAlbumList.UseCompatibleStateImageBehavior = false;
            this.listViewAlbumList.SelectedIndexChanged += new System.EventHandler(this.listViewAlbumList_SelectedIndexChanged);
            // 
            // imageListAlbumImages
            // 
            this.imageListAlbumImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListAlbumImages.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListAlbumImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Enabled = false;
            this.buttonDownload.Location = new System.Drawing.Point(12, 335);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(142, 23);
            this.buttonDownload.TabIndex = 2;
            this.buttonDownload.Text = "Download Album";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // textBoxDownloadPath
            // 
            this.textBoxDownloadPath.Enabled = false;
            this.textBoxDownloadPath.Location = new System.Drawing.Point(12, 418);
            this.textBoxDownloadPath.Name = "textBoxDownloadPath";
            this.textBoxDownloadPath.Size = new System.Drawing.Size(329, 20);
            this.textBoxDownloadPath.TabIndex = 3;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(364, 418);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(84, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelDownloadTo
            // 
            this.labelDownloadTo.AutoSize = true;
            this.labelDownloadTo.Location = new System.Drawing.Point(13, 386);
            this.labelDownloadTo.Name = "labelDownloadTo";
            this.labelDownloadTo.Size = new System.Drawing.Size(80, 13);
            this.labelDownloadTo.TabIndex = 5;
            this.labelDownloadTo.Text = "Download Path";
            // 
            // labelAlbumNameToDownload
            // 
            this.labelAlbumNameToDownload.AutoSize = true;
            this.labelAlbumNameToDownload.Location = new System.Drawing.Point(171, 340);
            this.labelAlbumNameToDownload.Name = "labelAlbumNameToDownload";
            this.labelAlbumNameToDownload.Size = new System.Drawing.Size(0, 13);
            this.labelAlbumNameToDownload.TabIndex = 6;
            // 
            // FormAlbumManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 492);
            this.Controls.Add(this.labelAlbumNameToDownload);
            this.Controls.Add(this.labelDownloadTo);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxDownloadPath);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.listViewAlbumList);
            this.Controls.Add(this.labelAlbums);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlbumManager";
            this.Text = "FormAlbumManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlbums;
        private System.Windows.Forms.ListView listViewAlbumList;
        private System.Windows.Forms.ImageList imageListAlbumImages;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.TextBox textBoxDownloadPath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelDownloadTo;
        private System.Windows.Forms.Label labelAlbumNameToDownload;
    }
}