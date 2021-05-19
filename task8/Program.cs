using System;
using System.Collections.Generic;
using task8.Cats;
using task8.Dogs;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            var calculator = new SumCalculator();

            var clients = new Client[]
            {
                new Client("Кузьмин Никита Максимович", new List<Pet> { new BritishCat("Пуша"), new RussianBlue("Жека") },"123456789"),
                new Client("Ниполев Николай Иванович", new List<Pet> { new SphynxCat("Пушистик")},"123456789"),
                new Client("Любина Вероника Павловна", new List<Pet> { new Bulldog("Жима"), new Pug("Мотя") },"123456789"),
                new Client("Карасинова Елена Михайловна", new List<Pet> { new Terrier("Мося"), new Pug("Лопа"), new BritishCat("Жужа"),new Terrier("Зава") },"123456789")
            };

            var orderList = new Order[]
            {
                new Order(clients[1], DateTime.Now),
                new Order(clients[3], DateTime.Now),
            };

            while (flag)
            {
                Console.WriteLine("\nВведите:\n\"1\" - для просмотра всех клиентов" + "\n\"2\" - для просмотра всех заказов");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        foreach (var client in clients)
                        {
                            Console.WriteLine(client.ToString());
                        }
                        break;
                    case 2:
                        foreach (var order in orderList)
                        {
                            Console.WriteLine($"{order}Чек на сумму: {calculator.Calculate(order.Client.Pets)}");
                        }
                        break;
                }
                //var c =  new Client("Name", new List<Pet> { new Bulldog("Жека"), new Pug("Жека") },"123123123123");
                //var oder = new Order(c, DateTime.Now);
                //Console.WriteLine(oder.ToString()+"\nЧек на сумму: "+ calc.Calculate(c.Pets)+"\n");
            }

        }
    }
}
