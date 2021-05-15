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
    public class RankUI : IRankUI
    {
        private readonly IRankBL _iRankBL;

        public RankUI(IRankBL iRankBL)
        {
            _iRankBL = iRankBL;
        }

        public Rank AddNewRank(Rank rank, string image)
        {
            return _iRankBL.AddNewRank(rank, image);
        }

        public Rank ChangeRankData(RankVM rank)
        {
            return _iRankBL.ChangeRankData(rank);
        }

        public bool ChangeRankLogo(int rankID, string image)
        {
            return _iRankBL.ChangeRankLogo(rankID, image);
        }

        public bool DeleteRank(int rankID)
        {
            return _iRankBL.DeleteRank(rankID);
        }

        public List<Rank> GetAllRanks()
        {
            return _iRankBL.GetAllRanks();
        }
    }
}
