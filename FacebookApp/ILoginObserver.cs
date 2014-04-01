using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApp
{
    /// <summary>
    /// Interface for Login Observer
    /// </summary>
    public interface ILoginObserver
    {
        /// <summary>
        /// Notify function to invoke at observer
        /// </summary>
        /// <param name="i_IsLoggedIn">rather the user loggedin to Facebook or not</param>
        void notify(bool i_IsLoggedIn);
    }
}
