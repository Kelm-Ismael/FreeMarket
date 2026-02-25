namespace Entidades
{
    public class Carrito : IOperable
    {
        private List<Publicacion> publicaciones;
        private Comprador comprador;

        //propiedades
        public Comprador Comprador
        {
            get => comprador;
            set
            {
                 comprador = value; //value.CarritoActual = this; //verificar si esta bien asi o alreves  /// CONSULTAR
            }
        }
        public Carrito(Comprador comprador)
        {
            Comprador = comprador;
            publicaciones = new List<Publicacion>();
        }

        //metodos 
        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (Publicacion publicacion in publicaciones)
            {
                total += publicacion.CalcularTotal();
            }
            return total;
        }
        //metodo para agregar publicaciones al carrito
        public void AddPublicacion(Publicacion publicacion)
        {
            publicaciones.Add(publicacion);
        }
        //metodo para obtener las publicaciones del carrito
        public List<Publicacion> GetPublicaciones()
        {
            return publicaciones;
        }
        //metodo para remover publicaciones del carrito
        public void RemoverPublicacio(Publicacion publiacion)
        {
            publicaciones.Remove(publiacion);
        }
        //metodo para limpiar el carrito
        public void ClearPublicaciones()
        {
            publicaciones.Clear();
        }

        public override string ToString()
        {
            return $"Carrito con: {publicaciones.Count} - Productos: {publicaciones} - Valor: {this.CalcularTotal()}";
        }

    }
}
