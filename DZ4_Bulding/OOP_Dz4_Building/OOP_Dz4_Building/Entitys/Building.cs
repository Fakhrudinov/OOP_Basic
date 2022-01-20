using static OOP_Dz4_Building.Library.EnumBildingMaterials;


namespace OOP_Dz4_Building.Entitys
{
    internal class Building
    {
        /// Поля которые нельзя изменять впоследствии:
        private readonly int _floorsCount;                      // этажность
        private readonly int _entrancesCount;                   // подъезды
        private readonly int _apartmentsCount;                  // квартиры общее колво
        private readonly int _apartmentsCountAtEntrance;        // квартиры на подъезд

        private readonly BildingMaterial _material;             // из чего изготовлен

        private readonly float _buildingHeight;                 // высота общая
        private readonly float _floorsHeight;                   // высота этажа

        private static ulong buildingNumber = 0;                // стартовый номер здания, храним текущее значение номера
        private string _buildingNumber;                         // формируемый номер здания для выдачи потребителю
        private static ulong BuildingNumber
        {
            get => buildingNumber;
            set => buildingNumber = value;
        }

        /// Изменяемые поля
        private Adress _adress;


        internal Building(Adress adress, BildingMaterial material, int floorsCount, int entrancesCount, int apartmentsCount, float buildingHeight)
        {
            GenerateBuildingNumber();
            _adress = adress;
            _material = material;

            _floorsCount = floorsCount;
            _entrancesCount = entrancesCount;
            _apartmentsCount = apartmentsCount;
            _buildingHeight = buildingHeight;            

            _apartmentsCountAtEntrance = apartmentsCount / entrancesCount;
            _floorsHeight = buildingHeight / floorsCount;
        }

        /// <summary>
        /// Создание нового уникального номера дома
        /// </summary>
        private void GenerateBuildingNumber()
        {
            BuildingNumber = BuildingNumber += 1;

            _buildingNumber = String.Format("{0:Kadastr000000000000000}", BuildingNumber);
        }
        /// <summary>
        /// Количество этажей в доме
        /// </summary>
        /// <returns></returns>
        internal int GetFloorsCount()
        {
            return _floorsCount;
        }
        /// <summary>
        /// Количество подъездов в доме
        /// </summary>
        /// <returns></returns>
        internal int GetEntrancesCount()
        {
            return _entrancesCount;
        }
        /// <summary>
        /// Общее количество квартир в доме
        /// </summary>
        /// <returns></returns>
        internal int GetApartmentsCount()
        {
            return _apartmentsCount;
        }
        /// <summary>
        /// Количество квартир в подъезде
        /// </summary>
        /// <returns></returns>
        internal int GetApartmentsCountAtEntrance()
        {
            return _apartmentsCountAtEntrance;
        }
        /// <summary>
        /// Материал из которого построен дом
        /// </summary>
        /// <returns></returns>
        internal BildingMaterial GetBildingMaterial()
        {
            return _material;
        }
        /// <summary>
        /// Общая высота здания
        /// </summary>
        /// <returns></returns>
        internal float GetBuildingHeight()
        {
            return _buildingHeight;
        }
        /// <summary>
        /// Высота одного этажа
        /// </summary>
        /// <returns></returns>
        internal float GetFloorsHeight()
        {
            return _floorsHeight;
        }
        /// <summary>
        /// Уникальный номер дома
        /// </summary>
        /// <returns></returns>
        internal string GetBuildingNumber()
        {
            return _buildingNumber;
        }
        /// <summary>
        /// Адрес дома
        /// </summary>
        /// <returns></returns>
        internal Adress GetBuildingAdress()
        {
            return _adress;
        }
        /// <summary>
        /// Изменение адреса дома
        /// </summary>
        /// <param name="adress"></param>
        internal void EditBuildingAdress(Adress adress)
        {
            if (adress.index is not null)
            {
                _adress.index = adress.index;
            }

            if (adress.street is not null)
            {
                _adress.street = adress.street;
            }

            if (adress.building is not null)
            {
                _adress.building = adress.building;
            }

            if (adress.buildingSuffix is not null)
            {
                _adress.buildingSuffix = adress.buildingSuffix;
            }

            _adress.country = adress.country;
            _adress.city = adress.city;
        }
        /// <summary>
        ////количество квартир на этаже в одном подъезде
        /// </summary>
        /// <returns></returns>
        internal int GetCountOfAppartmentAtFloor()
        {
            return _apartmentsCount / _entrancesCount / _floorsCount;
        }
    

        public override string ToString()
            {
                string result = $"" +
                    $"Здание номер {_buildingNumber},\r\n" +
                    $"По адресу {_adress.index}, {_adress.country}, город {_adress.city}, {_adress.street} {_adress.building} {_adress.buildingSuffix}\r\n" +
                    $"Изготовлен из материала '{_material}', общей высотой {_buildingHeight}м.\r\n" +
                    $"Этажей: {_floorsCount}, подъездов: {_entrancesCount}, квартир: {_apartmentsCount}\r\n" +
                    $"Высота этажа: {_floorsHeight}м., квартир в подъезде: {_apartmentsCountAtEntrance}";

                return result;
            }
        }
}
