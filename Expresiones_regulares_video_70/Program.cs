using Microsoft.VisualBasic;
using System;
using System.Text.RegularExpressions;

namespace Expresiones_regulares_video_70
{
    class Program
    {
        private delegate int DelegadoCoincidencias(MatchCollection coleccion);
        
        static void Main(string[] args)
        {

            string frase = "Mi nombre es \'IJsrael y mi nº de tfno es" +
                                   "(+34)91-764-63-41, y my codIJIgo postal 38760" +
                                   "(+34)91-764-63-42  (+34)91-764-63-55";

            // Expresiones regulares video 70-------------------------
            // son muy potentes pero poco utilizadas
            // Son secuencias de caracteres que funcionan como un patrón de busqueda
            // Se suelen utilizar para buscar cadenas de caracteres
            // La clase que les da nombre es Regex (regular expresion)

            string pattern1 = @"IJ";

            string pattern2 = @"(\d{5})";

            string pattern3 = @"\W{2}\d{2}\W\d{2}-\d{3}-\d{2}-\d{2}";


            Regex miRegex = new Regex(pattern1);

            MatchCollection resultados = miRegex.Matches(frase);          

            ImprimirResultadosCuenta.imprimirResultado(resultados.Count, pattern1);


            miRegex = new Regex(pattern2);

            resultados = miRegex.Matches(frase);

            ImprimirResultadosCuenta.imprimirResultado(resultados.Count, pattern2);


            miRegex = new Regex(pattern3);

            resultados = miRegex.Matches(frase);

            ImprimirResultadosCuenta.imprimirResultado(resultados.Count, pattern3);
        }
    }
}
