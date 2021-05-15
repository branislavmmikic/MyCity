using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.ModelsWithPictures
{
    public class PostWithImages
    {
        public Post Challenge { get; set; }
        public IFormFile[] Images { get; set; }
    }
}
