using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo_Denuncias
{
    internal class ArchivoExpediente
    {
        // txt creado
        private static readonly string Ruta =
            Path.Combine(Application.StartupPath, "expedientes.txt");

        public static bool Existe()
        {
            return File.Exists(Ruta);
        }

        // Reescribe TODO el archivo con lo que hay en la lista (3 datos)
        public static void Guardar(List<Expediente> lista)
        {
            string[] lineas = new string[lista.Count];

            for (int i = 0; i < lista.Count; i++)
            {
                Expediente e = lista[i];
                lineas[i] = string.Join("|",
                    e.Codigo, e.FechaRegistro, e.DNI, Limpiar(e.Nombres),
                    e.Categoria, e.Distrito, e.Estado, Limpiar(e.Descripcion));
            }

            File.WriteAllLines(Ruta, lineas);
        }

        //Para el codigo (10001)
        public static string SiguienteCodigo()
        {
            int mayor = 10000;   // el primero será EXP-10001

            foreach (Expediente e in Cargar())
            {
                // "EXP-10003" -> 10003
                if (int.TryParse(e.Codigo.Replace("EXP-", ""), out int numero) && numero > mayor)
                {
                    mayor = numero;
                }
            }
            return "EXP-" + (mayor + 1);
        }

        // Lee el archivo y devuelve la lista de expedientes
        public static List<Expediente> Cargar()
        {
            List<Expediente> lista = new List<Expediente>();

            if (!File.Exists(Ruta)) return lista;

            foreach (string linea in File.ReadAllLines(Ruta))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                // leen una línea del txt y comprueban que esté completa.
                string[] c = linea.Split('|');
                if (c.Length != 8) continue;   

                lista.Add(new Expediente
                {
                    Codigo = c[0],
                    FechaRegistro = c[1],
                    DNI = c[2],
                    Nombres = c[3],
                    Categoria = c[4],
                    Distrito = c[5],
                    Estado = c[6],
                    Descripcion = c[7]
                });
            }
            return lista;
        }

        // Evita que un "|" o un salto de línea escrito por el usuario rompa el formato
        private static string Limpiar(string texto)
        {
            return (texto ?? "").Replace("|", "/").Replace("\r", " ").Replace("\n", " ");
        }

        //Busqueda para consulta de denunica
        public static Expediente BuscarPorCodigo(string codigo)
        {
            foreach (Expediente e in Cargar())
            {
                if (e.Codigo.ToUpper() == codigo.ToUpper())
                {
                    return e;
                }
            }
            return null;   // no existe
        }
    }
}
