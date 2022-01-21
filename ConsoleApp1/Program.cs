using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = string.Join(Environment.NewLine, QuestionClass.NamesList);
            Console.Write(names);
        }
    }
}
