using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.AppModels
{
    public class AppNotification
    {
        public string Header { get; set; }
        public ImagePath UserProfilePhoto { get; set; }
        public ImagePath PostImage { get; set; }
        public DateTime Date { get; set; }
        public int PostID { get; set; }
        public int NotificationType { get; set; }
    }
}
