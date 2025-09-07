using GestorRestaurantePII2025.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorRestaurantePII2025.Models
{
    public class Platillo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int CategoriaId { get; set; }

        public string CategoriaNombre
        {
            get
            {
                Categoria categoria = DBTemporal.Categorias.Find( c => c.Id == this.CategoriaId );
                return categoria != null ? categoria.Nombre : "Sin Categoría";
            }
        }
    }
}
