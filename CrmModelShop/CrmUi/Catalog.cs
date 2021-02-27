using CrmBL.Model;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class Catalog<T> : Form
        where T : class
    {

        CrmContext db;
        DbSet<T> set;
        Main mainForm;

        public Catalog(DbSet<T> _set, CrmContext _db, Main main)
        {
            InitializeComponent();

            this.db = _db;
            this.set = _set;
            mainForm = main;

            set.Load();
            dataGridView.DataSource = set.Local.ToBindingList();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (typeof(T) == typeof(Product))
            {
                var form = new ProductForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.Products.Add(form.Product);
                    db.SaveChanges();
                    dataGridView.Update();
                }

                mainForm.UpdateListBox();
            }
            else if (typeof(T) == typeof(Customer))
            {
                var form = new CustomerForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.Customers.Add(form.Customer);
                    db.SaveChanges();
                    dataGridView.Update();
                }
            }
            else if (typeof(T) == typeof(Seller))
            {
                var form = new SellerForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.Sellers.Add(form.Seller);
                    db.SaveChanges();
                    dataGridView.Update();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;

            if (typeof(T) == typeof(Product))
            {
                var product = set.Find(id) as Product;

                if (product != null)
                {
                    var form = new ProductForm(product);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        product = form.Product;
                        db.SaveChanges();
                        dataGridView.Update();
                    }

                    mainForm.UpdateListBox();
                }
            }
            else if (typeof(T) == typeof(Customer))
            {
                var customer = set.Find(id) as Customer;

                if (customer != null)
                {
                    var form = new CustomerForm(customer);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        customer = form.Customer;
                        db.SaveChanges();
                        dataGridView.Update();
                    }
                }
            }
            else if (typeof(T) == typeof(Seller))
            {
                var seller = set.Find(id) as Seller;

                if (seller != null)
                {
                    var form = new SellerForm(seller);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        seller = form.Seller;
                        db.SaveChanges();
                        dataGridView.Update();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;

            if (typeof(T) == typeof(Product))
            {
                var product = set.Find(id) as Product;

                if (product != null)
                {
                    db.Products.Remove(product);
                    db.SaveChanges();
                    dataGridView.Update();

                    mainForm.UpdateListBox();
                }
            }
            else if (typeof(T) == typeof(Customer))
            {
                var customer = set.Find(id) as Customer;

                if (customer != null)
                {
                    db.Customers.Remove(customer);
                    db.SaveChanges();
                    dataGridView.Update();
                }
            }
            else if (typeof(T) == typeof(Seller))
            {
                var seller = set.Find(id) as Seller;

                if (seller != null)
                {
                    db.Sellers.Remove(seller);
                    db.SaveChanges();
                    dataGridView.Update();
                }
            }
        }
    }
}
