using bot_backEnd.Models;
using bot_backEnd.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.DAL.Interfaces
{
    public interface IUserDAL
    {
        Task<ActionResult<IEnumerable<User>>> GetAllUsers();
        Task<ActionResult<User>> AddUser(User user);
        Task<ActionResult<User>> GetUserByID(int id);
        Task<ActionResult<User>> UpdateUserInfo(UserVM userVM);
        Task<ActionResult<bool>> UpdateUserPassword(int userID, string oldPassword, string newPassword);
        Task<ActionResult<bool>> CheckUserExistance(int userID);
    }
}
