using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6oop
{
    class ControlPart
    {
        private string steeringType;
        private bool epsStatus;

        public ControlPart()
        {
            this.steeringType = string.Empty;
            this.epsStatus = false;
        }

        public ControlPart(string steeringType, bool epsStatus)
        {
            this.steeringType = steeringType;
            this.epsStatus = epsStatus;
        }

        public string SteeringType
        {
            get => this.steeringType;
            set => this.steeringType = value;
        }

        public bool EpsStatus
        {
            get => this.epsStatus; 
            set => this.epsStatus = value;
        }

        public bool ChangeEpsStatus()
        {
            if(EpsStatus == false)
            {
                EpsStatus = true;
            } else
            {
                EpsStatus = false;
            }

            return EpsStatus;
        }
    }
}
