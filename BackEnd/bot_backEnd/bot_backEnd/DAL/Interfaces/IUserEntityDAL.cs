using bot_backEnd.Models.DbModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.DAL.Interfaces
{
    public interface IUserEntityDAL
    {
        Task<ActionResult<UserEntity>> AddUserEntity(UserEntity userEntity);
        Task<ActionResult<bool>> DeleteUserEntity(int userEntityID);
        Task<ActionResult<UserEntity>> GetUserEntityByID(int userEntityID);
        Task<ActionResult<bool>> GenerateUserPassword(string email, int userTypeID);
    }
}
