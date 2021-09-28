using System;

namespace GestionFinca.App.Dominio
{
    public class Transaccion
    {
        public int Id  { set; get; } //Id Transacción
        public float PrecioVenta {set; get;} 
        public int  CantidadProduccion {set; get;}
    }
}