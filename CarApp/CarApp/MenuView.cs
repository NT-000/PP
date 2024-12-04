using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    internal class MenuView
    {


        public MenuView()
        {
            var dealer = new CarDealer();
            var customer = new Customer("Joe", "Just won the lottery", 1000000);

            bool isRunning = true;
            while (isRunning)

            {
                Console.WriteLine("1.Purchase car");
                Console.WriteLine("2.Sell car");
                Console.WriteLine("3.Show owned cars");
                Console.WriteLine("4.Filter by Price range");
                Console.WriteLine("5.Exit");
                var inputSwitch = Console.ReadLine();

                switch (inputSwitch)
                {
                    case "1":
                        Console.Clear();
                        dealer.ShowCarsDealer(customer);
                        break;
                    case "2":
                        break;
                    case "3":
                        Console.Clear();
                        customer.ShowCars();
                        break;
                    case "4":
                        Console.Clear();
                        dealer.FilterBypriceRange();
                        break;
                    case "5":
                        Console.WriteLine($"{customer.GetName()} is heading home...");
                        isRunning = false;
                        break;

                }
            }

        }
    }
}

