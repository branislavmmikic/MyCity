using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.AppModels
{
    public class ImagePath
    {
        [Key]
        public int Id { get; set; }
        public string Path { get; set; }
    }
}
