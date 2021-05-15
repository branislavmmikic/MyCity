using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL.Interfaces
{
    public interface ICommentImageBL
    {
        Task<ActionResult<bool>> UploadCommentImages(IFormFile[] images, int commentID, int PostID, int typeID);
        bool DeleteCommentImages(int commentID, int postID);
        Task<ActionResult<bool>> UploadInstitutionCommentImage(int commentID, int postID, string image);
    }
}
