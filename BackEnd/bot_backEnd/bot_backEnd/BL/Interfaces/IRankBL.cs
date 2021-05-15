using bot_backEnd.Models.DbModels;
using bot_backEnd.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL.Interfaces
{
    public interface IRankBL
    {
        List<Rank> GetAllRanks();
        Rank GetRankForGivenPoints(int points);
        Rank AddNewRank(Rank rank, string image);
        bool DeleteRank(int rankID);
        Rank ChangeRankData(RankVM rank);
        bool ChangeRankLogo(int rankID, string image);
    }
}
