using bot_backEnd.Models.AppModels;
using bot_backEnd.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL.Interfaces
{
    public interface IAcceptedChallengeBL
    {
        AcceptedChallenge AddAcceptedChallenge(AcceptedChallenge challenge);
        bool DeleteAcceptedChallenge(int postEntityID, int userEntityID);
        List<AppAcceptedChallenge> GetAcceptedChallengesByUserID(int userID);
        int GetWithdrawalNumber(int userEntityID);
    }
}
