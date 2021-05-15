using bot_backEnd.BL.Interfaces;
using bot_backEnd.Models.DbModels;
using bot_backEnd.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI
{
    public class UserEntityUI : IUserEntityUI
    {
        private readonly IUserEntityBL _iUserEntityBL;

        public UserEntityUI(IUserEntityBL iUserEntityBL)
        {
            _iUserEntityBL = iUserEntityBL;
        }

        public UserEntity AddUserEntity(UserEntity userEntity)
        {
            return _iUserEntityBL.AddUserEntity(userEntity);
        }

        public bool DeleteUserEntity(int userEntityID)
        {
            return _iUserEntityBL.DeleteUserEntity(userEntityID);
        }

        public bool GenerateUserPassword(string email, int userTypeID)
        {
            return _iUserEntityBL.GenerateUserPassword(email, userTypeID);
        }
    }
}
