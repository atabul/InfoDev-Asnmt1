using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoDev_Assnmt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //stringconcatinate();
            //stringformatting();
            //stringinterpolation();
            stringbuilder();
        }

        private static void stringconcatinate()
        {
            string a = "Hello";
            string b = "World!";
            var res1 = a + " " + b;
            Console.WriteLine(res1);
            Console.ReadLine();
        }

        private static void stringformatting()
        {
            string a = "super";
            string b = "man!";
            string template = "{0} {1}";
            var res = string.Format(template, a, b);
            Console.WriteLine(res);
            Console.ReadLine();
        }

        private static void stringinterpolation()
        {
            string a = "Hello";
            string b = "World!";
            var res = $"{a} {b}, => {a} and {b}";
            Console.WriteLine(res);
            Console.ReadLine();
        }

        private static void stringbuilder()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hello Everyone!");
            sb.AppendLine("\t" + "I am learning dot net technology");
            var res = sb.ToString();
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}