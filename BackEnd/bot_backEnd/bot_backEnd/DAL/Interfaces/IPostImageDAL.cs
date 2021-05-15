using bot_backEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.DAL.Interfaces
{
    public interface IPostImageDAL
    {
        Task<ActionResult<bool>> AddImage(PostImage image);
        Task<ActionResult<List<PostImage>>> GetImagesByPostID(int id);
        Task<ActionResult<List<string>>> GetImagesURLByPostID(int id);
        Task<ActionResult<bool>> UpdateImage(int imageID, string imgExt, string path);
    }
}
