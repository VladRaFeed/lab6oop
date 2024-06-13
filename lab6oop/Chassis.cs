using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6oop
{
    class Chassis
    {

        private Gearbox gearBox;
        private Brakes brakes;
        private Transmission transmission;
        private ControlPart controlPart;
        private RunningGear runningGear;
        private SmartService smartService;

        public Chassis()
        {
            this.gearBox = new Gearbox();
            this.brakes = new Brakes();
            this.transmission = new Transmission();
            this.controlPart = new ControlPart();
            this.runningGear = new RunningGear();
            this.smartService = new SmartService();
        }

        public Chassis(Gearbox gearBox, Brakes brakes, Transmission transmission, ControlPart controlPart, RunningGear runningGear, SmartService smartService)
        {
            this.gearBox = gearBox;
            this.brakes = brakes;
            this.transmission = transmission;
            this.controlPart = controlPart;
            this.runningGear = runningGear;
            this.smartService = smartService;
        }

        public Gearbox GearBox
        {
            get => this.gearBox; 
            set => this.gearBox = value;
        }

        public Brakes Brakes
        {
            get => this.brakes;
            set => this.brakes = value;
        }

        public Transmission Transmission
        {
            get => this.transmission; 
            set => this.transmission = value;
        }

        public ControlPart ControlPart 
        { 
            get => this.controlPart; 
            set => this.controlPart = value; 
        }

        public RunningGear RunningGear
        {
            get => this.runningGear;
            set => this.runningGear = value;
        }

        public SmartService SmartService
        {
            get => this.smartService; 
            set => this.smartService = value;
        }

        public void AddOiltToGear(float oil)
        {
            gearBox.AddOilToGear(oil);
        }

        public void ChangeCurrentGear(int gear)
        {
            int currentGear = gearBox.ChangeCurrentGear(gear);
            Console.WriteLine($"CurrentGear is {currentGear}");
        }

        public void AddBrakeFluid(float fluid)
        {
            float ress = brakes.AddBrakeFluid(fluid);
            if(ress == 0)
            {
                Console.WriteLine("We cant add fluid to brakes");
            } else
            {
                Console.WriteLine($"Fluid leve in brakes is {ress}");
            }
        }

        public void TurnAbs()
        {
            bool ress = brakes.TurningABS();
            if(ress == true)
            {
                Console.WriteLine("ABS are turned on!");
            } else
            {
                Console.WriteLine("ABS are turned off!");
            }
        }

        public void ChangeBlockStatus()
        {
            bool ress = transmission.ChangeBlockStatus();
            if(ress = true)
            {
                Console.WriteLine("Differential are blocked!");
            } else
            {
                Console.WriteLine("Differential are unblocked!");
            }
        }

        public void ChangeEpsStat()
        {
            bool ress = controlPart.ChangeEpsStatus();
            if(ress == true)
            {
                Console.WriteLine("EPS are turned on!");
            } else
            {
                Console.WriteLine("EPS are turned off!");
            }
        }

        public void AddPressure(float tire)
        {
            runningGear.AddPressureToWheels(tire);
        }
        
        public void ChangeCarStat(string stat)
        {
            string ress = smartService.ChangeCarStatus(stat);
            Console.WriteLine($"Current status of car is {ress}");
        }
    }
}
