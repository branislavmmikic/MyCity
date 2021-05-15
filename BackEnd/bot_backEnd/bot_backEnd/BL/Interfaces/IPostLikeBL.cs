using bot_backEnd.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL.Interfaces
{
    public interface IPostLikeBL
    {
        List<PostLike> GetLikesByPostID(int PostID);
        int AddPostLike(PostLike like);
        int DeletePostLike(int PostID, int userID);
    }
}
