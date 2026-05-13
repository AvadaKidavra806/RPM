using System;
using System.Collections.Generic;
using System.Linq;

//NOD.ReshenieNOD NOD = new NOD.ReshenieNOD(); NOD.TipoMain();
namespace NOD
{
    public class ReshenieNOD
    {
        public void TipoMain()
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
                    else if (hellp <= 0)
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
            void Inizializaciy()
            {
                ChislaString = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                ChislaInt = new List<int>(ChislaString.Count);
            }
            ChislaInt.Sort();
            ChislaInt.Reverse();
            Console.WriteLine("НОД: " + BigNOD(ChislaInt.ToArray()));
            int BigNOD(int[] Chisla)
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