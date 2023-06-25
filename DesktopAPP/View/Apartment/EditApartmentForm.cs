using DesktopAPP.Model;
using DesktopAPP.Services;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DesktopAPP.View.Apartment
{
    public partial class EditApartmentForm : Form
    {
        private ApartmentService apartmentService;
        private ApartmentModel apartment;
        private bool IsInsert;
        private int buildingId;
        public EditApartmentForm(int buildingId)
        {
            InitializeComponent();
            apartmentService = ApartmentService.GetInstance();
            IsInsert = true;
            this.buildingId = buildingId;
            this.apartment= new ApartmentModel();
        }

        public EditApartmentForm(int buildingId, ApartmentModel apartment)
        {
            InitializeComponent();
            apartmentService = ApartmentService.GetInstance();
            IsInsert = false;
            this.buildingId = buildingId;
            this.apartment = apartment;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (IsInsert)
                await apartmentService.Post(buildingId, apartment);
            else
                await apartmentService.Update(buildingId, apartment);
            DialogResult= DialogResult.OK;
            this.Close();
        }

        private void EditApartmentForm_Load(object sender, EventArgs e)
        {
            txtId.DataBindings.Add("Text", apartment, "Id");
            txtFloor.DataBindings.Add("Text", apartment, "Floor");
            txtBadroomsQuantity.DataBindings.Add("Text", apartment, "BadroomsQuantity");
            txtSizeM2.DataBindings.Add("Text", apartment, "SizeM2");
        }
    }
}
