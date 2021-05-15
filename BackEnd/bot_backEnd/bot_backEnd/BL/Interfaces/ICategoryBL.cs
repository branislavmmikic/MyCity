using bot_backEnd.Models;
using bot_backEnd.Models.ViewModels.Statistic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL.Interfaces
{
    public interface ICategoryBL
    {
        Task<ActionResult<IEnumerable<Category>>> GetAllCategories();
        List<CategoryStats> GetAllCategoryStats();
    }
}
