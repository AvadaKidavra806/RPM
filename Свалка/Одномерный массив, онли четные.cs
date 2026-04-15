using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odnomermassiv
{
	public class Nap
	{
		public void Gha()
		{
			void n1 ()
			{
				Console.Write("Введите кол-во элементов массива ");
				int kolvoelements = 0; bool outkolvoelements = true;
				while (outkolvoelements)
				{
					if (!int.TryParse(Console.ReadLine(), out kolvoelements))
						Console.Write("Ошибка! Введите кол-во элементов еще раз ");
					else if (kolvoelements <= 0)
						Console.Write("Кол-во элементов не может быть неположительным. Введите кол-во элементов еще раз ");
					else
						outkolvoelements = false;
				}
				int[] massiv = new int[kolvoelements];
				Random random = new Random();
				for (int i = 0; i < kolvoelements; i++)
				{
					massiv[i] = random.Next(-10, 101);
				}
				Console.WriteLine("Первоначальный массив: " + string.Join(", ", massiv));
				Console.WriteLine("Все четные элементы массива: " + string.Join(", ", Array.FindAll(massiv, h => h % 2 == 0 && h != 0)));
				Console.WriteLine("Все элементы массива, чьи индексы четные (0 четный): " + string.Join(", ", Array.FindAll(massiv, h => Array.IndexOf(massiv, h) % 2 == 0)));
			}
			void n2 ()
			{
                Console.Write("Введите кол-во элементов массива ");
                int kolvoelements = 0; bool outkolvoelements = true;
                while (outkolvoelements)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvoelements))
                        Console.Write("Ошибка! Введите кол-во элементов еще раз ");
                    else if (kolvoelements <= 0)
                        Console.Write("Кол-во элементов не может быть неположительным. Введите кол-во элементов еще раз ");
                    else
                        outkolvoelements = false;
                }
                int[] massiv = new int[kolvoelements];
                Random random = new Random();
                for (int i = 0; i < kolvoelements; i++)
                {
                    massiv[i] = random.Next(-10, 11);
                }
                Console.WriteLine("Первоначальный массив: " + string.Join(", ", massiv));
				for (int i = 0; i < kolvoelements; i++)
				{
					if (i % 2 == 0)
						massiv[i] = 0;
				}
				Console.WriteLine("Все элементы массива, чьи индексы четные (0 четный): " + string.Join(", ", massiv));
            }
			//n1();
			n2();
		}
	}//Odnomermassiv.Nap nap = new Odnomermassiv.Nap(); nap.Gha();
}