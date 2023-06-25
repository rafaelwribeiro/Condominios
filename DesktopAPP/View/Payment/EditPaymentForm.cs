using DesktopAPP.Model;
using System.Windows.Forms;

namespace DesktopAPP.View.Payment
{
    public partial class EditPaymentForm : Form
    {
        private PaymentModel payment;
        private bool IsInsert;
        public EditPaymentForm()
        {
            InitializeComponent();
            payment = new PaymentModel();
            IsInsert = true;
        }

        public EditPaymentForm(PaymentModel payment)
        {
            InitializeComponent();
            this.payment = payment;
            IsInsert = false;
        }
    }
}
