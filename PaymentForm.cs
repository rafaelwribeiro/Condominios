using DesktopAPP.Model;
using DesktopAPP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAPP.View.Payment
{
    public partial class PaymentForm : Form
    {
        private IList<PaymentModel> payments;
        private PaymentService paymentService;
        public PaymentForm()
        {
            InitializeComponent();
            paymentService =PaymentService.GetInstance();
        }

        private async void PaymentForm_Load(object sender, EventArgs e)
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
                .ForEach(p => {
                    dataGridView.Rows.Add(p.Id, "", p.CreatedAt, p.ApartamentId, p.Value);
                }
            );
        }

        private async Task<IList<PaymentModel>> GetPayments()
        {
            try
            {
                return await paymentService.GetAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Falha ao tentar obter pagamentos.\n{ex.Message}\n\n{ex.InnerException}\n\n{ex.StackTrace}");
                return Enumerable.Empty<PaymentModel>().ToList();
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            await PopulateGrid();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int id = GetIdSelectedRow();
            if (id <= 0) return;
            DialogResult result = MessageBox.Show("Deseja excluir o registro selecionado?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;


            await paymentService.Delete(id);
            await PopulateGrid();
        }

        private int GetIdSelectedRow()
        {
            if (dataGridView.SelectedRows.Count <= 0) return -1;
            var selectedRow = dataGridView.SelectedRows[0];
            return Convert.ToInt32(selectedRow.Cells["Id"].Value);
        }
    }
}
