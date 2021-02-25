using System;

namespace WhereIsMyCar
{
    class Program
    {
        class Car
        {
            public string mark;
            public string model;
            public string registrationNumber;
            public string color;
            public int odometer;
            public int fuelTank;

            public Car(string _mark, string _model, string _registrationNumber, string _color)
            {
                mark = _mark;
                model = _model;
                registrationNumber = _registrationNumber;
                color = _color;
                odometer = 0;
                fuelTank = 60;
            }

            public void PrintCarInfo()
            {
                Console.WriteLine($"Mark:{mark} Model:{model} Registration number:{registrationNumber} Color:{color} Odometer:{odometer} Fuel tank:{fuelTank} ");
            }
           
               
                public void Lap()
                {
                    odometer +=100;
                    fuelTank -=5; 
                }
            
        }
        static void Main(string[] args)
        { 
            Car Drive = new Car("Audi", "Sedan", "AAA666", "White");
            Drive.PrintCarInfo();
            int lap = 0;

           while(Drive.fuelTank > 0)
            {
                Drive.Lap();
                lap++;
            }

            Console.WriteLine("The race is over");
            Drive.PrintCarInfo();
            Console.WriteLine(lap);
        }
    }
}
