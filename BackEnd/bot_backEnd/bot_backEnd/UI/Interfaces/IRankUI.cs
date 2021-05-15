using bot_backEnd.Models.DbModels;
using bot_backEnd.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI.Interfaces
{
    public interface IRankUI
    {
        List<Rank> GetAllRanks();
        Rank AddNewRank(Rank rank, string image);
        bool DeleteRank(int rankID);
        Rank ChangeRankData(RankVM rank);
        bool ChangeRankLogo(int rankID, string image);
    }
}
