using bot_backEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI.Interfaces
{
    public interface IPostImageUI
    {
        void AddImage(PostImage image);
        List<PostImage> GetImagesByPostID(int id);
    }
}
