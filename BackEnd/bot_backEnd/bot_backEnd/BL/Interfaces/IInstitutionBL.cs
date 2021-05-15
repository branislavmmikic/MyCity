using bot_backEnd.Models.AppModels;
using bot_backEnd.Models.DbModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL.Interfaces
{
    public interface IInstitutionBL
    {
        List<Institution> getAllInstitutions();
        Institution InstitutionValidation(string email, string password);
        AppInstitution AddInstitution(Institution institution, string password);
        bool DeleteInstitution(int userEntityID);
        bool ChangePassword(int userEntityID, string oldPassword, string newPassword);
        bool ChangeData(int userEntityID, string name, int headquaterID, string address, string email, string phone);
        AppInstitution GetAppInstitution(int userEntityID);
        List<AppInstitution> GetAllAppInstitutions();
        List<AppInstitution> GetFilteredInstitutions(string filterText, int cityID);
    }
}
