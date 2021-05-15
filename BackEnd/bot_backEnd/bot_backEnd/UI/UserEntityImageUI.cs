using bot_backEnd.BL.Interfaces;
using bot_backEnd.UI.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI
{
    public class UserEntityImageUI : IUserEntityImageUI
    {
        private readonly IUserEntityImageBL _iUserEntityImageBL;

        public UserEntityImageUI(IUserEntityImageBL iUserEntityImageBL)
        {
            _iUserEntityImageBL = iUserEntityImageBL;
        }

        public string ChangeInstitutionProfilePhoto(int userEntityID, string image)
        {
            return _iUserEntityImageBL.ChangeInstitutionProfilePhoto(userEntityID, image).Result;
        }

        public bool ChangeUserProfilePicture(IFormFile image, int userEntityID)
        {
            return _iUserEntityImageBL.ChangeUserProfilePicture(image, userEntityID).Result;
        }

        public bool DeleteUserProfilePhoto(int userEntityID)
        {
            return _iUserEntityImageBL.DeleteUserProfilePhoto(userEntityID);
        }
    }
}
