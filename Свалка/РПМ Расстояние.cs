using System;

//Rasstoynie.ZadanieRasstoynie rasstoynie = new Rasstoynie.ZadanieRasstoynie(); rasstoynie.TipoMain();
namespace Rasstoynie
{
    public class ZadanieRasstoynie
    {
        public void TipoMain()
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
        double Vuchisleni(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));
        }
    }
}