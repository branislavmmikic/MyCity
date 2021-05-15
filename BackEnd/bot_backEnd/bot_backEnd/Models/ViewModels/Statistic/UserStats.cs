using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.ViewModels
{
    public class UserStats
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BithDate { get; set; }
        public DateTime JoinDate { get; set; }
        public int GenderID { get; set; }
        public int NumOfEcoFPoints { get; set; }
    }
}
