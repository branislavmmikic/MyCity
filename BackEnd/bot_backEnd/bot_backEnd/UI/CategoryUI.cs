using bot_backEnd.BL.Interfaces;
using bot_backEnd.Models;
using bot_backEnd.UI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI
{
    public class CategoryUI : ICategoryUI
    {
        private readonly ICategoryBL _iCategoryBL;

        public CategoryUI(ICategoryBL iCategoryBL)
        {
            _iCategoryBL = iCategoryBL;
        }

        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategories()
        {
            return await _iCategoryBL.GetAllCategories();
        }
    }
}
