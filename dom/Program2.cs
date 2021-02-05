using System;

namespace zad_2_Sevdiye
{
    class Program
    {
        static void Example1()
        {
            Console.WriteLine("1)  12+15= ");
            string num1 = Convert.ToString(12, 16);
            string num2 = Convert.ToString(15, 16);
            int number_one = Convert.ToInt32(num1, 16);
            int number_two = Convert.ToInt32(num2, 16);
            string Hex = Convert.ToString(number_one + number_two, 16);
            Hex = Hex.ToUpper();
            int Decimal = Convert.ToInt32(Hex, 16);
            Console.WriteLine("Hexadecimal: {0}, Decimal: {1}", Hex, Decimal);
        }
        static void Example2()
        {
            Console.WriteLine("2)  9 + 15 = ");
            string num1 = Convert.ToString(9, 16);
            string num2 = Convert.ToString(15, 16);
            int number_one = Convert.ToInt32(num1, 16);
            int number_two = Convert.ToInt32(num2, 16);
            string Hex = Convert.ToString(number_one + number_two, 16);
            Hex = Hex.ToUpper();
            int Decimal = Convert.ToInt32(Hex, 16);
            Console.WriteLine("Hexadecimal: {0}, Decimal: {1}", Hex, Decimal);
        }
        static void Example3()
        {
            Console.WriteLine("3)  25-10= ");
            string num1 = Convert.ToString(25, 16);
            string num2 = Convert.ToString(10, 16);
            int number_one = Convert.ToInt32(num1, 16);
            int number_two = Convert.ToInt32(num2, 16);
            string Hex = Convert.ToString(number_one - number_two, 16);
            Hex = Hex.ToUpper();
            int Decimal = Convert.ToInt32(Hex, 16);
            Console.WriteLine("Hexadecimal: {0}, Decimal: {1}", Hex, Decimal);
        }
        static void Example4()
        {
            Console.WriteLine("4)  45-17= ");
            string num1 = Convert.ToString(45, 16);
            string num2 = Convert.ToString(17, 16);
            int number_one = Convert.ToInt32(num1, 16);
            int number_two = Convert.ToInt32(num2, 16);
            string Hex = Convert.ToString(number_one - number_two, 16);
            Hex = Hex.ToUpper();
            int Decimal = Convert.ToInt32(Hex, 16);
            Console.WriteLine("Hexadecimal: {0}, Decimal: {1}", Hex, Decimal);
        }
        static void Example5()
        {
            Console.WriteLine("5)  13*5= ");
            string num1 = Convert.ToString(45, 16);
            string num2 = Convert.ToString(17, 16);
            int number_one = Convert.ToInt32(num1, 16);
            int number_two = Convert.ToInt32(num2, 16);
            string Hex = Convert.ToString(number_one * number_two, 16);
            Hex = Hex.ToUpper();
            int Decimal = Convert.ToInt32(Hex, 16);
            Console.WriteLine("Hexadecimal: {0}, Decimal: {1}", Hex, Decimal);
        }
        static void Example6()
        {
            Console.WriteLine("6)  17*3= ");
            string num1 = Convert.ToString(45, 16);
            string num2 = Convert.ToString(17, 16);
            int number_one = Convert.ToInt32(num1, 16);
            int number_two = Convert.ToInt32(num2, 16);
            string Hex = Convert.ToString(number_one * number_two, 16);
            Hex = Hex.ToUpper();
            int Decimal = Convert.ToInt32(Hex, 16);
            Console.WriteLine("Hexadecimal: {0}, Decimal: {1}", Hex, Decimal);
        }
        static void Example7()
        {
            Console.WriteLine("7)  36/4= ");
            string num1 = Convert.ToString(36, 16);
            string num2 = Convert.ToString(4, 16);
            int number_one = Convert.ToInt32(num1, 16);
            int number_two = Convert.ToInt32(num2, 16);
            string Hex = Convert.ToString(number_one / number_two, 16);
            Hex = Hex.ToUpper();
            int Decimal = Convert.ToInt32(Hex, 16);
            Console.WriteLine("Hexadecimal: {0}, Decimal: {1}", Hex, Decimal);
        }
        static void Example8()
        {
            Console.WriteLine("8)  81/9= ");
            string num1 = Convert.ToString(81, 16);
            string num2 = Convert.ToString(9, 16);
            int number_one = Convert.ToInt32(num1, 16);
            int number_two = Convert.ToInt32(num2, 16);
            string Hex = Convert.ToString(number_one / number_two, 16);
            Hex = Hex.ToUpper();
            int Decimal = Convert.ToInt32(Hex, 16);
            Console.WriteLine("Hexadecimal: {0}, Decimal: {1}", Hex, Decimal);
        }
        static void Main(string[] args)
        {
            Example1();
            Example2();
            Example3();
            Example4();
            Example5();
            Example6();
            Example7();
            Example8();

        }
    }
}
