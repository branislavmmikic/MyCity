using bot_backEnd.BL.Interfaces;
using bot_backEnd.Models;
using bot_backEnd.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI
{
    public class PostImageUI : IPostImageUI
    {
        private readonly IPostImageBL _iUploadImageBL;

        public PostImageUI(IPostImageBL iUploadImageBL)
        {
            _iUploadImageBL = iUploadImageBL;
        }
        public void AddImage(PostImage image)
        {
            _iUploadImageBL.addImage(image);
        }
        public List<PostImage> GetImagesByPostID(int id)
        {
            return _iUploadImageBL.getImagesByPostID(id);
        }
    }
}
