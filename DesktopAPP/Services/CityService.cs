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


        public async Task<IList<CityModel>> GetAll()
        {
            var cities = await api.GetAllCitiesAsync();
            return cities;
        }

        public async Task<CityModel> Post(CityModel city)
        { 
            return await api.PostCityAsync(city);
        }

        public async Task Update(CityModel city)
        {
            await api.UpdateCityAsync(city);
        }

        public async Task Delete(int id)
        {
            await api.DeleteCityAsync(id);
        }
    }
}
