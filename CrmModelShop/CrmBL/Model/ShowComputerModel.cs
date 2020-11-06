using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class ShowComputerModel
    {
        Generator Generator = new Generator();
        Random rnd = new Random();

        public List<CashDesk> CashDesks { get; set; } = new List<CashDesk>();
        public List<Cart> Carts { get; set; } = new List<Cart>();
        public List<Sell> Sells { get; set; } = new List<Sell>();
        public List<Chek> Cheks { get; set; } = new List<Chek>();

        public Queue<Seller> Sellers { get; set; } = new Queue<Seller>();

        public ShowComputerModel()
        {
            var sellers = Generator.GetNewSellers(20);
            var products = Generator.GetNewProduct(1000);
            var customers = Generator.GetNewCustomers(100);

            foreach (var item in sellers)
            {
                Sellers.Enqueue(item);
            }

            for (int i = 0; i < 3; i++)
            {
                CashDesks.Add(new CashDesk(CashDesks.Count ,Sellers.Dequeue()));
            }
        }

        public void Start()
        {
            var customers = Generator.GetNewCustomers(10);
            var carts = new Queue<Cart>();

            foreach (var custormer in customers)
            {
                var cart = new Cart(custormer);

                foreach (var prod in Generator.GetRandomProduct(10, 30))
                {
                    cart.Add(prod);
                }

                carts.Enqueue(cart);
            }

            while (carts.Count > 0)
            {
                var cash = CashDesks[rnd.Next(CashDesks.Count - 1)];
                cash.Enqueue(carts.Dequeue());
            }


            while (true)
            {
                var cash = CashDesks[rnd.Next(CashDesks.Count - 1)];
                cash.Dequeue();
            }
        }
    }
}
