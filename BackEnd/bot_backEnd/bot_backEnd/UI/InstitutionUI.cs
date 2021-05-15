using bot_backEnd.BL.Interfaces;
using bot_backEnd.Models.AppModels;
using bot_backEnd.Models.DbModels;
using bot_backEnd.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI
{
    public class InstitutionUI : IInstitutionUI
    {
        private readonly IInstitutionBL _iInstitutionBL;

        public InstitutionUI(IInstitutionBL iInstitutionBL)
        {
            _iInstitutionBL = iInstitutionBL;
        }

        public AppInstitution AddInstitution(Institution institution, string password)
        {
            return _iInstitutionBL.AddInstitution(institution, password);
        }

        public bool ChangeData(int userEntityID, string name, int headquaterID, string address, string email, string phone)
        {
            return _iInstitutionBL.ChangeData(userEntityID, name, headquaterID, address, email, phone);
        }

        public bool ChangePassword(int userEntityID, string oldPassword, string newPassword)
        {
            return _iInstitutionBL.ChangePassword(userEntityID, oldPassword, newPassword);
        }

        public bool DeleteInstitution(int userEntityID)
        {
            return _iInstitutionBL.DeleteInstitution(userEntityID);
        }

        public List<AppInstitution> GetAllAppInstitutions()
        {
            return _iInstitutionBL.GetAllAppInstitutions();
        }

        public List<Institution> getAllInstitutions()
        {
            return _iInstitutionBL.getAllInstitutions();
        }

        public AppInstitution GetAppInstitution(int userEntityID)
        {
            return _iInstitutionBL.GetAppInstitution(userEntityID);
        }

        public List<AppInstitution> GetFilteredInstitutions(string filterText, int cityID)
        {
            return _iInstitutionBL.GetFilteredInstitutions(filterText, cityID);
        }

        public Institution InstitutionValidation(string email, string password)
        {
            return _iInstitutionBL.InstitutionValidation(email, password);
        }
    }
}
