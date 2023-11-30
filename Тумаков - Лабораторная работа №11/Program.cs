using System;
using System.Collections.Generic;
using Bank;
using ConstructionCompany;

namespace Тумаков___Лабораторная_работа__11
{
    class Program
    {
        static void Main()
        {
            bool isTaskEnd = false;
            string taskNumber;

            do
            {
                Console.WriteLine("{0, 86}", "ТУМАКОВ - ЛАБОРАТОРНАЯ РАБОТА №11. МЕНЮ ЗАДАНИЙ\n");

                Console.WriteLine("Подсказка:\n" +
                                  "Упражнение 11.1 и 11.2. Создается фабрака объектов класса BankAccount. Создается и подключается сборка      -   цифра 1\n" +
                                  "Домашнее задание 11.1 и 11.2. Создается фабрака объектов класса Building. Создается и подключается сборка   -   цифра 2\n" +
                                  "Закончить выполнение заданий и выйти из программы                                                           -   цифра 0\n");

                Console.Write("Введите номер задания: ");
                taskNumber = Console.ReadLine();

                switch (taskNumber)
                {
                    case "1":
                        // Упражнение 11.1 и 11.2. Создается фабрака объектов класса BankAccount. Создается и подключается сборка.
                        Console.Clear();
                        Console.WriteLine("{0, 112}", "УПРАЖНЕНИЕ 11.1 И 11.2. СОЗДАЕТСЯ ФАБРИКА ОБЪЕКТОВ КЛАССА BANKACCOUNT. СОЗДАЕТСЯ И ПОДКЛЮЧАЕТСЯ СБОРКА\n");

                        int firstBankAccount = BankAccountCreator.CreateAccount();
                        BankAccountCreator.CreateAccount(AccountType.Сберегательный_счет);
                        BankAccountCreator.CreateAccount(5078878854);
                        BankAccountCreator.CreateAccount(4654487854, AccountType.Текущий_счет);

                        Dictionary<int, BankAccount> accountsDictionary = BankAccountCreator.AccountsDictionary;
                        Console.WriteLine("Созданы банковские счета:\n");

                        foreach (BankAccount bankAccount in accountsDictionary.Values)
                        {
                            Console.WriteLine(bankAccount.ToString());
                        }

                        BankAccountCreator.ClosingBankAccount(firstBankAccount);
                        Console.WriteLine($"\nУдален банковский счет под номером {firstBankAccount:D4}:\n");

                        foreach (BankAccount bankAccount in accountsDictionary.Values)
                        {
                            Console.WriteLine(bankAccount.ToString());
                        }

                        Console.Write("\nЧтобы закончить выполнение упражнения, нажмите на любую кнопку ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        // Домашнее задание 11.1 и 11.2. Создается фабрака объектов класса Building. Создается и подключается сборка.
                        Console.Clear();
                        Console.WriteLine("{0, 113}", "ДОМАШНЕЕ ЗАДАНИЕ 11.1 И 11.2. СОЗДАЕТСЯ ФАБРИКА ОБЪЕКТОВ КЛАССА BUILDING. СОЗДАЕТСЯ И ПОДКЛЮЧАЕТСЯ СБОРКА\n");

                        int firstBuilding = Creator.CreateBuild();
                        Creator.CreateBuild(5);
                        Creator.CreateBuild(30, 5);
                        Creator.CreateBuild(30, 5, 6, 2);

                        Dictionary<int, Building> buildingsDictionary = Creator.BuildingsDictionary;
                        Console.WriteLine("Созданы здания:\n");

                        foreach (Building building in buildingsDictionary.Values)
                        {
                            Console.WriteLine(building.ToString());
                        }

                        Creator.RemoveBuilding(firstBuilding);
                        Console.WriteLine($"\nУдалено здание под номером {firstBuilding:D4}:\n");

                        foreach (Building building in buildingsDictionary.Values)
                        {
                            Console.WriteLine(building.ToString());
                        }

                        Console.Write("\nЧтобы закончить выполнение упражнения, нажмите на любую кнопку ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine("{0, 71}", "ВЫ ВЫШЛИ ИЗ ПРОГРАММЫ");
                        isTaskEnd = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("{0, 102}", "ТАКОГО ЗАДАНИЯ НЕТ! ДОСТУПНЫЕ ЗАДАНИЯ УКАЗАНЫ В ПОДСКАЗКЕ. ПОВТОРИТЕ ПОПЫТКУ\n");
                        break;
                }
            } while (!isTaskEnd);
        }
    }
}