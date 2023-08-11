namespace EjercicioLINQ1;
using EjercicioLINQ1.Class;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

public static class Env
    {
        private static string fileName = "productos.json";
        private static List<Productos> productos = new();

        public static string FileName { get => fileName; set => fileName = value; }
        public static List<Productos> Productos { get => productos; set => productos = value; }
        
        public static void LoadDataProductos(string nombreArchivo, List<Productos> listProducts)
        {
            if (!File.Exists(nombreArchivo))
            {
                File.WriteAllText(nombreArchivo, "");
                Productos = listProducts;
                return;
            }

            try
            {
                using (StreamReader reader = new StreamReader(nombreArchivo))
                {
                    string json = reader.ReadToEnd();
                    if (!string.IsNullOrEmpty(json))
                    {
                        Productos = JsonSerializer.Deserialize<List<Productos>>(json, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        }) ?? new List<Productos>();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while loading data: " + ex.Message);
            }
        }


/* 
if (!File.Exists(nombreArchivo))
            {
                File.WriteAllText(nombreArchivo, "");
                Productos = listProducts;
                return;
            }

            using (StreamReader reader = new StreamReader(nombreArchivo))
            {
                string json = reader.ReadToEnd();
                Productos = JsonSerializer.Deserialize<List<Productos>>(json, new JsonSerializerOptions() 
                { PropertyNameCaseInsensitive = true }) ?? new List<Productos>();
            }


if (!File.Exists(nombreArchivo))
    {
        File.WriteAllText(nombreArchivo, "");
        Productos = listProducts;
        return;
    }

    try
    {
        using (StreamReader reader = new StreamReader(nombreArchivo))
        {
            string json = reader.ReadToEnd();
            if (!string.IsNullOrEmpty(json))
            {
                Productos = JsonSerializer.Deserialize<List<Productos>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }) ?? new List<Productos>();
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error while loading data: " + ex.Message);
    }
 */
    }
