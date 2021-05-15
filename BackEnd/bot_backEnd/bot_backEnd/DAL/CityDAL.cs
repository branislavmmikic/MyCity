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
    public class CityDAL : ICityDAL
    {
        private readonly AppDbContext _context;

        public CityDAL(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<List<City>>> GetAllCities()
        {
            return await _context.City.ToListAsync();
        }
    }
}
