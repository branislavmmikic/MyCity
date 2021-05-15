using bot_backEnd.BL.Interfaces;
using bot_backEnd.Models.DbModels;
using bot_backEnd.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI
{
    public class CommentReportUI : ICommentReportUI
    {
        private readonly ICommentReportBL _iCommentReportBL;

        public CommentReportUI(ICommentReportBL iCommentReportBL)
        {
            _iCommentReportBL = iCommentReportBL;
        }

        public CommentReport AddCommentReport(CommentReport report)
        {
            return _iCommentReportBL.AddCommentReport(report);
        }

        public List<CommentReport> GetAllCommentReports()
        {
            return _iCommentReportBL.GetAllCommentReports();
        }

        public bool MarkCommentReportAsRead(int reportID)
        {
            return _iCommentReportBL.MarkCommentReportAsRead(reportID);
        }
    }
}
