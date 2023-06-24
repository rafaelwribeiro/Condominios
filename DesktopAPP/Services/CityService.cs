using DesktopAPP.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesktopAPP.Services
{
    public class CityService
    {
        private static CityService instance;
        private readonly ICondominiosApi api;

        private CityService()
        {
            api = CondominiosApiFactory.GetApi();
        }

        public static CityService GetInstance()
        {
            if(instance == null)
                instance = new CityService();
            return instance;
        }


        public async Task<IList<City>> GetAll()
        {
            var cities = await api.GetAllAsync();
            return cities;
        }
    }
}
