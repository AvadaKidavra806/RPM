using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// ClassForMassiv.Help help = new ClassForMassiv.Help(); help.help();
namespace ClassForMassiv
{
	public class Help
	{
		const int KolvoMassivovDlyArifOper = 2; //не удалось(
		int [] ints = new int [KolvoMassivovDlyArifOper];
		public void help()
		{
			//пункт 1
			Console.WriteLine("Пункт 1");
			int KolvoMassivov;
            void VvodKolvaMassivov ()
			{
				Console.Write("Введите кол-во массивов ");
			    KolvoMassivov = 0; bool OutKolvoMassivov = true;
				while (OutKolvoMassivov)
				{
					if (!int.TryParse(Console.ReadLine(), out KolvoMassivov))
						Console.Write("Ошибка! Введите кол-во массивов еще раз ");
					else if (KolvoMassivov <= 0)
						Console.Write("Кол-во массивов не может быть неположительным. Введите кол-во массивов еще раз ");
					else
						OutKolvoMassivov = false;
				}
			}
			VvodKolvaMassivov();
            OdnomerMassiv [] massivs = new OdnomerMassiv [KolvoMassivov];
            int[] KolvoVsehMassivov = new int[KolvoMassivov];
            for (int i = 0; i < KolvoMassivov; i++)
			{
				OdnomerMassiv massiv = new OdnomerMassiv();
				massiv.InicializaciyMassiva(i, out int KolvoElementsMassiva);
				massivs[i] = massiv;
				KolvoVsehMassivov[i] = KolvoElementsMassiva;
            }
			Console.WriteLine("KolvoVsehMassivov.Distinct().Count(): " + string.Join(", ", KolvoVsehMassivov.Distinct()) +
				" KolvoVsehMassivov.Length: " + string.Join(", ", KolvoVsehMassivov));
			//пункт 2
			Console.WriteLine("Пункт 2");
			Console.WriteLine("Арифметическое действие над массивами:");
			if (massivs.Length == 1)
				Console.WriteLine("Пользователем был введен только 1 массив, поэтому невозможно выполнить задание с поэлементным преобразованием массивов и оно было пропущено");
			else if (KolvoVsehMassivov.Distinct().Count() == KolvoVsehMassivov.Length)
				Console.WriteLine("Среди введенных массивов нет массивов с одинаковой длиной, поэтому невозможно выполнить поэлементную сумму и разность массивов ");
			else
			{
				Punkt2();
				void Punkt2()
				{
					void ideizakonchilis()
					{
						for (int i = 0; i < KolvoMassivovDlyArifOper; i++)
						{
							VuborMassivov(i + 1, out this.ints[i]);
						}
					}
					ideizakonchilis();
					while (massivs[ints[0] - 1].DLINA() != massivs[ints[1] - 1].DLINA())
					{
						Console.WriteLine("Выбранные массивы не одинаковой длины. Для повторного выбора массивов нажмите Y/N для пропуска этого пункта ");
						ConsoleKey sd;
						do
						{
							sd = Console.ReadKey(true).Key;
						}
						while (sd != ConsoleKey.Y && sd != ConsoleKey.N);
						if (sd == ConsoleKey.Y)
							ideizakonchilis();
						else if (sd == ConsoleKey.N)
							return;
					}
					Console.WriteLine("Номера массивов: " + string.Join(",", ints));
                    //=========================
                    ArifmeticheskieDeystviy(massivs[ints[0] - 1], massivs[ints[1] - 1]);
					
				}
			}
			//пункт 3
			Console.WriteLine("Пункт 3");
			Console.WriteLine("Арифметическое действие над массивом и числом ");
			{
				VuborMassivov(0, out this.ints[0]);
				double Chislo = 0; 
				void ideizakonchilis2()
				{
                    Console.Write("Введите число, для арифметической операции ");
                    bool OutChislo = true;
                    while (OutChislo)
					{
						if (!double.TryParse(Console.ReadLine(), out Chislo))
							Console.Write("Ошибка! Введите число еще раз ");
						else if (Chislo == 0)
						{
							Console.WriteLine("Введенное число равно 0, при деление на него каждый элемент будет выведен как \"деление на 0\"\nДля подтверждения выбора нажмите Y/N для ввода числа еще раз ");
							ConsoleKey sd;
							do
							{
								sd = Console.ReadKey(true).Key;
							}
							while (sd != ConsoleKey.Y && sd != ConsoleKey.N);
							if (sd == ConsoleKey.Y)
							{
								return;
							}
							else if (sd == ConsoleKey.N)
								ideizakonchilis2();
							return;
						}
						else
							OutChislo = false;
					}
				}
                ideizakonchilis2();
                ArifmeticheskieDeystviy(massivs[ints[0] - 1], Chislo: Chislo);
            }
            //пункт 4
            Console.WriteLine("Пункт 4");
			Console.WriteLine("Вывод элемента по индексу выбранного массива ");
            {
				VuborMassivov(0, out int NomerMassiva);
				massivs[NomerMassiva - 1].VuvodIndexa(NomerMassiva);
			}

            void ArifmeticheskieDeystviy(OdnomerMassiv massiv1, OdnomerMassiv massiv2 = null, double? Chislo = null)
            {
                switch (VvodZnakArifOper())
                {
                    case "+":
                        {
                            double[] massiv = new double [massiv1.DLINA()];
							if (Chislo == null)
							{
								for (int i = 0; i < massiv1.DLINA(); i++)
								{
									massiv[i] = massiv1.Element(i) + massiv2.Element(i);
								}
								Console.WriteLine($"Поэлементная сумма {ints[0]}-го и {ints[1]}-го массивов: " + string.Join(", ", massiv));
							}
							else
                            {
                                for (int i = 0; i < massiv1.DLINA(); i++)
                                {
                                    massiv[i] = massiv1.Element(i) + (double)Chislo;
                                }
                                Console.WriteLine($"Поэлементная сумма {ints[0]}-го массива и {Chislo}: " + string.Join(", ", massiv));
                            }   
                        }
                        break;
                    case "-":
                        {
                            double[] massiv = new double[massiv1.DLINA()];
                            if (Chislo == null)
                            {
                                for (int i = 0; i < massiv1.DLINA(); i++)
                                {
                                    massiv[i] = massiv1.Element(i) - massiv2.Element(i);
                                }
                                Console.WriteLine($"Поэлементная разность {ints[0]}-го и {ints[1]}-го массивов: " + string.Join(", ", massiv));
                            }
                            else
                            {
                                for (int i = 0; i < massiv1.DLINA(); i++)
                                {
                                    massiv[i] = massiv1.Element(i) - (double)Chislo;
                                }
                                Console.WriteLine($"Поэлементная разность {ints[0]}-го массива и {Chislo}: " + string.Join(", ", massiv));
                            }
                        }
                        break;
                    case "*":
                        {
                            double[] massiv = new double[massiv1.DLINA()];
                            if (Chislo == null)
                            {
                                for (int i = 0; i < massiv1.DLINA(); i++)
                                {
                                    massiv[i] = massiv1.Element(i) * massiv2.Element(i);
                                }
                                Console.WriteLine($"Поэлементное произведение {ints[0]}-го и {ints[1]}-го массивов: " + string.Join(", ", massiv));
                            }
                            else
                            {
                                for (int i = 0; i < massiv1.DLINA(); i++)
                                {
                                    massiv[i] = massiv1.Element(i) * (double)Chislo;
                                }
                                Console.WriteLine($"Поэлементное произведение {ints[0]}-го массива и {Chislo}: " + string.Join(", ", massiv));
                            }
                        }
                        break;
                    case "/":
                        {
                            double[] doubles = new double[massiv1.DLINA()];

							if (Chislo == null)
							{
                                Console.Write($"Поэлементное деление {ints[0]}-го и {ints[1]}-го массивов: ");
                                for (int i = 0; i < massiv1.DLINA(); i++)
								{

									doubles[i] = Math.Round((double)massiv1.Element(i) / (double)massiv2.Element(i), 3);
									bool ad = doubles[i] is double.NaN || doubles[i] is double.PositiveInfinity || doubles[i] is double.NegativeInfinity;
									if (!ad)
									{
										if (i < massiv1.DLINA() - 1)
											Console.Write(doubles[i] + "; ");
										else
											Console.Write(doubles[i] + "\n");
									}
									else
									{ 
										if (i < massiv1.DLINA() - 1)
											Console.Write("Ошибка! Деление на 0; ");
										else
											Console.Write("Ошибка! Деление на 0\n");
									}
								}
							}
							else
							{
                                Console.Write($"Поэлементное деление {ints[0]}-го массива и {Chislo}: ");
                                for (int i = 0; i < massiv1.DLINA(); i++)
								{

									doubles[i] = Math.Round((double)massiv1.Element(i) / (double)Chislo, 3);
                                    bool ad = doubles[i] is double.NaN || doubles[i] is double.PositiveInfinity || doubles[i] is double.NegativeInfinity;
                                    if (!ad)
                                    {
                                        if (i < massiv1.DLINA() - 1)
                                            Console.Write(doubles[i] + "; ");
                                        else
                                            Console.Write(doubles[i] + "\n");
                                    }
                                    else
                                    {
                                        if (i < massiv1.DLINA() - 1)
                                            Console.Write("Ошибка! Деление на 0; ");
                                        else
                                            Console.Write("Ошибка! Деление на 0\n");
                                    }
                                }
							}
                        }
						break;

                }
            } 
            string VvodZnakArifOper()
			{
				Console.Write("Введите знак арифметической операции (+, -, *, /) ");
				string ZnakArifOper = null; bool OutZnakArifOper = true;
				while (OutZnakArifOper)
				{
					ZnakArifOper = Console.ReadLine();
					if (ZnakArifOper != "+" && ZnakArifOper != "-" && ZnakArifOper != "*" && ZnakArifOper != "/")
						Console.Write("Ошибка! Введите знак арифметической операции еще раз ");
					else
						OutZnakArifOper = false;
				}
				return ZnakArifOper;
			}
			void VuborMassivov (int MassivNomer, out int NomerMassiva)
			{
				string lala = $"{MassivNomer}-го ";
				if (MassivNomer == 0)
					lala = "";
				Console.Write($"Введите номер {lala}массива для арифметической операции ");
				NomerMassiva = 0; bool OutNomerMassiva = true;
				while (OutNomerMassiva)
				{
					if (!int.TryParse(Console.ReadLine(), out NomerMassiva))
						Console.Write($"Ошибка! Введите номер {lala}массива еще раз ");
					else if (NomerMassiva <= 0 || NomerMassiva > KolvoMassivov)
						Console.Write($"Номер {lala}массива не может быть неположительным и больше кол-ва массивов. Введите номер {lala}массива еще раз ");
					else 
						OutNomerMassiva = false;
				}
			}
		}
	}
	public class OdnomerMassiv
	{
		int[] massiv;
		int KolvoElementsMassiva;
		int NizGranica;
		int VerhGranica;
		int NomerMassiva;
		private void ZaprosKolvaElementovMassiva()
		{
			Console.Write($"Введите кол-во элементов {NomerMassiva+1}-го массива ");
			int KolvoElementsMassiva = 0; bool OutKolvoElementsMassiva = true;
			while (OutKolvoElementsMassiva)
			{
				if (!int.TryParse(Console.ReadLine(), out KolvoElementsMassiva))
					Console.Write("Ошибка! Введите кол-во элементов массива еще раз ");
				else if (KolvoElementsMassiva <= 0)
					Console.Write("Кол-во элементов массива не может быть неположительным. Введите кол-во элементов еще раз ");
				else
					OutKolvoElementsMassiva = false;
			}
			this.KolvoElementsMassiva = KolvoElementsMassiva;
		}
		public void InicializaciyMassiva(int NomerMassiva, out int KolvoElementsMassiva)
		{
			KolvoElementsMassiva = this.KolvoElementsMassiva;
            this.NomerMassiva = NomerMassiva;
			ZaprosKolvaElementovMassiva();
			massiv = new int[this.KolvoElementsMassiva];
			Granicu();
			Random random = new Random();
			for (int i = 0; i < this.KolvoElementsMassiva; i++)
			{
				massiv[i] = random.Next(NizGranica, VerhGranica);
			}
			VuvodMassiva();
		}
		private void Granicu()
		{
	        void NizGranicaVoid()
			{
				Console.Write($"Введите нижнюю границу чисел, заполняющих {NomerMassiva + 1}-й массив ");
				int NizGranica = 0; bool OutNizGranica = true;
				while (OutNizGranica)
				{
					if (!int.TryParse(Console.ReadLine(), out NizGranica))
						Console.Write("Ошибка! Введите нижнюю границу еще раз ");
					else
						OutNizGranica = false;
				}
				this.NizGranica = NizGranica;
			}
			void VerhGranicaVoid()
			{
				Console.Write($"Введите верхнюю границу чисел, заполняющих {NomerMassiva + 1}-й массив ");
				int VerhGranica = 0; bool OutVerhGranica = true;
				string slovo;
				while (OutVerhGranica)
				{
					slovo = Console.ReadLine();
					if (slovo == "Еще раз")
					{
						Granicu();
						return;
					}
					else if (!int.TryParse(slovo, out VerhGranica))
						Console.Write("Ошибка! Введите верхнюю границу еще раз ");
					else if (VerhGranica < NizGranica)
						Console.Write("Нижняя граница должна быть меньше, чем верхняя граница!\nВведите верхнюю границу еще раз или введите \"Еще раз\" чтобы заново ввести нижнюю границу ");
					else
						OutVerhGranica = false;
				}
				this.VerhGranica = VerhGranica;
			}
			NizGranicaVoid();
			VerhGranicaVoid();
		}
		public void VuvodMassiva()
		{
			Console.WriteLine($"Массив {NomerMassiva + 1}-й: " + string.Join(", ", massiv));
		}
		public int DLINA()
		{
			return massiv.Length;
		}
		public int Element(int i)
		{
			return massiv[i];
		}
		public void VuvodIndexa(int NomerMassiva)
		{
            Console.Write("Введите индекс необходимого элемента ");
            int Index = 0; bool OutIndex = true;
			while (OutIndex)
			{
				if (!int.TryParse(Console.ReadLine(), out Index))
					Console.Write("Ошибка! Введите необходимый индекс еще раз ");
				else if (Index < 0 || Index > massiv.Length - 1)
					Console.Write($"Индекс не может быть отрицательным и больше, чем {KolvoElementsMassiva - 1}. Введите индекс еще раз ");
				else
					OutIndex = false;
			}
			Console.WriteLine($"Элемент {NomerMassiva}-го массива с индексом {Index}: " + massiv[Index]);
        }
	}
}