using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account<string> account1 = new Account<string>();
            Account<int> account2 = new Account<int>();

            account1.SetNameConsole();
            account1.SetAccNumConsole();
            account1.SetAmountConsole();

            account2.SetName("Иван", "Иванович", "Иванов");
            account2.SetAccNum(525);
            account2.SetAmount(700568.15);

            account1.ShowInfo();
            account2.ShowInfo();

            Console.ReadKey();
        }
    }
}
