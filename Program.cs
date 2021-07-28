using System;

namespace HomeWork5._5
{
    
    class Program
    {

        static int KeyInputInt(string text)
        {
            string s = KeyInputString(text);

            int ret = 0;

            Int32.TryParse(s, out ret);

            return ret;
        }
        static string KeyInputString(string text)
        {
            Console.WriteLine($"Input string ({text})");

            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }
}
