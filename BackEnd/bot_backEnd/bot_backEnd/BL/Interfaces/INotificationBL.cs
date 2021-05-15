using bot_backEnd.Models.AppModels;
using bot_backEnd.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL.Interfaces
{
    public interface INotificationBL
    {
        bool AddCommentNotification(CommentNotification commentNotif);
        bool AddPostNotification(PostNotification entityNotif);
        List<AppNotification> GetAllNotificationsByUserID(int userEntityID);
        bool DeleteCommentNotification(int commentID, int PostID, int userID, int notificationType);
        bool DeletePostNotification(int PostID, int userID, int notificationType);
        bool CheckUnreadNotification(int userID);
        bool MakeAllNotificationsAsRead(int userID);
    }
}
