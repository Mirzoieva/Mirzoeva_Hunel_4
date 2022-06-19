using System;
using System.Collections.Generic;
using System.Text;
using TansportType;

namespace Lab_4
{
    class Depo
    {
       
        public List<Transport> transport = new List<Transport>();

        public void Add( string name, double speed, double cost)
        {
            if(name=="train")
            {
                transport.Add(new Train(speed, cost));
            }
            else if (name =="airplane")
            {
                transport.Add(new Airplane(speed, cost));
            }
            else if (name=="car")
            {
                transport.Add(new Car(speed, cost));
            }
            else if (name =="bus")
            {
                transport.Add(new Bus (speed, cost));
            }
            else
            {
                transport.Add(new Helicopter(speed, cost));
            }
        }

        public void Choose()
        {
            foreach (var value in transport)
            {
                Type t = value.GetType();
                if (t.Equals(typeof(Train)))
                {
                    Console.WriteLine("Поїзд");
                    value.Length();
                    value.Price();
                    value.Time();
                }
                else if (t.Equals(typeof(Bus)))
                {
                    Console.WriteLine("Автобус");
                    value.Length();
                    value.Price();
                    value.Time();
                }
                else if (t.Equals(typeof(Car)))
                {
                    Console.WriteLine("Автомобiль");
                    value.Length();
                    value.Price();
                    value.Time();
                }
                else if (t.Equals(typeof(Airplane)))
                {
                    Console.WriteLine("Лiтак");
                    value.Length();
                    value.Price();
                    value.Time();
                }
                else if (t.Equals(typeof(Helicopter)))
                {
                    Console.WriteLine("Вертолiт");
                    value.Length();
                    value.Price();
                    value.Time();
                }
            }
        }
    }
}
