using bot_backEnd.BL.Interfaces;
using bot_backEnd.Models.DbModels;
using bot_backEnd.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI
{
    public class PostLikeUI : IPostLikeUI
    {
        private readonly IPostLikeBL _iEntityLikeBL;

        public PostLikeUI(IPostLikeBL iPostLikeBL)
        {
            _iEntityLikeBL = iPostLikeBL;
        }

        public int AddPostLike(PostLike like)
        {
            return _iEntityLikeBL.AddPostLike(like);
        }

        public int DeletePostLike(int PostID, int userID)
        {
            return _iEntityLikeBL.DeletePostLike(PostID, userID);
        }
    }
}
