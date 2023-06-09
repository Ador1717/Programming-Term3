using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class ReadTools
    {
        public static int ReadInt(string question)
        {
            Console.Write(question);
            int value = int.Parse(Console.ReadLine());
            return value;
        }
        public static int ReadInt(string question, int max, int min)
        {
            Console.Write(question);
            int age = int.Parse(Console.ReadLine());
            while ((age < 0) || (age > 121))
            {
                Console.Write(question);
                age = int.Parse(Console.ReadLine());
            }
            return age;
        }

        public static string ReadString(string question)
        {
            Console.Write(question);
            string name = Console.ReadLine();
            return name;
        }
    }
}
