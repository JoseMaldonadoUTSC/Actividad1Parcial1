using System;

namespace Actividad1
{
    class Captura
    {

        public Captura() { }
        public Captura(Animal perro, Usuario usuario) { realizarAdopcion(perro, usuario); }

        public int folio { get; set; }
        public void realizarAdopcion(Animal perro, Usuario usuario)
        {
            Console.WriteLine("Buen día: " + usuario.nombre + "\nSe realizó la adopción de: " + perro.nombre);
            Console.Write("Gracias!");
            Console.ReadLine();
        }
    }
}