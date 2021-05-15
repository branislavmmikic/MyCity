using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.ViewModels.Statistic
{
    public class CategoryStats
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumOfChallenges { get; set; }
    }
}
