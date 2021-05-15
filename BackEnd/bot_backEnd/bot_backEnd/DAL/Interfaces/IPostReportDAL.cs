using bot_backEnd.Models.DbModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.DAL.Interfaces
{
    public interface IPostReportDAL
    {
        Task<ActionResult<List<PostReport>>> GetAllPostReports();
        Task<ActionResult<PostReport>> AddPostReport(PostReport report);
        Task<ActionResult<bool>> MarkPostReportAsRead(int reportID);
    }
}
