using bot_backEnd.BL.Interfaces;
using bot_backEnd.Models.AppModels;
using bot_backEnd.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI
{
    public class CommentLikeUI : ICommentLikeUI
    {
        private readonly ICommentLikeBL _iCommentLikeBL;
        public CommentLikeUI(ICommentLikeBL iCommentLikeBL)
        {
            _iCommentLikeBL = iCommentLikeBL;
        }

        public int AddCommentLike(CommentLike like)
        {
            return _iCommentLikeBL.AddCommentLike(like);
        }

        public int DeleteCommentLike(int commentID, int PostID, int userID)
        {
            return _iCommentLikeBL.DeleteCommentLike(commentID, PostID, userID);
        }

        public List<AppUser> GetUsersWhoLikesThisComment(int PostID, int commentID)
        {
            return _iCommentLikeBL.GetUsersWhoLikesThisComment(PostID, commentID);
        }
    }
}
