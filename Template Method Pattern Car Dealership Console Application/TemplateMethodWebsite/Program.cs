using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodCarDealership
{
    class Program
    {
        static void Main(string[] args)
        {
            Car compactCar = new RenaultMegane();
            compactCar.MakeCar("Renault Megane");

            Console.WriteLine();

            Car fastCar = new HondaCivic();
            fastCar.MakeCar("Honda Civic");

            Console.WriteLine();

            Car oldCar = new ToyotaCamry();
            oldCar.MakeCar("Toyota Camry");

            Console.Read();
            return;
        }
    }
}