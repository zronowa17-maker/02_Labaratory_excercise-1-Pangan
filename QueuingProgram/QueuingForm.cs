using System.Collections.Generic;
namespace QueuingProgram
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            CashierClass.getNumberInQueue = CashierClass.CashierGeneratedNumber("P - ");
            lblQueue.Text = CashierClass.getNumberInQueue;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void btnOpenQueueForm_Click_Click(object sender, EventArgs e)
        {
            CashierWindowQueueForm queueForm = new CashierWindowQueueForm();
            queueForm.Show();
        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
