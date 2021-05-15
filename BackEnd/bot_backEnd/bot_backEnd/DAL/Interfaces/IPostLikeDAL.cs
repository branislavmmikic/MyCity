using bot_backEnd.Models.DbModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.DAL.Interfaces
{
    public interface IPostLikeDAL
    {
        Task<ActionResult<List<PostLike>>> GetLikesByPostID(int PostID);
        Task<ActionResult<int>> AddPostLike(PostLike like);
        Task<ActionResult<int>> DeletePostLike(int PostID, int userID);
    }
}
