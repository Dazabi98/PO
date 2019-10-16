using System;

namespace cwiczenia2
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = "Mój samochód";
            Console.WriteLine(carName); // zadanie 0
            Car car1 = new Car();
            car1.marka = "Volvo"; // zadanie 3
            car1.rok = 2014;
            car1.srednieSpalanie = 5;
            Console.WriteLine(car1.marka + " " + car1.rok);
            Car car2 = new Car(); // zadanie 4
            car2.marka = "Audi";
            car2.rok = 2016;
            Console.WriteLine(car2.marka + " " + car2.rok);
           // car1 = car2; // do zadania 5
            Console.WriteLine(car1.marka + " " + car1.rok); // zadanie 5
            Console.WriteLine(car2.marka + " " + car2.rok); // zadanie 5
            //double spalanie = car1.ObliczSpalanie(20); // metoda musi być public aby zadziałało
           // Console.WriteLine("spalanie : {0}", spalanie); 
            

        }
    }
}
