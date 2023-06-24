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

namespace DesktopAPP.View.Buildings
{
    public partial class BuildingForm : Form
    {
        private BuildingService buildingService;
        private IList<BuildingModel> buildings;
        public BuildingForm()
        {
            buildingService = BuildingService.GetInstance();
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void BuildingForm_Load(object sender, EventArgs e)
        {
            await PopulateGrid();
        }

        private async Task PopulateGrid()
        {
            buildings = await GetBuildings();
            if (buildings == null) return;

            dataGridView.Rows.Clear();
            buildings
                .ToList()
                .ForEach(b => {
                    dataGridView.Rows.Add(b.Id, b.Name, b.Floors, b.City.Name, b.City.State);
                }
            );
        }

        private async Task<IList<BuildingModel>> GetBuildings()
        {
            try
            {
                return await buildingService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao tentar obter os edifícios.\n{ex.Message}");
                return null;
            }
        }
    }
}
