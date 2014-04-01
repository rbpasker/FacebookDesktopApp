using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    /// <summary>
    /// Interface IPostStrategy as part of Strategy pattern
    /// </summary>
    public interface IPostStrategy
    {
        /// <summary>
        /// Ececute method as part of strategy pattern
        /// </summary>
        /// <param name="i_LoggedInUserFriends">Lost of friends</param>
        /// <param name="i_StatusToPost">Status to post</param>
        /// <returns></returns>
        bool excecute(List<User> i_LoggedInUserFriends, string i_StatusToPost);
    }
}
