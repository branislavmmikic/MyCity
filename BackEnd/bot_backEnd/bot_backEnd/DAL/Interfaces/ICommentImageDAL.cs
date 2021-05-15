using bot_backEnd.Models.DbModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.DAL.Interfaces
{
    public interface ICommentImageDAL
    {
        Task<ActionResult<CommentImage>> AddCommentImage(CommentImage image);
        Task<ActionResult<bool>> UpdateImage(int imageID, string imgExt, string path);
        Task<ActionResult<List<CommentImage>>> GetAllCommentImages(int commentID, int postID);
    }
}
