using System;
using System.Collections.Generic;
using System.Text;

namespace task8
{
    public class Order
    {
        public Client Client { get; }
        public DateTime OrderTime { get; }

        public Order(Client client, DateTime orderTime)
        {
            Client = client;
            OrderTime = orderTime;
        }

        public override string ToString()
        {
            
            return $"\nЗаказ от {OrderTime}: {Client}";

        }
    }
}
