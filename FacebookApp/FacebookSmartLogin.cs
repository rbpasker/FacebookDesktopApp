namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// The Smart Login class is used a Facade in order to perform actions in behalf of the logged in user.
    /// The actions that are done by this facade are : 
    /// 1. Posing a status on the user's wall according to the time he logged in.
    /// 2. Posting a birthday message to all user's friends that has birthday at the same day.
    /// </summary>
    public class FacebookSmartLogin : ILoginObserver
    {
        private const string k_BirthdayPost = "Happy birthday !!!";
        private DateTime k_StartMorning = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 07, 00, 00);
        private DateTime k_EndMorning = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 00, 00);
        private DateTime k_StartNight = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);

        /// <summary>
        /// The function gives the user the ability to perform smart login that will perform a few actions on his behalf. 
        /// </summary>
        public void performSmartLogin()
        {
            bool postResult = true;
            FacebookAppLogic appLogic = FacebookAppLogic.GetFacebookAppLogicInstance;
            appLogic.PostStatusOnUser(createStringAccordingToCurrentTime(), appLogic.LoggedInUser);
            postResult = appLogic.PostStatus(k_BirthdayPost, new PostToBirthdayStrategy());
        }

        private string createStringAccordingToCurrentTime()
        {
            string stringToReturn = string.Empty;
            DateTime now = DateTime.Now;

            if (now > k_StartMorning && now < k_EndMorning)
            {
                stringToReturn = "Good morning world!";
            }
            else if (now > k_EndMorning && now < k_StartNight)
            {
                stringToReturn = "Good afternoon world!";
            }
            else
            {
                stringToReturn = "Good night world!";
            }

            return stringToReturn;
        }

        /// <summary>
        /// Implementing ILoginObserver interface 
        /// </summary>
        /// <param name="i_IsLoggedIn">Boolean if logged in to Facebook or not</param>
        public void notify(bool i_IsLoggedIn)
        {
            if (i_IsLoggedIn == true)
            {
                DialogResult performFacebookSmartLoginResult = MessageBox.Show("Do you want to perform smart login?", "Smart Login", MessageBoxButtons.YesNo);
                if (performFacebookSmartLoginResult == DialogResult.Yes)
                {
                    this.performSmartLogin();
                }
            }
        }
    }
}
