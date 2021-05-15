using bot_backEnd.DAL.Interfaces;
using bot_backEnd.Models.DbModels;
using bot_backEnd.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL.Interfaces
{
    public interface IAdministratorBL
    {
        Administrator AdministratorValidation(string username, string password);
        Administrator AddAdministrator(string email, string username, string password);
        List<Administrator> GetAllAdministrators();
        bool DeleteAdministrator(int userEntityID);
        AdministratorStats GetStatisticForDashboard();
        Administrator GetAdministratorByID(int adminID);
        List<Administrator> GetFilteredAdministrators(string filterText);
        bool ChangePassword(int adminID, string oldPassword, string newPassword);
    }
}
