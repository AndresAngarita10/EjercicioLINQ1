

namespace EjercicioLINQ1.View;

    public class VistaPrincipal
    {
        public VistaPrincipal(){}

        public int MenuPrincipal(){
            Console.Clear();
            Console.WriteLine("Bienvenido a Super Tienda ABS");
            Console.WriteLine("Seleccione una opcion\n");
            Console.WriteLine("1. Registrar Producto");
            Console.WriteLine("2. Registrar Categoria");
            Console.WriteLine("3. Listar Categorias");
            Console.WriteLine("4. Listar Productos");
            Console.WriteLine("5. Costo total del inventario");
            Console.WriteLine("6. salir");
            return int.Parse(Console.ReadLine());
        }
    }
