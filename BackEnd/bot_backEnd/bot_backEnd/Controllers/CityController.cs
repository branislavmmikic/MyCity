using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bot_backEnd.UI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bot_backEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityUI _iCityUI;

        public CityController(ICityUI iCityUI)
        {
            _iCityUI = iCityUI;
        }

        public IActionResult GetAllCities()
        {
            try
            {
                return Ok(_iCityUI.GetAllCities());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}