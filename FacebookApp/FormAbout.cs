using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp
{
    /// <summary>
    /// About Form
    /// </summary>
    public partial class FormAbout : Form
    {
        /// <summary>
        /// FormAbout constructor
        /// </summary>
        public FormAbout()
        {
            Application.EnableVisualStyles();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            InitializeComponent();
        }
    }
}
