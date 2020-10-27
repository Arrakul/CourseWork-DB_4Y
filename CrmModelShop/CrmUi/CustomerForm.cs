using System;
using System.Windows.Forms;
using CrmBL.Model;

namespace CrmUi
{
    public partial class CustomerForm : Form
    {
        public Customer Customer { get; set; }

        public CustomerForm()
        {
            InitializeComponent();
        }

        public CustomerForm(Customer customer) : this()
        {
            Customer = customer;
            textBox1.Text = Customer.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var customer = Customer ?? new Customer();
            customer.Name = textBox1.Text;

            Customer = customer;
            Close();
        }
    }
}
