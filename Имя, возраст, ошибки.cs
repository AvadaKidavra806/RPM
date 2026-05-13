using System;
using System.Linq;

namespace Imy
{
	public class Vozrast
	{
		public void TipoMain()
		{
			People people = new People();
			Console.Write("Введите ваше имя ");
			while (true)
			{
				people.Name = Console.ReadLine();
				if (IsBukvu(people.Name) && !string.IsNullOrEmpty(people.Name))
					break;
				else
					Console.Write("Не корректный ввод! Попробуйте снова! ");
			}
			Console.Write($"{people.Name}, введите свой возраст (полное кол-во лет) ");
			while (true)
			{
				try
				{
					people.Age = int.Parse(Console.ReadLine());
					if (people.Age != 0)
						break;
				}
				catch (System.FormatException)
				{
					Console.WriteLine($"{people.Name}, не корректный ввод! Попробуй снова! ");
				}
			}
			if (people.Age < 18)
				Console.WriteLine($"{people.Name}, вы несовершеннолетний!");
			bool IsBukvu(string name)
			{
				char[] RuBukvu = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
				char[] NeRuBukvu = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
				return name.All(b => Array.Exists(RuBukvu, f => f == b)) || name.All(b => Array.Exists(NeRuBukvu, f => f == b));
			}
		}
	}
	internal class People
	{
		private string name;
		private int age = 0;
		public string Name
		{
			set
			{
				name = value;
			}
			get { return name; }
		}
		public int Age
		{
			set {
				if (value < 0 || value > 110)
					Console.WriteLine("Возраст не может быть меньше 0 и больше 110. Попробуй еще рaз ");
				else
					age = value; }
			get { return age; }
		}
	}
}