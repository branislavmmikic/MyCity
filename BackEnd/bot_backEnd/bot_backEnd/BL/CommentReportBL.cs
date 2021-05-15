using bot_backEnd.BL.Interfaces;
using bot_backEnd.DAL.Interfaces;
using bot_backEnd.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL
{
    public class CommentReportBL : ICommentReportBL
    {
        private readonly ICommentReportDAL _iCommentReportDAL;

        public CommentReportBL(ICommentReportDAL iCommentReportDAL)
        {
            _iCommentReportDAL = iCommentReportDAL;
        }

        public CommentReport AddCommentReport(CommentReport report)
        {
            return _iCommentReportDAL.AddCommentReport(report).Result.Value;
        }

        public List<CommentReport> GetAllCommentReports()
        {
            return _iCommentReportDAL.GetAllCommentReports().Result.Value;
        }

        public bool MarkCommentReportAsRead(int reportID)
        {
            return _iCommentReportDAL.MarkCommentReportAsRead(reportID).Result.Value;
        }
    }
}
