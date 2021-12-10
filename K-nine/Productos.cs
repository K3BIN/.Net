using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace K_nine
{
    public class Productos
    {
        private int id;
        private string producto;
        private int cantidad;
        private string marca;
        private int precio;



        public Productos(int id, string producto, int cantidad, string marca, int precio)
        {
            this.Id = id;
            this.Producto = producto;
            this.Cantidad = cantidad;
            this.Marca = marca;
            this.Precio = precio;
        }
        public int Id { get => id; set => id = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Precio { get => precio; set => precio = value; }
    }
}