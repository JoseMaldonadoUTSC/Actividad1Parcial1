using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            Animal perro = new Animal();
            Console.Write("Bienvenid@\n");
            Console.WriteLine("¿Cúal es su nombre?");
            usuario.nombre = Console.ReadLine();
            Console.WriteLine("¿Cual es el nombre de la mascota que adoptará?");
            perro.nombre = Console.ReadLine();
            Captura tramite = new Captura(perro, usuario);
        }
    }
}
