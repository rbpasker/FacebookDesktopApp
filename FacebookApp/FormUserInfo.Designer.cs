namespace FacebookApp
{
    public partial class FormUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserInfo));
            this.picture_UserPicture = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelRelationship = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelHometown = new System.Windows.Forms.Label();
            this.labelBirthdayResult = new System.Windows.Forms.Label();
            this.labelSexResult = new System.Windows.Forms.Label();
            this.labelRelationshipResult = new System.Windows.Forms.Label();
            this.labelEmailResult = new System.Windows.Forms.Label();
            this.labelHometownResult = new System.Windows.Forms.Label();
            this.labelReligion = new System.Windows.Forms.Label();
            this.labelReligionResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_UserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_UserPicture
            // 
            this.picture_UserPicture.Location = new System.Drawing.Point(13, 13);
            this.picture_UserPicture.Name = "picture_UserPicture";
            this.picture_UserPicture.Size = new System.Drawing.Size(142, 156);
            this.picture_UserPicture.TabIndex = 0;
            this.picture_UserPicture.TabStop = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserName.Location = new System.Drawing.Point(161, 13);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(98, 20);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "User Name";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(161, 80);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Tag = "Status";
            this.labelStatus.Text = "Status";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(164, 123);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(241, 20);
            this.textBoxStatus.TabIndex = 3;
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(411, 123);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(75, 23);
            this.buttonPostStatus.TabIndex = 4;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(21, 183);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(45, 13);
            this.labelBirthday.TabIndex = 5;
            this.labelBirthday.Text = "Birthday";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(21, 219);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(25, 13);
            this.labelSex.TabIndex = 6;
            this.labelSex.Text = "Sex";
            // 
            // labelRelationship
            // 
            this.labelRelationship.AutoSize = true;
            this.labelRelationship.Location = new System.Drawing.Point(21, 262);
            this.labelRelationship.Name = "labelRelationship";
            this.labelRelationship.Size = new System.Drawing.Size(98, 13);
            this.labelRelationship.TabIndex = 7;
            this.labelRelationship.Text = "Relationship Status";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(21, 305);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email";
            // 
            // labelHometown
            // 
            this.labelHometown.AutoSize = true;
            this.labelHometown.Location = new System.Drawing.Point(21, 344);
            this.labelHometown.Name = "labelHometown";
            this.labelHometown.Size = new System.Drawing.Size(58, 13);
            this.labelHometown.TabIndex = 9;
            this.labelHometown.Text = "Hometown";
            // 
            // labelBirthdayResult
            // 
            this.labelBirthdayResult.AutoSize = true;
            this.labelBirthdayResult.Location = new System.Drawing.Point(161, 183);
            this.labelBirthdayResult.Name = "labelBirthdayResult";
            this.labelBirthdayResult.Size = new System.Drawing.Size(0, 13);
            this.labelBirthdayResult.TabIndex = 10;
            // 
            // labelSexResult
            // 
            this.labelSexResult.AutoSize = true;
            this.labelSexResult.Location = new System.Drawing.Point(161, 219);
            this.labelSexResult.Name = "labelSexResult";
            this.labelSexResult.Size = new System.Drawing.Size(0, 13);
            this.labelSexResult.TabIndex = 11;
            // 
            // labelRelationshipResult
            // 
            this.labelRelationshipResult.AutoSize = true;
            this.labelRelationshipResult.Location = new System.Drawing.Point(161, 262);
            this.labelRelationshipResult.Name = "labelRelationshipResult";
            this.labelRelationshipResult.Size = new System.Drawing.Size(0, 13);
            this.labelRelationshipResult.TabIndex = 12;
            // 
            // labelEmailResult
            // 
            this.labelEmailResult.AutoSize = true;
            this.labelEmailResult.Location = new System.Drawing.Point(161, 305);
            this.labelEmailResult.Name = "labelEmailResult";
            this.labelEmailResult.Size = new System.Drawing.Size(0, 13);
            this.labelEmailResult.TabIndex = 13;
            // 
            // labelHometownResult
            // 
            this.labelHometownResult.AutoSize = true;
            this.labelHometownResult.Location = new System.Drawing.Point(161, 344);
            this.labelHometownResult.Name = "labelHometownResult";
            this.labelHometownResult.Size = new System.Drawing.Size(0, 13);
            this.labelHometownResult.TabIndex = 14;
            // 
            // labelReligion
            // 
            this.labelReligion.AutoSize = true;
            this.labelReligion.Location = new System.Drawing.Point(21, 387);
            this.labelReligion.Name = "labelReligion";
            this.labelReligion.Size = new System.Drawing.Size(45, 13);
            this.labelReligion.TabIndex = 15;
            this.labelReligion.Text = "Religion";
            // 
            // labelReligionResult
            // 
            this.labelReligionResult.AutoSize = true;
            this.labelReligionResult.Location = new System.Drawing.Point(161, 387);
            this.labelReligionResult.Name = "labelReligionResult";
            this.labelReligionResult.Size = new System.Drawing.Size(0, 13);
            this.labelReligionResult.TabIndex = 18;
            // 
            // FormUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 509);
            this.Controls.Add(this.labelReligionResult);
            this.Controls.Add(this.labelReligion);
            this.Controls.Add(this.labelHometownResult);
            this.Controls.Add(this.labelEmailResult);
            this.Controls.Add(this.labelRelationshipResult);
            this.Controls.Add(this.labelSexResult);
            this.Controls.Add(this.labelBirthdayResult);
            this.Controls.Add(this.labelHometown);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelRelationship);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.picture_UserPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUserInfo";
            this.Text = "U";
            ((System.ComponentModel.ISupportInitialize)(this.picture_UserPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_UserPicture;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelRelationship;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelHometown;
        private System.Windows.Forms.Label labelBirthdayResult;
        private System.Windows.Forms.Label labelSexResult;
        private System.Windows.Forms.Label labelRelationshipResult;
        private System.Windows.Forms.Label labelEmailResult;
        private System.Windows.Forms.Label labelHometownResult;
        private System.Windows.Forms.Label labelReligion;
        private System.Windows.Forms.Label labelReligionResult;
    }
}