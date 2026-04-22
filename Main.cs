using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPM
{
    internal class ClassMain
    {
        static void Main()
        {
            //NOD.ReshenieNOD NOD = new NOD.ReshenieNOD(); NOD.TipoMain();   
            //Uskorenie.Reshenie reshenie = new Uskorenie.Reshenie(); reshenie.TipoMain();
            //MatricaDiagonali.Resheniy resheniy = new MatricaDiagonali.Resheniy(); resheniy.Qwerty();
            Individual.Zadanie zadanie = new Individual.Zadanie(); zadanie.TipoMain();
            Console.Write("Для завершения программы нажмите Enter");
            Console.ReadLine();
        }
    }
}
