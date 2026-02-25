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
        private int dni;
        private List<Operacion> operaciones;

        //propiedades
        public int Dni
        {
            get => dni;
            set
            {
                if (value < 1000000 || value > 99999999)
                {
                    throw new ArgumentException("Error! El Dni debe estar entre 1.000.000 & 99.999.999");
                }
                dni = value;
            }

        }
        //relacion con carrito de compras
        public Carrito CarritoActual { get; internal set; } //CONSULTAR SI ESTA BIEN ASI 

        //constructor
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
