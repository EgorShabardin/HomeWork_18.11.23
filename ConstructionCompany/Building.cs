namespace ConstructionCompany
{
    /// <summary>
    /// Класс, описывающий здание.
    /// </summary>
    public class Building
    {
        #region Поля
        private static int numberOfBuildings;
        private int buildingNumber;
        private double buildingHeight;
        private int numberOfFloors;
        private int numberOfApartments;
        private int numberOfEntrances;
        #endregion

        #region Свойства
        /// <summary>
        /// Свойство, позволяющее читать поле buildingNumber.
        /// </summary>
        public int BuildingNumber
        {
            get
            {
                return buildingNumber;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле buildingHeight.
        /// </summary>
        public double BuildingHeight
        {
            get
            {
                return buildingHeight;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле numberOfFloors.
        /// </summary>
        public int NumberOfFloors
        {
            get
            {
                return numberOfFloors;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле numberOfApartments.
        /// </summary>
        public int NumberOfApartments
        {
            get
            {
                return numberOfApartments;

            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле numberOfEntrances.
        /// </summary>
        public int NumberOfEntrances
        {
            get
            {
                return numberOfEntrances;
            }
        }
        #endregion

        #region Методы
        /// <summary>
        /// Метод, вычисляющий высоту этажей.
        /// </summary>
        /// <returns> Высота этажей в доме. </returns>
        public double CalculationFloorHeight()
        {
            return buildingHeight / numberOfFloors;
        }

        /// <summary>
        /// Метод, вычисляющий количество квартир в подъезде.
        /// </summary>
        /// <returns> Количество квартир в подъезде. </returns>
        public int CalculationNumberOfApartmentsInEntrance()
        {
            return NumberOfApartments / NumberOfEntrances;
        }

        /// <summary>
        /// Метод, вычисляющий количество квартир на одном этаже.
        /// </summary>
        /// <returns> Количество квартир на одном этаже. <returns>
        public int CalculationNumberOfApartmentsOnFloor()
        {
            return (NumberOfApartments / NumberOfEntrances) / numberOfFloors;
        }

        /// <summary>
        /// Метод, изменяющий количество зданий (поле numberOfBuildings).
        /// </summary>
        private void ChangeNumberOfBuilding()
        {
            numberOfBuildings++;
        }

        /// <summary>
        /// Переопределение метода ToString.
        /// </summary>
        /// <returns> Возвращает строку, содержащую данные о здании. </returns>
        public override string ToString()
        {
            return $"Здание №{buildingNumber:D4} высотой {buildingHeight} содержит {NumberOfApartments} квартир, {numberOfFloors} этажей, {NumberOfEntrances} подъездов";
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор, который создает экземпляр класса Building и заполняет его данными.
        /// </summary>
        /// <param name="buildingHeight"> Высота здания </param>
        /// <param name="numberOfFloors"> Количество этажей в здании. </param>
        /// <param name="numberOfApartments"> Количество квартир в здании. </param>
        /// <param name="numberOfEntrances"> Количество подъездов в здании. </param>
        internal Building(int buildingHeight, int numberOfFloors, int numberOfApartments, int numberOfEntrances)
        {
            this.buildingHeight = buildingHeight;
            this.numberOfFloors = numberOfFloors;
            this.numberOfApartments = numberOfApartments;
            this.numberOfEntrances = numberOfEntrances;
            buildingNumber = numberOfBuildings;
            ChangeNumberOfBuilding();
        }

        /// <summary>
        /// Конструктор, который создает экземпляр класса Building и заполняет его данными.
        /// </summary>
        /// <param name="buildingHeight"> Высота здания </param>
        /// <param name="numberOfFloors"> Количество этажей в здании. </param>
        internal Building(int buildingHeight, int numberOfFloors)
        {
            this.buildingHeight = buildingHeight;
            this.numberOfFloors = numberOfFloors;
            numberOfApartments = 50;
            numberOfEntrances = 2;
            buildingNumber = numberOfBuildings;
            ChangeNumberOfBuilding();
        }

        /// <summary>
        /// Конструктор, который создает экземпляр класса Building и заполняет его данными.
        /// </summary>
        /// <param name="numberOfEntrances"> Количество подъездов в здании. </param>
        internal Building(int numberOfEntrances)
        {
            this.numberOfEntrances = numberOfEntrances;
            buildingHeight = 50;
            numberOfFloors = 10;
            numberOfApartments = 50;
            buildingNumber = numberOfBuildings;
            ChangeNumberOfBuilding();
        }

        /// <summary>
        /// Конструктор, который создает экземпляр класса Building и заполняет его данными.
        /// </summary>
        internal Building()
        {
            buildingHeight = 50;
            numberOfFloors = 10;
            numberOfApartments = 50;
            numberOfEntrances = 2;
            buildingNumber = numberOfBuildings;
            ChangeNumberOfBuilding();
        }
        #endregion
    }
}
