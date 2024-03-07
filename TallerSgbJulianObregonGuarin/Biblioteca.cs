using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerSgbJulianObregonGuarin
{
    class Biblioteca : IBiblioteca
    {
        private List<Libro> Catalogo;
        private List<Usuario> Usuarios;

        public Biblioteca()
        {
            Catalogo = new List<Libro> ();
            Usuarios = new List<Usuario>();


        }
        public void Agregarlibro(Libro libro)
        {
            Catalogo.Add(libro);
        }
        s

        public void AgregarUsuario(Usuario usuario)
        {
            if (!Usuarios.Contains(usuario))
            
            {
                Usuarios.Add(usuario);
                Console.WriteLine($"El Usuario se agrego {usuario.Nombre} al sistema");

            }

            else
            {
                Console.WriteLine($"El Usuario {usuario.Nombre} ya existe en el sistema");
            }
        }


        public void Devolerlibro(Libro libro)
        {
            if (Catalogo.Contains(libro))
            {
                if (!libro.Disponible)
                {
                    libro.Disponible = true;
                    Console.WriteLine($"Se devolvió el libro '{libro.Titulo}' a la biblioteca.");
                }
                else
                {
                    Console.WriteLine("El libro ya está disponible en la biblioteca.");
                }
            }
            else
            {
                Console.WriteLine("El libro no está en el catálogo.");
            }

        }

        public void MostrarCatalogo()
        {
            Console.WriteLine("Catálogo de la Biblioteca:");
            foreach (var libro in Catalogo)
            {
                Console.WriteLine(libro);
            }
        }

     

        public void Prestarlibro(Libro libro, Usuario usuario)
        {

            if (Catalogo.Contains(libro))
            {
                if (libro.Disponible)
                {
                    libro.Disponible = false;
                    Console.WriteLine($"Se prestó el libro '{libro.Titulo}' a {usuario.Nombre}.");
                }
                else
                {
                    Console.WriteLine("El libro no está disponible para ser prestado.");
                }
            }
            else
            {
                Console.WriteLine("El libro no está en el catálogo.");
            }

        }
    }
}
