namespace Library
{
    /// <summary>
    /// Класс, описывающий книгу.
    /// </summary>
    class Book
    {
        #region Поля
        private string bookTitle;
        private string bookAuthor;
        private string publishingHouse;
        #endregion

        #region Свойства
        /// <summary>
        /// Свойство, позволяющее читать поле bookTitle.
        /// </summary>
        public string BookTitle
        {
            get
            {
                return bookTitle;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле bookAuthor.
        /// </summary>
        public string BookAuthor
        {
            get
            {
                return bookAuthor;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле publishingHouse.
        /// </summary>
        public string PublishingHouse
        {
            get
            {
                return publishingHouse;
            }
        }
        #endregion

        #region Методы
        /// <summary>
        /// Перелпределение методы ToString.
        /// </summary>
        /// <returns> Возвращает строку, содержащую данные о книге. </returns>
        public override string ToString()
        {
            return $"{bookTitle}, {bookAuthor}, {publishingHouse}";
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор, позволяющий создать экземпляр класса Book.
        /// </summary>
        /// <param name="bookTitle"> Название книги. </param>
        /// <param name="bookAuthor"> Автор книги. </param>
        /// <param name="publishingHouse"> Издательство книги. </param>
        public Book(string bookTitle, string bookAuthor, string publishingHouse)
        {
            this.bookTitle = bookTitle;
            this.bookAuthor = bookAuthor;
            this.publishingHouse = publishingHouse;
        }
        #endregion
    }
}