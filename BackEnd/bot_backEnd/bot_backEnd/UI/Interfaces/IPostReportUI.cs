using bot_backEnd.Models.AppModels;
using bot_backEnd.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI.Interfaces
{
    public interface IPostReportUI
    {
        PostReport AddPostReport(PostReport report);
        List<PostReport> GetAllPostReports();
        List<AppReport> GetAllAppReports();
        bool MarkPostReportAsRead(int reportID);
    }
}
