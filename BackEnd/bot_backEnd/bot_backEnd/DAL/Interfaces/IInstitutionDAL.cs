using bot_backEnd.Models.DbModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.DAL.Interfaces
{
    public interface IInstitutionDAL
    {
        Task<ActionResult<List<Institution>>> getAllInstitutions();
        Task<ActionResult<Institution>> AddInstitution(Institution institution);
        Task<ActionResult<bool>> DeleteInstitution(int userEntityID);
        Task<ActionResult<bool>> ChangePassword(int userEntityID, string oldPassword, string newPassword);
        Task<ActionResult<bool>> ChangeData(int userEntityID, string name, int headquaterID, string address, string email, string phone);
        Task<ActionResult<Institution>> GetInstitutionByID(int userEntityID);
    }
}
