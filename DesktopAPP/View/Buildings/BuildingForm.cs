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
            frmEdit.ShowDialog();
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
            if(frm.ShowDialog() == DialogResult.OK);
                await PopulateGrid();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedRow = dataGridView.Rows[e.RowIndex];
            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            EditRegistry(id);
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


            await buildingService.Delete(id);
            await PopulateGrid();
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
    }
}
