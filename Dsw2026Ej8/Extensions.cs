using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Dsw2026Ej8
{
    internal static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            if(code == null)
            {
                return "SIN-CODIGO";
            }

            return code.Trim().ToUpper().Replace(" ", "-");
        }

    }
}
