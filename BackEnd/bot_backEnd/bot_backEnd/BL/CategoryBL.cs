using bot_backEnd.BL.Interfaces;
using bot_backEnd.DAL.Interfaces;
using bot_backEnd.Data;
using bot_backEnd.Models;
using bot_backEnd.Models.ViewModels.Statistic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL
{
    public class CategoryBL : ICategoryBL
    {
        private readonly ICategoryDAL _iCategoryDAL;
        private readonly IPostDAL _iPostDAL;
        public CategoryBL(ICategoryDAL iCategoryDAL, IPostDAL iPostDAL)
        {
            _iCategoryDAL = iCategoryDAL;
            _iPostDAL = iPostDAL;
        }

        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategories()
        {
            return await _iCategoryDAL.GetAllCategories();
        }

        public List<CategoryStats> GetAllCategoryStats()
        {
            List<CategoryStats> list = new List<CategoryStats>();
            var categories = GetAllCategories().Result.Value;
            var posts = _iPostDAL.GetAllDbPosts().Result.Value;

            foreach (var item in categories)
                list.Add(new CategoryStats
                {
                    Id = item.Id,
                    Name = item.Name,
                    NumOfChallenges = posts
                        .Where(p => p.TypeID == (int)Enums.PostEntityType.CHALLENGE && p.CategoryID == item.Id)
                        .Count()
                });
            return list;
        }
    }
}
