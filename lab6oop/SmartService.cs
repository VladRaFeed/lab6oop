using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6oop
{
    class SmartService
    {

        private string currentCarStatus;
        private bool carPlane;
        private bool carBoat;
        private bool defaultCar;

        public SmartService()
        {
            this.currentCarStatus = "default";
            this.carPlane = false;
            this.carBoat = false;
            this.defaultCar = true;
        }

        public SmartService(string currentCarStatus, bool carPlane, bool carBoat, bool defaultCar)
        {
            this.currentCarStatus = currentCarStatus;
            this.carPlane = carPlane;
            this.carBoat = carBoat;
            this.defaultCar = defaultCar;
        }

        public string CurrentCatStatus
        {
            get => this.currentCarStatus;
            set => this.currentCarStatus = value;
        }

        public bool CarPlane
        {
            get => this.carPlane;
            set => this.carPlane = value;
        }

        public bool CarBoat
        {
            get => this.carBoat; 
            set => this.carBoat = value;
        }

        public bool DefaultCar
        {
            get => this.defaultCar; 
            set => this.defaultCar = value;
        }

        public string ChangeCarStatus(string status)
        {
            if(status == "default")
            {
                CurrentCatStatus = "default";
                CarPlane = false;
                CarBoat = false;
                DefaultCar = true;
            } else if(status == "plane")
            {
                CurrentCatStatus = "plane";
                CarPlane = true;
                CarBoat = false;
                DefaultCar = false;
            } else
            {
                CurrentCatStatus = "boat";
                CarPlane = false;
                CarBoat = true;
                DefaultCar = false;
            }
            return CurrentCatStatus;
        }
    }
}
