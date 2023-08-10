using EjercicioLINQ1.Class;
using EjercicioLINQ1;
using Newtonsoft.Json;
internal class Program{
    private static void  Main(string[] args)
    {
        Productos p = new ();
        Guid idG = Guid.NewGuid();
        p.Id = idG.ToString();
        p.Nombre = "XXXXXX";
        p.PrecioVenta = 23000;
        p.PrecioCompra = 5000;
        p.Stock = 8;
        p.StockMin = 10;
        p.StockMax = 20;
        Env.Productos.Add (p);

        string json = JsonConvert.SerializeObject(Env.Productos, Formatting.Indented);
        File.WriteAllText(Env.FileName, json);
    }
}