using bot_backEnd.DAL.Interfaces;
using bot_backEnd.Data;
using bot_backEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.DAL
{
    public class CategoryDAL : ICategoryDAL
    {
        private readonly AppDbContext _context;

        public CategoryDAL(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategories()
        {
            return await _context.Category.ToListAsync();
        }
        public async Task<ActionResult<Category>> getCategoryByID(int id)
        {
            return await _context.Category.FindAsync(id);
        }
    }
}
