using EjercicioLINQ1.Class;
using EjercicioLINQ1;
using System.Text.Json;
using System.IO;
using System;
using System.Collections.Generic;
internal class Program{
    private static void  Main(string[] args)
    {
        //Env.LoadDataProductos(Env.FileName,);
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
        List<Productos> prod = new()
        {
            p
        };
        Env.LoadDataProductos(Env.FileName,prod);

        string json = JsonSerializer.Serialize(Env.Productos, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText(Env.FileName, json);
    }
}