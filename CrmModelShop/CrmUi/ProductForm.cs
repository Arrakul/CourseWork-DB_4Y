using System;
using System.Windows.Forms;
using CrmBL.Model;

namespace CrmUi
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }

        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(Product product) : this()
        {
            Product = product;

            textBox1.Text = Product.Name;
            numericUpDown1.Value = Product.Price;
            numericUpDown2.Value = Product.Count;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var product = Product ?? new Product();

            product.Name = textBox1.Text;
            product.Price = numericUpDown1.Value;
            product.Count = (int)numericUpDown2.Value;

            Product = product;
            Close();
        }
    }
}
