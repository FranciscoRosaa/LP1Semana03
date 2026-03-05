using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("String: ");
            string s = Console.ReadLine();

            Console.Write("Char: ");
            char c = char.Parse(Console.ReadLine());

            string result = "";

            foreach (char l in s)
            {
                if (l == c)
                {
                    result += "x";
                }
                else
                {
                    result += l;
                }
            }
            Console.WriteLine(result);
        }
    }
}
