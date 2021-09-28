using System;

namespace GestionFinca.App.Dominio
{
    public class Finca
    {
        public int Id  { set; get; }
        public string  Nombre {set; get;}
        public string  Ubicacion {set; get;} 
        public int  Lotes {set; get;}
        public int  CantProdSembrados {set; get;}
        public Lote lote {set; get;}
        public Inventario inventario {set; get;} 
    }
}