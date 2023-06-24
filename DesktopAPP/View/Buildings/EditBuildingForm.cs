using DesktopAPP.Model;
using DesktopAPP.Services;
using DesktopAPP.View.City;
using System;
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
    }
}
