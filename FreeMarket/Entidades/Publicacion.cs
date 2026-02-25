using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Publicacion : Entidad, IOperable
    {
        private decimal precio;
        private int Stock { get; set; }
        private bool Habilitada = true;

        //propiedad para el precio de la publicacion
        public decimal Precio
        {
            get => precio;
            set 
            {
                if (value < 0)
                    throw new Exception("El precion debe ser mayor a cero.");
                precio = value;
            }
        }
        //propiedad para habilitar o deshabilitar la publicacion
        public bool habilitada
        {
            get => habilitada;
            set
            {
                habilitada = value;
                
            }
        }
        //metodo para calcular el precio de la publicacion
        public decimal CalcularTotal()
        {
            return precio;
            
        }
        //constructor

        public Publicacion(string nombre, decimal precio, int stock) : base(nombre)
        {
            Precio = precio;
            Stock = stock;
        }
        public Publicacion(string nombre, decimal precio, bool habilitada) : base(nombre)
        {
            Habilitada = habilitada;
        }

        public override string ToString()
        {
            return $"Publicacion: {nombre} - Valor: {this.CalcularTotal()} ";
        }



    }
}
