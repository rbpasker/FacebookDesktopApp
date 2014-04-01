namespace FacebookApp
{
    public partial class FormStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatus));
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBoxUserPicture = new System.Windows.Forms.PictureBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxStatusMessage = new System.Windows.Forms.TextBox();
            this.labelLikes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUsername.Location = new System.Drawing.Point(137, 13);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(86, 16);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "User Name";
            // 
            // pictureBoxUserPicture
            // 
            this.pictureBoxUserPicture.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxUserPicture.Name = "pictureBoxUserPicture";
            this.pictureBoxUserPicture.Size = new System.Drawing.Size(108, 126);
            this.pictureBoxUserPicture.TabIndex = 1;
            this.pictureBoxUserPicture.TabStop = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(137, 41);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date";
            // 
            // textBoxStatusMessage
            // 
            this.textBoxStatusMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxStatusMessage.Location = new System.Drawing.Point(140, 67);
            this.textBoxStatusMessage.Multiline = true;
            this.textBoxStatusMessage.Name = "textBoxStatusMessage";
            this.textBoxStatusMessage.ReadOnly = true;
            this.textBoxStatusMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxStatusMessage.Size = new System.Drawing.Size(441, 72);
            this.textBoxStatusMessage.TabIndex = 4;
            this.textBoxStatusMessage.TabStop = false;
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikes.ForeColor = System.Drawing.Color.Blue;
            this.labelLikes.Location = new System.Drawing.Point(12, 155);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(41, 13);
            this.labelLikes.TabIndex = 5;
            this.labelLikes.Text = "Likes:";
            // 
            // FormStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 189);
            this.Controls.Add(this.labelLikes);
            this.Controls.Add(this.textBoxStatusMessage);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.pictureBoxUserPicture);
            this.Controls.Add(this.labelUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStatus";
            this.Text = "Status";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox pictureBoxUserPicture;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxStatusMessage;
        private System.Windows.Forms.Label labelLikes;
    }
}