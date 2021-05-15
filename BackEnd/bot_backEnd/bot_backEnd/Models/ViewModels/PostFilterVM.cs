using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.ViewModels
{
    public class PostFilterVM
    {
        public int UserEntityID { get; set; }
        public int CityID { get; set; }
        public int CategoryID { get; set; }
        public bool ChallengePost { get; set; }
        public bool UserPost { get; set; }
        public bool InstitutionPost { get; set; }
        public int Counter { get; set; }
    }
}
