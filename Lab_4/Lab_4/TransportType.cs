using System;
using System.Collections.Generic;
using System.Text;
using Lab_4;


namespace TansportType
{
    class Airplane : Transport
    {
     
        public Airplane(double speed, double cost) : base(speed, cost) { }

    }

    class Train : Transport
    {
       
        public Train (double speed, double cost) : base(speed, cost) { }

    }
    class Car : Transport
    {
       
        public Car (double speed, double cost) : base(speed, cost) { }
    }

    class Bus : Transport 
    {      
        public Bus(double speed, double cost) : base(speed, cost) { }
    }
    class Helicopter : Transport 
    {
        public Helicopter(double speed, double cost) : base(speed, cost) { }
    }


}
