using System;
using System.Collections.Generic;
using System.Linq;

//Otrabotka.Metodov metodov = new Otrabotka.Metodov(); metodov.TipoMain();
namespace Otrabotka
{

    public class Metodov
    {
        public void TipoMain()
        {
            //ZadanieVklad();
            //Rasstoynie();
            ReshenieNOD();
            //-------------------------
            void ZadanieVklad()
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
            //===================================
            void Rasstoynie()
            {
                {
                    Console.Write("Введите x первой точки отрезка ");
                    double x1 = VvodPeremennih();
                    Console.Write("Введите y первой точки отрезка ");
                    double y1 = VvodPeremennih();
                    Console.Write("Введите x второй точки отрезка ");
                    double x2 = VvodPeremennih();
                    Console.Write("Введите y второй точки отрезка ");
                    double y2 = VvodPeremennih();
                    Console.WriteLine($"Расстояние между точками с координатами ({x1} ; {y1}) и ({x2} ; {y2}) равно " + Math.Round(Vuchisleni(x1, x2, y1, y2), 5));
                    //============
                    double VvodPeremennih()
                    {
                        double q = 1; bool outq = true;
                        while (outq)
                        {
                            if (!double.TryParse(Console.ReadLine(), out q))
                                Console.Write("Неверный ввод, координата должна быть числом. Введите координату еще раз ");
                            else
                                outq = false;
                        }
                        return q;
                    }
                }
                //==============
                double Vuchisleni(double x1, double x2, double y1, double y2)
                {
                    return Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));
                }
            }
            //===================================
            void ReshenieNOD ()
            {
                List<string> ChislaString;
                List<int> ChislaInt;
                Console.Write("Введите натуральные числа для вычисления НОД через зпт или пробел (5, 10, ...) ");
                Inizializaciy();
                bool OutChisla = true;
                while (OutChisla)
                {
                    int i = 0; byte Indikator = 0;
                    while (i < ChislaString.Count && Indikator == 0)
                    {
                        if (!int.TryParse(ChislaString[i], out int hellp))
                        {
                            Indikator = 1;
                        }
                        else if (hellp <=0)
                        {
                            Indikator = 2;
                        }
                        else
                            ChislaInt.Add(Math.Abs(hellp));
                        i++;
                    }
                    if (Indikator == 1 || ChislaString.Count == 0)
                    {
                        Console.Write("Ошибка! Введите числа еще раз ");
                        Inizializaciy();
                    }
                    else if (Indikator == 2)
                    {
                        Console.Write("Среди введенных чисел есть ненатуральное. Введите числа еще раз ");
                        Inizializaciy();
                    }
                    else
                        OutChisla = false;
                }
                void Inizializaciy ()
                {
                    ChislaString = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    ChislaInt = new List<int>(ChislaString.Count);
                }
                ChislaInt.Sort();
                ChislaInt.Reverse();
                Console.WriteLine("НОД: " + BigNOD(ChislaInt.ToArray()));
                int BigNOD(int [] Chisla)
                {
                    int PromeshutResut = Chisla[0];
                    for (int i = 0; i < Chisla.Length - 1; i++)
                        PromeshutResut = NOD(PromeshutResut, Chisla[i + 1]);
                    return PromeshutResut;
                }
                int NOD(int FirstChuislo, int SecondChislo)
                {
                    int Ostatok;
                    do
                    {
                        Ostatok = FirstChuislo % SecondChislo;
                        if (Ostatok != 0)
                        {
                            FirstChuislo = SecondChislo;
                            SecondChislo = Ostatok;
                        }
                    }
                    while (Ostatok != 0);
                    return SecondChislo;
                }
            }
        }
    }   
}