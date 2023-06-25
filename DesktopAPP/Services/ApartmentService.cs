using DesktopAPP.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesktopAPP.Services
{
    public class ApartmentService
    {
        private static ApartmentService instance;
        private readonly ICondominiosApi api;

        private ApartmentService()
        {
            api = CondominiosApiFactory.GetApi();
        }

        public static ApartmentService GetInstance()
        {
            if(instance == null)
                instance = new ApartmentService();
            return instance;
        }

        public async Task<IList<ApartmentModel>> GetAll(int buildingId)
        {
            var apartments = await api.GetAllApartmentAsync(buildingId);
            return apartments;
        }

        public async Task<ApartmentModel> Post(int buildingId, ApartmentModel apartment)
        {
            return await api.PostApartmentAsync(buildingId, apartment);
        }

        public async Task Update(int buildingId, ApartmentModel apartment)
        {
            await api.UpdateApartmentAsync(buildingId, apartment);
        }

        public async Task Delete(int buildingId, int id)
        {
            await api.DeleteApartmentAsync(buildingId, id);
        }

        public async Task<ApartmentModel> GetApartmentAsync(int buildingId, int id)
        {
            try
            {
                return await api.GetApartmentAsync(buildingId, id);
            } catch (Exception ex)
            {
                return null;
            }
        }
    }
}
