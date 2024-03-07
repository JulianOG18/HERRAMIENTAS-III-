using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerSgbJulianObregonGuarin
{
    public interface IBiblioteca
    {
        void Agregarlibro(Libro libro);
        void AgregarUsuario(Usuario usuario);
        void Prestarlibro(Libro libro, Usuario usuario );
        void Devolerlibro(Libro libro);
        void MostrarCatalogo();
    }
}
