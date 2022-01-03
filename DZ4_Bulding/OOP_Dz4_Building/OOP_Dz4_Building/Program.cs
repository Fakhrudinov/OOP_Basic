using OOP_Dz4_Building.Entitys;
using static OOP_Dz4_Building.Library.EnumBildingMaterials;
using static OOP_Dz4_Building.Library.EnumCitys;
using static OOP_Dz4_Building.Library.EnumCountrys;

/*
 * Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов). 
 * 
 * Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати. 
 * Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д. 
 * 
 * Предусмотреть возможность, чтобы уникальный номер здания генерировался программно. 
 * Для этого в классе предусмотреть статическое поле, которое бы хранило последний использованный номер здания, 
 *  и предусмотреть метод, который увеличивал бы значение этого поля.
 */

Console.WriteLine("New Building!");

Adress adress = new Adress()
{
    index = "132456",
    country = Country.Россия,
    city = City.Магадан,
    street = "Ленина",
    building = "11a",
    buildingSuffix = "корпус 1"    
};
Building bld = new Building(adress, BildingMaterial.Кирпич, 5, 3, 60, 13);
Console.WriteLine(bld);
Console.WriteLine(bld.GetCountOfAppartmentAtFloor());
Console.WriteLine();

bld.EditBuildingAdress(adress: new Adress{ city = City.Магадан, country = Country.Россия, street = "asdf"});
Console.WriteLine(bld);

Console.WriteLine();

Adress adress2 = new Adress()
{
    index = "4567657",

    building = "55",
};
Building bld2 = new Building(adress2, BildingMaterial.Бетон, 9, 1, 72, 27);
Console.WriteLine(bld2);





Console.ReadLine();
