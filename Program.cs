using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        { 

            double mydouble = 13.37;
            //explicit conversion
            //int myInt;
           // myInt = (int)mydouble;
            //String MyString = mydouble.ToString();
            String MyString = "12";
            String mySecondString = "23";
            String result = MyString + mySecondString;
            Console.WriteLine(result);


            int num1 = Int32.Parse(MyString);
            int num2 = Int32.Parse(mySecondString);
            int resultInt = num1 + num2;

            Console.WriteLine(resultInt);




           // Console.WriteLine(myInt);
           // Console.WriteLine(MyString);
            Console.Read();

        
           
        }
    }
}
