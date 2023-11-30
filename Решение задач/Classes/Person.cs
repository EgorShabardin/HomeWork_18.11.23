using System;

namespace Решение_задач
{
    /// <summary>
    /// Класс, описывающий человека.
    /// </summary>
    class Person
    {
        #region Поля
        readonly string personName;
        private string[] hobbies;
        #endregion

        #region Свойства
        /// <summary>
        /// Свойство, позволяющее читать поле hobbies.
        /// </summary>
        public string[] Hobbies
        {
            get
            {
                return hobbies;
            }
        }
        #endregion

        #region Методы
        /// <summary>
        /// Метод, позволяющий человеку отреогировать на событие.
        /// </summary>
        /// <param name="eventName"> Название события. </param>
        public void ReactsToEvent(string eventName)
        {
            if (Array.IndexOf(hobbies, eventName) != -1)
            {
                Console.WriteLine($"\n{personName} так рад(-а), что скоро будет {eventName}");
            }
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор, позволяющий создать экземпляр класса Person.
        /// </summary>
        /// <param name="personName"> Имя человека. </param>
        /// <param name="hobbies"> Увлечения человека. </param>
        public Person(string personName, params string[] hobbies)
        {
            this.personName = personName;
            this.hobbies = hobbies;
        }
        #endregion
    }
}