using bot_backEnd.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL.Interfaces
{
    public interface ICommentReportBL
    {
        List<CommentReport> GetAllCommentReports();
        CommentReport AddCommentReport(CommentReport report);
        bool MarkCommentReportAsRead(int reportID);
    }
}
