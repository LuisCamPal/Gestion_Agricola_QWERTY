using System;

namespace GestionFinca.App.Dominio
{
    public class Lote
    {
        public int Id  { set; get; }
        public int  Numero {set; get;}
        public int  CantidadPlantas {set; get;} 
        public string  TipoCultivo {set; get;}
        public string  Estado {set; get;}
        public Transaccion transaccion {set; get;} //Relación de asociación
    }
}