using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion
    {
        //campos
        private DateTime Fecha { get; set; }
        private decimal Monto = 0;
        private Comprador comprador;

        //propiedades
       
        public IOperable Operable { get; internal set; }
        public decimal monto
        {
            get
            {
                return Operable.CalcularTotal();
            }
        }
        //public Comprador Comprador
        //{
        //    get => comprador;
        //    set
        //    {
        //        //value = comprador
        //        comprador = value;
        //        value.AddOperacion(this);
        //    }
        //}
        public Comprador Comprador
        {
            get => comprador;
            set
            {
                comprador = value;//verificar si esta bien asi o alreves  /// CONSULTAR
                value.AddOperacion(this);
            }

        }

        //constructor
        public Operacion(Comprador comprador, DateTime fecha, IOperable operable)
        { 
            Comprador = comprador;
            Fecha = fecha;
            Operable = operable;

        }

        public override string ToString()
        {
            return $"{comprador} - Fecha: {Fecha} - Monto: {monto}";
        }


    }
}
