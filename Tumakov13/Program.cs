using System;
using Tumakov13.Classes;

namespace Tumakov13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13.1
            BankAccount account = new BankAccount(123445, 12300, BankAccount.AccountType.Текущий);
            Console.WriteLine($"тип: {account.BankAccountType} счет");
            Console.WriteLine($"номер счета: {account.AccountNumber}");
            Console.WriteLine($"баланс: {account.AccountBalance} руб");
            account.AccountOwner = "Шарюкова Алина";
            Console.WriteLine($"держатель: {account.AccountOwner}");

            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();


            // дз 13.1
            Console.WriteLine("Домашнее задание 13.1 В классе здания из домашнего задания 7.1 все методы для\r\nзаполнения и получения значений полей заменить на свойства. Написать тестовый пример.");
            Building b = new Building();
            b.NumberOfApartments = 10;
            Console.WriteLine(b.NumberOfApartments);
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();

            // дз 13.2
            Console.WriteLine("Домашнее задание 13.2 Создать класс для нескольких зданий. Поле класса – массив на 10\r\nзданий. В классе создать индексатор, возвращающий здание по его номеру.");
            SeveralBuildings building = new SeveralBuildings();
            building[0] = "здание 12";
            building[1] = "здание 34";
            
            Console.WriteLine(building[0]); 
            Console.WriteLine(building[1]); 
            Console.WriteLine(building[11]);
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();

        }
    }
}
