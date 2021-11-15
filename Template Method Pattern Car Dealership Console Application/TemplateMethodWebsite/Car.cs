using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodCarDealership
{
    abstract class Car
    {
        public void MakeCar(string brand)
        {
            CreateVehicleBasicConstruction();   

            if(customerWantsEngine())
            {
                MountEngine();
            }

            if (customerWantsExtraWheel())
            {
                AddExtraWheel();
            }

            if (customerWantsExtraDoors())
            {
                AddDoors();
            }

            if (customerWantsRim())
            {
                AddRim();
            }

            if (customerWantsHeadlight())
            {
                AddHeadlight();
            }

            if (customerWantsSteeringWheel())
            {
                AddSteeringWheel();
            }

            if (customerWantsGearBox())
            {
                AddGearBox();
            }

            SubmitCar(brand);
        }

        public void CreateVehicleBasicConstruction()
        {
            Console.WriteLine("The Basic Vehicle Structure is Constructed");
        }

        public void SubmitCar(string name)
        {
            Console.WriteLine("Car Model: " + name);
        }

        public abstract void MountEngine();
        public abstract void AddExtraWheel();
        public abstract void AddDoors();
        public abstract void AddRim();
        public abstract void AddHeadlight();
        public abstract void AddSteeringWheel();
        public abstract void AddGearBox();

        bool customerWantsEngine() { return true; }
        bool customerWantsExtraWheel() { return true; }
        bool customerWantsExtraDoors() { return true; }
        bool customerWantsRim() { return true; }
        bool customerWantsHeadlight() { return true; }
        bool customerWantsSteeringWheel() { return true; }
        bool customerWantsGearBox() { return true; }

    }
}