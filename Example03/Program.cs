using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //亂數產生器
            Random random = new Random();
            int randomNumber = random.Next(0, 2);

            Console.Write("請輸入你的名字:");
            string name = Console.ReadLine();
            string gender = (randomNumber == 0) ? "女" : "男";
            Console.WriteLine("{0} 您好!我猜您是{1}的吧!", name, gender);
            /*
             if (randomNumber == 0)
                 Console.WriteLine("{0} 您好!我猜您是女的吧!", name);
             else
                 Console.WriteLine("{0} 您好!我猜您是男的吧!", name);
             */
        }
    }
}