using bot_backEnd.Models.AppModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL.Interfaces
{
    public interface ICommentLikeDAL
    {
        Task<ActionResult<List<CommentLike>>> getLikesByCommentID(int PostID, int commentID);
        Task<ActionResult<int>> AddCommentLike(CommentLike like);
        Task<ActionResult<int>> DeleteCommentLike(int commentID, int PostID, int userID);
    }
}
