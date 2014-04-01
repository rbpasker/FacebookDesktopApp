using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    /// <summary>
    /// Class FriendWithBirthday that implements the Iterator pattern: IEnumeable
    /// </summary>
    public class FriendsWithBirthday : IEnumerable, IEnumerable<UserWithBirthday>
    {
        #region Data Members

        private readonly List<UserWithBirthday> m_FriendsWithBirthday;
        
        #endregion

        #region Methods

        /// <summary>
        /// FriendWithBirthday constructor
        /// </summary>
        /// <param name="i_FriendsList">List of friends - type List of User</param>
        public FriendsWithBirthday(List<User> i_FriendsList)
        {
            m_FriendsWithBirthday = new List<UserWithBirthday>();

            foreach (UserWithBirthday friend in i_FriendsList)
            {
                if (friend.GetBirthdayDate.Month == DateTime.Now.Month && friend.GetBirthdayDate.Day == DateTime.Now.Day)
                {
                    m_FriendsWithBirthday.Add(friend);
                }
            }
        }

        /// <summary>
        /// GetEnumerator function as part of Iterator pattern
        /// </summary>
        /// <returns>IEnumerator of UserWithBrithday</returns>
        public IEnumerator<UserWithBirthday> GetEnumerator()
        {
            for (int i = 0; i < m_FriendsWithBirthday.Count; i++)
            {
                yield return m_FriendsWithBirthday[i];
            }
        }
       
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < m_FriendsWithBirthday.Count; i++)
            {
                yield return m_FriendsWithBirthday[i];
            }
        }

        #endregion
    }
}
