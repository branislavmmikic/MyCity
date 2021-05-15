using bot_backEnd.BL.Interfaces;
using bot_backEnd.Models.AppModels;
using bot_backEnd.Models.DbModels;
using bot_backEnd.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI
{
    public class PostReportUI : IPostReportUI
    {
        private readonly IPostReportBL _iPostReportBL;

        public PostReportUI(IPostReportBL iPostReportBL)
        {
            _iPostReportBL = iPostReportBL;
        }

        public PostReport AddPostReport(PostReport report)
        {
            return _iPostReportBL.AddPostReport(report);
        }

        public List<AppReport> GetAllAppReports()
        {
            return _iPostReportBL.GetAllAppReports();
        }

        public List<PostReport> GetAllPostReports()
        {
            return _iPostReportBL.GetAllPostReports();
        }

        public bool MarkPostReportAsRead(int reportID)
        {
            return _iPostReportBL.MarkPostReportAsRead(reportID);
        }
    }
}
