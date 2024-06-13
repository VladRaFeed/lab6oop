using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6oop
{
    class Brakes
    {

        private string brakesType;
        private string brakeDiscCondition;
        private float brakeFluidLevel;
        private bool absStatus;

        public Brakes() 
        { 
            this.brakesType = string.Empty;
            this.brakeDiscCondition = string.Empty;
            this.brakeFluidLevel = 0;
            this.absStatus = false;
        }

        public Brakes(string brakesType, string brakeDiscCondition, float brakeFluidLevel, bool absStatus)
        {
            this.brakesType = brakesType;
            this.brakeDiscCondition = brakeDiscCondition;
            this.brakeFluidLevel = brakeFluidLevel;
            this.absStatus = absStatus;
        }

        public string BrakesType
        {
            get => this.brakesType;
            set => this.brakesType = value;
        }

        public string BrakeDiscCondition
        {
            get => this.brakeDiscCondition;
            set => this.brakeDiscCondition = value;
        }

        public float BrakeFluidLevel
        {
            get => this.brakeFluidLevel; 
            set => this.brakeFluidLevel = value;
        }

        public bool AbsStatus
        {
            get => this.absStatus; 
            set => this.absStatus = value;
        }

        public float AddBrakeFluid(float brakeFluid)
        {
            if(brakeFluid < 100)
            {
                BrakeFluidLevel += brakeFluid;
                return BrakeFluidLevel;
            }
            else
            {
                return 0;
            }
        }

        public bool TurningABS()
        {
            if(AbsStatus == false)
            {
                absStatus = true;
            } else
            {
                AbsStatus = false;
            }

            return AbsStatus;
        }
    }
}
