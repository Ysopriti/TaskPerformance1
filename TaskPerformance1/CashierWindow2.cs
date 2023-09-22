using System.Collections;

namespace TaskPerformance1
{
    public partial class CashierWindow2 : Form
    {
        QueueNumber qnumber = new QueueNumber();

        public CashierWindow2()
        {
            InitializeComponent();
            /*
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
            */
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            QueueNumber queuenumber = new QueueNumber();
            queuenumber.ShowDialog();
            CashierNumber();   
        }
        
        public void CashierNumber()
        {
            qnumber.ShowDialog();
            qnumber.labelNumber.Text = CashierClass.CashierQueue.Peek().ToString();
            CashierClass.CashierQueue.Dequeue();
        }
        
    }
}
