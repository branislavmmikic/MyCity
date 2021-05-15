using bot_backEnd.Models.DbModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.DAL.Interfaces
{
    public interface IUserEntityImageDAL
    {
        Task<ActionResult<bool>> AddUserProfilePhoto(UserEntityImage image, int userEntityID);
        Task<ActionResult<bool>> UpdateUserProfilePhoto(int userEntityID, string fileName);
        Task<ActionResult<UserEntityImage>> GetEntityImageByUserEntityID(int userEntityID);
        Task<ActionResult<bool>> DeleteUserProfilePhoto(int userEntityID, IWebHostEnvironment environment);
        Task<ActionResult<bool>> UpdateImage(int imageID, string path, string ext, int userEntityID);
    }
}
