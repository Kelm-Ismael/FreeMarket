using Entidades;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t ---------- FreeMarket ---------");

            Comprador comprador1 = new Comprador("Juan Perez", 12345678);
            Comprador comprador2 = new Comprador("Pedro Perez", 12345678);
            Comprador comprador3 = new Comprador("Pablo Perez", 12345678);
            Console.WriteLine();
            Console.WriteLine(comprador1);

            try
            {
                Comprador comprador4 = new Comprador("Lucas Gomez", 1000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Publicacion publicacion1 = new Publicacion("Pc gamer", 500000, 5);
            Publicacion publicacion2 = new Publicacion("Teclado", 1000, 5);
            Publicacion publicacion3 = new Publicacion("Mouse", 300, 5);
            Publicacion publicacion4 = new Publicacion("Pantalla", 8000, 5);
            Publicacion publicacion5 = new Publicacion("Gabinete", 450000, 5);
            Console.WriteLine();
            try
            {
                Publicacion publicacion6 = new Publicacion("Cargador", -1, 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //operacion de compra 1
            Operacion operacion1 = new Operacion(comprador2, DateTime.Now, publicacion5);
            Console.WriteLine("\nPrimera Operacion de Publicacion ");
            Console.WriteLine(operacion1);
            Console.WriteLine();


            Carrito carrito1 = new Carrito(comprador3);
            carrito1.AddPublicacion(publicacion1);
            carrito1.AddPublicacion(publicacion2);
            carrito1.AddPublicacion(publicacion3);
            carrito1.AddPublicacion(publicacion4);
            carrito1.AddPublicacion(publicacion5);



            Operacion operacion2 = new(carrito1.Comprador, DateTime.Now, carrito1);
            Console.WriteLine("\nSegunda Operacion carrito con varias Publicaciones ");
            Console.WriteLine(operacion2);


            FreeMarket.AddComprador(comprador1);
            FreeMarket.AddComprador(comprador2);
            FreeMarket.AddComprador(comprador3);

            FreeMarket.AddPublicacion(publicacion1);
            FreeMarket.AddPublicacion(publicacion2);
            FreeMarket.AddPublicacion(publicacion3);
            FreeMarket.AddPublicacion(publicacion4);
            FreeMarket.AddPublicacion(publicacion5);

            MostrarPublicaciones();
            MostrarCompradores();


        }

        private static void MostrarPublicaciones()
        {
            Console.WriteLine("\nLista de Publicaciones");
            foreach (Publicacion publicacion in FreeMarket.GetPublicaciones())
            {
                Console.WriteLine(publicacion);
            }

        }
        private static void MostrarCompradores()
        {

            Console.WriteLine("\nLista de Compradores");
            foreach (Comprador comprador in FreeMarket.GetCompradores())
            {
                Console.WriteLine(comprador);
                Console.WriteLine("\nOperaciones de Compradores\n");

                foreach (Operacion operacion in comprador.GetOperaciones())
                {
                    Console.WriteLine(operacion);
                }
            }

        }
    }
}
