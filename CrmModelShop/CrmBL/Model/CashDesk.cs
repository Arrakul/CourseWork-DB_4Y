﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class CashDesk
    {
        CrmContext db = new CrmContext();

        public int Number { get; set; }
        public int MaxQueueLenght { get; set; }
        public int ExitCustomer { get; set; }

        public Seller Seller { get; set; }

        public Queue<Cart> Queue { get; set; }

        public bool IsModel { get; set; }
        public int Count => Queue.Count;

        public CashDesk(int number, Seller seller)
        {
            Number = number;
            Seller = seller;

            Queue = new Queue<Cart>();
            IsModel = true;
        }

        public void Enqueue(Cart cart)
        {
            if (Queue.Count <= MaxQueueLenght)
            {
                Queue.Enqueue(cart);
            }
            else
            {
                ExitCustomer++;
            }
        }

        public decimal Dequeue()
        {
            decimal sum = 0;

            if(Queue.Count == 0)
            {
                return 0;
            }

            var card = Queue.Dequeue();

            if (card != null)
            {
                var chek = new Chek()
                {
                    SellerId = Seller.SellerId,
                    Seller = Seller,
                    CustomerId = card.Customer.CustomerId,
                    Customer = card.Customer,
                    Created = DateTime.Now
                };

                if (!IsModel)
                {
                    db.Cheks.Add(chek);
                }
                else
                {
                    chek.ChekId = 0;
                }

                var sells = new List<Sell>();

                foreach (Product product in card)
                {
                    if (product.Count > 0)
                    {
                        var sell = new Sell()
                        {
                            CheckId = chek.ChekId,
                            Chek = chek,
                            ProductId = product.ProductId,
                            Product = product
                        };

                        sells.Add(sell);

                        if (!IsModel)
                        {
                            db.Sells.Add(sell);
                        }

                        sum += product.Price;
                        product.Count--;
                    }
                }

                if (!IsModel)
                {
                    db.SaveChanges();
                }
            }

            return sum;
        }
    }
}