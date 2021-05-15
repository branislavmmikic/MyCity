using bot_backEnd.Models;
using bot_backEnd.Models.AppModels;
using bot_backEnd.Models.ModelsWithPictures;
using bot_backEnd.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI.Interfaces
{
    public interface IPostUI
    {
        Task<ActionResult<List<Post>>> GetAllDbPosts();
        bool AddPost(PostWithImages challengeWithImages);
        bool DeletePost(int postID);
        List<AppPost> GetAllAppPosts(int userID);
        List<AppUser> GetUsersWhoLikesThisPost(int postID);
        AppPost GetAppPostByID(int postID, int userID);
        AppPost AddInstitutionPost(InstitutionPostWithImage post);
        List<AppPost> GetAppPostsByUserID(int userID);
        bool ChangePostData(PostVM post);
        List<AppPost> GetFilteredPosts(PostFilterVM filter);
        List<AppPost> GetFilteredPostsAdminPage(string filterText, int cityID, int postType);
        bool PostExistance(int postID);
    }
}
