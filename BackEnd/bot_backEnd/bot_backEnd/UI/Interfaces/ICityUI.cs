using bot_backEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI.Interfaces
{
    public interface ICityUI
    {
        List<City> GetAllCities();
    }
}
