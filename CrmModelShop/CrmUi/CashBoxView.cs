using CrmBL.Model;
using System;
using System.Windows.Forms;

namespace CrmUi
{
    class CashBoxView
    {
        CashDesk cashDesk;

        public Label CashDeskName { get; set; }
        public Label LeaveCustomersCount { get; set; }
        public NumericUpDown Price { get; set; }
        public ProgressBar QueueLenght { get; set; }

        public CashBoxView(CashDesk cashDesk, int number, int x, int y)
        {
            this.cashDesk = cashDesk;

            CashDeskName = new Label();
            LeaveCustomersCount = new Label();
            QueueLenght = new ProgressBar();
            Price = new NumericUpDown();

            CashDeskName.AutoSize = true;
            CashDeskName.Location = new System.Drawing.Point(x, y);
            CashDeskName.Name = "label" + number;
            CashDeskName.Size = new System.Drawing.Size(35, 13);
            CashDeskName.TabIndex = number;
            CashDeskName.Text = cashDesk.ToString();

            Price.Location = new System.Drawing.Point(x + 70, y);
            Price.Name = "numericUpDown" + number;
            Price.Size = new System.Drawing.Size(128, 20);
            Price.TabIndex = number;
            Price.Maximum = 1000000000000;

            QueueLenght.Location = new System.Drawing.Point(x + 200, y);
            QueueLenght.Maximum = cashDesk.MaxQueueLenght;
            QueueLenght.Name = "progressBar" + number;
            QueueLenght.Size = new System.Drawing.Size(100, 23);
            QueueLenght.TabIndex = number;
            QueueLenght.Value = 0;

            LeaveCustomersCount.AutoSize = true;
            LeaveCustomersCount.Location = new System.Drawing.Point(x + 300, y);
            LeaveCustomersCount.Name = "label2" + number;
            LeaveCustomersCount.Size = new System.Drawing.Size(35, 13);
            LeaveCustomersCount.TabIndex = number;
            LeaveCustomersCount.Text = "";

            cashDesk.ChekClosed += CashDesk_ChekClosed;
        }

        private void CashDesk_ChekClosed(object sender, Chek e)
        {
            Price?.Invoke((Action)delegate 
            { 
                Price.Value += e.Price;
                QueueLenght.Value = cashDesk.Count;
                LeaveCustomersCount.Text = cashDesk.ExitCustomer.ToString();
            });
        }
    }
}
