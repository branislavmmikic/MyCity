using bot_backEnd.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI.Interfaces
{
    public interface IUserEntityUI
    {
        UserEntity AddUserEntity(UserEntity userEntity);
        bool DeleteUserEntity(int userEntityID);
        bool GenerateUserPassword(string email, int userTypeID);
    }
}
