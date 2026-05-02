using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Product
    {
        public string Description { get; set; }

        public Product(string description)
        {
            Description = description;
        }

        public void SetDescription(string description)
        {
            Description = description;
        }

        public string GetDescription()
        {
            return Description;
        }
    }
}
