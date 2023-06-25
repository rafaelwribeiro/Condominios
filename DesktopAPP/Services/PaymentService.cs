using DesktopAPP.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesktopAPP.Services
{
    public class PaymentService
    {
        private static PaymentService instance;
        private readonly ICondominiosApi api;

        private PaymentService()
        {
            api = CondominiosApiFactory.GetApi();
        }

        public static PaymentService GetInstance()
        {
            if(instance == null)
                instance = new PaymentService();
            return instance;
        }

        public async Task<IList<PaymentModel>> GetAll()
        {
            var payments = await api.GetAllPaymentsAsync();
            return payments;
        }

        public async Task Delete(int id)
        {
            await api.DeletePaymentAsync(id);
        }
    }
}
