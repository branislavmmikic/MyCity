using bot_backEnd.Models.AppModels;
using bot_backEnd.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL.Interfaces
{
    public interface IPostReportBL
    {
        List<PostReport> GetAllPostReports();
        PostReport AddPostReport(PostReport report);
        List<AppReport> GetAllAppReports();
        bool MarkPostReportAsRead(int reportID);
    }
}
