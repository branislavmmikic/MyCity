using bot_backEnd.Models.DbModels;
using bot_backEnd.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.DAL.Interfaces
{
    public interface ICommentDAL
    {
        Task<ActionResult<List<Comment>>> getComments();
        Task<ActionResult<Comment>> AddComment(Comment comment);
        Task<ActionResult<bool>> DeleteComment(int commentID, int PostID);
        Task<ActionResult<Comment>> GetCommentByID(int commentID, int postID);
        Task<ActionResult<List<Comment>>> GetCommentsByUserID(int userID);
        Task<ActionResult<bool>> ChangeCommentText(CommentVM commentData);
    }
}
