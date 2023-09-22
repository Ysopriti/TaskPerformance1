namespace TaskPerformance1
{
    public partial class Form1 : Form
    {
        
        CashierClass cashierClass = new CashierClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashierClass.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void lbclick_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CashierWindow2 cashierwindow = new CashierWindow2();
            cashierwindow.ShowDialog();
        }
    }
}