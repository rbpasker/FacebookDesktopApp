using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    /// <summary>
    /// Class PostToBirthdayStratey = Implementing IPostStrategy
    /// </summary>
    public class PostToBirthdayStrategy : IPostStrategy
    {
        /// <summary>
        /// Ececute method as part of strategy pattern
        /// </summary>
        /// <param name="i_LoggedInUserFriends">Lost of friends</param>
        /// <param name="i_StatusToPost">Status to post</param>
        /// <returns></returns>
        public bool excecute(List<User> i_LoggedInUserFriends, string i_StatusToPost)
        {
            FriendsWithBirthday friendsWithBirthday = new FriendsWithBirthday(i_LoggedInUserFriends);

            foreach (UserWithBirthday friend in friendsWithBirthday)
            {                
                try
                {
                    friend.PostStatus(i_StatusToPost);
                }
                catch (Facebook.FacebookOAuthException)
                {
                    return false;
                }                
            }

            return true;
        }        
    }
}
