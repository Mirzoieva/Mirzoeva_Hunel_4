using System;
using TansportType;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Depo depo = new Depo();

            depo.Add("car", 100, 4);
            depo.Add("train", 60, 2);
            depo.Add("bus", 80, 3);
            depo.Add("helicopter", 180, 4);
            depo.Add("airplane", 900, 5);
            depo.Choose();  
        }
    }
}
