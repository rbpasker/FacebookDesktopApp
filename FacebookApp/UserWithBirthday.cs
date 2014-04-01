

namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Globalization;
    using FacebookWrapper.ObjectModel;

    /// <summary>
    /// Class which represents the Facebook user just with a small difference.
    /// The UserWithBirtday is a user that has the birthday not as a String format but as a Date format.
    /// </summary>
    public class UserWithBirthday : User
    {
        private CultureInfo m_ApplicationCultureFormat = new CultureInfo("en-US");

        /// <summary>
        /// Returns the user birthday with the DateTime format
        /// </summary>
        public DateTime GetBirthdayDate
        {
            get { return StringToDateConvertor.s_ParsetDateStrToDateTimeObjInCurrentCulture(this.Birthday, m_ApplicationCultureFormat); }
        }   
    }
}
