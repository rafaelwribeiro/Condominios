using DesktopAPP.Model;
using DesktopAPP.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAPP.View.Ranking
{
    public partial class RankingForm : Form
    {
        private ReportService reportService;
        private IList<PaymentRankingReportModel> payments;
        public RankingForm()
        {
            InitializeComponent();
            reportService = ReportService.GetInstance();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await PopulateGrid();
        }
        private async Task PopulateGrid()
        {
            payments = await GetPayments();
            if (payments == null) return;

            dataGridView.Rows.Clear();
            payments
                .ToList()
                .ForEach(payment => {
                    dataGridView.Rows.Add(
                        payment.Id,
                        payment.ApartmentId,
                        payment.BuildingId,
                        payment.BuildingName,
                        payment.SizeM2,
                        payment.Floor,
                        payment.RoomQuantity,
                        payment.CityName,
                        payment.State,
                        payment.Value
                        );
                }
            );
        }

        private async Task<IList<PaymentRankingReportModel>> GetPayments()
        {
            try
            {
                return await reportService.GetCondominiumPaymentRanking(dtpStart.Value, dtpFinish.Value);
            } catch (Exception ex)
            {
                MessageBox.Show($"Falha ao obter dados do relatório. \n{ex.Message}\n\n{ex.StackTrace}");
                return new List<PaymentRankingReportModel>();
            }
            
        }
    }
}
