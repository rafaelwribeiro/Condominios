using DesktopAPP.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAPP.View.City
{
    public partial class CityForm : Form
    {
        private CityService cityService;
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
            var cities = await GetCities();
            if (cities == null) return;

            foreach (var city in cities)
            {
                dataGridView.Rows.Add(city.Id, city.Name, city.State);
            }
        }

        private async Task<IList<Model.City>> GetCities()
        {
            try
            {
                return await cityService.GetAll();
            } catch(Exception ex)
            {
                MessageBox.Show("Fatalha ao tentar obter as cidades cadastradas.");
                return null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new Form();
            frm.ShowDialog();
        }
    }
}
