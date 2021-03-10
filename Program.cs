using System;

namespace MyName
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor=ConsoleColor.Blue; 
            String MyName = "onoja";
            String Message = "My name is " + MyName;
            String CapsMessage = Message.ToUpper();
            Console.WriteLine(MyName);
            Console.WriteLine(Message);
            Console.WriteLine(CapsMessage);
            Console.Read();

        }
    }
}