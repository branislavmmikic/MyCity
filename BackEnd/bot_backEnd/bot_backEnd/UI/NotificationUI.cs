using bot_backEnd.BL.Interfaces;
using bot_backEnd.Models.AppModels;
using bot_backEnd.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI
{
    public class NotificationUI : INotificationUI
    {
        private readonly INotificationBL _iNotificationBL;

        public NotificationUI(INotificationBL iNotificationBL)
        {
            _iNotificationBL = iNotificationBL;
        }

        public List<AppNotification> GetAllNotificationsByUserID(int userEntityID)
        {
            return _iNotificationBL.GetAllNotificationsByUserID(userEntityID);
        }

        public bool MakeAllNotificationsAsRead(int userID)
        {
            return _iNotificationBL.MakeAllNotificationsAsRead(userID);
        }
    }
}
