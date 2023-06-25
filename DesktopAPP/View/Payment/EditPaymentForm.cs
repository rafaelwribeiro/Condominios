using DesktopAPP.Model;
using DesktopAPP.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAPP.View.Payment
{
    public partial class EditPaymentForm : Form
    {
        private PaymentModel payment;
        private bool IsInsert;
        private BuildingService buildingService;
        private ApartmentService apartmentService;
        private PaymentService paymentService;
        private IList<BuildingModel> buildings;
        public EditPaymentForm()
        {
            InitializeComponent();
            payment = new PaymentModel();
            IsInsert = true;
            Init();
        }

        public EditPaymentForm(PaymentModel payment)
        {
            InitializeComponent();
            this.payment = payment;
            IsInsert = false;
            Init();
        }

        private void Init()
        {
            buildingService = BuildingService.GetInstance();
            apartmentService = ApartmentService.GetInstance();
            paymentService = PaymentService.GetInstance();
        }

        private async void EditPaymentForm_Load(object sender, System.EventArgs e)
        {
            await LoadBuildings();
            txtId.DataBindings.Add("Text", payment, "Id");
            dtpDate.DataBindings.Add("Text", payment, "CreatedAt");
            cmbApartment.DataBindings.Add("Text", payment, "ApartmentId");
            txtValue.DataBindings.Add("Text", payment, "Value");
        }

        private async Task LoadBuildings()
        {
            buildings = await buildingService.GetAll();
            cmbBuilding.DisplayMember= "DisplayName";
            cmbBuilding.ValueMember = "Id";
            
            cmbBuilding.DataSource = buildings;
            cmbBuilding.SelectedIndex = 0;
        }

        private void cmbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            var building = GetSelectedBuilding();
            LoadApartments(building);
        }

        private BuildingModel GetSelectedBuilding()
        {
            int id = Convert.ToInt32(cmbBuilding.SelectedValue);
            return buildings.FirstOrDefault(b => b.Id == id);
        }

        private void LoadApartments(BuildingModel building)
        {
            //var apartments = await apartmentService.GetAll(id);
            var apartments = building.Apartments;
            cmbApartment.DataSource = apartments;
            cmbApartment.DisplayMember = "DisplayName";
            cmbApartment.ValueMember = "Id";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int buildingId = GetSelectedBuilding().Id;
                int apartmentId = GetSelectedApartmentId();
                if (IsInsert)
                    await paymentService.Post(buildingId, apartmentId, payment);
                else
                    await paymentService.Update(payment);
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Abort;
                MessageBox.Show($"Falha ao {(IsInsert ? "Cadastrar" : "Atualizar")} Pagamento. \n{ex.Message}\n\n{ex.StackTrace}");
            }
        }

        private int GetSelectedApartmentId()
        {
            return Convert.ToInt32(cmbApartment.SelectedValue);
        }
    }
}
