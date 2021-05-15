using bot_backEnd.BL.Interfaces;
using bot_backEnd.Models;
using bot_backEnd.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI
{
    public class CityUI : ICityUI
    {
        private readonly ICityBL _iCityBL;

        public CityUI(ICityBL iCityBL)
        {
            _iCityBL = iCityBL;
        }

        public List<City> GetAllCities()
        {
            return _iCityBL.GetAllCities();
        }
    }
}
