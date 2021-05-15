using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.AppModels
{
    public class AppReply
    {
        public int Id { get; set; }
        public int PostID { get; set; }
        public int? ParrentID { get; set; }
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public int Likes { get; set; }
        public string Text { get; set; }
        public string ProfileImage { get; set; }
        public bool LikedByUser { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int UserTypeID { get; set; }
    }
}
