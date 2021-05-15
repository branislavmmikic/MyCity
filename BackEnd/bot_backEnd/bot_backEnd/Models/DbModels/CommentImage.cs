using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.DbModels
{
    public class CommentImage
    {
        [Key]
        public int Id { get; set; }
        public int CommentID { get; set; }
        public int PostID { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }

        public Comment Comment { get; set; }
    }
}
