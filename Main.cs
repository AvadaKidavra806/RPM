using System;

namespace RPM
{
    internal class ClassMain
    {
        static void Main()
        {
            //Oshibka.Nahodjdenie f = new Oshibka.Nahodjdenie(); f.PochtiMain();
            Imy.Vozrast vozrast = new Imy.Vozrast(); vozrast.TipoMain();
            Console.Write("Для завершения программы нажмите Enter");
            Console.ReadLine();
        }
    }
}
