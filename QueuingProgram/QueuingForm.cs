using System.Collections.Generic;
namespace QueuingProgram
{
    public partial class QueuingForm : Form
    {
        public QueuingForm()
        {
            InitializeComponent();

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            CashierClass.getNumberInQueue = CashierClass.CashierGeneratedNumber("P - ");
            lblQueue.Text = CashierClass.getNumberInQueue;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}
