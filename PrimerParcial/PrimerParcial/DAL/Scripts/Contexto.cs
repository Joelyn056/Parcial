using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using PrimerParcial.Entidades;

namespace PrimerParcial.DAL.Scripts
{
    public class Contexto : DbContext
    {
        public DbSet<Grupos> grupos { get; set; }

        public Contexto() : base("ConStr")
         {  }
  
    }
}
