using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class ShowComputerModel
    {
        Generator Generator = new Generator();
        Random rnd = new Random();
        bool IsWorking = false;

        public List<CashDesk> CashDesks { get; set; } = new List<CashDesk>();
        public List<Cart> Carts { get; set; } = new List<Cart>();
        public List<Sell> Sells { get; set; } = new List<Sell>();
        public List<Chek> Cheks { get; set; } = new List<Chek>();

        public Queue<Seller> Sellers { get; set; } = new Queue<Seller>();

        public int CustomersSpeed { get; set; } = 100;
        public int CashDeskSpeed { get; set; } = 100;


        public ShowComputerModel()
        {
            var sellers = Generator.GetNewSellers(20);
            
            Generator.GetNewProduct(1000);
            Generator.GetNewCustomers(100);

            foreach (var item in sellers)
            {
                Sellers.Enqueue(item);
            }

            for (int i = 0; i < 3; i++)
            {
                CashDesks.Add(new CashDesk(CashDesks.Count ,Sellers.Dequeue(), null));
            }
        }

        public void Start()
        {
            IsWorking = true;
            Task.Run(() => CreateCarts(10));

            var cashDeskTasks = CashDesks.Select(c => new Task(() => CashDeskWork(c)));

            foreach (var task in cashDeskTasks)
            {
                task.Start();
            }
        }

        public void Stop()
        {
            IsWorking = false;
            Thread.Sleep(1000);
        }

        private void CashDeskWork(CashDesk cashDesk)
        {
            while (IsWorking)
            {
                if (cashDesk.Count > 0)
                {
                    cashDesk.Dequeue();
                    Thread.Sleep(CashDeskSpeed);
                }
            }
        }

        private void CreateCarts(int customerCounts)
        {
            while (IsWorking)
            {
                var customers = Generator.GetNewCustomers(customerCounts);

                foreach (var custormer in customers)
                {
                    var cart = new Cart(custormer);

                    foreach (var prod in Generator.GetRandomProduct(10, 30))
                    {
                        cart.Add(prod);
                    }

                    var cash = CashDesks[rnd.Next(CashDesks.Count)];
                    cash.Enqueue(cart);
                }

                Thread.Sleep(CustomersSpeed);
            }
        }
    }
}
