using System;

namespace TecnoPunto
{
    class Producto
    {
        private string codigo;
        private string nombre;
        private decimal precio;
        private int cantidad;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacio.");

                nombre = value;
            }
        }

        public decimal Precio
        {
            get { return precio; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El precio debe ser mayor que cero.");

                precio = value;
            }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("La cantidad no puede ser negativa.");

                cantidad = value;
            }
        }

        public decimal ValorTotal
        {
            get { return Precio * Cantidad; }
        }

        public Producto(string codigo, string nombre, decimal precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Codigo: " + Codigo);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio: RD$ " + Precio);
            Console.WriteLine("Cantidad: " + Cantidad);
            Console.WriteLine("Valor total: RD$ " + ValorTotal);
        }
    }
}
