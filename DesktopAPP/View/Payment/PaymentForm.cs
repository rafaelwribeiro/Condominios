using DesktopAPP.Model;
using DesktopAPP.Services;
using DesktopAPP.View.City;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            paymentService = PaymentService.GetInstance();
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
                    dataGridView.Rows.Add(p.Id, p.Apartment.Building.DisplayName, p.CreatedAt, p.ApartmentId, p.Value);
                }
            );
        }

        private async Task<IList<PaymentModel>> GetPayments()
        {
            try
            {
                return await paymentService.GetAll();
            }
            catch (Exception ex)
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
            try
            {
                int id = GetIdSelectedRow();
                if (id <= 0) return;
                DialogResult result = MessageBox.Show("Deseja excluir o registro selecionado?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;


                await paymentService.Delete(id);
                await PopulateGrid();
            } catch(Exception ex)
            {
                MessageBox.Show($"Falha ao tentar excluir registro. \n{ex.Message} \n\n {ex.StackTrace}");
            }
        }

        private int GetIdSelectedRow()
        {
            if (dataGridView.SelectedRows.Count <= 0) return -1;
            var selectedRow = dataGridView.SelectedRows[0];
            return Convert.ToInt32(selectedRow.Cells["Id"].Value);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = GetIdSelectedRow();
            if (id <= 0) return;
            EditRegistry(id);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedRow = dataGridView.Rows[e.RowIndex];
            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            EditRegistry(id);
        }

        private async void EditRegistry(int id)
        {
            var payment = payments.FirstOrDefault(c => c.Id == id);

            var editForm = new EditPaymentForm(payment);
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
                await PopulateGrid();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new EditPaymentForm();
            frm.ShowDialog();
            await PopulateGrid();
        }
    }
}
