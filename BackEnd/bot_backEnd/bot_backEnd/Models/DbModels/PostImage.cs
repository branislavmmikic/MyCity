using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models
{
    public class PostImage
    {
        [Key]
        public int Id { get; set; }
        public int PostID { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
    }
}
