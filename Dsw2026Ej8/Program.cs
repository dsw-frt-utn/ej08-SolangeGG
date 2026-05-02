namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var helper = new ProductHelper();

            string resultado = helper.ObtenerEtiquetaProducto(2026, "Figuritas", 2000);

            Console.WriteLine(resultado);

            var p2 = new Problema2();

            string resul1 = p2.CrearResumenVenta(2022, "Album22", 2, 12000);

            Console.WriteLine(resul1);

            string resul2 = p2.CrearResumenVenta(2023, "Album23", 0, 500);

            Console.WriteLine(resul2);

            var producto = new Product("Figuritas");

            var p3 = new Problema3();

            string resultado3= p3.CompararCopias(5, producto);

            Console.WriteLine(resultado3);
        }
    }
}
