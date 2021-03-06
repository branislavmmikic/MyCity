using bot_backEnd.Models.AppModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL.Interfaces
{
    public interface ICommentLikeBL
    {
        List<AppUser> GetUsersWhoLikesThisComment(int PostID, int commentID);
        int AddCommentLike(CommentLike like);
        int DeleteCommentLike(int commentID, int PostID, int userID);
    }
}
