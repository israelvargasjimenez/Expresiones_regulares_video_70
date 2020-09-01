using System;
using System.Text.RegularExpressions;

namespace Expresiones_regulares_video_70
{
    class Program
    {

        
        static void Main(string[] args)
        {

            string frase = "Mi nombre es \'Israel y mi nº de tfno es" +
                                   "(+34)91-764-63-41, y my codIIIIIIIIIIIIIgo postal 28760";

            // Expresiones regulares video 70-------------------------
            // son muy potentes pero poco utilizadas
            // Son secuencias de caracteres que funcionan como un patrón de busqueda
            // Se suelen utilizar para buscar cadenas de caracteres
            // La clase que les da nombre es Regex (regular expresion)

            string pattern1 = @"[I]";

            Regex miRegex = new Regex(pattern1);

            MatchCollection resultados = miRegex.Matches(frase);

            if (resultados.Count > 0) Console.WriteLine(
                           $"Se han encontrado {resultados.Count} coincidencias");


            

        }
    }
}
