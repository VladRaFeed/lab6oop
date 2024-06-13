using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6oop
{
    class MainCar
    {

        private Bodywork body;
        private Engine engine;
        private Chassis chassis;

        public MainCar(Bodywork body, Engine engine, Chassis chassis)
        {
            this.body = body;
            this.engine = engine;
            this.chassis = chassis;
        }

        public Bodywork Body
        {
            get => this.body; 
            set => this.body = value;
        }

        public Engine Engine
        {
            get => this.engine;
            set => this.engine = value;
        }   

        public Chassis Chassis
        {
            get => this.chassis; 
            set => this.chassis = value;
        }
    }
}
