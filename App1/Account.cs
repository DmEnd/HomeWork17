using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Account<T>
    {
        string name;
        string middleName;
        string lastName;
        T accNum;
        double amount;

        public void SetName(string name, string middleName, string lastName)
        {
            this.name = name;
            this.middleName = middleName;
            this.lastName = lastName;
        }
        public void SetAccNum(T accNum)
        {
            this.accNum = accNum;
        }
        public void SetAmount(double amount)
        {

            this.amount = Math.Round(amount, 2);
        }
        public void SetNameConsole()
        {
            Console.Write("Введите имя ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Введите отчество ");
            middleName = Convert.ToString(Console.ReadLine());
            Console.Write("Введите фамилию ");
            lastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
        }
        public void SetAccNumConsole()
        {
            Console.Write("Введите номер счёта ");
            accNum = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine();
        }
        public void SetAmountConsole()
        {
            Console.Write("Введите баланс счёта ");
            amount = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
            Console.WriteLine();
        }
        public void ShowInfo()
        {
            Console.WriteLine("{0} {1} {2} номер счёта {3}, баланс {4:N2}.", lastName, name, middleName, accNum, amount);
            Console.WriteLine();
        }
    }
}
