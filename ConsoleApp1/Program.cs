using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = string.Join(Environment.NewLine, QuestionClass.NamesList);
            Console.WriteLine(names);
            Console.WriteLine($"the result is {Convert.ToString(TESTModule(1))}");
        }

        private static dynamic TESTModule(dynamic value)
        {
            switch (value.GetType().Name)
            {
                case ("Int32"):
                    var intResult = Convert.ToInt32(value);
                    if (intResult >= 1 && intResult <= 4)
                        return intResult * 2;
                    if (intResult > 4)
                        return intResult * 3;
                    if (intResult < 1)
                        throw new InvalidOperationException("Invalid value");
                    break;
                case ("Double"):
                    var doubleResult = Convert.ToDouble(value);
                    if (doubleResult >= 1.0 && doubleResult <= 2.0)
                        return 3.0;
                    break;
                case ("String"):
                    return value.ToString().ToUpperInvariant();
                default:
                    return value;
            }

            return 0;
        }

        public bool IsValueType<T>()
        {
            return typeof(T).IsValueType;
        }
    }
}
