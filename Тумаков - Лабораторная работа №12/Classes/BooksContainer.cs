using System.Linq;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Делегат, помогающий сортировать контейнер книг.
    /// </summary>
    /// <param name="book"> Книга. </param>
    /// <returns> Возвращает поле книги, по которому осуществляется сортировка. </returns>
    delegate string SortDelegate(Book book);

    /// <summary>
    /// Класс, описывающий контейнер книг.
    /// </summary>
    static class BooksContainer
    {
        #region Поля
        private static List<Book> booksList = new List<Book>();
        #endregion

        #region Свойства
        /// <summary>
        /// Свойство, позволяющее читать поле booksList.
        /// </summary>
        public static List<Book> BooksList
        {
            get
            {
                return booksList;
            }
        }
        #endregion

        #region Методы
        /// <summary>
        /// Метод, осуществляющий сортировку контейнера книг.
        /// </summary>
        /// <param name="sortDelegate"> Делегат, сортирующий контейнер книг. </param>
        public static void SortingListOfBooks(SortDelegate sortDelegate)
        {
            booksList = booksList.OrderBy(book => sortDelegate.Invoke(book)).ToList<Book>();
        }

        /// <summary>
        /// Метод, добавляющий книги в контейнер книг
        /// </summary>
        /// <param name="booksArray"> Передаваемые книги. </param>
        public static void AddBookToList(params Book[] booksArray)
        {
            foreach (Book book in booksArray)
            {
                booksList.Add(book);
            }
        }
        #endregion
    }
}