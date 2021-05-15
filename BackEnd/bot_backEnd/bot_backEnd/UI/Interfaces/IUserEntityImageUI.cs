using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI.Interfaces
{
    public interface IUserEntityImageUI
    {
        bool ChangeUserProfilePicture(IFormFile image, int userEntityID);
        bool DeleteUserProfilePhoto(int userEntityID);
        string ChangeInstitutionProfilePhoto(int userEntityID, string image);
    }
}
