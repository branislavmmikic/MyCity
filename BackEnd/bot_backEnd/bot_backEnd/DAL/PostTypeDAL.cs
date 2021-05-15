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
    public class PostTypeDAL : IPostTypeDAL
    {
        private readonly AppDbContext _context;

        public PostTypeDAL(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<List<PostType>>> GetAllPostTypes()
        {
            return await _context.PostType.ToListAsync();
        }
    }
}
