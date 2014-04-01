namespace FacebookApp
{
    /// <summary>
    /// Facebook Status Manager class
    /// </summary>
    public partial class FormStatusManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatusManager));
            this.labelFriends = new System.Windows.Forms.Label();
            this.listBoxFriendsList = new System.Windows.Forms.ListBox();
            this.listBoxStatusSearchResult = new System.Windows.Forms.ListBox();
            this.labelStatusSearch = new System.Windows.Forms.Label();
            this.textBoxStatusSearch = new System.Windows.Forms.TextBox();
            this.buttonSearchSelected = new System.Windows.Forms.Button();
            this.buttonSearchAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriends.Location = new System.Drawing.Point(13, 13);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(60, 16);
            this.labelFriends.TabIndex = 0;
            this.labelFriends.Text = "Friends";
            // 
            // listBoxFriendsList
            // 
            this.listBoxFriendsList.FormattingEnabled = true;
            this.listBoxFriendsList.Location = new System.Drawing.Point(16, 46);
            this.listBoxFriendsList.Name = "listBoxFriendsList";
            this.listBoxFriendsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxFriendsList.Size = new System.Drawing.Size(163, 212);
            this.listBoxFriendsList.TabIndex = 1;
            // 
            // listBoxStatusSearchResult
            // 
            this.listBoxStatusSearchResult.FormattingEnabled = true;
            this.listBoxStatusSearchResult.HorizontalScrollbar = true;
            this.listBoxStatusSearchResult.Location = new System.Drawing.Point(16, 276);
            this.listBoxStatusSearchResult.Name = "listBoxStatusSearchResult";
            this.listBoxStatusSearchResult.ScrollAlwaysVisible = true;
            this.listBoxStatusSearchResult.Size = new System.Drawing.Size(620, 238);
            this.listBoxStatusSearchResult.TabIndex = 2;
            this.listBoxStatusSearchResult.SelectedIndexChanged += new System.EventHandler(this.listBoxStatusSearchResult_SelectedIndexChanged);
            // 
            // labelStatusSearch
            // 
            this.labelStatusSearch.AutoSize = true;
            this.labelStatusSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelStatusSearch.Location = new System.Drawing.Point(207, 46);
            this.labelStatusSearch.Name = "labelStatusSearch";
            this.labelStatusSearch.Size = new System.Drawing.Size(104, 16);
            this.labelStatusSearch.TabIndex = 3;
            this.labelStatusSearch.Text = "Status Search";
            // 
            // textBoxStatusSearch
            // 
            this.textBoxStatusSearch.Location = new System.Drawing.Point(210, 83);
            this.textBoxStatusSearch.Name = "textBoxStatusSearch";
            this.textBoxStatusSearch.Size = new System.Drawing.Size(426, 20);
            this.textBoxStatusSearch.TabIndex = 4;
            // 
            // buttonSearchSelected
            // 
            this.buttonSearchSelected.Location = new System.Drawing.Point(210, 133);
            this.buttonSearchSelected.Name = "buttonSearchSelected";
            this.buttonSearchSelected.Size = new System.Drawing.Size(112, 23);
            this.buttonSearchSelected.TabIndex = 5;
            this.buttonSearchSelected.Text = "Search Selected";
            this.buttonSearchSelected.UseVisualStyleBackColor = true;
            this.buttonSearchSelected.Click += new System.EventHandler(this.buttonSearchSelected_Click);
            // 
            // buttonSearchAll
            // 
            this.buttonSearchAll.Location = new System.Drawing.Point(328, 133);
            this.buttonSearchAll.Name = "buttonSearchAll";
            this.buttonSearchAll.Size = new System.Drawing.Size(112, 23);
            this.buttonSearchAll.TabIndex = 6;
            this.buttonSearchAll.Text = "Search All";
            this.buttonSearchAll.UseVisualStyleBackColor = true;
            this.buttonSearchAll.Click += new System.EventHandler(this.buttonSearchAll_Click);
            // 
            // FormStatusManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 528);
            this.Controls.Add(this.buttonSearchAll);
            this.Controls.Add(this.buttonSearchSelected);
            this.Controls.Add(this.textBoxStatusSearch);
            this.Controls.Add(this.labelStatusSearch);
            this.Controls.Add(this.listBoxStatusSearchResult);
            this.Controls.Add(this.listBoxFriendsList);
            this.Controls.Add(this.labelFriends);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStatusManager";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.ListBox listBoxFriendsList;
        private System.Windows.Forms.ListBox listBoxStatusSearchResult;
        private System.Windows.Forms.Label labelStatusSearch;
        private System.Windows.Forms.TextBox textBoxStatusSearch;
        private System.Windows.Forms.Button buttonSearchSelected;
        private System.Windows.Forms.Button buttonSearchAll;
    }
}