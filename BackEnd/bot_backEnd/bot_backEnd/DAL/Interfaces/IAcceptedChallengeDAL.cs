using bot_backEnd.Models;
using bot_backEnd.Models.DbModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.DAL.Interfaces
{
    public interface IAcceptedChallengeDAL
    {
        Task<ActionResult<AcceptedChallenge>> AddAcceptedChallenge(AcceptedChallenge challenge);
        Task<ActionResult<bool>> DeleteAcceptedChallenge(int postEntityID, int userEntityID);
        Task<ActionResult<List<Post>>> GetAcceptedChallengesByUserID(int userID);
        Task<ActionResult<AcceptedChallenge>> GetAcceptedChallengeByPK(int postEntityID, int userEntityID);
        Task<ActionResult<bool>> ChangeStatus(int postEntityID, int userEntityID, int status);
        Task<ActionResult<int>> GetWithdrawalNumber(int userEntityID);
        Task<ActionResult<List<int>>> UsersWhoAcceptedChallenge(int postEntityID, int userID);
    }
}
