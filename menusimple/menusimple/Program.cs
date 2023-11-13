using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menusimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bandera = true;
            int valorSeleccionado;

            while (bandera)
            {
                Console.WriteLine("Bienvenido al poderoso menu");
                Console.WriteLine("Selecciona una accion: ");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Actualizar");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("5. Salir del sistema");
                valorSeleccionado = int.Parse(Console.ReadLine());
                switch (valorSeleccionado)
                {
                    case 1:
                        Console.WriteLine("Dato ingresado");
                        break;
                    case 2:
                        Console.WriteLine("Dato actualizado");
                        break;
                    case 3:
                        Console.WriteLine("Busqueda de datos");
                        break;
                    case 4:
                        Console.WriteLine("Dato eliminado");
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del sistema");
                        bandera = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no encontrada");
                        break;
                }
            }
        }
    }
}
