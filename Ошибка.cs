using System;
//Oshibka.Nahodjdenie f = new Oshibka.Nahodjdenie(); f.PochtiMain();
namespace Oshibka
    {
    public class Nahodjdenie
        {
        public void PochtiMain()
        {
            Console.WriteLine("Введите любое целое число и нажмите Enter");
            int i = int.Parse(Console.ReadLine());
            int x = 5;
            try
            {
                double y = x / i;
                Console.WriteLine($"{x}/{i}={y}");
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Деление на 0 невозможно");
            }
        }
    }
}