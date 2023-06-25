using DesktopAPP.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesktopAPP.Services
{
    public class ReportService
    {
        private static ReportService instance;
        private readonly ICondominiosApi api;

        private ReportService()
        {
            api = CondominiosApiFactory.GetApi();
        }

        public static ReportService GetInstance()
        {
            if(instance == null)
                instance = new ReportService();
            return instance;
        }


        public async Task<IList<PaymentRankingReportModel>> GetCondominiumPaymentRanking(DateTime start, DateTime finish)
        {
            var report = await api.GetCondominiumPaymentRanking(start.ToString("yyyy-MM-dd"), finish.ToString("yyyy-MM-dd"));
            return report;
        }
    }
}
