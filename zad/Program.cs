using System;

namespace ConsoleApp1
{
    class Program

    {
        /* Да се напише програма, която въвежда разстоянието в метри,
          времето - час, минути, секунди - на отделни редове.
          Да се напишат методи:
          - да изчисли времето в секунди
          - изчислява времето и връща в часове
          - изчислява и връща метрите в мили
          Задачата извежда:
          скоростта в метри/секунди
          мили/час
          км/час 
        */

        static double timetosec(double h, double m, double s)
        {
            double time = h * 60 * 60 + m * 60 + s;
            return time;
        }

        static double mtomi(double m)
        {
            double mili = m * 0.00062137;
            return mili;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете разстояние в метри:");
            double M= double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете час:");
            double H= double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете минути:");
            double MIN= double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете секунди:");
            double S= double.Parse(Console.ReadLine());

            //да изчисли времето в секунди
            Console.WriteLine(M / timetosec(H, MIN, S));

            //изчислява и връща метрите в мили
            //Задачата извежда: скоростта в метри / секунди;  мили / час;  км / час
            Console.WriteLine("Скоростта в метри/секунди {0}",M/S);
            Console.WriteLine("Скоростта в мили/час {0}",mtomi(M)/H);
            Console.WriteLine("Скоростта в км/час {0}", (M* 0.001) / H);

        }
    }
}
