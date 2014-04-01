using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    /// <summary>
    /// Class PostToSelectedStratey = Implementing IPostStrategy
    /// </summary>
    public class PostToSelectedStrategy : IPostStrategy
    {
        /// <summary>
        /// Patameter FriendToPostTo - type int
        /// </summary>
        public int FriendToPostTo { get; set; }

        /// <summary>
        /// Ececute method as part of strategy pattern
        /// </summary>
        /// <param name="i_LoggedInUserFriends">Lost of friends</param>
        /// <param name="i_StatusToPost">Status to post</param>
        /// <returns></returns>
        public bool excecute(List<User> i_LoggedInUserFriends, string i_StatusToPost)
        {
            try
            {
                i_LoggedInUserFriends[FriendToPostTo].PostStatus(i_StatusToPost);
            }
            catch (Facebook.FacebookOAuthException)
            {
                return false;
            }

            return true;
        }
    }
}
