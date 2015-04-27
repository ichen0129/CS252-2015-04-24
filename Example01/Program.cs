using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入你的名字:");
            string Name = Console.ReadLine();
            Console.WriteLine("請輸入你的性別:");
            Console.WriteLine("Hello World !");
            Console.WriteLine("{0} 您好!", Name);
            Console.WriteLine("{0} 您好! {1}", Name, "晚上好!");
            string a = "1";

            int b = int.Parse(a) + 3;
            Console.WriteLine("b={0}", b);
        }
    }
}