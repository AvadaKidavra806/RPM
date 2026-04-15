using System;

// Footbol.Help help = new Footbol.Help(); help.TipoMain();  
namespace Footbol
{
	public class Help
	{
		public void TipoMain()
		{
			Console.Write("Введите кол-во игр ");
			int Kolvoigr = int.Parse(Console.ReadLine());
			Komandu komandu = new Komandu();
			Console.WriteLine("Пункт 11");
			komandu.InicializaciyMassivov(Kolvoigr);
			Console.WriteLine("===============================");
			Console.WriteLine("Пункт 11.a");
			komandu.PechatRezult();
			Console.WriteLine("===============================");
			komandu.KolvoWinLoseDraw(out int Win, out int Lose, out int Draw);
			Console.WriteLine("Пункт 11.б");
			Console.WriteLine("Кол-во выигрышей данной команды: " + Win);
			Console.WriteLine("===============================");
			Console.WriteLine("Пункт 11.в");
			Console.WriteLine("Кол-во выигрышей данной команды: " + Win + "\nКол-во проигрышей данной команды: " + Lose);
			Console.WriteLine("===============================");
			Console.WriteLine("Пункт 11.г");
			Console.WriteLine("Кол-во выигрышей данной команды: " + Win + "\nКол-во проигрышей данной команды: " + Lose + "\nКол-во ничьих данной команды: " + Draw);
			Console.WriteLine("===============================");
			Console.WriteLine("Пункт 11.д");
			Console.WriteLine("Кол-во игр, в которых разность забитых и пропущенных мячей была больше или равна 3: " + komandu.RaznoctBolsheRavno3());
			Console.WriteLine("===============================");
			Console.WriteLine("Пункт 11.e");
			Console.WriteLine("Общее число очков, набранных командой: " + komandu.ObcheeChisloOchkov());
		}
	}
	public class Komandu
	{
		int KolvoIgr;
		int[] ZabitueMychi;
		int[] PropuchenueMychi;
		public void InicializaciyMassivov(int KolvoIgr)
		{
			ZabitueMychi = new int[KolvoIgr];
			PropuchenueMychi = new int[KolvoIgr];
			this.KolvoIgr = KolvoIgr;
			Zapolnenie();
		}
		private void Zapolnenie()
		{
			Random random = new Random();
			Console.WriteLine("Забитые\t  Пропущенные");
			for (int i = 0; i < KolvoIgr; i++)
			{
				ZabitueMychi[i] = random.Next(10);
				PropuchenueMychi[i] = random.Next(10);
				Console.WriteLine($"{ZabitueMychi[i]}\t  {PropuchenueMychi[i]}");
			}
		}
		public void PechatRezult()
		{
			Console.WriteLine($"Номер игры\tРезультат");
			string Result;
			for (int i = 0; i < KolvoIgr; i++)
			{
				if (ZabitueMychi[i] > PropuchenueMychi[i])
					Result = "Выигрыш";
				else if (ZabitueMychi[i] < PropuchenueMychi[i])
					Result = "Проигрыш";
				else
					Result = "Ничья";
				Console.WriteLine($"{i + 1}\t\t{Result}");
			}
		}
		public void KolvoWinLoseDraw(out int Win, out int Lose,  out int Draw)
		{
			Win = 0; Lose = 0; Draw = 0;
			for (int i = 0; i < KolvoIgr; i++)
			{
				if (ZabitueMychi[i] > PropuchenueMychi[i])
					Win++;
				else if (ZabitueMychi[i] < PropuchenueMychi[i])
					Lose++;
				else
					Draw++;
			}
		}
		public int RaznoctBolsheRavno3()
		{
			int RaznoctBolsheRavno3 = 0;
			for (int i = 0; i < KolvoIgr; i++)
			{
				if (ZabitueMychi[i] - PropuchenueMychi[i] >= 3)
				{
					RaznoctBolsheRavno3++;
				}
				//Console.WriteLine($"{ZabitueMychi[i]}-{PropuchenueMychi[i]} = {ZabitueMychi[i] - PropuchenueMychi[i]}");
			}
			return RaznoctBolsheRavno3;
		}
		public int ObcheeChisloOchkov()
		{
			KolvoWinLoseDraw(out int Win, out int Lose, out int Draw);
			return Win * 3 + Draw * 1;
		}
	}
}