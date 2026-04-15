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
            //Vklad.ZadanieVklad vklad = new Vklad.ZadanieVklad(); vklad.TipoMain();
            //Rasstoynie.ZadanieRasstoynie rasstoynie = new Rasstoynie.ZadanieRasstoynie(); rasstoynie.TipoMain();
            NOD.ReshenieNOD NOD = new NOD.ReshenieNOD(); NOD.TipoMain();
            //Footbol.Help help = new Footbol.Help(); help.TipoMain();
            Console.Write("Для завершения программы нажмите Enter");
            Console.ReadLine();
        }
    }
}
