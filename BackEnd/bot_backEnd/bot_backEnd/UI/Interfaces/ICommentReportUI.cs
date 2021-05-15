using bot_backEnd.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI.Interfaces
{
    public interface ICommentReportUI
    {
        CommentReport AddCommentReport(CommentReport report);
        List<CommentReport> GetAllCommentReports();
        bool MarkCommentReportAsRead(int reportID);
    }
}
