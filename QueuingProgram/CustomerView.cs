using System;
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
    public partial class CustomerView : Form
    {

        private static CustomerView instance;

        public static CustomerView Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new CustomerView();
                return instance;
            }
        }

        public CustomerView()
        {
            InitializeComponent();

            // Optional: auto-update label with current next in queue (if meron na)
            if (CashierClass.CashierQueue.Count > 0)
            {
                string next = CashierClass.CashierQueue.Peek();
                LblNowServing.Text = "Now Serving: " + next;
            }

            // Optional: Hook to queue change (BONUS)
            CashierClass.OnQueueChanged += () =>
            {
                if (CashierClass.CashierQueue.Count > 0)
                {
                    string next = CashierClass.CashierQueue.Peek();
                    UpdateNowServing(next);
                }
            };
        }

        public void UpdateNowServing(string number)
        {
            if (LblNowServing.InvokeRequired)
            {
                LblNowServing.Invoke(new MethodInvoker(() =>
                    LblNowServing.Text = "Now Serving: " + number));
            }
            else
            {
                LblNowServing.Text = "Now Serving: " + number;

            }
        }
    }
}


