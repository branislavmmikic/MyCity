using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.ViewModels
{
    public class TopUser
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string photoURL { get; set; }
        public int points { get; set; }
    }
}
