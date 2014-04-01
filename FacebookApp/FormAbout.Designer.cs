namespace FacebookApp
{
    public partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelFacebook = new System.Windows.Forms.Label();
            this.pictureBoxOriel = new System.Windows.Forms.PictureBox();
            this.labelOrielName = new System.Windows.Forms.Label();
            this.labelIdoName = new System.Windows.Forms.Label();
            this.pictureBoxIdo = new System.Windows.Forms.PictureBox();
            this.labelDesignPatterns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFacebook
            // 
            this.labelFacebook.AutoSize = true;
            this.labelFacebook.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacebook.Location = new System.Drawing.Point(29, 32);
            this.labelFacebook.Name = "labelFacebook";
            this.labelFacebook.Size = new System.Drawing.Size(185, 21);
            this.labelFacebook.TabIndex = 0;
            this.labelFacebook.Text = "Facebook Application ";
            // 
            // pictureBoxOriel
            // 
            this.pictureBoxOriel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxOriel.BackgroundImage")));
            this.pictureBoxOriel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxOriel.Location = new System.Drawing.Point(32, 86);
            this.pictureBoxOriel.Name = "pictureBoxOriel";
            this.pictureBoxOriel.Size = new System.Drawing.Size(91, 90);
            this.pictureBoxOriel.TabIndex = 1;
            this.pictureBoxOriel.TabStop = false;
            // 
            // labelOrielName
            // 
            this.labelOrielName.AutoSize = true;
            this.labelOrielName.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrielName.Location = new System.Drawing.Point(146, 86);
            this.labelOrielName.Name = "labelOrielName";
            this.labelOrielName.Size = new System.Drawing.Size(88, 17);
            this.labelOrielName.TabIndex = 3;
            this.labelOrielName.Text = "Oriel Belzer";
            // 
            // labelIdoName
            // 
            this.labelIdoName.AutoSize = true;
            this.labelIdoName.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdoName.Location = new System.Drawing.Point(146, 191);
            this.labelIdoName.Name = "labelIdoName";
            this.labelIdoName.Size = new System.Drawing.Size(74, 17);
            this.labelIdoName.TabIndex = 5;
            this.labelIdoName.Text = "Ido Lustig";
            // 
            // pictureBoxIdo
            // 
            this.pictureBoxIdo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxIdo.BackgroundImage")));
            this.pictureBoxIdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxIdo.Location = new System.Drawing.Point(33, 191);
            this.pictureBoxIdo.Name = "pictureBoxIdo";
            this.pictureBoxIdo.Size = new System.Drawing.Size(91, 90);
            this.pictureBoxIdo.TabIndex = 6;
            this.pictureBoxIdo.TabStop = false;
            // 
            // labelDesignPatterns
            // 
            this.labelDesignPatterns.AutoSize = true;
            this.labelDesignPatterns.Location = new System.Drawing.Point(30, 319);
            this.labelDesignPatterns.Name = "labelDesignPatterns";
            this.labelDesignPatterns.Size = new System.Drawing.Size(109, 13);
            this.labelDesignPatterns.TabIndex = 7;
            this.labelDesignPatterns.Text = "2012 Design Patterns";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 355);
            this.Controls.Add(this.labelDesignPatterns);
            this.Controls.Add(this.pictureBoxIdo);
            this.Controls.Add(this.labelIdoName);
            this.Controls.Add(this.labelOrielName);
            this.Controls.Add(this.pictureBoxOriel);
            this.Controls.Add(this.labelFacebook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFacebook;
        private System.Windows.Forms.PictureBox pictureBoxOriel;
        private System.Windows.Forms.Label labelOrielName;
        private System.Windows.Forms.Label labelIdoName;
        private System.Windows.Forms.PictureBox pictureBoxIdo;
        private System.Windows.Forms.Label labelDesignPatterns;
    }
}