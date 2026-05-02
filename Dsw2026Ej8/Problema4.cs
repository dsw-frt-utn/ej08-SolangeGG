using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double suma = 0;
            int contador = 0;

            if (nota1 != null && nota1 >= 0 && nota1 <= 10)
            {
                suma += nota1.Value;
                contador++;
            }

            if (nota2 != null && nota2 >= 0 && nota2 <= 10)
            {
                suma += nota2.Value;
                contador++;
            }

            if (nota3 != null && nota3 >= 0 && nota3 <= 10)
            {
                suma += nota3.Value;
                contador++;
            }

            if (contador == 0)
                return 0;

            return suma / contador;
        }
    }
}
