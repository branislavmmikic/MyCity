using bot_backEnd.Models.DbModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.ModelsWithPictures
{
    public class CommentWithImages
    {
        public Comment Comment{ get; set; }
        public IFormFile[] Images { get; set; }
    }
}

