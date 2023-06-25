using DesktopAPP.View.Buildings;
using DesktopAPP.View.City;
using DesktopAPP.View.Payment;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DesktopAPP.View
{
    public partial class MainForm : Form
    {
        private Form currentChieldForm;
        public MainForm()
        {
            InitializeComponent();
            pnlMasterContainer.BringToFront();
        }

        private void OpenChieldForm(Form childForm)
        {
            currentChieldForm?.Close();
            currentChieldForm = childForm;

            childForm.TopLevel= false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(childForm);
            pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void Reset()
        {
            lblTitle.Text = "Home";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentChieldForm?.Close();
            Reset();
        }

        private void btnCities_Click(object sender, EventArgs e)
        {
            OpenChieldForm(new CityForm());
        }

        private void btnBuilding_Click(object sender, EventArgs e)
        {
            OpenChieldForm(new BuildingForm());
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            OpenChieldForm(new PaymentForm());
        }
    }
}
