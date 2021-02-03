using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 1;
            int number2 = 2;
            int result = Add(number1, number2);
            Console.WriteLine("Numbers : "+number1+" "+number2);
            Console.WriteLine("Result : "+result);

            int number3 = 3;
            int number4 = 4;
            int resultUsingRef = AddUsingRef(number3,ref number4);
            Console.WriteLine("Numbers : " + number3 + " " + number4);
            Console.WriteLine("Result : " + resultUsingRef);

            int number5 = 5;
            int number6 = 6;
            int resultUsingOut = AddUsingOut(out number5, number6);
            Console.WriteLine("Numbers : " + number5 + " " + number6);
            Console.WriteLine("Result : " + resultUsingOut);
        }

        static int Add(int number1, int number2)
        {
            number1 = 10;
            number2 = 20;
            int sum = number1 + number2;
            return sum;
        }

        static int AddUsingRef(int number3,ref int number4)
        {
            number4 = 30;     //değeri set edilebilir de edilmeyebilir de
            return number3+number4;
        }

        static int AddUsingOut(out int number5, int number6)
        {
            number5 = 8;   //değeri set edilmek zorunda
            return number5+number6;
        }


    }
}
