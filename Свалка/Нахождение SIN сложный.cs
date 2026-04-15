using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ReshenieSislosh
{
	public class Sinslosh
	{
		public void sin()
		{
			Console.WriteLine("Введите номер задания\n1-Решение через встроенную функцию\n2-Решение методом разложения в ряд");
			byte nzd = 0; bool outnzd = true;
			while (outnzd)
			{
				if (!byte.TryParse(Console.ReadLine(), out nzd))
					Console.Write("Ошибка! Введите номер задания еще раз ");
				else if (nzd <= 0 || nzd > 2)
					Console.Write("Номер задания не может быть неположительным и больше 2\nВведите номер задания еще раз ");
				else 
					outnzd = false;
			}
			switch (nzd)
			{
				case 1:
					n1();
					break;
				case 2:
					n2();
					break;
			}
			void n1 ()
			{
				Console.Write("Введите x для нахождения синуса (в градусах) ");
                double x;
                while (!double.TryParse(Console.ReadLine(), out x))
                    Console.Write("Ошибка! Введите х еще раз ");
                Console.WriteLine($"Sin({x}) = {Math.Sin(x * Math.PI / 180)}");
			}
			void n2 ()
			{
				Console.Write("Введите x для нахождения синуса (в градусах) ");
				double x;
				while (!double.TryParse(Console.ReadLine(), out x))
					Console.Write("Ошибка! Введите х еще раз ");
				Console.WriteLine("Введите n ");
				int n = 0; bool outn = true;
				while (outn)
				{
					if (!int.TryParse(Console.ReadLine(), out n))
						Console.Write("Ошибка! n должно быть целочисленным. Введите n еще раз ");
					else if (n <= 0)
						Console.Write("n должно быть положительным. Введите n еще раз ");
					else 
						outn = false;
				}
				double sum = 0;
				for (int i = 0; i < n; i++)
				{
					sum += (Math.Pow(-1, i) * Math.Pow(x * Math.PI / 180, 2 * i + 1)) / factorial(2 * i + 1);
				}
				int factorial (int f )
				{
					int factorial1 = 1;
					for (int i = 1; i <= f; ++i)
						factorial1 *= i;
					return factorial1;
				}
				Console.WriteLine($"Sin({x}) = {sum}");
			}
			//ReshenieSislosh.Sinslosh sinslosh = new ReshenieSislosh.Sinslosh(); sinslosh.sin();
		}
	}
}