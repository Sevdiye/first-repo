using System;

namespace zad_1
{
    class Program
    {
        static void Example1()
        {
            Console.WriteLine("1)  12+15= ");
            string num1=Convert.ToString(12, 2);
            string num2 = Convert.ToString(15, 2);
            int number_one = Convert.ToInt32(num1, 2);
            int number_two = Convert.ToInt32(num2, 2);          
           string Binary= Convert.ToString(number_one + number_two, 2);          
           int Decimal= Convert.ToInt32(Binary, 2);
            Console.WriteLine("Binary: {0}, Decimal: {1}",Binary,Decimal);
        }
        static void Example2()
        {
            Console.WriteLine("2)  9 + 15 = ");
            string num1 = Convert.ToString(9, 2);
            string num2 = Convert.ToString(15, 2);
            int number_one = Convert.ToInt32(num1, 2);
            int number_two = Convert.ToInt32(num2, 2);
            string Binary = Convert.ToString(number_one + number_two, 2);
            int Decimal =Convert.ToInt32(Binary, 2);
            Console.WriteLine("Binary: {0}, Decimal: {1}", Binary, Decimal);
        }
        static void Example3()
        {
            Console.WriteLine("3)  25-10= ");
            string num1 = Convert.ToString(25, 2);
            string num2 = Convert.ToString(10, 2);
            int number_one = Convert.ToInt32(num1, 2);
            int number_two = Convert.ToInt32(num2, 2);
            string Binary = Convert.ToString(number_one - number_two, 2);
            int Decimal = Convert.ToInt32(Binary, 2);
            Console.WriteLine("Binary: {0}, Decimal: {1}", Binary, Decimal);
        }
        static void Example4()
        {
            Console.WriteLine("4)  45-17= ");
            string num1 = Convert.ToString(45, 2);
            string num2 = Convert.ToString(17, 2);
            int number_one = Convert.ToInt32(num1, 2);
            int number_two = Convert.ToInt32(num2, 2);
            string Binary = Convert.ToString(number_one - number_two, 2);
            int Decimal = Convert.ToInt32(Binary, 2);
            Console.WriteLine("Binary: {0}, Decimal: {1}", Binary, Decimal);
        }
        static void Example5()
        {
            Console.WriteLine("5)  13*5= ");
            string num1 = Convert.ToString(45, 2);
            string num2 = Convert.ToString(17, 2);
            int number_one = Convert.ToInt32(num1, 2);
            int number_two = Convert.ToInt32(num2, 2);
            string Binary = Convert.ToString(number_one * number_two, 2);
            int Decimal = Convert.ToInt32(Binary, 2);
            Console.WriteLine("Binary: {0}, Decimal: {1}", Binary, Decimal);
        }
        static void Example6()
        {
            Console.WriteLine("6)  17*3= ");
            string num1 = Convert.ToString(45, 2);
            string num2 = Convert.ToString(17, 2);
            int number_one = Convert.ToInt32(num1, 2);
            int number_two = Convert.ToInt32(num2, 2);
            string Binary = Convert.ToString(number_one * number_two, 2);
            int Decimal = Convert.ToInt32(Binary, 2);
            Console.WriteLine("Binary: {0}, Decimal: {1}", Binary, Decimal);
        }
        static void Example7()
        {
            Console.WriteLine("7)  36/4= ");
            string num1 = Convert.ToString(36, 2);
            string num2 = Convert.ToString(4, 2);
            int number_one = Convert.ToInt32(num1, 2);
            int number_two = Convert.ToInt32(num2, 2);
            string Binary = Convert.ToString(number_one / number_two, 2);
            int Decimal = Convert.ToInt32(Binary, 2);
            Console.WriteLine("Binary: {0}, Decimal: {1}", Binary, Decimal);
        }
        static void Example8()
        {
            Console.WriteLine("8)  81/9= ");
            string num1 = Convert.ToString(81, 2);
            string num2 = Convert.ToString(9, 2);
            int number_one = Convert.ToInt32(num1, 2);
            int number_two = Convert.ToInt32(num2, 2);
            string Binary = Convert.ToString(number_one / number_two, 2);
            int Decimal = Convert.ToInt32(Binary, 2);
            Console.WriteLine("Binary: {0}, Decimal: {1}", Binary, Decimal);
        }
        static void Main(string[] args)
        {
          
        }

    }
}
