
namespace EjercicioLINQ1.Class;

    public class Categorias
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Categorias(){}
        public Categorias(int id, string descripcion)
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }

        public void AgregarCategoria(){
            Console.Clear();
            Console.WriteLine("Agregando Nueva Categoria");
            Console.WriteLine("Ingrese el id de la categoria");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la descripcion de la categoria");
            string descipcion = Console.ReadLine();
            Categorias cate = new(id, descipcion);
        }

        public bool ValidarId(List<Categorias> categorias ,int idValidar){
            var filteredResult = from s in categorias
                    where s.Id == idValidar
                    select s;
            //bool a =  categorias.Contains(idValidar);
            if(filteredResult.Any()){
                return true;
            }else{
                return false;
            }

        }

        public List<Categorias> ValidarIdRetornando(List<Categorias> categorias ,int idValidar){
            List<Categorias> categori = new();
            var filteredResult = from s in categorias
                    where s.Id == idValidar
                    select s;
            foreach (Categorias cate in filteredResult)
            {
                categori.Add(cate);
            }
            return categori;

        }
        public void MostrarCategorias(List<Categorias> categorias){
            Console.WriteLine("Mostrar categorias");
            var orderByResult = from s in categorias
                            orderby s.Id//s.StudentName, s.Age
                            select new{ s.Id, s.Descripcion };
                            
            foreach (var std in orderByResult)
                    Console.WriteLine($"ID:{std.Id} - {std.Descripcion}"); 
        }
    }
