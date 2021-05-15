using bot_backEnd.Models.DbModels;
using bot_backEnd.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI.Interfaces
{
    public interface IAdministratorUI
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
