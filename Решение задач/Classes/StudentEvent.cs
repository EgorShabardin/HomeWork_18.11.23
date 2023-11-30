using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Решение_задач
{
    /// <summary>
    /// Класс, описывающий мероприятие.
    /// </summary>
    class StudentEvent
    {
        #region Поля
        private string studentEventDate;
        private string studentEventDescription;
        private int numberOfParticipants;
        #endregion

        #region Свойства
        /// <summary>
        /// Свойство, позволяющее читать поле studentEventDate.
        /// </summary>
        public string StudentEventDate
        {
            get
            {
                return studentEventDate;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле studentEventDescription.
        /// </summary>
        public string StudentEventDescription
        {
            get
            {
                return studentEventDescription;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле numberOfParticipants.
        /// </summary>
        public int NumberOfParticipants
        {
            get
            {
                return numberOfParticipants;
            }
        }
        #endregion

        #region Методы
        /// <summary>
        /// Метод, записывающий мероприятие в файл с мероприятиеми.
        /// </summary>
        /// <param name="studetEventsPath"> Путь к файлу с мероприятиями. </param>
        public void AddEventToFile(string studetEventsPath)
        {
            File.AppendAllText(studetEventsPath, $"{studentEventDate} пройдет мероприятие {studentEventDescription}. Для участия " +
                                                 $"необходимо по {numberOfParticipants} человек из каждой группы. Участники: \n");
        }

        /// <summary>
        /// Метод, выбирающий студентов для мероприятия.
        /// </summary>
        /// <param name="studentsDividedByGroups"> Список со списками студентов по группам. </param>
        /// <param name="studetEventsPath"> Путь к файлу с мероприятиями. </param>
        public void SelectionOfParticipants(List<List<Student>> studentsDividedByGroups, string studetEventsPath)
        {
            int[] numberOfRegistrants = new int[studentsDividedByGroups.Count];

            for (int i = 0; i < studentsDividedByGroups.Count; i++)
            {
                List<Student> registeredStudents = new List<Student>();

                for (int j = 0; j < studentsDividedByGroups[i].Count; j++)
                {
                    if ((numberOfRegistrants[i] + 1) < (numberOfParticipants * 0.5))
                    {
                        bool registrationResult = studentsDividedByGroups[i][j].VoluntaryRegistration();

                        if (registrationResult)
                        {
                            numberOfRegistrants[i] += 1;
                            registeredStudents.Add(studentsDividedByGroups[i][j]);
                            File.AppendAllText(studetEventsPath, $"{studentsDividedByGroups[i][j].StudentSurname}_{studentsDividedByGroups[i][j].StudentName}\n");
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                studentsDividedByGroups[i] = studentsDividedByGroups[i].OrderBy(student => student.NumberOfRecentEventsAttended).ToList<Student>();

                for (int j = 0; j < studentsDividedByGroups[i].Count; j++)
                {
                    if ((!registeredStudents.Contains(studentsDividedByGroups[i][j])) && (numberOfRegistrants[i] + 1 <= numberOfParticipants))
                    {
                        numberOfRegistrants[i] += 1;
                        studentsDividedByGroups[i][j].ForcedRegistration();
                        registeredStudents.Add(studentsDividedByGroups[i][j]);
                        File.AppendAllText(studetEventsPath, $"{studentsDividedByGroups[i][j].StudentSurname}_{studentsDividedByGroups[i][j].StudentName}\n");
                    }
                }

                for (int j = 0; j < studentsDividedByGroups[i].Count; j++)
                {
                    if (!registeredStudents.Contains(studentsDividedByGroups[i][j]))
                    {
                        studentsDividedByGroups[i][j].RefusesToRegister();
                    }
                }
            }
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор, позволяющий создать экземпляр класса StudentEvent.
        /// </summary>
        /// <param name="studentEventDate"> Дата мероприятия. </param>
        /// <param name="studentEventDescription"> Описание мероприятия. </param>
        /// <param name="numberOfParticipants"> Необходимое число участников. </param>
        public StudentEvent(string studentEventDate, string studentEventDescription, int numberOfParticipants)
        {
            this.studentEventDate = studentEventDate;
            this.studentEventDescription = studentEventDescription;
            this.numberOfParticipants = numberOfParticipants;
        }
        #endregion
    }
}
