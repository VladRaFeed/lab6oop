using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6oop
{
    class Transmission
    {

        private string transmissionType;
        private string differentialType;
        private bool differentialBlockStatus;

        public Transmission() 
        { 
            this.transmissionType = string.Empty;
            this.differentialType = string.Empty;
            this.differentialBlockStatus = false;
        }

        public Transmission(string transmissionType, string differentialType, bool differentialBlockStatus)
        {
            this.transmissionType = transmissionType;
            this.differentialType = differentialType;
            this.differentialBlockStatus = differentialBlockStatus;
        }

        public string TransmissionType 
        {
            get => this.transmissionType;
            set => this.transmissionType = value;
        }

        public string DifferentialType
        {
            get => this.differentialType;
            set => this.differentialType = value;
        }

        public bool DifferentialBlockStatus
        {
            get => this.differentialBlockStatus; 
            set => this.differentialBlockStatus = value;
        }

        public bool ChangeBlockStatus()
        {
            if(DifferentialBlockStatus == false)
            {
                DifferentialBlockStatus = true;
            } else
            {
                DifferentialBlockStatus = false;
            }

            return DifferentialBlockStatus;
        }
    }
}
