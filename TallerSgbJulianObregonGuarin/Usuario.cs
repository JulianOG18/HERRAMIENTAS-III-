using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerSgbJulianObregonGuarin
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public Usuario(string nombre)
            
        {
            Nombre = nombre;
        }


        public override string ToString()
        {
            return ($"Usuario: {Nombre}");
        }


    }
}
