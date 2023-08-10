
namespace EjercicioLINQ1.Class;

    public class Productos
    {
        public string Id { get; set;}
        public string Nombre { get; set;}
        public int Stock { get; set;}
        public int StockMin { get; set;}
        public int StockMax { get; set;}
        public double PrecioVenta{ get; set;}
        public double PrecioCompra { get; set;}
        public int IdCategoria { get; set;}

        public Productos()
        {
            if(!File.Exists(Env.FileName)){
                File.WriteAllText(Env.FileName, "");
            }
        }

        public Productos(string id, string nombre, int stock, int stockMin, int stockMax, double precioVenta, double precioCompra, int idCategoria){
            this.Id = id;
            this.Nombre = nombre;
            this.Stock = stock;
            this.StockMin = stockMin;
            this.StockMax = stockMax;
            this.PrecioVenta = precioVenta;
            this.PrecioCompra = precioCompra;
            this.IdCategoria = idCategoria;
        }

        public Productos AgregarNuevoProducto(List<Categorias> categorias){
            Console.Clear();

            Categorias cate = new();
            cate.MostrarCategorias(categorias);
            Console.WriteLine("Ingrese el Id de la categoria");
            int idCategoria = int.Parse(Console.ReadLine());

            bool rest = cate.ValidarId(categorias, idCategoria);
            if (rest){
                Console.WriteLine("Agregando Nueva Categoria");
                Console.WriteLine("Ingrese el id del producto");
                string id = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del producto");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el stock del producto");
                int stock = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el stock minimo del producto");
                int stockMin = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el stock maximo del producto");
                int stockMax = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el precio venta del producto");
                int precioVenta = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el precio de compra del producto");
                int precioCompra = int.Parse(Console.ReadLine());
                Productos prod = new (id,nombre,stock,stockMin,stockMax,precioVenta,precioCompra,idCategoria);
                return prod;
            }else {
                Console.WriteLine("Id Categoria Invalido");
                Console.ReadKey();
                
                return AgregarNuevoProducto(categorias);
            }

        }
    }
