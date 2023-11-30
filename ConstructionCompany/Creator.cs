using System.Collections.Generic;

namespace ConstructionCompany
{
    /// <summary>
    /// Статический класс, являющийся фабрикой объектов класса Building.
    /// </summary>
    public static class Creator
    {
        #region Поля
        private static Dictionary<int, Building> buildingsDictionary = new Dictionary<int, Building>();
        #endregion

        #region Свойства
        /// <summary>
        /// Свойство, позволяющее читать поле buildingsDictionary.
        /// </summary>
        public static Dictionary<int, Building> BuildingsDictionary
        {
            get
            {
                return buildingsDictionary;
            }
        }
        #endregion

        #region Методы
        /// <summary>
        /// Метод, позволяющий создать экземпляр класса Building.
        /// </summary>
        /// <param name="buildingHeight"> Высота здания. </param>
        /// <param name="numberOfFloors"> Количество этажей в здании. </param>
        /// <param name="numberOfApartments"> Количество квартир в здании. </param>
        /// <param name="numberOfEntrances"> Количество подъездов в здании. </param>
        /// <returns> Возвращает номер дома. </returns>
        public static int CreateBuild(int buildingHeight, int numberOfFloors, int numberOfApartments, int numberOfEntrances)
        {
            Building building = new Building(buildingHeight, numberOfFloors, numberOfApartments, numberOfEntrances);
            buildingsDictionary.Add(building.BuildingNumber, building);
            return building.BuildingNumber;
        }

        /// <summary>
        /// Метод, позволяющий создать экземпляр класса Building.
        /// </summary>
        /// <param name="buildingHeight"> Высота здания. </param>
        /// <param name="numberOfFloors"> Количество этажей в здании. </param>
        /// <returns> Возвращает номер дома. </returns>
        public static int CreateBuild(int buildingHeight, int numberOfFloors)
        {
            Building building = new Building(buildingHeight, numberOfFloors);
            buildingsDictionary.Add(building.BuildingNumber, building);
            return building.BuildingNumber;
        }

        /// <summary>
        /// Метод, позволяющий создать экземпляр класса Building.
        /// </summary>
        /// <param name="numberOfEntrances"> Количество подъездов в здании. </param>
        /// <returns> Возвращает номер дома. </returns>
        public static int CreateBuild(int numberOfEntrances)
        {
            Building building = new Building(numberOfEntrances);
            buildingsDictionary.Add(building.BuildingNumber, building);
            return building.BuildingNumber;
        }

        /// <summary>
        /// Метод, позволяющий создать экземпляр класса Building.
        /// </summary>
        /// <returns> Возвращает номер дома. </returns>
        public static int CreateBuild()
        {
            Building building = new Building();
            buildingsDictionary.Add(building.BuildingNumber, building);
            return building.BuildingNumber;
        }

        /// <summary>
        /// Метод, позволяющий удалить дом из списка.
        /// </summary>
        /// <param name="buildingNumber"> Номер дома. </param>
        public static void RemoveBuilding(int buildingNumber)
        {
            buildingsDictionary.Remove(buildingNumber);
        }
        #endregion
    }
}
