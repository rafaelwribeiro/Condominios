using DesktopAPP.Model;
using DesktopAPP.Services;
using DesktopAPP.View.Apartment;
using DesktopAPP.View.City;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAPP.View.Buildings
{
    public partial class EditBuildingForm : Form
    {
        private BuildingModel building;
        private bool IsInsert;
        private BuildingService buildingService;
        private CityService cityService;
        private ApartmentService apartmentService;

        public EditBuildingForm()
        {
            InitializeComponent();
            building = new BuildingModel();
            IsInsert = true;
            Init();
        }
        
        public EditBuildingForm(BuildingModel model)
        {
            InitializeComponent();
            this.building = model;
            IsInsert = false;
            Init();
        }

        private void Init()
        {
            buildingService = BuildingService.GetInstance();
            cityService = CityService.GetInstance();
            apartmentService = ApartmentService.GetInstance();
            btnAdd.Enabled = !IsInsert;
            btnDelete.Enabled = !IsInsert;
            btnEdit.Enabled = !IsInsert;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var formSearch = new CitySearchForm();
            if (formSearch.ShowDialog() != DialogResult.OK)
                return;
            var city = formSearch.SelectedCity;
            FillCityFields(city);
        }

        private void FillCityFields(CityModel city)
        {
            txtCityId.Text = city.Id.ToString();
            txtCityName.Text = city.Name.ToString();
        }

        private void EditBuildingForm_Load(object sender, EventArgs e)
        {
            txtId.DataBindings.Add("Text", building, "Id");
            txtName.DataBindings.Add("Text", building, "Name");
            txtFloors.DataBindings.Add("Text", building, "Floors");
            txtCityId.DataBindings.Add("Text", building, "CityId");

            txtCityId_KeyPress(txtCityId, new KeyPressEventArgs((char)Keys.Enter));

            PopulateGrid(building.Apartments);
        }

        private void PopulateGrid(IList<ApartmentModel> apartments)
        {
            dataGridView.Rows.Clear();

            apartments.ToList().ForEach(x => {
                dataGridView.Rows.Add(x.Id, x.Floor, x.BadroomsQuantity);
            });
        }

        private async void txtCityId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            var cityId = Convert.ToInt32("0"+txtCityId.Text);
            var city = await GetCity(cityId);
            if (city == null) return;
            FillCityFields(city);
        }

        private async Task<CityModel> GetCity(int cityId)
        {
            return await cityService.GetCityAsync(cityId);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedRow = dataGridView.Rows[e.RowIndex];
            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            EditRegistry(id);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsInsert)
                    await buildingService.Post(building);
                else
                    await buildingService.Update(building);
                this.Close();
                this.DialogResult = DialogResult.OK;
            } catch (Exception ex)
            {
                MessageBox.Show($"Falha ao salvar dados do Edifício.\n{ex.Message}\n{ex.InnerException}");
            }
        }

        private async void btnAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new EditApartmentForm(building.Id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var apartments = await GetApartmetns();
                PopulateGrid(apartments);
            }
        }

        private async Task<IList<ApartmentModel>> GetApartmetns()
        {
            return await apartmentService.GetAll(building.Id);
        }

        private async void btnDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int id = GetIdSelectedRow();
            if (id <= 0) return;
            DialogResult result = MessageBox.Show("Deseja excluir o registro selecionado?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;


            await apartmentService.Delete(building.Id, id);

            var apartments = await GetApartmetns();
            PopulateGrid(apartments);
        }

        private int GetIdSelectedRow()
        {
            if (dataGridView.SelectedRows.Count <= 0) return -1;
            var selectedRow = dataGridView.SelectedRows[0];
            return Convert.ToInt32(selectedRow.Cells["Id"].Value);
        }

        private void btnEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int id = GetIdSelectedRow();
            if (id <= 0) return;
            EditRegistry(id);
        }

        private async void EditRegistry(int id)
        {
            var apartment = building.Apartments.FirstOrDefault(a => a.Id == id);

            var editForm = new EditApartmentForm(building.Id, apartment);
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                var apartments = await GetApartmetns();
                PopulateGrid(apartments);
            }
        }
    }
}
