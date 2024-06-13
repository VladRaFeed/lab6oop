using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6oop
{
    class Bodywork
    {

        private string typeOfBody;
        private string vinCode;
        private string color;
        private string material;
        private int yearOfCreate;
        private string carModel;
        private int numOfSits;
        private int weightOfBody;
        private int maxWeightOfCar;

        public Bodywork()
        {
            this.typeOfBody = string.Empty;
            this.vinCode = string.Empty;
            this.color = string.Empty;
            this.material = string.Empty;
            this.yearOfCreate = 0;
            this.carModel = string.Empty;
            this.numOfSits = 0;
            this.weightOfBody = 0;
            this.maxWeightOfCar = 0;
        }

        public Bodywork(string typeOfBody, string vinCode, string color, string material, int yearOfCreate, string carModel, int numOfSits, int weightOfBody, int maxWeightOfCar)
        {
            this.typeOfBody = typeOfBody;
            this.vinCode = vinCode;
            this.color = color;
            this.material = material;
            this.yearOfCreate = yearOfCreate;
            this.carModel = carModel;
            this.numOfSits = numOfSits;
            this.weightOfBody = weightOfBody;
            this.maxWeightOfCar = maxWeightOfCar;
        }

        public string TypeOfBody
        {
            get => this.typeOfBody;
            set => this.typeOfBody = value;
        }

        public string VinCode
        {
            get => this.vinCode;
            set => this.vinCode = value;
        }

        public string Color
        {
            get => this.color; 
            set => this.color = value;
        }

        public string Material
        {
            get => this.material; 
            set => this.material = value;
        }

        public int YearOfCreate
        {
            get => this.yearOfCreate; 
            set => this.yearOfCreate = value;
        }

        public string CarModel
        {
            get => this.carModel; 
            set => this.carModel = value;
        }

        public int NumOfSits
        {
            get => this.numOfSits; 
            set => this.numOfSits = value;
        }

        public int WeightOfBody
        {
            get => this.weightOfBody; 
            set => this.weightOfBody = value;
        }

        public int MaxWeightOfCar
        {
            get => this.maxWeightOfCar;
            set => this.maxWeightOfCar = value;
        }
    }
}
