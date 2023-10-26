using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    enum BankType
    {
        Сберегательный, Зарплатный
    }
    internal class Bankaccount
    {
        private static int accountCounter = 1000;

        private int accountnumber;
        private double balance;
        private BankType type;

        // Конструктор класса
        public Bankaccount(BankType type)
        {
            accountnumber = GenerateAccountNumber();
            balance = 0;
            this.type = type;
        }


        private int GenerateAccountNumber()
        {
            return accountCounter++;
        }


        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Депозит на {amount} успешно выполнен.\nНовый баланс: {balance}");
            }
            else
            {
                Console.WriteLine("Сумма депозита должна быть больше нуля.");
            }
        }


        public void Withdraw(double amount)
        {
            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Списание {amount} успешно выполнено.\nНовый баланс: {balance}");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Сумма для списания должна быть больше нуля.");
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете.");
            }
        }
        public void Transfer(Bankaccount account1, Bankaccount account2, double amount)
        {
            account1.balance -= amount;
            account2.balance += amount;
            Console.WriteLine($"Перевод на счёт {account1.accountnumber} выполнен, ваш текущий баланс {account1.balance}");
        }


        public void PrintAccountInfo()
        {
            Console.WriteLine($"Номер счета: {accountnumber}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип счета: {type}");
        }
    }
}
