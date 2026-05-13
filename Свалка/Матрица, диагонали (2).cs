using System;

//MatricaDiagonali.Resheniy resheniy = new MatricaDiagonali.Resheniy(); resheniy.Qwerty();
namespace MatricaDiagonali
{
    public class Resheniy
    {
        public void Qwerty()
        {
            Console.Write("Введите номер варианта ");
            byte NomerVarianta = 0; bool OutNomerVarianta = true;
            while (OutNomerVarianta)
            {
                if (!byte.TryParse(Console.ReadLine(), out NomerVarianta))
                    Console.Write("Ошибка! Введите номер варианта еще раз ");
                else if (NomerVarianta <= 0 || NomerVarianta > 2)
                    Console.Write("Всего 2 варианта! Введите номер варианта еще раз ");
                else 
                    OutNomerVarianta = false;
            }
            switch (NomerVarianta)
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
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                long sum = 0; 
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(-100, 101);
                        Console.Write(nums[i, j] + "\t");
                        if (i == j)
                            sum += nums[i, j];
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Сумма элементов по главной диагонали: " + sum);
            }
            void n2 ()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                long proiz = 1;
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(-100, 101);
                        Console.Write(nums[i, j] + "\t");
                        if (j == kolvostolb -1 - i)
                            proiz *= nums[i, j];
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Произведение элементов по побочной диагонали: " + proiz);
            }
            
        }
    }
}