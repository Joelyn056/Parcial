using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;



namespace PrimerParcial.Entidades
{
    public class Grupos
    {
        [Key]

        public int GruposID { get; set; }
        public string Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Cantidad { get; set; }
        public string Integrantes { get; set; }

        public Grupos()
        {
            GruposID = 0;
            Fecha = string.Empty;
            Descripcion = string.Empty;
            Cantidad = string.Empty;
            Integrantes = string.Empty;
            
             
        }

    }
}
