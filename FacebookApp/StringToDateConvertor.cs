using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace FacebookApp
{
    /// <summary>
    /// This class represents a static funciton that enables us to convert a date which is in a String format
    /// to be a DateTime object according to the culture that the String was entered in.
    /// </summary>
    public class StringToDateConvertor
    {
        /// <summary>
        /// Returns the pared date
        /// </summary>
        /// <param name="i_DateInStringFormat">The date we would like to convert in a String format</param>
        /// <param name="i_SourceCulture">The colture of the String that represents the date we would like to convert</param>
        /// <returns> parsing result</returns> 
        public static DateTime s_ParsetDateStrToDateTimeObjInCurrentCulture(string i_DateInStringFormat, CultureInfo i_SourceCulture)
        {
            DateTime dateToReturn;
            try
            {
                dateToReturn = Convert.ToDateTime(i_DateInStringFormat, i_SourceCulture);
                dateToReturn = Convert.ToDateTime(dateToReturn, CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                throw new FormatException("Error: Unable to parse string to date!");
            }

            return dateToReturn;
        }
    }
}
