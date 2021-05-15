using bot_backEnd.Models;
using bot_backEnd.Models.AppModels;
using bot_backEnd.Models.ModelsWithPictures;
using bot_backEnd.Models.ViewModels;
using bot_backEnd.Models.ViewModels.Statistic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL.Interfaces
{
    public interface IPostBL
    {
        Task<ActionResult<List<Post>>> GetAllDbPosts();
        Task<ActionResult<bool>> AddPost(PostWithImages challengeWithImages);
        bool DeletePost(int postID);
        List<AppPost> GetAllAppPosts(int userID);
        List<AppUser> GetUsersWhoLikesThisPost(int postID);
        AppPost GetAppPostByID(int postID, int? userID);
        List<Post> GetPostsByUserID(int userID);
        Task<ActionResult<AppPost>> AddInstitutionPost(InstitutionPostWithImage post);
        List<AppPost> GetAppPostsByUserID(int userID);
        bool ChangePostData(PostVM post);
        List<AppPost> GetFilteredPosts(PostFilterVM filter);
        List<AppPost> GetFilteredPostsAdminPage(string filterText, int cityID, int postType);
        bool PostExistance(int postID);
    }
}
