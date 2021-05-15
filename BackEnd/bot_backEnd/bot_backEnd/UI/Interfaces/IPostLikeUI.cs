using bot_backEnd.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI.Interfaces
{
    public interface IPostLikeUI
    {
        int AddPostLike(PostLike like);
        int DeletePostLike(int PostID, int userID);
    }
}
