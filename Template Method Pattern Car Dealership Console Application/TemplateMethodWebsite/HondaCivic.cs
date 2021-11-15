using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodCarDealership
{
    class HondaCivic : Car
    {
        string[] detailsDoors = { "5" };
        string[] detailsRim = { "Steel" };
        string[] detailsWheel = { "Normal" };
        string[] detailsEngine = { "3.0 280 KM" };
        string[] detailsSteeringWheel = {  "Leather" };
        string[] detailsGearBox = { "Manual" };
        string[] detailsHeadlight = { "Xenon" };

        public override void AddDoors()
        {
            Console.Write("Mounting Doors - ");
            foreach (string item in detailsDoors)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public override void AddRim()
        {
            Console.Write("Mounting Rim - ");
            foreach (string item in detailsRim)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public override void AddExtraWheel()
        {
            Console.Write("Mounting Extra Wheel - ");
            foreach (string item in detailsWheel)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public override void MountEngine()
        {
            Console.Write("Mounting Engine - ");
            foreach (string item in detailsEngine)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public override void AddSteeringWheel()
        {
            Console.Write("Mounting Steering Wheel - ");
            foreach (string item in detailsSteeringWheel)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public override void AddGearBox()
        {
            Console.Write("Mounting GearBox - ");
            foreach (string item in detailsGearBox)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public override void AddHeadlight()
        {
            Console.Write("Mounting Headlight - ");
            foreach (string item in detailsHeadlight)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
