using bot_backEnd.Models.DbModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.DAL.Interfaces
{
    public interface ICommentReportDAL
    {
        Task<ActionResult<List<CommentReport>>> GetAllCommentReports();
        Task<ActionResult<CommentReport>> AddCommentReport(CommentReport report);
        Task<ActionResult<bool>> MarkCommentReportAsRead(int reportID);
    }
}
