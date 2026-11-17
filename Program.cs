using System;

namespace TecnoPunto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("      TECNOPUNTO - CONTROL DE INVENTARIO");
            Console.WriteLine("==================================================");
            Console.WriteLine("  Programa para registrar 3 productos.");
            Console.WriteLine("==================================================");

            Producto producto1 = null;
            Producto producto2 = null;
            Producto producto3 = null;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine();
                Console.WriteLine(">> INGRESO DEL PRODUCTO #" + i);
                Console.WriteLine("--------------------------------------------------");

                Producto nuevoProducto = null;
                bool registrado = false;

                // Repetimos hasta que los datos pasen las validaciones del Producto
                while (registrado == false)
                {
                    Console.Write("  Código   : ");
                    string codigo = Console.ReadLine();

                    Console.Write("  Nombre   : ");
                    string nombre = Console.ReadLine();

                    decimal precio = LeerPrecio();
                    int cantidad = LeerCantidad();

                    try
                    {
                        // Aquí las propiedades del Producto validan y lanzan excepción
                        // si el nombre está vacío, precio <= 0 o cantidad < 0.
                        nuevoProducto = new Producto(codigo, nombre, precio, cantidad);
                        registrado = true;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("  [ERROR] " + ex.Message);
                        Console.WriteLine("  [ERROR] Vuelva a ingresar los datos del producto #" + i);
                        Console.WriteLine();
                    }
                }

                if (i == 1) producto1 = nuevoProducto;
                else if (i == 2) producto2 = nuevoProducto;
                else producto3 = nuevoProducto;

                Console.WriteLine("  [OK] Producto registrado correctamente.");
            }

            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine("        PRODUCTOS REGISTRADOS EN EL INVENTARIO");
            Console.WriteLine("==================================================");

            producto1.MostrarInfo();
            producto2.MostrarInfo();
            producto3.MostrarInfo();

            // *** AQUÍ ESTÁ EL TOTAL QUE LE FALTABA ***
            decimal totalInventario = producto1.ValorTotal
                                    + producto2.ValorTotal
                                    + producto3.ValorTotal;

            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine("  VALOR TOTAL DEL INVENTARIO: RD$ " + totalInventario.ToString("F2"));
            Console.WriteLine("==================================================");

            Console.WriteLine();
            Console.WriteLine("Presione ENTER para salir...");
            Console.ReadLine();
        }

        static decimal LeerPrecio()
        {
            decimal precio = 0;
            bool datoValido = false;

            while (datoValido == false)
            {
                Console.Write("  Precio   : ");
                try
                {
                    precio = decimal.Parse(Console.ReadLine());
                    datoValido = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("  [ERROR] Eso no es un número válido. Intente de nuevo.");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("  [ERROR] No escribió nada. Intente de nuevo.");
                }
            }

            return precio;
        }

        static int LeerCantidad()
        {
            int cantidad = 0;
            bool datoValido = false;

            while (datoValido == false)
            {
                Console.Write("  Cantidad : ");
                try
                {
                    cantidad = int.Parse(Console.ReadLine());
                    datoValido = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("  [ERROR] La cantidad debe ser un número entero. Intente de nuevo.");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("  [ERROR] No escribió nada. Intente de nuevo.");
                }
            }

            return cantidad;
        }
    }
}