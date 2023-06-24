using DesktopAPP.Model;
using Refit;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesktopAPP.Services
{
    public interface ICondominiosApi
    {
        [Get("/cities")]
        Task<IList<CityModel>> GetAllAsync();

        [Post("/cities")]
        Task<CityModel> PostAsync(CityModel city);
        [Put("/cities")]
        Task UpdateAsync(CityModel city);
        [Delete("/cities/{id}")]
        Task DeleteAsync(int id);
    }
}
