using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Код_по_блок_схеме_на_10._02._26
{
    internal class Blockshema
    {
        public void Nomera()
        { 
            Console.Write("Введите номер задания: ");
            byte a1 = 1, b1 = 0;
            while (b1 == 0)
            {
                if (!byte.TryParse(Console.ReadLine(), out a1))
                    Console.Write("Ошибка! Введите номер задания еще раз ");
                else if (a1 <= 0 || a1 > 3)
                    Console.Write("В дз всего 3 задания, Введите номер задания еще раз ");
                else
                    b1++;
            }
            switch (a1)
            {
                case 1:
                    n1();
                    break;
                case 2:
                    n2();
                    break;
                case 3:
                    n3();
                    break;

            }
            void n1 () 
            {
                byte a = 0; int p = 0;
                Console.Write("Введите оценку, полученную учеником ");
                /*while (a == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out p))
                        Console.Write("Ошибка! Введите оценку еще раз ");
                    else if (p <= 0 || p > 6)
                        Console.Write("Оценка не может быть неположительной и больше 5\nВведите оценку еще раз ");
                    else
                        a = 1;
                }*/
                //Console.WriteLine(p);
                if (p == 5)
                    Console.WriteLine("Молодец!");
                else if (p == 4)
                    Console.WriteLine("Хорошо!");
                else if (p <= 3)
                    Console.WriteLine("Лентяй!");
            }
            void n2 ()
            {
                Random random = new Random();
                int a = random.Next(2, 6);
                string s = " ";
                switch (a)
                {
                    case 5:
                        s = "Отл";
                        break;
                    case 4:
                        s = "Хор";
                        break;
                    case 3:
                        s = "Удовл";
                        break;
                    case 2:
                        s = "Неуд";
                        break;

                }
                Console.WriteLine($"Оценка: {a}\t {s}");
            }
            void n3()
            {
                byte a = 0, i=0; int p = 0;
                Console.WriteLine("Дано число n=1000. Оно делится на 2 столько раз, пока результат деления не станет меньше некоторого N");
                Console.Write("Введите число N: ");
                p = int.Parse(Console.ReadLine());
                /*while (a == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out p))
                        Console.Write("Ошибка! Введите N еще раз ");
                    else if (p <= 0)
                        Console.Write("N не может быть больше 1000 и неположительным т.к. при делении на 2 ноль никогда не достигнется  \nВведите N еще раз ");
                    else if (p >= 1000)
                    {
                        Console.WriteLine($"При N = {p}, условие достигается сразу же");
                        return; 
                    }
                    else
                        a = 1;
                }*/
                double n = 1000;
                while (n >= p)
                { 
                    n /= 2;
                    i++;
                }
                Console.WriteLine($"Кол-во итераций: {i}");
            }
            //n11(); //через if
            //n2();
            //n3();
            
            //Blockshema blockshema = new Blockshema(); blockshema.Nomera();
            Console.Write("Для завершения программы нажмите любую клавишу ");
            Console.ReadKey();
        }
    }
}
