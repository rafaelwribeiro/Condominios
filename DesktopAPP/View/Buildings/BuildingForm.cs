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

        private async void EditRegistry(int id)
        {
            var building = buildings.FirstOrDefault(x => x.Id == id);
            var frmEdit = new EditBuildingForm(building);
            if (frmEdit.ShowDialog() == DialogResult.OK)
                await PopulateGrid();
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

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new EditBuildingForm();
            frm.ShowDialog();
            await PopulateGrid();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedRow = dataGridView.Rows[e.RowIndex];
            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            EditRegistry(id);
        }
    }
}
