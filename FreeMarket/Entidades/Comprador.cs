using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comprador : Entidad
    {
        //campos
        private int Dni;
        private List<Operacion> operaciones;

        //propiedades
        public int dni
        {
            get => Dni;
            set
            {
                if (value < 1000000 || value > 99999999)
                    throw new Exception("Error! El Dni debe estar entre 1.000.000 & 99.999.999");
                Dni = value;
            }
        }
        //relacion con carrito de compras
        public Carrito CarritoActual { get; set; }

        public Comprador(string nombre, int dni) : base(nombre)
        {
            Dni = dni;
            operaciones = new List<Operacion>();
        }

        //metodo funcion
        public List<Operacion> GetOperaciones()
        {
            return operaciones;
        }

        //metodos subrutina
        internal void  AddOperacion(Operacion operacion)
        {
            operaciones.Add(operacion);

        }

        public override string ToString()
        {
            return $"Nombre: {nombre} -  Dni: {dni} " ;
        }


    }
}
