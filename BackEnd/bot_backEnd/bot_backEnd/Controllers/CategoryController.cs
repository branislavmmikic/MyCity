using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bot_backEnd.Models;
using bot_backEnd.UI.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bot_backEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryUI _iCategoryUI;

        public CategoryController(ICategoryUI iCategoryUI)
        {
            _iCategoryUI = iCategoryUI;
        }

        [Authorize(Roles = "User, Institution, Admin")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategories()
        {
            return await _iCategoryUI.GetAllCategories();
        }
    }
}