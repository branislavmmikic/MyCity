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
    public class AcceptedChallengeUI : IAcceptedChallengeUI
    {
        private readonly IAcceptedChallengeBL _iAcceptedChallengeBL;

        public AcceptedChallengeUI(IAcceptedChallengeBL iAcceptedChallengeBL)
        {
            _iAcceptedChallengeBL = iAcceptedChallengeBL;
        }

        public AcceptedChallenge AddAcceptedChallenge(AcceptedChallenge challenge)
        {
            return _iAcceptedChallengeBL.AddAcceptedChallenge(challenge);
        }

        public bool DeleteAcceptedChallenge(int postEntityID, int userEntityID)
        {
            return _iAcceptedChallengeBL.DeleteAcceptedChallenge(postEntityID, userEntityID);
        }
        public List<AppAcceptedChallenge> GetAcceptedChallengesByUserID(int userID)
        {
            return _iAcceptedChallengeBL.GetAcceptedChallengesByUserID(userID);
        }
    }
}
