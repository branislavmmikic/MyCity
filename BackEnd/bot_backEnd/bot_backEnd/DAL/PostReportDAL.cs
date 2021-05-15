using bot_backEnd.DAL.Interfaces;
using bot_backEnd.Data;
using bot_backEnd.Models.DbModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.DAL
{
    public class PostReportDAL : IPostReportDAL
    {
        private readonly AppDbContext _context;

        public PostReportDAL(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<PostReport>> AddPostReport(PostReport report)
        {
            _context.PostReport.Add(report);
            await _context.SaveChangesAsync();
            return report;
        }

        public async Task<ActionResult<List<PostReport>>> GetAllPostReports()
        {
            return await _context.PostReport
                .Include(pr => pr.ReportedUser)
                .Include(pr => pr.Sender)
                .Include(pr => pr.Post)
                .ToListAsync();
        }

        public async Task<ActionResult<bool>> MarkPostReportAsRead(int reportID)
        {
            var rep = _context.PostReport.FindAsync(reportID);
            rep.Result.Read = true;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
