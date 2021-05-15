using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Post> Posts { get; set; }
        //public virtual List<HomePagePost> HomePagePosts { get; set; }
    }
}
