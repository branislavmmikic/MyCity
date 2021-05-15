using bot_backEnd.BL.Interfaces;
using bot_backEnd.DAL.Interfaces;
using bot_backEnd.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL
{
    public class UserEntityBL : IUserEntityBL
    {
        private readonly IUserEntityDAL _iUserEntityDAL;

        public UserEntityBL(IUserEntityDAL iUserEntityDAL)
        {
            _iUserEntityDAL = iUserEntityDAL;
        }

        public UserEntity AddUserEntity(UserEntity userEntity)
        {
            return _iUserEntityDAL.AddUserEntity(userEntity).Result.Value;
        }

        public bool DeleteUserEntity(int userEntityID)
        {
            return _iUserEntityDAL.DeleteUserEntity(userEntityID).Result.Value;
        }

        public bool GenerateUserPassword(string email, int userTypeID)
        {
            return _iUserEntityDAL.GenerateUserPassword(email, userTypeID).Result.Value;
        }
    }
}
