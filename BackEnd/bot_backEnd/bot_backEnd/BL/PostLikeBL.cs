using bot_backEnd.BL.Interfaces;
using bot_backEnd.DAL.Interfaces;
using bot_backEnd.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL
{
    public class PostLikeBL : IPostLikeBL
    {
        private readonly IPostLikeDAL _iEntityLikeDAL;

        public PostLikeBL(IPostLikeDAL iEntityLikeDAL)
        {
            _iEntityLikeDAL = iEntityLikeDAL;
        }

        public int AddPostLike(PostLike like)
        {
            return _iEntityLikeDAL.AddPostLike(like).Result.Value;
        }

        public int DeletePostLike(int PostID, int userID)
        {
            return _iEntityLikeDAL.DeletePostLike(PostID, userID).Result.Value;
        }

        public List<PostLike> GetLikesByPostID(int PostID)
        {
            return _iEntityLikeDAL.GetLikesByPostID(PostID).Result.Value;
        }
    }
}
