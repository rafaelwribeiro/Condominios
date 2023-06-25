using DesktopAPP.Model;
using Refit;
using System;
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

        [Get("/cities/{id}")]
        Task<CityModel> GetCityAsync(int id);

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

        [Put("/buildings")]
        Task UpdateBuildingAsync(BuildingModel building);

        [Delete("/buildings/{id}")]
        Task DeleteBuildingAsync(int id);

        //Apartments
        [Get("/buildings/{buildingId}/apartments")]
        Task<IList<ApartmentModel>> GetAllApartmentAsync(int buildingId);

        [Post("/buildings/{buildingId}/apartments")]
        Task<ApartmentModel> PostApartmentAsync(int buildingId, ApartmentModel building);

        [Put("/buildings/{buildingId}/apartments")]
        Task UpdateApartmentAsync(int buildingId, ApartmentModel building);

        [Delete("/buildings/{buildingId}/apartments/{id}")]
        Task DeleteApartmentAsync(int buildingId, int id);
        
        [Get("/buildings/{buildingId}/apartments/{id}")]
        Task<ApartmentModel> GetApartmentAsync(int buildingId, int id);
        
        //Payments
        [Get("/payments")]
        Task<IList<PaymentModel>> GetAllPaymentsAsync();

        [Delete("/payments/{id}")]
        Task DeletePaymentAsync(int id);

        [Post("/buildings/{buildingId}/apartments/{apartmentId}/condominiumpayments")]
        Task PostPaymentAsync(int buildingId, int apartmentId, PaymentModel payment);

        [Put("/payments")]
        Task UpdatePaymentAsync(PaymentModel payment);

        //Report
        [Get("/report/{start}/{finish}")]
        Task<IList<PaymentRankingReportModel>> GetCondominiumPaymentRanking(string start, string finish);
    }
}
