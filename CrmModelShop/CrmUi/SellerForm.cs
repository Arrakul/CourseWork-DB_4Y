using System;
using System.Windows.Forms;
using CrmBL.Model;

namespace CrmUi
{
    public partial class SellerForm : Form
    {
        public Seller Seller { get; set; }

        public SellerForm()
        {
            InitializeComponent();
        }

        public SellerForm(Seller seller) : this()
        {
            Seller = seller;
            textBox1.Text = Seller.Name;
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var seller = Seller ?? new Seller();
            seller.Name = textBox1.Text;

            Seller = seller;
            Close();
        }
    }
}
