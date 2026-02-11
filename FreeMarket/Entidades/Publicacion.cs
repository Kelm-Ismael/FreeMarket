using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Publicacion : Entidad, IOperable
    {
        private decimal Precio;
        private int Stock;
        private bool Habilitada = true;

        public decimal precio
        {
            get => Precio;
            set 
            {
                if (value > 0)
                    throw new Exception("El precion debe ser mayor a cero.");
                Precio = value;
            }
        }


    }
}
