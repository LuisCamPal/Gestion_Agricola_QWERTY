using System;

namespace GestionFinca.App.Dominio
{
    public class Insumo
    {
        public int Id  { set; get; }
        public DateTime  FechaCompra {set; get;}
        public string  NombreProducto {set; get;} 
        public float  CantidadIngreso {set; get;}
        public float  CantidadSalida {set; get;}
        public string  UnidadMedida {set; get;}
        public float  Precio {set; get;}
        public string Responsable {set; get;}
    }
} 