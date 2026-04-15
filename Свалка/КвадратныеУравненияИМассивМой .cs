    using System;

namespace классворк_20._01._26__квадратное_уравнение_
{
    internal class Квадратные
    {
        static void Main()
        {
            void КвадратныеУравнения ()
            {
                double a, b, c, x1, x2, d, k1;
                Console.WriteLine("Эта программа решает квадратные уравнения вида ax^2+bx+c=0");
                Console.Write("Введите а ");
                while (!double.TryParse(Console.ReadLine(), out a))
                    Console.Write("Ошибка! Введите а еще раз ");
                Console.Write("Введите b ");
                while (!double.TryParse(Console.ReadLine(), out b))
                    Console.Write("Ошибка! Введите b еще раз ");
                Console.Write("Введите c ");
                while (!double.TryParse(Console.ReadLine(), out c))
                    Console.Write("Ошибка! Введите c еще раз ");
                if (a == 0 && b == 0 && c != 0)
                    Console.WriteLine($"Уравнение не имеет смысла и решений ({c}=0, что неверно) ");
                else if (a == 0 && b == 0 && c == 0)
                    Console.WriteLine("Уравнение не имеет смысла и решений (0=0)");
                else if (a == 0 && b != 0)
                {
                    x1 = -c / b;
                    Console.WriteLine($"Уравнение имеет один корень, равный {x1}");
                }
                else
                {
                    d = b * b - 4 * a * c;
                    if (d > 0)
                    {
                        x1 = (-b + Math.Sqrt(d)) / (2 * a);
                        x2 = (-b - Math.Sqrt(d)) / (2 * a);
                        Console.WriteLine($"Уравнение имеет два корня, равные {x1} и {x2}");
                    }
                    else if (d == 0)
                    {
                        x1 = -b / (2 * a);
                        Console.WriteLine($"Уравнение имеет два одинаковых корня, равные {x1}");
                    }
                    else
                    {
                        k1 = -b / (2 * a);
                        x1 = Math.Sqrt(Math.Abs(d)) / (2 * a);
                        x1= Math.Abs(x1);
                        if (k1 == 0 && x1 == 1)
                            Console.WriteLine($"Уравнение имеет два комплексных корня, равные i и -i");
                        else if (k1 == 0)
                            Console.WriteLine($"Уравнение имеет два комплексных корня, равные {x1}i и -{x1}i");
                        else
                            Console.WriteLine($"Уравнение имеет два комплексных корня, равные {k1}+{x1}i и {k1}-{x1}i");
                    }
                    //Console.WriteLine("Для завершения программы нажмите на любую клавишу");
                }
            }
            //КвадратныеУравнения();
            void дз1 ()
            {
                double x = 1, y, z = 1, c, q, w, e;
                int a = 1;
                //const int s = 0;
                Console.WriteLine("Эта программа вычисляет значение выражения: (x^2+y^2)/z^(1/2)*ln(xz)*cos(x^4-z^3)");
                Console.Write("Введите x ");
                while (a != 0)
                {
                    if (!double.TryParse(Console.ReadLine(), out x))
                            Console.Write("Ошибка! x введен неверно, введите еще раз ");
                    else if (x <= 0)
                        Console.Write("При таком значении x основание натурального логарифма неположительно, т.к. область определения z, z>0" +
                            "\nПри произведении получится положительное число только если оба множителя положительны \nВведите x еще раз ");
                    else
                        a = 0;
                }
                Console.Write("Введите y ");
                while (!double.TryParse(Console.ReadLine(), out y))
                    Console.Write("Ошибка! y введен неверно, введите еще раз ");
                Console.Write("Введите z ");
                while (a != 2)
                {
                    if (!double.TryParse(Console.ReadLine(), out z))
                            Console.Write("Ошибка! z введен неверно, введите еще раз ");
                    else if (z < 0)
                        Console.Write("При таком значении z подкоренное выражение становиться отрицательным, что неверно\nВведите z еще раз ");
                    else if (z == 0)
                        Console.Write("При таком значении z знаменатель равняется 0, деление на 0 невозможно в данном контексте\nВведите z еще раз ");
                    else
                        a = 2;
                }
                double x1 = (x * Math.PI) / 180;
                double z1 = (z * Math.PI) / 180;
                //y = (y * Math.PI) / 180;
                q = x * z; //основание логарифма
                w = (Math.Pow(x, 2) + Math.Pow(y, 3)) / Math.Sqrt(z); //дробь
                e = Math.Log(q) * Math.Cos(Math.Pow(x1, 4) - Math.Pow(z1, 3)); //все остальное
                c = w * e;
                Console.WriteLine($"Ответ: {c}");
                //с exel совпадает, но только без преобразования в радианы
                //1317,8029288008
                //23
            }
            дз1();
            void дз2 ()
            {
                double v, a, l;
                Console.WriteLine("Эта программа вычисляет дальность полета тела по формуле: (V^2*sin(2*a))/g");
                Console.Write("Введите начальную скорость (м/с) ");
                while (!double.TryParse(Console.ReadLine(), out v) || v <= 0)
                {
                    if (v < 0)
                        Console.Write("Начальная скорость не может быть отрицательной\n Введите начальную скорость еще раз ");
                    else if (v == 0)
                    {
                        Console.WriteLine("При нулевой скорости тело останется на месте");
                        return;
                    }
                    else
                        Console.Write("Ошибка! Начальная скорость введена неверно, \nВведите начальную скорость еще раз ");
                }
                    Console.Write("Введите угол наклона к горизонту (в градусах, от 0 до 90) ");
                while (!double.TryParse(Console.ReadLine(), out a) || a < 0 || a > 90)
                {
                    if (a < 0 || a > 90)
                        Console.Write("Ошибка! Угол наклона к горизонту должен быть от 0 до 90\nВведите угол наклона еще раз ");
                    else
                        Console.Write("Ошибка! Угол введен неверно, введите еще раз ");
                }
                    a = (a * Math.PI) / 180;
                l =(v*v*Math.Sin(2*a))/9.8;
                Console.WriteLine($"Ответ: {Math.Round(l,3)}м");
            }
            дз2();
            void СложныеСтроки()
            {
                Console.Write("Введите числа через точку с запятой или пробел ");
                string s = Console.ReadLine();
                string[] chislastr = s.Split(new char[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
                double[] chisladou = new double[chislastr.Length];
                double sum = 0, del = 0;
                for (int i = 0; i < chislastr.Length; i++)
                {
                    if (!double.TryParse(chislastr[i], out chisladou[i]))
                    {
                        Console.Write($"Элемент под номером {i + 1} введен не верно! Введите еще раз ");
                        while (!double.TryParse(Console.ReadLine(), out chisladou[i]))
                            Console.Write($"Элемент под номером {i + 1} введен не верно! Введите еще раз ");
                        chislastr[i] = /*chisladou[i];*/Convert.ToString(chisladou[i]); //это преобразование объяснить надо
                    }
                    sum += chisladou[i];
                    del++;
                }
                for (int i = 0; i < chislastr.Length; i++)
                {
                    if (i != chisladou.Length - 1)
                        Console.Write($"{chislastr[i]};  ");
                    else
                        Console.Write($"{chislastr[i]}");
                }
                if (del != 0)
                    Console.WriteLine($"\nСреднее арифметическое чисел равно: {Math.Round((sum / del), 3)}");
                //можно сортировку сделать
            }
            //СложныеСтроки();
        }
    }
}
