using DesktopAPP.Model;
using DesktopAPP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAPP.View.City
{
    public partial class CityForm : Form
    {
        private CityService cityService;
        private IList<CityModel> cities;
        public CityForm()
        {
            cityService = CityService.GetInstance();
            InitializeComponent();
        }

        private void CityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((Form)sender).Dispose();
        }

        private void CityForm_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private async Task PopulateGrid()
        {
            cities = await GetCities();
            if (cities == null) return;

            dataGridView.Rows.Clear();
            cities
                //.Where(c => c.State != "SP")
                .ToList()
                .ForEach(city => {
                    dataGridView.Rows.Add(city.Id, city.Name, city.State);
                }
            );            
        }

        private async Task<IList<CityModel>> GetCities()
        {
            try
            {
                return await cityService.GetAll();
            } catch(Exception ex)
            {
                MessageBox.Show($"Falha ao tentar obter as cidades.\n{ex.Message}");
                return null;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new EditCityForm();
            frm.ShowDialog();
            await PopulateGrid();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            await PopulateGrid();
        }

        private async void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedRow = dataGridView.Rows[e.RowIndex];
            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            EditRegistry(id);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int id = GetIdSelectedRow();
            if(id<=0) return;
            DialogResult result = MessageBox.Show("Você excluir o registro selecionado?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            
            await cityService.Delete(id);
            await PopulateGrid();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = GetIdSelectedRow();
            if (id <= 0) return;
            EditRegistry(id);
        }

        private int GetIdSelectedRow()
        {
            if (dataGridView.SelectedRows.Count <= 0) return -1;
            var selectedRow = dataGridView.SelectedRows[0];
            return Convert.ToInt32(selectedRow.Cells["Id"].Value);
        }

        private async void EditRegistry(int id)
        {
            var city = cities.FirstOrDefault(c => c.Id == id);

            var editForm = new EditCityForm(city);
            editForm.ShowDialog();
            if(editForm.DialogResult ==  DialogResult.OK)
                await PopulateGrid();
        }
    }
}
