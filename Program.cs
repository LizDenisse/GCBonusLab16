using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;


namespace GCBonusLab16
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int thisManyCars = 0;
            int anual = 0;
            double precio = 0;

            List<Car> cars = new List<Car>(24);

            Console.WriteLine("How Many cars do you want to enter?");
            string t = Console.ReadLine();

            try
            {
                thisManyCars = int.Parse(t);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid entry, Enter an intiger");
                t = Console.ReadLine();
                thisManyCars = int.Parse(t);

            }
            //TODO: Add Exceptions 

            for (int i = 0; i < thisManyCars; i++)
            {

                Console.WriteLine("");
                Console.WriteLine("Enter car Number {0}", i + 1);
                Console.WriteLine("What's the Make?");
                string marca = Console.ReadLine().Trim().ToUpper();

                Console.WriteLine("What is the Model?");
                string modelo = Console.ReadLine().ToUpper();

                Console.WriteLine("What is the Year?");
                string a = Console.ReadLine();

                try
                {
                    anual = int.Parse(a);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid entry, Enter an intiger");
                    a = Console.ReadLine();
                    anual = int.Parse(t);
                }


                Console.WriteLine("What is the price");
                string p = Console.ReadLine();

                try
                {
                    precio = double.Parse(p);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Format");
                    p = Console.ReadLine();
                    precio = double.Parse(p);
                }

                Car car = new Car();

                cars.Add(new Car { Make = marca, Model = modelo, Year = anual, Price = precio });

            }
            double total = cars.Sum(item => item.Price);

            Console.WriteLine("Current Inventory ({0}) Total: {1} ", cars.Count, total.ToString("C2", CultureInfo.CurrentCulture));


            {
                int i = 1;
                foreach (var c in cars)
                {
                    Console.WriteLine(i + "-" + c);
                    i++;

                }

            }
        }
    }
}

