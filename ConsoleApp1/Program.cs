using System;

namespace ConsoleApp1
{
    class Program
    {
        public void print(int value)
        {
            value *= value;
            Console.WriteLine("Call by value = " + value);
        }
        public void print2(ref int value)
        {
            value *= value;
            Console.WriteLine(value);
        }
        // Just like that
        public void OutParameter(out int value)
        {
            int val = 50;
                value = val;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program prog = new Program();
            int value = 5;
            prog.print(value);
            Console.WriteLine("After call by value, the value is " + value);
            int value2 = 10;
            prog.print2(ref value2);
            Console.WriteLine("After call by reference, the value is " + value2);
            int value3 = 20;
            prog.OutParameter(out value3);
            Console.WriteLine("After using 20 with out parameter, " + value3);
            Console.ReadLine();
        }
    }
}
