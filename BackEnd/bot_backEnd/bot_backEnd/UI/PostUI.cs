﻿using bot_backEnd.BL.Interfaces;
using bot_backEnd.Models;
using bot_backEnd.Models.AppModels;
using bot_backEnd.Models.ModelsWithPictures;
using bot_backEnd.Models.ViewModels;
using bot_backEnd.UI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI
{
    public class PostUI : IPostUI
    {
        private readonly IPostBL _iPostBL;

        public PostUI(IPostBL iChallengePostBL)
        {
            _iPostBL = iChallengePostBL;
        }
        public bool AddPost(PostWithImages challengeWithImages)
        {
            return _iPostBL.AddPost(challengeWithImages).Result.Value;
        }
        public async Task<ActionResult<List<Post>>> GetAllDbPosts()
        {
            return await _iPostBL.GetAllDbPosts();
        }
        public List<AppPost> GetAllAppPosts(int userID)
        {
            return _iPostBL.GetAllAppPosts(userID);
        }

        public List<AppUser> GetUsersWhoLikesThisPost(int postID)
        {
            return _iPostBL.GetUsersWhoLikesThisPost(postID);
        }
        public bool DeletePost(int postID)
        {
            return _iPostBL.DeletePost(postID);
        }

        public AppPost GetAppPostByID(int postID, int userID)
        {
            return _iPostBL.GetAppPostByID(postID, userID);
        }

        public AppPost AddInstitutionPost(InstitutionPostWithImage post)
        {
            return _iPostBL.AddInstitutionPost(post).Result.Value;
        }

        public List<AppPost> GetAppPostsByUserID(int userID)
        {
            return _iPostBL.GetAppPostsByUserID(userID);
        }

        public bool ChangePostData(PostVM post)
        {
            return _iPostBL.ChangePostData(post);
        }

        public List<AppPost> GetFilteredPosts(PostFilterVM filter)
        {
            return _iPostBL.GetFilteredPosts(filter);
        }

        public List<AppPost> GetFilteredPostsAdminPage(string filterText, int cityID, int postType)
        {
            return _iPostBL.GetFilteredPostsAdminPage(filterText, cityID, postType);
        }

        public bool PostExistance(int postID)
        {
            return _iPostBL.PostExistance(postID);
        }
    }
}
