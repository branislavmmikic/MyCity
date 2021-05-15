using bot_backEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI.Interfaces
{
    public interface ICategoryUI
    {
        Task<ActionResult<IEnumerable<Category>>> GetAllCategories();
    }
}
