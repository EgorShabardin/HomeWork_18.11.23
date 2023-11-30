using System;

namespace Решение_задач
{
    /// <summary>
    /// Класс, описывающий студента.
    /// </summary>
    class Student
    {
        #region Поля
        private string studentSurname;
        private string studentName;
        private int groupNumber;
        private int numberOfRecentEventsAttended;
        #endregion

        #region Свойства
        /// <summary>
        /// Свойство, позволяющее читать поле studentSurname.
        /// </summary>
        public string StudentSurname
        {
            get
            {
                return studentSurname;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле studentName.
        /// </summary>
        public string StudentName
        {
            get
            {
                return studentName;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле groupNumber.
        /// </summary>
        public int GroupNumber
        {
            get
            {
                return groupNumber;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле numberOfRecentEventsAttended.
        /// </summary>
        public int NumberOfRecentEventsAttended
        {
            get
            {
                return numberOfRecentEventsAttended;
            }
        }
        #endregion

        #region Методы
        /// <summary>
        /// Метод, позволяющий студенту добровольно зарегестрироваться на мероприятие.
        /// </summary>
        /// <returns> Возвращает true, если студент зарегистрировался на мероприятие, иначе false. </returns>
        public bool VoluntaryRegistration()
        {
            Random random = new Random();

            if (random.Next(0, 2) == 1)
            {
                numberOfRecentEventsAttended = (numberOfRecentEventsAttended == 3) ? 3 : (numberOfRecentEventsAttended + 1);
                return true;
            }

            numberOfRecentEventsAttended = (numberOfRecentEventsAttended == 0) ? 0 : (numberOfRecentEventsAttended - 1);
            return false;
        }

        /// <summary>
        /// Метод, не добровольно регистрирующий студента на мероприятие.
        /// </summary>
        public void ForcedRegistration()
        {
            numberOfRecentEventsAttended = (numberOfRecentEventsAttended == 3) ? 3 : (numberOfRecentEventsAttended + 1);
        }

        /// <summary>
        /// Метод, позволяющий студенту отказаться от участия в мероприятии.
        /// </summary>
        public void RefusesToRegister()
        {
            numberOfRecentEventsAttended = (numberOfRecentEventsAttended == 0) ? 0 : (numberOfRecentEventsAttended - 1);
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор, позволяющий создать экземпляр класса Student.
        /// </summary>
        /// <param name="studentDetailsArray"> Массив с данными о студенте. </param>
        public Student(string[] studentDetailsArray)
        {
            studentSurname = studentDetailsArray[0];
            studentName = studentDetailsArray[1];
            groupNumber = int.Parse(studentDetailsArray[2]);
            numberOfRecentEventsAttended = int.Parse(studentDetailsArray[3]);
        }
        #endregion
    }
}
