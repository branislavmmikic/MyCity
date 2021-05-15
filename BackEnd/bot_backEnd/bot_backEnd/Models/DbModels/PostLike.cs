using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.DbModels
{
    public class PostLike
    {
        public int PostID { get; set; }
        public int UserID { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        public virtual Post Post { get; set; }
    }
}
