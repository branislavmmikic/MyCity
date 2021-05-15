using bot_backEnd.Models.AppModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI.Interfaces
{
    public interface INotificationUI
    {
        List<AppNotification> GetAllNotificationsByUserID(int userEntityID);
        bool MakeAllNotificationsAsRead(int userID);
    }
}
