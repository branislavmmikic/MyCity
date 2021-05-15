using bot_backEnd.Models.DbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.AppModels
{
    public class CommentLike
    {
        public int CommentID { get; set; }
        public int PostID { get; set; }
        public int UserEntityID { get; set; }
        public int Value { get; set; }

        public virtual Comment Comment { get; set; }

        [ForeignKey("UserEntityID")]
        public virtual User User { get; set; }
    }
}
