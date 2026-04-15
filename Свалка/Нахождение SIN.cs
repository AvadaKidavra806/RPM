using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ReshenieSin
{
	public class Sin
	{
		public void sin()
		{
			Console.WriteLine("Введите номер задания\n1-Решение через встроенную функцию\n2-Решение методом разложения в ряд");
			byte nzd = byte.Parse(Console.ReadLine());
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
				double x = double.Parse(Console.ReadLine());
				Console.WriteLine($"Sin({x}) = {Math.Sin(x * Math.PI / 180)}");
			}
			void n2 ()
			{
				Console.Write("Введите x для нахождения синуса (в градусах) ");
				double x = double.Parse(Console.ReadLine());
				Console.WriteLine("Введите n ");
				int n = int.Parse(Console.ReadLine());
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
            //ReshenieSin.Sin sin = new ReshenieSin.Sin(); sin.sin();
        }
	}
}