namespace Тумаков___Лабораторная_работа__12
{
    /// <summary>
    /// Класс, описывающий комплексное число.
    /// </summary>
    class ComplexNumber
    {
        #region Поля
        readonly double realPart;
        readonly double imaginaryPart;
        #endregion

        #region Переопределение операторов
        /// <summary>
        /// Переопределение оператора +.
        /// </summary>
        /// <param name="firstComplexNumber"> Первый операнд, комплексное число. </param>
        /// <param name="secondComplecxNumber"> Второй операнд, комплексное число. </param>
        /// <returns> Возвращает сумму двух операндов. </returns>
        public static ComplexNumber operator + (ComplexNumber firstComplexNumber, ComplexNumber secondComplecxNumber)
        {
            return new ComplexNumber(firstComplexNumber.realPart + secondComplecxNumber.realPart, firstComplexNumber.imaginaryPart + secondComplecxNumber.imaginaryPart);
        }

        /// <summary>
        /// Переопределение оператора -.
        /// </summary>
        /// <param name="firstComplexNumber"> Первый операнд, комплексное число. </param>
        /// <param name="secondComplecxNumber"> Второй операнд, комплексное число. </param>
        /// <returns> Возвращает разность двух операндов. </returns>
        public static ComplexNumber operator - (ComplexNumber firstComplexNumber, ComplexNumber secondComplecxNumber)
        {
            return new ComplexNumber(firstComplexNumber.realPart - secondComplecxNumber.realPart, firstComplexNumber.imaginaryPart - secondComplecxNumber.imaginaryPart);
        }

        /// <summary>
        /// Переопределение оператора *.
        /// </summary>
        /// <param name="firstComplexNumber"> Первый операнд, комплексное число. </param>
        /// <param name="secondComplecxNumber"> Второй операнд, комплексное число. </param>
        /// <returns> Возвращает произведение двух операндов. </returns>
        public static ComplexNumber operator * (ComplexNumber firstComplexNumber, ComplexNumber secondComplecxNumber)
        {
            double newImaginaryPart = firstComplexNumber.realPart * secondComplecxNumber.imaginaryPart + firstComplexNumber.imaginaryPart * secondComplecxNumber.realPart;
            double newRealPart;

            if ((firstComplexNumber.imaginaryPart * secondComplecxNumber.imaginaryPart) > 0)
            {
                newRealPart = firstComplexNumber.realPart * secondComplecxNumber.realPart - (- firstComplexNumber.imaginaryPart * secondComplecxNumber.imaginaryPart);
            }
            else
            {
                newRealPart = firstComplexNumber.realPart * secondComplecxNumber.realPart + (- firstComplexNumber.imaginaryPart * secondComplecxNumber.imaginaryPart);
            }

            return new ComplexNumber(newRealPart, newImaginaryPart);
        }

        /// <summary>
        /// Переопределение оператора ==.
        /// </summary>
        /// <param name="firstComplexNumber"> Первый операнд, комплексное число. </param>
        /// <param name="secondComplecxNumber"> Второй операнд, комплексное число. </param>
        /// <returns> Возвращает true, если операнды равны, иначе false. </returns>
        public static bool operator == (ComplexNumber firstComplexNumber, ComplexNumber secondComplecxNumber)
        {
            return ((firstComplexNumber.realPart == secondComplecxNumber.realPart) && (firstComplexNumber.imaginaryPart == secondComplecxNumber.imaginaryPart));
        }

        /// <summary>
        /// Переопределение оператора !=.
        /// </summary>
        /// <param name="firstComplexNumber"> Первый операнд, комплексное число. </param>
        /// <param name="secondComplecxNumber"> Второй операнд, комплексное число. </param>
        /// <returns> Возвращает true, если операнды неравны, иначе false. </returns>
        public static bool operator !=(ComplexNumber firstComplexNumber, ComplexNumber secondComplecxNumber)
        {
            return ((firstComplexNumber.realPart != secondComplecxNumber.realPart) || (firstComplexNumber.imaginaryPart != secondComplecxNumber.imaginaryPart));
        }
        #endregion

        #region Методы
        /// <summary>
        /// Переопределение методы Equals.
        /// </summary>
        /// <param name="obj"> Комплексное число. </param>
        /// <returns> Возвращает true, если числа равны, иначе false. </returns>
        public override bool Equals(object obj)
        {
            if (obj is ComplexNumber complexNumber)
            {
                if ((realPart == complexNumber.realPart) && (imaginaryPart == complexNumber.imaginaryPart))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Переопределение методы GetHashCode.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Переопределение метода ToString.
        /// </summary>
        /// <returns> Возвращает строку, содержащую комплексное число. </returns>
        public override string ToString()
        {
            return (imaginaryPart > 0 ? $"({realPart} + {imaginaryPart}i)" : $"({realPart} - {-imaginaryPart}i)");
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор, позволяющий создать экземпляр класса ComplexNumber.
        /// </summary>
        /// <param name="realPart"> Действительная часть комплексного числа. </param>
        /// <param name="imaginaryPart"> Мнимая часть комплексного числа. </param>
        public ComplexNumber(double realPart, double imaginaryPart)
        {
            this.realPart = realPart;
            this.imaginaryPart = imaginaryPart;
        }
        #endregion
    }
}