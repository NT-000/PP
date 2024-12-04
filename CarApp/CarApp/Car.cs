using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    internal class Car
    {
        private string Model { get; set; }
        private int Year { get; set; }
        private int Mileage { get; set; }
        private string PlateNumber { get; set;}

        private int Price { get; set; }

        public Car(string model, int year, int mileage, string plateNumber, int price)
        {
            Model = model;
            Year = year;
            Mileage = mileage;
            PlateNumber = plateNumber;
            Price = price;

        }

        public string GetModel()
        {
            return Model;
        }
        public int GetYear()
        {
            return Year;
        }
        public int GetMileage()
        {
            return Mileage;
        }
        public string GetPlate()
        {
            return PlateNumber;
        }

        public int GetPrice()
        {
            return Price;
        }
    }
}
