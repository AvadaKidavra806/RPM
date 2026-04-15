using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Петергоф
{
    public class Куколка
    {
        public void gd()
        {
            Console.Write("Введите кол-во элементов массива ");
            int a = int.Parse(Console.ReadLine());
            int[] massiv = new int[a];
            for (int i = 0; i < a; i++)
            {
                Console.Write($"Введите {i + 1} элемент массива ");
                massiv[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"{i + 1}\t{massiv[i]}");
            }
            Console.Write("Введите число, для которого необходимо найти первое вхождение ");
            int n = int.Parse(Console.ReadLine());
            int k = 0;//, j = 0;
            while (k < a) 
            {
                if (massiv[k] == n)
                {
                    Console.WriteLine($"Номер первого вхождения элемента {n}: {k + 1}");
                    return;
                }
            }
            //j = k + 1;
            Console.WriteLine($"Элемента {n} нет в массиве");

            gd();
            Console.WriteLine("Для завершения нажмите любую кнопку");
            Console.ReadKey();
            //Петергоф.Куколка ап = new Петергоф.Куколка(); ап.gd();
        }

    }
}
