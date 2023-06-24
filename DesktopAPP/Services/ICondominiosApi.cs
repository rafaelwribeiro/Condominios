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
        Task<IList<City>> GetAllAsync();
    }
}
