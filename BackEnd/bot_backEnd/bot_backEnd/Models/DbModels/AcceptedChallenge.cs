using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.DbModels
{
    public class AcceptedChallenge
    {
        public int PostID { get; set; }
        public int UserEntityID { get; set; }
        public int Status { get; set; }

        [ForeignKey("UserEntityID")]
        public virtual User User { get; set; }
    }
}
