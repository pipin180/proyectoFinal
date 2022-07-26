﻿/*
Se deben crear las clases que servirán de modelo para su proyecto final. 
Hacer las clases con las propiedades que se les indican con sus respectivos tipos de datos.

Clase: Usuario;
Propiedades: Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail
Clase: Producto;
Propiedades: Id, Descripcion, Costo, PrecioVenta, Stock, IdUsuario
Clase: ProductoVendido;
Propiedades: Id, IdProducto, Stock, IdVenta
Clase: Venta;
Propiedades: Id, Comentarios

*/

namespace Entregable1
{

    public class Usuario
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String NombreUsuario { get; set; }
        public String Contrasena { get; set; }
        public String Mail { get; set; }
    }

    public class Producto
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public float Costo { get; set; }
        public float PrecioVenta { get; set; }
        public int Stock { get; set; }
    }

    public class ProductoVendido
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int Stock { get; set; }
        public int IdVenta { get; set; }
    }

    public class Venta
    {
        public int Id { get; set; }
        public String Comentarios { get; set; }
    }


}