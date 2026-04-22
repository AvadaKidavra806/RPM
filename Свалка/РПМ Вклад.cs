using System;

//Vklad.ZadanieVklad vklad = new Vklad.ZadanieVklad(); vklad.TipoMain();
namespace Vklad
{
	public class ZadanieVklad
	{
		public void TipoMain()
		{
			Console.Write($"Введите сумму вашего вклада ");
			double chislo = 0; bool outchislo = true;
			while (outchislo)
			{
				if (!double.TryParse(Console.ReadLine(), out chislo))
					Console.Write($"Ошибка! Сумма вклада не число, введите еще раз ");
				else if (chislo <= 0)
					Console.Write($"Сумма вклада не может быть неположительной, введите сумму еще раз ");
				else
					outchislo = false;
			}
			Console.Write("Введите на какое кол-во месяцев вы делаете вклад ");
			int KolvoMesyc = 0; bool OutKolvoMesyc = true;
			while (OutKolvoMesyc)
			{
				if (!int.TryParse(Console.ReadLine(), out KolvoMesyc))
					Console.Write("Ошибка! Введите кол-во месяцев еще раз ");
				else if (KolvoMesyc <= 0)
					Console.Write("Кол-во месяцев не может быть неположительным. Введите кол-во месяцев еще раз ");
				else
					OutKolvoMesyc = false;
			}
			for (int i = 0; i < KolvoMesyc; i++)
			{
				Procents(ref chislo, out int p);
				//Console.WriteLine("Сумма вклада с начисленными процентами: " + Math.Round(chislo, 3) + ". Начисленно " + p + $"% за {i+1}-й месяц");
			}
			Console.WriteLine("Сумма вклада с начисленными процентами: " + Math.Round(chislo, 2));

			void Procents(ref double Chislo, out int proc)
			{
				if (Chislo < 100)
				{
					Chislo *= 1.05;
					proc = 5;
				}
				else if (Chislo >= 100 && Chislo <= 200)
				{
					Chislo *= 1.07;
					proc = 7;
				}
				else
				{
					Chislo *= 1.10;
					proc = 10;
				}

			}
		}
	}
}
