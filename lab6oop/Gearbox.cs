using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6oop
{
    class Gearbox
    {
        private string gearboxType;
        private int gearCount;
        private float gearOilLevel;
        private int currentGear;
        private string driveMode;

        public Gearbox() 
        { 
            this.gearboxType = string.Empty;
            this.gearCount = 0;
            this.currentGear = 0;
            this.currentGear = 0;
            this.driveMode = string.Empty;
        }

        public Gearbox(string gearboxType, int gearCount, float gearOilLevel, int currentGear, string driveMode)
        {
            this.gearboxType = gearboxType;
            this.gearCount = gearCount;
            this.gearOilLevel = gearOilLevel;
            this.currentGear = currentGear;
            this.driveMode = driveMode;
        }

        public string GearBoxType
        {
            get => this.gearboxType;
            set => this.gearboxType = value;
        }

        public int GearCount
        {
            get => this.gearCount;
            set => this.gearCount = value;
        }

        public float GearOilLevel
        {
            get => this.gearOilLevel; 
            set => this.gearOilLevel = value;
        }

        public int CurrentGear
        {
            get => this.currentGear; 
            set => this.currentGear = value;
        }

        public string DriveMode
        {
            get => this.driveMode; 
            set => this.driveMode = value;
        }

        public void AddOilToGear(float oil)
        {
            if(GearOilLevel < 100)
            {
                GearOilLevel += oil;
            } else
            {
                Console.Write("Error! Oil level is full!");
            }
        }

        public int ChangeCurrentGear(int gear)
        {
            if(gear <= GearCount)
            {
                GearCount = gear;
            } else
            {
                Console.WriteLine("Error! We cant change gear!");
            }
            return GearCount;
        }
    }
}
