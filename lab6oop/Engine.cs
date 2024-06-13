using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6oop
{
    class Engine
    {

        private string type;
        private float displacement;
        private int numOfCyliners;
        private int horsePowers;
        private int maxPower;
        private int fuelType;
        private bool turboCharged;
        private int height;
        private float fuelConsumption;

        public Engine() 
        { 
            this.type = string.Empty;
            this.displacement = 0;
            this.numOfCyliners = 0;
            this.horsePowers = 0;
            this.maxPower = 0;
            this.fuelType = 0;
            this.turboCharged = false;
            this.height = 0;
            this.fuelConsumption = 0;
        } 

        public Engine(string type, float displacement, int numOfCyliners, int horsePowers, int maxPower, int fuelType, bool turboCharged, int height, float fuelConsumption)
        {
            this.type = type;
            this.displacement = displacement;
            this.numOfCyliners = numOfCyliners;
            this.horsePowers = horsePowers;
            this.maxPower = maxPower;
            this.fuelType = fuelType;
            this.turboCharged = turboCharged;
            this.height = height;
            this.fuelConsumption = fuelConsumption;
        }

        public string Type
        {
            get => this.type;
            set => this.type = value;
        }

        public float Displacement
        {
            get => this.displacement;
            set => this.displacement = value;
        }

        public int NumOfCyliners
        {
            get => this.numOfCyliners; 
            set => this.numOfCyliners = value;
        }

        public int HorsePowers
        {
            get => this.horsePowers; 
            set => this.horsePowers = value;
        }

        public int MaxPower
        {
            get => this.maxPower; 
            set => this.maxPower = value;
        }

        public int FuelType
        {
            get => this.fuelType; 
            set => this.fuelType = value;
        }

        public bool TurboCharged
        {
            get => this.turboCharged; 
            set => this.turboCharged = value;
        }

        public int Height
        {
            get => this.height; 
            set => this.height = value;
        }

        public float FuelConsumption
        {
            get => this.fuelConsumption;
            set => this.fuelConsumption = value;
        }
    }
}
