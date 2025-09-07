using GestorRestaurantePII2025.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorRestaurantePII2025.Data
{
    public static class DBTemporal
    {
        private static int siguienteIdCategoria = 1;
        private static int siguienteIdPlatillo = 1;
        public static List<Categoria> Categorias { get; private set; } = new List<Categoria>();
        public static List<Platillo> Platillos { get; private set; } = new List<Platillo>();
        public static void CargarDatosIniciales() //datos de ejemplo para pruebas si no existen previos
        {
            if (Categorias.Count == 0)
            {
                AgregarCategoria("Entradas");
                AgregarCategoria("Platos Principales");
                AgregarCategoria("Postres");
                AgregarCategoria("Bebidas");
            }

            if (Platillos.Count == 0)
            {
                AgregarPlatillo("Ensalada César", 35.00m, 1);
                AgregarPlatillo("Sopa de Tortilla", 40.50m, 1);
                AgregarPlatillo("Lomito a la Parrilla", 120.00m, 2);
                AgregarPlatillo("Pepián", 65.00m, 2);
                AgregarPlatillo("Flan de la casa", 25.00m, 3);
                AgregarPlatillo("Limonada natural", 20.00m, 4);
            }
        }
        public static void AgregarCategoria(string nombre)
        {
            Categorias.Add(new Categoria { Id = siguienteIdCategoria++, Nombre = nombre });
        }

        public static void EditarCategoria(int id, string nuevoNombre)
        {
            Categoria categoria = Categorias.Find(c => c.Id == id);
            if (categoria != null)
            {
                categoria.Nombre = nuevoNombre;
            }
        }

        public static void EliminarCategoria(int id)
        {
            Categorias.RemoveAll(c => c.Id == id);
        }
        public static void AgregarPlatillo(string nombre, decimal precio, int categoriaId)
        {
            Platillos.Add(new Platillo { Id = siguienteIdPlatillo++, Nombre = nombre, Precio = precio, CategoriaId = categoriaId });
        }

        public static void EditarPlatillo(int id, string nuevoNombre, decimal nuevoPrecio, int nuevaCategoriaId)
        {
            Platillo platillo = Platillos.Find(p => p.Id == id);
            if (platillo != null)
            {
                platillo.Nombre = nuevoNombre;
                platillo.Precio = nuevoPrecio;
                platillo.CategoriaId = nuevaCategoriaId;
            }
        }

        public static void EliminarPlatillo(int id)
        {
            Platillos.RemoveAll(p => p.Id == id);
        }
    }
}
