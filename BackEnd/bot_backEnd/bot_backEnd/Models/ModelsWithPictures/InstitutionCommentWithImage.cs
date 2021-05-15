using bot_backEnd.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.ModelsWithPictures
{
    public class InstitutionCommentWithImage
    {
        public Comment Comment { get; set; }
        public string Image { get; set; }
    }
}
