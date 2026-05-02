using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copia = originalValue;
            copia++;
            Product productCopia = product;
            productCopia.SetDescription("Producto Modificado");
            return $"{originalValue}-{copia}-{product.GetDescription()}";
        }
    }
}
