using System;

//Individual.Zadanie zadanie = new Individual.Zadanie(); zadanie.TipoMain();
//Найти наибольшие элементы каждой строки матрицы Z(16;16) и поместить их на главную диагональ. Вывести полученную матрицу.
namespace Individual
{
	public class Zadanie
	{
		public void TipoMain()
		{
			Console.SetWindowSize(134, 35);
			const int Razryad = 16;
			double[,] Matrica = new double[Razryad, Razryad];
			Random random = new Random();
			Console.WriteLine("Первоначальная матрица");
			for (int i = 0; i < Razryad; i++)
			{
				for (int j = 0; j < Razryad; j++)
				{
					Matrica[i, j] = Math.Round(random.NextDouble() * 201 - 100, 2);
					Console.Write(Matrica[i, j] + "\t");
				}
				Console.WriteLine();
			}
			for (int i = 0; i < Razryad; i++)
			{
				NachoshdenieIZamenaMax(i);
			}
			Console.WriteLine("Полученная матрица");
			for (int i = 0; i < Razryad; i++)
			{
				for (int j = 0; j < Razryad; j++)
				{
					Console.Write(Matrica[i, j] + "\t");
				}
				Console.WriteLine();
			}
			void NachoshdenieIZamenaMax(int i)
			{
				double hellp = double.MinValue;
				int heiipj = 0;
				for (int j = 0; j < Razryad; j++)
				{
					if (Matrica[i, j] > hellp)
					{
						hellp = Matrica[i, j];
						heiipj = j;
					}
				}
				(Matrica[i, i], Matrica[i, heiipj]) = (Matrica[i, heiipj], Matrica[i, i]);
			}
		}
	}
}