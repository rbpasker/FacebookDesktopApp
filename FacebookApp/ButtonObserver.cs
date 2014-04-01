using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp
{
    /// <summary>
    /// Class ButtonObserver - Inherites brom Button and implements ILoginObserver
    /// </summary>
    public class ButtonObserver : Button, ILoginObserver
    {  
        /// <summary>
        /// Implementing ILoginObserver interface
        /// </summary>
        /// <param name="i_IsLoggedIn">boolean is logged in to Facebook or not</param>
        public void notify(bool i_IsLoggedIn)
        {
            this.Enabled = i_IsLoggedIn;
        }
    }
}
