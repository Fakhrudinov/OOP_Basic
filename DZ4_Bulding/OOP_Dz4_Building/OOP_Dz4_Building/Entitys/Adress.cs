using static OOP_Dz4_Building.Library.EnumCitys;
using static OOP_Dz4_Building.Library.EnumCountrys;

namespace OOP_Dz4_Building.Entitys
{
    internal class Adress
    {
        internal string index = "Not Defined";
        internal Country country;
        internal City city;
        internal string street = "Not Defined";
        internal string building = "Not Defined";
        internal string ? buildingSuffix;
    }
}
