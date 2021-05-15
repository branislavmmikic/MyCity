using bot_backEnd.BL.Interfaces;
using bot_backEnd.DAL.Interfaces;
using bot_backEnd.Models.AppModels;
using bot_backEnd.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL
{
    public class AcceptedChallengeBL : IAcceptedChallengeBL
    {
        private readonly IAcceptedChallengeDAL _iAcceptedChallengeDAL;
        private readonly IPostImageDAL _iPostImageDAL;
        
        public AcceptedChallengeBL(IAcceptedChallengeDAL iAcceptedChallengeDAL, IPostImageDAL iPostImageDAL)
        {
            _iAcceptedChallengeDAL = iAcceptedChallengeDAL;
            _iPostImageDAL = iPostImageDAL;
        }

        public AcceptedChallenge AddAcceptedChallenge(AcceptedChallenge challenge)
        {
            return _iAcceptedChallengeDAL.AddAcceptedChallenge(challenge).Result.Value;
        }

        public bool DeleteAcceptedChallenge(int postEntityID, int userEntityID)
        {
            return _iAcceptedChallengeDAL.DeleteAcceptedChallenge(postEntityID, userEntityID).Result.Value;
        }
        public List<AppAcceptedChallenge> GetAcceptedChallengesByUserID(int userID)
        {
            List<AppAcceptedChallenge> list = new List<AppAcceptedChallenge>();
            var posts = _iAcceptedChallengeDAL.GetAcceptedChallengesByUserID(userID).Result.Value;

            foreach (var item in posts)
            {
                var url = _iPostImageDAL.GetImagesURLByPostID(item.Id).Result.Value[0];
                AppAcceptedChallenge challenge = new AppAcceptedChallenge
                {
                    PostID = item.Id,
                    UserEntityID = userID,
                    Title = item.Title,
                    EndDate = (DateTime)item.EndDate,
                    Image = new ImagePath
                    {
                        Path = url.ToString()
                    },
                    Status = _iAcceptedChallengeDAL.GetAcceptedChallengeByPK(item.Id, userID).Result.Value.Status
                };
                list.Add(challenge);
            }
            return list;
        }

        public int GetWithdrawalNumber(int userEntityID)
        {
            return _iAcceptedChallengeDAL.GetWithdrawalNumber(userEntityID).Result.Value;
        }
    }
}
