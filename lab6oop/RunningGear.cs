using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6oop
{
    class RunningGear
    {
        private string suspensionType;
        private int wheelSize;
        private string wheelType;
        private float tirePerssure;
        private bool wheelBurst;

        public RunningGear()
        {
            this.suspensionType = string.Empty;
            this.wheelSize = 0;
            this.wheelType = string.Empty;
            this.tirePerssure = 0;
            this.wheelBurst = false;
        }

        public RunningGear(string suspensionType, int wheelSize, string wheelType, float tirePerssure, bool wheelBurst)
        {
            this.suspensionType = suspensionType;
            this.wheelSize = wheelSize;
            this.wheelType = wheelType;
            this.tirePerssure = tirePerssure;
            this.wheelBurst = wheelBurst;
        }

        public string SuspensionType
        {
            get => this.suspensionType;
            set => this.suspensionType = value;
        }

        public int WheelSize
        {
            get => this.wheelSize;
            set => this.wheelSize = value;
        }

        public string WheelType
        {
            get => this.wheelType; 
            set => this.wheelType = value;
        }

        public float TirePerssure
        {
            get => this.tirePerssure; 
            set => this.tirePerssure = value;
        }

        public bool WheelBurst
        {
            get => this.wheelBurst;
            set => this.wheelBurst = value;
        }

        public bool AddPressureToWheels(float tirePerssure)
        {
            TirePerssure += tirePerssure;
            if(TirePerssure > 5.5)
            {
                TirePerssure = 0;
                WheelBurst = true;
                Console.WriteLine("Колесо взірвалось!");
            } else
            {
                Console.WriteLine("Колесо успішно накачане!");
            }

            return WheelBurst;
        }
    }
}
