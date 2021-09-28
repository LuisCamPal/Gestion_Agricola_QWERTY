using System;
namespace GestionFinca.App.Dominio 
{
    public class Inventario 
    {
        public int Id {get;set;}
        public FertilizanteEnmienda fertilizanteEnmienda {get;set;}
        public Material material {get;set;}
        public Agroquimico agroquimico {get;set;}
        public float existencias {get;set;}
    }
}
