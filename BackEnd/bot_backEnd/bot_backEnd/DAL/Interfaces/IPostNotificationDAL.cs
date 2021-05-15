using bot_backEnd.Models.DbModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.DAL.Interfaces
{
    public interface IPostNotificationDAL
    {
        Task<ActionResult<PostNotification>> AddPostNotification(PostNotification notification);
        Task<ActionResult<List<PostNotification>>> GetAllPostNotificationsByUserID(int userEntityID);
        Task<ActionResult<bool>> DeletePostNotification(int PostID, int userEntityID, int notificationTypeID);
        Task<ActionResult<PostNotification>> GetPostNotificationByID(int postNotificationID);
        Task<ActionResult<bool>> MakeAllNotificationsRead(int userID);
    }
}
