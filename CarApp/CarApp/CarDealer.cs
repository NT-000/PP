using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    internal class CarDealer
    {
        private List<Car> carDealerList = new List<Car>();
        private int Balance { get; set; }
       
        public CarDealer()
        {
            carDealerList = new List<Car>()
            {
                new Car("Ford", 2010, 100000, "L7465", 50000),
                new Car("Volvo", 2014, 100000, "D7467", 150000),
                new Car("Tesla", 2020, 100000, "L8465", 200000),
                new Car("Opel", 2016, 100000, "G7465", 300000)
            };
            Balance = 1000000;
        }

        public void ShowCarsDealer(Customer customer)
        {
            int counter = 1;
            foreach (var car in carDealerList)
            {
                Console.WriteLine($"{counter}Model:{car.GetModel()} Year: {car.GetYear()} Mileage: {car.GetMileage()} Plate: {car.GetPlate()} Price: {car.GetPrice()}");
                counter++;
            }

            int carIndex = int.Parse(Console.ReadLine());
            var selectedCar = carDealerList[carIndex -1];

            if (customer.GetBalance() >= selectedCar.GetPrice())
            {
                customer.GetCarsList().Add(selectedCar);
                carDealerList.Remove(selectedCar);
                customer.PayForCar(customer,selectedCar);

                Console.WriteLine($"{customer.GetName()} just bought {selectedCar.GetModel()} for {selectedCar.GetPrice()}, he now has {customer.GetBalance()} in his account.");
            }
        }

        public void FilterBypriceRange()
        {
            Console.WriteLine("Input min price");
            int inputMin = int.Parse(Console.ReadLine());
            Console.WriteLine("input max price");
            int inputMax = int.Parse(Console.ReadLine());

            var filteredCars = carDealerList.Where(car => car.GetPrice() >= inputMin && car.GetPrice() <= inputMax)
                .ToList();

            if (filteredCars != null)
            {
                int counter = 1;
                Console.WriteLine($"Cars price between {inputMin} and {inputMax}");
                foreach (var car in filteredCars)
                {
                    Console.WriteLine($"{counter}Model:{car.GetModel()} Year: {car.GetYear()} Mileage: {car.GetMileage()} Plate: {car.GetPlate()} Price: {car.GetPrice()}");
                }
            }
            else
            {
                Console.WriteLine("No matches found");
            }
        }
    }
}
