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

namespace DesktopAPP.View.City
{
    public partial class CitySearchForm : Form
    {
        private CityService cityService;
        private IList<CityModel> cities;
        public CityModel SelectedCity { get; set; }
        public CitySearchForm()
        {
            cityService = CityService.GetInstance();
            SelectedCity = null;
            InitializeComponent();
            DialogResult = DialogResult.None;
        }

        private void CitySearchForm_Load(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao tentar obter as cidades.\n{ex.Message}");
                return null;
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedRow = dataGridView.Rows[e.RowIndex];
            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            SelectedCity = cities.FirstOrDefault(c => c.Id == id);
            DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
