using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Решение_задач
{
    /// <summary>
    /// Делегат, описывающий функцию, которая реагирует на событие.
    /// </summary>
    /// <param name="eventName"> Название события. </param>
    delegate void ReactionToEventDelegate(string eventName);
    class Program
    {
        /// <summary>
        /// Событие, которое описывает реакцию на произошедшее событие.
        /// </summary>
        static public event ReactionToEventDelegate ReactionToEvent;

        /// <summary>
        /// Метод, разделяющий список студентов на списки по группам.
        /// </summary>
        /// <param name="studentsList"> Список всех студентов. </param>
        /// <returns> Возвращает список, включающий в себя списки со студентами по группам. </returns>
        static public List<List<Student>> DividesStudentsIntoGroups(List<Student> studentsList)
        {
            int firstElement = 0;
            List<List<Student>> studentsDividedByGroups = new List<List<Student>>();

            studentsList = studentsList.OrderBy(student => student.GroupNumber).ToList<Student>();

            for (int i = 1; i < studentsList.Count; i++)
            {
                if ((studentsList[i].GroupNumber != studentsList[i - 1].GroupNumber) || (i == studentsList.Count -1))
                {
                    List<Student> studentsInOneGroup = new List<Student>();

                    for (int j = firstElement; j < i; j++)
                    {
                        studentsInOneGroup.Add(studentsList[j]);
                    }

                    studentsDividedByGroups.Add(studentsInOneGroup);
                    firstElement = i;
                }
            }

            if (studentsList[studentsList.Count-1].GroupNumber == studentsList[studentsList.Count-2].GroupNumber)
            {
                studentsDividedByGroups[studentsDividedByGroups.Count - 1].Add(studentsList[studentsList.Count - 1]);
            }
            else
            {
                List<Student> studentsInOneGroup = new List<Student> { studentsList[studentsList.Count - 1] };
                studentsDividedByGroups.Add(studentsInOneGroup);
            }

            return studentsDividedByGroups;
        }

        static void Main()
        {
            bool isTaskEnd = false;
            string taskNumber;

            do
            {
                Console.WriteLine("{0, 77}", "РЕШЕНИЕ ЗАДАЧ. МЕНЮ ЗАДАНИЙ\n");

                Console.WriteLine("Подсказка:\n" +
                                  "Задание №1. Программа считывает список студентов и распределяет их по мероприятиям                          -   цифра 1\n" +
                                  "Задание №2. Программа выводит на экран реакцию человека на событие, если оно совпало с его увлечениями      -   цифра 2\n" +
                                  "Закончить выполнение заданий и выйти из программы                                                           -   цифра 0\n");

                Console.Write("Введите номер задания: ");
                taskNumber = Console.ReadLine();

                switch (taskNumber)
                {
                    case "1":
                        // Задание №1. Программа считывает список студентов и распределяет их по мероприятиям.
                        Console.Clear();
                        Console.WriteLine("{0, 102}", "ЗАДАНИЕ №1. ПРОГРАММА СЧИТЫВАЕТ СПИСОК СТУДЕНТОВ И РАСПРЕДЕЛЯЕТ ИХ ПО МЕРОПРИЯТИЯМ\n");

                        string studentDataPath = "ProgramFiles/StudentData.txt";
                        string studetEventsPath = "ProgramFiles/StudentEventsData.txt";

                        bool isInputCompleted = false;

                        string[] studentDataArray = File.ReadAllLines(studentDataPath);
                        List<Student> studentsList = new List<Student>();

                        for (int i = 1; i < studentDataArray.Length; i++)
                        {
                            string[] studentDetailsArray = studentDataArray[i].Split(new string[] { " # " }, StringSplitOptions.RemoveEmptyEntries);

                            Student student = new Student(studentDetailsArray);
                            studentsList.Add(student);
                        }

                        List<List<Student>> studentsDividedByGroups = DividesStudentsIntoGroups(studentsList);

                        do
                        {
                            Console.Write("Чтобы закончить, введите ЗАКОНЧИТЬ. Чтобы продолжить, введите ЛЮБОЕ СЛОВО: ");
                            string finishingPhrase = Console.ReadLine();

                            if (finishingPhrase.ToLower() == "закончить")
                            {
                                isInputCompleted = true;
                                Console.Clear();
                            }
                            else
                            {
                                Console.Write("\nВведите дату мероприятия: ");
                                string eventDate = Console.ReadLine();
                                Console.Write("Введите описание мероприятия: ");
                                string eventDescription = Console.ReadLine();
                                Console.Write("Введите количество участников (целое число): ");
                                bool parseResult = int.TryParse(Console.ReadLine(), out int numberOfParticipants);

                                if (parseResult)
                                {
                                    StudentEvent studentEvent = new StudentEvent(eventDate, eventDescription, numberOfParticipants);
                                    studentEvent.AddEventToFile(studetEventsPath);

                                    studentEvent.SelectionOfParticipants(studentsDividedByGroups, studetEventsPath);

                                    File.WriteAllText(studentDataPath, String.Empty);
                                    File.AppendAllText(studentDataPath, studentDataArray[0] + "\n");

                                    for (int i = 0; i < studentsList.Count; i++)
                                    {
                                        string personData = $"{studentsList[i].StudentSurname} # {studentsList[i].StudentName} # {studentsList[i].GroupNumber} # {studentsList[i].NumberOfRecentEventsAttended}\n";
                                        File.AppendAllText(studentDataPath, personData);
                                    }

                                    Console.WriteLine("Файлы обновлены!");

                                    Console.Write("\nЧтобы продолжить выполнение упражнения, нажмите на любую кнопку ");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("Введенные данные некорректны. Повторите попытку!");

                                    Console.Write("\nЧтобы продолжить выполнение упражнения, нажмите на любую кнопку ");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                        } while (!isInputCompleted);

                        break;
                    case "2":
                        // Задание №2. Программа выводит на экран реакцию человека на событие, если оно совпало с его увлечениями.
                        Console.Clear();
                        Console.WriteLine("{0, 112}", "ЗАДАНИЕ №2. ПРОГРАММА ВЫВОДИТ НА ЭКРАН РЕАКЦИЮ ЧЕЛОВЕКА НА СОБЫТИЕ, ЕСЛИ ОНО СОВПАЛО С ЕГО УВЛЕЧЕНИЯМИ\n");

                        string[] events = { "выход нового фильма", "концерт любимого исполнителя", "выход нового сезона сериала", "выход нового музыкального альбома" };

                        Person anna = new Person("Анна", events[0], events[3]);
                        ReactionToEvent += anna.ReactsToEvent;
                        Person peter = new Person("Петр", events[0], events[1], events[3]);
                        ReactionToEvent += peter.ReactsToEvent;
                        Person dima = new Person("Дима", events[2]);
                        ReactionToEvent += dima.ReactsToEvent; 

                        isInputCompleted = false;
                        string eventNumber;

                        do
                        {
                            Console.WriteLine("Подсказка:\n" +
                                              "Выход нового фильма                                                                                         -   цифра 1\n" +
                                              "Концерт любимого исполнителя                                                                                -   цифра 2\n" +
                                              "Выход нового сезона сериала                                                                                 -   цифра 3\n" +
                                              "Выход нового музыкального альбома                                                                           -   цифра 4\n" +
                                              "Закончить выполнение задания и выйти                                                                        -   цифра 0\n");

                            Console.Write("Введите номер события: ");
                            eventNumber = Console.ReadLine();

                            switch (eventNumber)
                            {
                                case "1":
                                case "2":
                                case "3":
                                case "4":
                                    ReactionToEvent.Invoke(events[int.Parse(eventNumber) - 1]);

                                    Console.Write("\nЧтобы продолжить выполнение упражнения, нажмите на любую кнопку ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case "0":
                                    isInputCompleted = true;
                                    Console.Clear();
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine("{0, 101}", "ТАКОГО СОБЫТИЯ НЕТ! ДОСТУПНЫЕ СОБЫТИЯ УКАЗАНЫ В ПОДСКАЗКЕ. ПОВТОРИТЕ ПОПЫТКУ\n");
                                    break;
                            }
                        } while (!isInputCompleted);
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine("{0, 73}", "ВЫ ВЫШЛИ ИЗ ПРОГРАММЫ");
                        isTaskEnd = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("{0, 101}", "ТАКОГО ЗАДАНИЯ НЕТ! ДОСТУПНЫЕ ЗАДАНИЯ УКАЗАНЫ В ПОДСКАЗКЕ. ПОВТОРИТЕ ПОПЫТКУ\n");
                        break;
                }
            } while (!isTaskEnd);
        }
    }
}