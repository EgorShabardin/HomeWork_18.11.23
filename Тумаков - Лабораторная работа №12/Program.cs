using System;
using Library;

namespace Тумаков___Лабораторная_работа__12
{
    class Program
    {
        static void Main()
        {
            bool isTaskEnd = false;
            string taskNumber;

            do
            {
                Console.WriteLine("{0, 84}", "ТУМАКОВ - ЛАБОРАТОРНАЯ РАБОТА №12. МЕНЮ ЗАДАНИЙ\n");

                Console.WriteLine("Подсказка:\n" +
                                  "Упражнение 12.1. Для класса BankAccount переопределены операции сравнения и некоторые методы                -   цифра 1\n" +
                                  "Упражнение 12.2. Создан класс рациональных чисел. Для него переопределены некоторые операции и методы       -   цифра 2\n" +
                                  "Домашнее задание 12.1. Создан класс комплексных чисел. Для него переопределены некоторые операции и методы  -   цифра 3\n" +
                                  "Домашнее задание 12.2. Созданы классы книги и контейнера книг. Осуществляется сортировка с помощью делегата -   цифра 4\n" +
                                  "Закончить выполнение заданий и выйти из программы                                                           -   цифра 0\n");

                Console.Write("Введите номер задания: ");
                taskNumber = Console.ReadLine();

                switch (taskNumber)
                {
                    case "1":
                        // Упражнение 12.1. Для класса BankAccount переопределены операции сравнения и некоторые методы.
                        Console.Clear();
                        Console.WriteLine("{0, 106}", "УПРАЖНЕНИЕ 12.1. ДЛЯ КЛАССА BANKACCOUNT ПЕРЕОПРЕДЕЛЕНЫ ОПЕРАЦИИ СРАВНЕНИЯ И НЕКОТОРЫЕ МЕТОДЫ\n");

                        BankAccount firstBankAccount = new BankAccount(1000000, AccountType.Текущий_счет);
                        BankAccount secondBankAccount = new BankAccount(784562, AccountType.Сберегательный_счет);
                        BankAccount thirdBankAccount = new BankAccount(1000000, AccountType.Текущий_счет);

                        Console.WriteLine("Проверка операции == :");
                        if (firstBankAccount == secondBankAccount)
                        {
                            Console.WriteLine(firstBankAccount.ToString() + " равнен " + secondBankAccount.ToString());
                        }
                        else
                        {
                            Console.WriteLine(firstBankAccount.ToString() + " неравнен " + secondBankAccount.ToString());
                        }

                        Console.WriteLine("\nПроверка операции != :");
                        if (firstBankAccount != thirdBankAccount)
                        {
                            Console.WriteLine(firstBankAccount.ToString() + " неравнен " + thirdBankAccount.ToString());
                        }
                        else
                        {
                            Console.WriteLine(firstBankAccount.ToString() + " равнен " + thirdBankAccount.ToString());
                        }

                        Console.WriteLine("\nПроверка метода Equals:");
                        if (firstBankAccount.Equals(secondBankAccount))
                        {
                            Console.WriteLine(firstBankAccount.ToString() + " равнен " + secondBankAccount.ToString());
                        }
                        else
                        {
                            Console.WriteLine(firstBankAccount.ToString() + " неравнен " + secondBankAccount.ToString());
                        }

                        Console.Write("\nЧтобы закончить выполнение упражнения, нажмите на любую кнопку ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        // Упражнение 12.2. Создан класс рациональных чисел. Для него переопределены некоторые операции и методы.
                        Console.Clear();
                        Console.WriteLine("{0, 112}", "УПРАЖНЕНИЕ 12.2. СОЗДАН КЛАСС РАЦИОНАЛЬНЫХ ЧИСЕЛ. ДЛЯ НЕГО ПЕРЕОПРЕДЕЛЕНЫ НЕКОТОРЫЕ ОПЕРАЦИИ И МЕТОДЫ\n");

                        RationalNumber firstRationalNumber = RationalNumber.MakeRationalNumber(1, 2);
                        RationalNumber secondRationalNumber = RationalNumber.MakeRationalNumber(3, 4);

                        Console.WriteLine("Сумма: " + firstRationalNumber.ToString() + " + " + secondRationalNumber.ToString() + $" = {firstRationalNumber + secondRationalNumber}");
                        Console.WriteLine("Разность: " + firstRationalNumber.ToString() + " - " + secondRationalNumber.ToString() + $" = {firstRationalNumber - secondRationalNumber}");
                        Console.WriteLine("Умножение: " + firstRationalNumber.ToString() + " * " + secondRationalNumber.ToString() + $" = {firstRationalNumber * secondRationalNumber}");
                        Console.WriteLine("Деление: " + firstRationalNumber.ToString() + " / " + secondRationalNumber.ToString() + $" = {firstRationalNumber / secondRationalNumber}");
                        Console.WriteLine("Деление с остатком: " + firstRationalNumber.ToString() + " % " + secondRationalNumber.ToString() + $" = {firstRationalNumber % secondRationalNumber}");
                        Console.WriteLine("Инкремент: ++" + firstRationalNumber.ToString() + $" = {++firstRationalNumber}");
                        Console.WriteLine("Декремент: --" + secondRationalNumber.ToString() + $" = {--secondRationalNumber}\n");


                        Console.WriteLine("Равно: " + firstRationalNumber.ToString() + " == " + secondRationalNumber.ToString() + $" => {firstRationalNumber == secondRationalNumber}");
                        Console.WriteLine("Неравно: " + firstRationalNumber.ToString() + " != " + secondRationalNumber.ToString() + $" => {firstRationalNumber != secondRationalNumber}");
                        Console.WriteLine("Больше: " + firstRationalNumber.ToString() + " > " + secondRationalNumber.ToString() + $" => {firstRationalNumber > secondRationalNumber}");
                        Console.WriteLine("Меньше: " + firstRationalNumber.ToString() + " < " + secondRationalNumber.ToString() + $" => {firstRationalNumber < secondRationalNumber}");
                        Console.WriteLine("Больше или равно: " + firstRationalNumber.ToString() + " >= " + secondRationalNumber.ToString() + $" => {firstRationalNumber >= secondRationalNumber}");
                        Console.WriteLine("Меньше или равно: " + firstRationalNumber.ToString() + " <= " + secondRationalNumber.ToString() + $" => {firstRationalNumber <= secondRationalNumber}\n");

                        Console.WriteLine("Приведение типов в float: (float)" + secondRationalNumber.ToString() + $" => {(float)secondRationalNumber}" );
                        Console.WriteLine("Приведение типов в int: (int)" + firstRationalNumber.ToString() + $" => {(int)firstRationalNumber}");

                        Console.Write("\nЧтобы закончить выполнение упражнения, нажмите на любую кнопку ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        // Домашнее задание 12.1. Создан класс комплексных чисел. Для него переопределены некоторые операции и методы.
                        Console.Clear();
                        Console.WriteLine("{0, 113}", "ДОМАШНЕЕ ЗАДАНИЕ 12.1. СОЗДАН КЛАСС КОМПЛЕКСНЫХ ЧИСЕЛ. ДЛЯ НЕГО ПЕРЕОПРЕДЕЛЕНЫ НЕКОТОРЫЕ ОПЕРАЦИИ И МЕТОДЫ\n");

                        ComplexNumber firstComplexNumber = new ComplexNumber(5, 9);
                        ComplexNumber secondComplexNumber = new ComplexNumber(15, -7);

                        Console.WriteLine("Сумма: " + firstComplexNumber.ToString() + " + " + secondComplexNumber.ToString() + $" = {firstComplexNumber + secondComplexNumber}");
                        Console.WriteLine("Разность: " + firstComplexNumber.ToString() + " - " + secondComplexNumber.ToString() + $" = {firstComplexNumber - secondComplexNumber}");
                        Console.WriteLine("Умножение: " + firstComplexNumber.ToString() + " * " + secondComplexNumber.ToString() + $" = {firstComplexNumber * secondComplexNumber}\n");

                        Console.WriteLine("Равно: " + firstComplexNumber.ToString() + " == " + secondComplexNumber.ToString() + $" => {firstComplexNumber == secondComplexNumber}");
                        Console.WriteLine("Неравно: " + firstComplexNumber.ToString() + " != " + secondComplexNumber.ToString() + $" => {firstComplexNumber != secondComplexNumber}");

                        Console.Write("\nЧтобы закончить выполнение упражнения, нажмите на любую кнопку ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        // Домашнее задание 12.2. Созданы классы книги и контейнера книг. Осуществляется сортировка с помощью делегата.
                        Console.Clear();
                        Console.WriteLine("{0, 114}", "ДОМАШЕЕ ЗАДАНИЕ 12.2. СОЗДАНЫ КЛАССЫ КНИГИ И КОНТЕЙНЕРА КНИГ. ОСУЩЕСТВЛЯЕТСЯ СОРТИРОВКА С ПОМОЩЬЮ ДЕЛЕГАТА\n");

                        SortDelegate sortByTitle = book => book.BookTitle;
                        SortDelegate sortByAuthor = book => book.BookAuthor;
                        SortDelegate sortByPublishingHouse = book => book.PublishingHouse;

                        Book firstBook = new Book("Война и мир", "Толстой", "Речь");
                        Book secondBook = new Book("Преступление и наказание", "Достоевский", "АСТ");
                        Book thirdBook = new Book("Обломов", "Гончаров", "Буквоед");
                        Book fourtBook = new Book("Тихий Дон", "Шолохов", "Эксмо");
                        Book fifthBook = new Book("Капитанская дочка", "Пушкин", "Лабиринт");

                        BooksContainer.AddBookToList(firstBook, secondBook, thirdBook, fourtBook, fifthBook);

                        Console.WriteLine("Сортировка по названию: \n");
                        BooksContainer.SortingListOfBooks(sortByTitle);

                        foreach(Book book in BooksContainer.BooksList)
                        {
                            Console.WriteLine(book.ToString());
                        }

                        Console.WriteLine("\nСортировка по автору: \n");
                        BooksContainer.SortingListOfBooks(sortByAuthor);

                        foreach (Book book in BooksContainer.BooksList)
                        {
                            Console.WriteLine(book.ToString());
                        }

                        Console.WriteLine("\nСортировка по издательству: \n");
                        BooksContainer.SortingListOfBooks(sortByPublishingHouse);

                        foreach (Book book in BooksContainer.BooksList)
                        {
                            Console.WriteLine(book.ToString());
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
                        Console.WriteLine("{0, 99}", "ТАКОГО ЗАДАНИЯ НЕТ! ДОСТУПНЫЕ ЗАДАНИЯ УКАЗАНЫ В ПОДСКАЗКЕ. ПОВТОРИТЕ ПОПЫТКУ\n");
                        break;
                }
            } while (!isTaskEnd);
        }
    }
}
