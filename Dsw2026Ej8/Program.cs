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
        }
    }
}
