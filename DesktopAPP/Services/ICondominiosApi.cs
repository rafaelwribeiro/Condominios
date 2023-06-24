using DesktopAPP.Model;
using Refit;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesktopAPP.Services
{
    public interface ICondominiosApi
    {
        //Cities
        [Get("/cities")]
        Task<IList<CityModel>> GetAllCitiesAsync();

        [Post("/cities")]
        Task<CityModel> PostCityAsync(CityModel city);

        [Put("/cities")]
        Task UpdateCityAsync(CityModel city);

        [Delete("/cities/{id}")]
        Task DeleteCityAsync(int id);

        //Buildings
        [Get("/buildings")]
        Task<IList<BuildingModel>> GetAllBuildingsAsync();

        [Post("/buildings")]
        Task<BuildingModel> PostBuildingAsync(BuildingModel building);

        [Put("/buildibuildingsng")]
        Task UpdateBuildingAsync(BuildingModel building);

        [Delete("/buildings/{id}")]
        Task DeleteBuildingAsync(int id);
    }
}
