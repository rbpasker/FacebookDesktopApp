namespace FacebookApp
{
    public partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonAlbum = new ButtonObserver();
            this.buttonInfo = new ButtonObserver();
            this.buttonStatus = new ButtonObserver();
            this.buttonLogout = new ButtonObserver();            
            this.buttonFriends = new ButtonObserver();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);            
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);            
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);            
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogin.BackgroundImage")));
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogin.Image")));
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(219, 96);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonAlbum
            // 
            this.buttonAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAlbum.Enabled = false;
            this.buttonAlbum.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlbum.Image")));
            this.buttonAlbum.Location = new System.Drawing.Point(237, 12);
            this.buttonAlbum.Name = "buttonAlbum";
            this.buttonAlbum.Size = new System.Drawing.Size(271, 217);
            this.buttonAlbum.TabIndex = 1;
            this.buttonAlbum.UseVisualStyleBackColor = true;
            this.buttonAlbum.Click += new System.EventHandler(this.buttonAlbum_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInfo.Enabled = false;
            this.buttonInfo.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo.Image")));
            this.buttonInfo.Location = new System.Drawing.Point(12, 114);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(219, 161);
            this.buttonInfo.TabIndex = 2;
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonStatus
            // 
            this.buttonStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStatus.Enabled = false;
            this.buttonStatus.Image = ((System.Drawing.Image)(resources.GetObject("buttonStatus.Image")));
            this.buttonStatus.Location = new System.Drawing.Point(237, 235);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(271, 211);
            this.buttonStatus.TabIndex = 3;
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.Location = new System.Drawing.Point(85, 387);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(146, 59);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout.Image")));
            this.buttonAbout.Location = new System.Drawing.Point(12, 387);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(67, 59);
            this.buttonAbout.TabIndex = 5;
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonFriends
            // 
            this.buttonFriends.Enabled = false;
            this.buttonFriends.Image = ((System.Drawing.Image)(resources.GetObject("buttonFriends.Image")));
            this.buttonFriends.Location = new System.Drawing.Point(12, 281);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(219, 100);
            this.buttonFriends.TabIndex = 6;
            this.buttonFriends.UseVisualStyleBackColor = true;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 456);
            this.Controls.Add(this.buttonFriends);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonStatus);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonAlbum);
            this.Controls.Add(this.buttonLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDashboard";
            this.Text = "FacebookApp - Dashboard";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button ButtonObserver()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonAbout;
        private ButtonObserver buttonAlbum;
        private ButtonObserver buttonInfo;
        private ButtonObserver buttonStatus;
        private ButtonObserver buttonFriends;
        private ButtonObserver buttonLogout;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;        
        private System.Windows.Forms.ToolTip toolTip5;        
        private System.Windows.Forms.ToolTip toolTip6;        
        private System.Windows.Forms.ToolTip toolTip7;
    }
}
