using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL.Interfaces
{
    public interface IUserEntityImageBL
    {
        Task<bool> ChangeUserProfilePicture(IFormFile image, int userEntityID);
        bool DeleteUserProfilePhoto(int userEntityID);
        Task<string> ChangeInstitutionProfilePhoto(int userEntityID, string image);
    }
}
