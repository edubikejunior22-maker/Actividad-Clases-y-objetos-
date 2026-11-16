using System;

namespace TecnoPunto
{
    class Producto
    {
        string codigo;
        string nombre;
        decimal precio;
        int cantidad;

        public Producto(string codigo, string nombre, decimal precio, int cantidad)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("El código no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");

            if (precio < 0)
                throw new ArgumentException("El precio no puede ser negativo.");

            if (cantidad < 0)
                throw new ArgumentException("La cantidad no puede ser negativa.");

            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("\nCódigo: " + codigo);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Precio: " + precio);
            Console.WriteLine("Cantidad: " + cantidad);
            Console.WriteLine("Valor total: " + (cantidad * precio));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE INVENTARIO TECNOPUNTO");

            Producto producto1 = LeerProducto(1);
            Producto producto2 = LeerProducto(2);
            Producto producto3 = LeerProducto(3);

            Console.WriteLine("\nLISTADO DE PRODUCTOS");

            producto1.MostrarInfo();
            producto2.MostrarInfo();
            producto3.MostrarInfo();

            Console.WriteLine("\nPresione una tecla para salir.");
            Console.ReadKey();
        }

        static Producto LeerProducto(int numero)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("\nRegistro del producto " + numero);

                    Console.Write("Código: ");
                    string codigo = Console.ReadLine();

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Precio: ");
                    decimal precio = decimal.Parse(Console.ReadLine());

                    Console.Write("Cantidad: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    return new Producto(codigo, nombre, precio, cantidad);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Introduzca un número válido.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}