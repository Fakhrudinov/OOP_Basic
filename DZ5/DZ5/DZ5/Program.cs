using DZ5;

Console.WriteLine("Урок 5. Полиморфизм, перегрузка методов и операторов");

/*
 * Создать класс рациональных чисел. 
 * В классе два поля – числитель и знаменатель. 
 * Предусмотреть конструктор. 
 * 
 * Определить операторы 
 *  ==, != (метод Equals()), 
 *  <, >, <=, >=, 
 *  +, –, ++, --. 
 * Переопределить метод ToString() для вывода дроби. 
 * Определить операторы преобразования типов между типом дробь,float, int. 
 * Определить операторы *, /, %
 */

RationalNumber num1 = new RationalNumber(2, 6);// 1/3
RationalNumber num2 = new RationalNumber(2, 6);// 1/3
RationalNumber num3 = num2;
RationalNumber num4 = new RationalNumber(1, 3);
RationalNumber num5 = new RationalNumber(9, 2);
RationalNumber num6 = new RationalNumber(0);

Console.WriteLine();
Console.WriteLine($"{num1}.Equals({num2}) is " + num1.Equals(num2));
Console.WriteLine($"{num1}.Equals({num4}) is " + num1.Equals(num4));
Console.WriteLine($"{num2}.Equals({num3}) is " + num2.Equals(num3));
Console.WriteLine($"{num2}.Equals({num5}) is " + num2.Equals(num5));
Console.WriteLine($"{num1} == {num3} is " + (num1 == num3));
Console.WriteLine($"{num1} != {num5} is " + (num1 != num5));
Console.WriteLine($"{num1}.Equals({num6}) is " + num1.Equals(num6));

Console.WriteLine();
Console.WriteLine($"{num1} < {num5} = " + (num1 < num5));
Console.WriteLine($"{num1} > {num5} = " + (num1 > num5));
Console.WriteLine($"{num1} <= {num4} = " + (num1 <= num4));
Console.WriteLine($"{num1} >= {num4} = " + (num1 >= num4));
Console.WriteLine($"{num1} <= {num6} = " + (num1 <= num6));

Console.WriteLine();
Console.WriteLine($"{num1} + {num4} = " + (num1 + num4));
Console.WriteLine($"{num5} - {num4} = " + (num5 - num4));
Console.WriteLine($"++{num1} = " + (++num1));
Console.WriteLine($"--{num5} = " + (--num5));
Console.WriteLine($"{num1} + {num6} = " + (num1 + num6));
Console.WriteLine($"++{num6} = " + (++num6));
Console.WriteLine($"--{num6} = " + (--num6));

Console.WriteLine();
Console.WriteLine($"(float){num1} = " + (float)num1);
Console.WriteLine($"(int){num5} = " + (int)num5);
Console.WriteLine($"(float){num6} = " + (float)num6);
Console.WriteLine($"(int){num6} = " + (int)num6);

Console.WriteLine();
Console.WriteLine($"{num1} * {num4} = " + (num1 * num4));
Console.WriteLine($"{num1} * {num6} = " + (num1 * num6));
Console.WriteLine($"{num1} / {num4} = " + (num1 / num4));
Console.WriteLine($"{num6} / {num1} = " + (num6 / num1));
//Console.WriteLine($"{num1} / {num6} = " + (num1 / num6));
Console.WriteLine($"{num1} % {num4} = " + (num1 % num4));
Console.WriteLine($"{num5} % {num4} = " + (num5 % num4));
//Console.WriteLine($"{num1} % {num6} = " + (num1 % num6));
//Console.WriteLine($"{num6} % {num6} = " + (num6 % num6));




