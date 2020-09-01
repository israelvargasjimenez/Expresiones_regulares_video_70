using System;
using System.Collections.Generic;
using System.Text;

namespace Expresiones_regulares_video_70
{
    class ImprimirResultadosCuenta
    {
        public static void imprimirResultado(int cuenta, string patron) =>
        Console.WriteLine($"Se han encontrado {cuenta} coincidencias del patron \"{patron}\"");
    }
}
