using bot_backEnd.Models;
using bot_backEnd.Models.AppModels;
using bot_backEnd.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.DAL.Interfaces
{
    public interface IPostDAL
    {
        Task<ActionResult<List<Post>>> GetAllDbPosts();
        Task<ActionResult<Post>> AddPost(Post post);
        Task<ActionResult<bool>> DeletePost(int postID);
        Task<ActionResult<Post>> GetDbPostByID(int id);
        Task<ActionResult<int>> GetPostTypeID(int postID);
        Task<ActionResult<List<Post>>> GetPostsByUserID(int userID);
        Task<ActionResult<int>> GetNumberOfPostsByUserID(int userEntityID);
        Task<ActionResult<bool>> ChangePostData(PostVM newPost);
        Task<ActionResult<bool>> PostExistance(int postID);
    }
}
