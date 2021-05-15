using bot_backEnd.Models.DbModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.DAL.Interfaces
{
    public interface IAdministratorDAL
    {
        Task<ActionResult<List<Administrator>>> getAllAdministrators();
        Task<ActionResult<Administrator>> AdministratorValidation(string username, string password);
        Task<ActionResult<bool>> AddAdministrator(Administrator administrator);
        Task<ActionResult<List<Administrator>>> GetAllAdministrators();
        Task<ActionResult<bool>> DeleteAdministrator(int userEntityID);
        Task<ActionResult<Administrator>> GetAdministratorByID(int adminID);
        Task<ActionResult<bool>> ChangePassword(int adminID, string oldPassword, string newPassword);
    }
}
