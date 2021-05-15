using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.ViewModels
{
    public class CommentVM
    {
        public int Id { get; set; }
        public int PostID { get; set; }
        public string Text { get; set; }
    }
}
