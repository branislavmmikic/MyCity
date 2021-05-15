using bot_backEnd.BL;
using bot_backEnd.BL.Interfaces;
using bot_backEnd.Models.DbModels;
using bot_backEnd.Models.ViewModels;
using bot_backEnd.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI
{
    public class AdministratorUI : IAdministratorUI
    {
        private readonly IAdministratorBL _iAdministratorBL;
        public AdministratorUI(IAdministratorBL iAdministratorBL)
        {
            _iAdministratorBL = iAdministratorBL;
        }

        public Administrator AddAdministrator(string email, string username, string password)
        {
            return _iAdministratorBL.AddAdministrator(email, username, password);
        }

        public Administrator AdministratorValidation(string username, string password)
        {
            return _iAdministratorBL.AdministratorValidation(username, password);
        }

        public bool ChangePassword(int adminID, string oldPassword, string newPassword)
        {
            return _iAdministratorBL.ChangePassword(adminID, oldPassword, newPassword);
        }

        public bool DeleteAdministrator(int userEntityID)
        {
            return _iAdministratorBL.DeleteAdministrator(userEntityID);
        }

        public Administrator GetAdministratorByID(int adminID)
        {
            return _iAdministratorBL.GetAdministratorByID(adminID);
        }

        public List<Administrator> GetAllAdministrators()
        {
            return _iAdministratorBL.GetAllAdministrators();
        }

        public List<Administrator> GetFilteredAdministrators(string filterText)
        {
            return _iAdministratorBL.GetFilteredAdministrators(filterText);
        }

        public AdministratorStats GetStatisticForDashboard()
        {
            return _iAdministratorBL.GetStatisticForDashboard();
        }
    }
}
