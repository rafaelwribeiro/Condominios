using DesktopAPP.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAPP.Services
{
    public class BuildingService
    {
        private static BuildingService instance;
        private readonly ICondominiosApi api;

        private BuildingService()
        {
            api = CondominiosApiFactory.GetApi();
        }

        public static BuildingService GetInstance()
        {
            if (instance == null)
                instance = new BuildingService();
            return instance;
        }

        public async Task<IList<BuildingModel>> GetAll()
        {
            var buildings = await api.GetAllBuildingsAsync();
            return buildings;
        }

        public async Task<BuildingModel> Post(BuildingModel building)
        {
            return await api.PostBuildingAsync(building);
        }

        public async Task Update(BuildingModel building)
        {
            await api.UpdateBuildingAsync(building);
        }

        public async Task Delete(int id)
        {
            await api.DeleteBuildingAsync(id);
        }

    }
}
