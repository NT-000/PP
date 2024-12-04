using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    internal class Customer
    {   
        private List<Car> CustomerCars { get; set; }
        private string Name { get; set;}
        private string Description { get; set; }

        private int Balance { get; set; }

        public Customer(string name, string description, int balance)
        {
            Name = name;
            Description = description;
            Balance = balance;
            CustomerCars = new List<Car>();
        }

        public string GetName()
        {
            return Name;
        }

        public List<Car> GetCarsList()
        {
            return CustomerCars;
        }

        public string GetDescription()
        {
            return Description;
        }

        public int GetBalance()
        {
            return Balance;
        }

        public void PayForCar(Customer customer, Car selectedCar)
        {
            customer.Balance -= selectedCar.GetPrice();
        }

        public void ShowCars()
        {
            int counter = 1;
            foreach (var car in CustomerCars)
            {
                Console.WriteLine($"{counter}.Model: {car.GetModel()} Mileage: {car.GetMileage()} plate: {car.GetPlate()} Year: {car.GetYear()}");
                counter++;
            }
        }
    }
}
