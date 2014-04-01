namespace FacebookApp
{
    public partial class FormFriendsManager
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
            this.listViewFriendsList = new System.Windows.Forms.ListView();
            this.labelFriends = new System.Windows.Forms.Label();
            this.imageListFriends = new System.Windows.Forms.ImageList(this.components);
            this.textBoxInputStatus = new System.Windows.Forms.TextBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.comboBoxPostTo = new System.Windows.Forms.ComboBox();
            this.labelPostStatusTo = new System.Windows.Forms.Label();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewFriendsList
            // 
            this.listViewFriendsList.Location = new System.Drawing.Point(12, 37);
            this.listViewFriendsList.Name = "listViewFriendsList";
            this.listViewFriendsList.Size = new System.Drawing.Size(501, 179);
            this.listViewFriendsList.TabIndex = 2;
            this.listViewFriendsList.UseCompatibleStateImageBehavior = false;
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriends.Location = new System.Drawing.Point(12, 9);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(60, 16);
            this.labelFriends.TabIndex = 3;
            this.labelFriends.Text = "Friends";
            // 
            // imageListFriends
            // 
            this.imageListFriends.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListFriends.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListFriends.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBoxInputStatus
            // 
            this.textBoxInputStatus.Location = new System.Drawing.Point(31, 267);
            this.textBoxInputStatus.Multiline = true;
            this.textBoxInputStatus.Name = "textBoxInputStatus";
            this.textBoxInputStatus.Size = new System.Drawing.Size(221, 73);
            this.textBoxInputStatus.TabIndex = 4;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(28, 239);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(28, 13);
            this.labelPost.TabIndex = 6;
            this.labelPost.Text = "Post";
            // 
            // comboBoxPostTo
            // 
            this.comboBoxPostTo.FormattingEnabled = true;
            this.comboBoxPostTo.Items.AddRange(new object[] {
            "All Friends",
            "Selected Friend",
            "Friends With Birthday"});
            this.comboBoxPostTo.Location = new System.Drawing.Point(320, 267);
            this.comboBoxPostTo.Name = "comboBoxPostTo";
            this.comboBoxPostTo.Size = new System.Drawing.Size(161, 21);
            this.comboBoxPostTo.TabIndex = 7;
            // 
            // labelPostStatusTo
            // 
            this.labelPostStatusTo.AutoSize = true;
            this.labelPostStatusTo.Location = new System.Drawing.Point(317, 239);
            this.labelPostStatusTo.Name = "labelPostStatusTo";
            this.labelPostStatusTo.Size = new System.Drawing.Size(77, 13);
            this.labelPostStatusTo.TabIndex = 8;
            this.labelPostStatusTo.Text = "Post Status To";
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(323, 308);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(158, 31);
            this.buttonPostStatus.TabIndex = 9;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // FormFriendsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 369);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.labelPostStatusTo);
            this.Controls.Add(this.comboBoxPostTo);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.textBoxInputStatus);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.listViewFriendsList);
            this.Name = "FormFriendsManager";
            this.Text = "FormFriendsManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewFriendsList;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.ImageList imageListFriends;
        private System.Windows.Forms.TextBox textBoxInputStatus;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.ComboBox comboBoxPostTo;
        private System.Windows.Forms.Label labelPostStatusTo;
        private System.Windows.Forms.Button buttonPostStatus;
    }
}