using bot_backEnd.Models.DbModels;
using bot_backEnd.Models.ViewModels.Statistic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL.Interfaces
{
    public interface IPostTypeBL
    {
        List<PostType> GetAllPostTypes();
        List<TypeStats> GetPostTypeStats();
    }
}
