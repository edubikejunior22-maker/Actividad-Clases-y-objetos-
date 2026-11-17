using System;

namespace TecnoPunto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de inventario TecnoPunto");

            Producto producto1 = LeerProducto(1);
            Producto producto2 = LeerProducto(2);
            Producto producto3 = LeerProducto(3);

            Console.WriteLine("\nListado de productos");

            producto1.MostrarInfo();
            producto2.MostrarInfo();
            producto3.MostrarInfo();

            Console.WriteLine("Fin del programa.");
            Console.ReadKey();
        }

        static Producto LeerProducto(int numero)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("\nIngrese los datos del producto " + numero);

                    Console.Write("Codigo: ");
                    string codigo = Console.ReadLine();

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    decimal precio;
                    Console.Write("Precio: ");

                    while (!decimal.TryParse(Console.ReadLine(), out precio))
                    {
                        Console.Write("Ingrese un precio valido: ");
                    }

                    int cantidad;
                    Console.Write("Cantidad: ");

                    while (!int.TryParse(Console.ReadLine(), out cantidad))
                    {
                        Console.Write("Ingrese una cantidad valida: ");
                    }

                    Producto producto = new Producto(codigo, nombre, precio, cantidad);

                    Console.WriteLine("Producto registrado correctamente.");

                    return producto;
                }
                catch (ArgumentException error)
                {
                    Console.WriteLine("Error: " + error.Message);
                    Console.WriteLine("Intente ingresar los datos nuevamente.");
                }
            }
        }
    }
}
