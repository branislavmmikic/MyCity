using bot_backEnd.Models.AppModels;
using bot_backEnd.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI.Interfaces
{
    public interface IAcceptedChallengeUI
    {
        AcceptedChallenge AddAcceptedChallenge(AcceptedChallenge challenge);
        bool DeleteAcceptedChallenge(int postEntityID, int userEntityID);
        List<AppAcceptedChallenge> GetAcceptedChallengesByUserID(int userID);
    }
}
