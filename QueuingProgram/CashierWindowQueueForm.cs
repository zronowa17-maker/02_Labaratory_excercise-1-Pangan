using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingProgram
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());

            }
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
                string nowServingNumber = CashierClass.DequeueNumber();

            if (nowServingNumber != null)
            {
                // Open the CustomerView if not yet visible
                CustomerView.Instance.Show();
                CustomerView.Instance.BringToFront();

                // Update the display
                CustomerView.Instance.UpdateNowServing(nowServingNumber);
            }
            else
            {
                MessageBox.Show("The queue is empty.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
}
   


