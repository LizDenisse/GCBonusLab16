using System;
using System.Threading;
using System.Globalization;


namespace GCBonusLab16
{
    class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public double Price;



        private string v1;
        private string v2;

        public override string ToString()
        {
            return $" {Make} \t {Model} \t {Year}\t {Price.ToString("C2", CultureInfo.CurrentCulture)}";
        }

        public Car(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public Car(string make, string model, int year, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;


        }

        public Car()
        {
        }

        //public static implicit operator Car(Car)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
