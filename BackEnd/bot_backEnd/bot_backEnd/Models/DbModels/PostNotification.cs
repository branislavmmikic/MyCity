using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.DbModels
{
    public class PostNotification
    {
        public int Id { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public int NotificationTypeID { get; set; }
        public int PostID { get; set; }
        public bool Read { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("NotificationTypeID")]
        public NotificationType NotificationType { get; set; }

        [ForeignKey("ReceiverID")]
        public User Receiver { get; set; }

        [ForeignKey("SenderID")]
        public User Sender { get; set; }
        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }
    }
}
