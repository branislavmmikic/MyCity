using bot_backEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.DAL.Interfaces
{
    public interface ICategoryDAL
    {
        Task<ActionResult<IEnumerable<Category>>> GetAllCategories();
        Task<ActionResult<Category>> getCategoryByID(int id);
    }
}
