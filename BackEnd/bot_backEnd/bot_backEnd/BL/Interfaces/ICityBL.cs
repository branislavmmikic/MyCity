using bot_backEnd.Models;
using bot_backEnd.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.BL.Interfaces
{
    public interface ICityBL
    {
        List<City> GetAllCities();
        List<CityStats> GetAllCitiesStats();
    }
}
