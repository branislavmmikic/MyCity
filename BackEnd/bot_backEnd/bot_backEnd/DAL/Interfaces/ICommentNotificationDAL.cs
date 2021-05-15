using bot_backEnd.Models.DbModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.DAL.Interfaces
{
    public interface ICommentNotificationDAL
    {
        Task<ActionResult<CommentNotification>> AddCommentNotification(CommentNotification notification);
        Task<ActionResult<List<CommentNotification>>> GetAllCommentNotificationsByUserID(int userEntityID);
        Task<ActionResult<bool>> DeleteCommentNotification(int commentID, int PostID, int userEntityID, int notificationTypeID);
        Task<ActionResult<CommentNotification>> GetCommentNotificationByID(int commentNotificationID);
        Task<ActionResult<bool>> MakeAllNotificationsRead(int userID);
    }
}
