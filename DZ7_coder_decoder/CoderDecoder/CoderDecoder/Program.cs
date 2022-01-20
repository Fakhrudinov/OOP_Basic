using EncodeDecodeLib.Interfaces;
using EncodeDecodeLib.Realisation;

/*
 * Определить интерфейс IСoder, который полагает методы поддержки шифрования строк. 
 * В интерфейсе объявляются два метода Encode() и Decode(), используемые для шифрования и дешифрования строк. 
 * 
 * Создать класс ACoder, реализующий интерфейс ICoder. 
 * Класс шифрует строку посредством сдвига каждого символа на одну «алфавитную» позицию выше. 
 * (В результате такого сдвига буква А становится буквой Б). 
 * 
 * Создать класс BCoder, реализующий интерфейс ICoder. 
 * Класс шифрует строку, выполняя замену каждой буквы, 
 * стоящей в алфавите на i-й позиции, на букву того же регистра, расположенную в алфавите на i-й позиции с конца алфавита. 
 * (Например, буква В заменяется на букву Э. 
 * 
 * Написать программу, демонстрирующую функционирование классов).
 */

string stringInitial = "В чащах юга жил бы цитрус? Да, но фальшивый экземпляр! The quick brown fox jumps over the lazy dog.";

Console.WriteLine("ACoder:");
IСoder aa = new ACoder();
Console.WriteLine("Initial=" + stringInitial);

string stringEncodedA = aa.Encode(stringInitial);
Console.WriteLine("Encoded=" + stringEncodedA);

string stringDecodedA = aa.Decode(stringEncodedA);
Console.WriteLine("Decoded=" + stringDecodedA);

Console.WriteLine("Compare string is " + stringInitial.Equals(stringDecodedA));


Console.WriteLine("\nBCoder:");
IСoder bb = new BCoder();
Console.WriteLine("Initial=" + stringInitial);

string stringEncodedB = bb.Encode(stringInitial);
Console.WriteLine("Encoded=" + stringEncodedB);

string stringDecodedB = bb.Decode(stringEncodedB);
Console.WriteLine("Decoded=" + stringDecodedB);

Console.WriteLine("Compare string is " + stringInitial.Equals(stringDecodedB));

