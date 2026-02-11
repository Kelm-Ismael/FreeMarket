using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Entidad
    {
        private string Nombre;

        public string nombre
        {
            get => Nombre;
            set
            {
                if (value.Length < 3)
                   throw new Exception("El nombre debe tener al menos 3 caracteres");
                Nombre = value;
            }

        }

        public Entidad(string nombre)
        {
            this.Nombre = nombre;
        }
       
    }
}
