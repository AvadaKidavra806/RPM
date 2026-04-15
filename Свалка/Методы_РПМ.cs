using System;
using System.Collections.Generic;
using System.Linq;

namespace Metod
{
	public class Hellp
	{
		public void Heellp()
		{
			Treugolnik treugolnik = new Treugolnik();
			treugolnik.VvodStoron();

			if (treugolnik.ProverkaNaSuch())
			{
				Console.WriteLine("Площадь такого треугольника равна " + treugolnik.Ploshad());
				Console.WriteLine("Периметр такого треугольника равна " + treugolnik.Perimetr());
				
			}
		}
	}
	internal class Treugolnik
	{
		double[] abc = new double[3];
		public void VvodStoron()
		{
			double[] abc = new double[3];
			for (int i = 0; i < abc.Length; i++)
			{
				VvodStoron(i, out abc[i]);
			}
			void VvodStoron (int i, out double storona)
			{
				Console.Write($"Введите {i + 1}-ю сторону ");
				storona = 0; bool outstorona = true;
                while (outstorona)
                {
                    if (!double.TryParse(Console.ReadLine(), out storona))
                        Console.Write($"Ошибка! Введите {i + 1}-ю сторону треугольника еще раз ");
                    else if (storona <= 0)
                        Console.Write($"{i + 1}-я сторона не может быть неположительной. Введите {i + 1}-ю сторону еще раз ");
                    else
                        outstorona = false;

                }
            }
			InizialStoron(abc);
		}
		private void InizialStoron(double[] abc)
		{
			for (int i = 0; i < abc.Length; i++)
			{
				this.abc[i] = abc[i];
			}
		}
		public bool ProverkaNaSuch()
		{
			sbyte asd = 0;
			while (asd < abc.Length)
			{
				if (abc[asd % 3] >= (abc[(asd+1) % 3] + abc[(asd + 2) % 3]))
				{
					Console.WriteLine($"Треугольник с такими сторонами не существует");
					return false;
				}
				asd++;
			}
            Console.WriteLine($"Треугольник с такими сторонами существует");
            return true;
		}
		public double Ploshad()
		{
			double PolPer = Perimetr() / 2;
			return Math.Sqrt(PolPer * (PolPer - abc[0]) * (PolPer - abc[1]) * (PolPer - abc[2]));
		}
		public double Perimetr()
		{
			return abc[0] + abc[1] + abc[2];
		}
	}
}
