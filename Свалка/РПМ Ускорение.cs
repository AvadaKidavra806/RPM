using System;
using System.Collections.Generic;

namespace Uskorenie
{
    public class Reshenie
    {
        public void TipoMain()
        {
            PhysicsVelichinu physics = new PhysicsVelichinu();
            Console.Write("Выберите состояние тела, 1 - движется, 2 - в состоянии покоя ");
            byte SostoynieTela = 0; bool OutSostoynieTela = true;
            while (OutSostoynieTela)
            {
                if (!byte.TryParse(Console.ReadLine(), out SostoynieTela))
                    Console.Write("Ошибка! Введите состояние тела еще раз ");
                else if (SostoynieTela != 1 && SostoynieTela != 2)
                    Console.Write("Состояние тела может быть либо 1, либо 2. Введите состояние тела еще раз ");
                else
                    OutSostoynieTela = false;
            }
            double m = physics.ZaprosMassu();
            double a = 0; bool outa = true;
            string NasvanieUgla = "альфа";
            while (outa)
            {
                a = physics.ZaprosUgla(NasvanieUgla);
                if (a < 0 || a > 180)
                    Console.Write($"Угол {NasvanieUgla} не может быть неположительным и больше 180 градусов. ");
                else
                    outa = false;
            }
            a = a * Math.PI / 180;
            double F0 = physics.ZaproSilu("F0") * Math.Cos(a);
            List<double> Silu = new List<double>();
            switch (SostoynieTela)
            {
                case 1:
                    double u = physics.ZaprosNu();
                    double Ft = physics.VuchislenieFt(u, m, a);
                    Silu.Add(F0);
                    Silu.Add(Ft);
                    break;
                case 2:
                    Silu.Add(F0);
                    break;
            }
            double RavnodeystSila = physics.VuchislenieRavnondeystvSilu(Silu);
            Console.WriteLine("Ускорение равно: " + physics.VuchislenieUskoreniy(RavnodeystSila, m)+" м/с^2");
        }

    }
    public class PhysicsVelichinu
    {
        const double g = 9.8;
        public double ZaprosMassu()
        {
            Console.Write("Введите массу тела (кг) ");
            double m = 0; bool outm = true;
            while (outm)
            {
                if (!double.TryParse(Console.ReadLine(), out m))
                    Console.Write("Ошибка! Введите массу тела еще раз ");
                else if (m <= 0)
                    Console.Write("Масса не может быть неположительной. Введите массу еще раз ");
                else
                    outm = false;
            }
            return m;
        }
        public double ZaprosNu()
        {
            Console.Write("Введите коэффициент трения ");
            double u = 0; bool outu = true;
            while (outu)
            {
                if (!double.TryParse(Console.ReadLine(), out u))
                    Console.Write("Ошибка! Введите коэффициент трения еще раз ");
                else if (u <= 0)
                    Console.Write("Коэффициент трения не может быть неположительным. Введите коэффициент трения еще раз ");
                else
                    outu = false;
            }
            return u;
        }
        public double ZaprosUgla(string name)
        {
            Console.Write($"Введите угол {name} (в градусах) ");
            double Ugol = 0; bool OutUgol = true;
            while (OutUgol)
            {
                if (!double.TryParse(Console.ReadLine(), out Ugol))
                    Console.Write($"Ошибка! Введите угол {name} еще раз ");
                else
                    OutUgol = false;
            }
            return Ugol;
        }
        public double ZaproSilu(string name)
        {
            Console.Write($"Введите {name} (в ньютонах) ");
            double Sila = 0; bool OutSila = true;
            while (OutSila)
            {
                if (!double.TryParse(Console.ReadLine(), out Sila))
                    Console.Write($"Ошибка! Введите {name} еще раз ");
                else
                    OutSila = false;
            }
            return Sila;
        }
        public double VuchislenieFt(double u, double m, double a)
        {
            return -(u * m * g * Math.Sin(a));
        }
        public double VuchislenieRavnondeystvSilu(List<double> Silu)
        {
            double sum = 0;
            for (int i = 0; i < Silu.Count; i++)
            {
                sum += Silu[i];
            }
            return sum;
        }
        public double VuchislenieUskoreniy(double F, double m)
        {
            return F / m;
        }
    }
}