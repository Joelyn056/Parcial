using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimerParcial.Entidades;
using PrimerParcial.DAL;
using System.Linq.Expressions;
using PrimerParcial.DAL.Scripts;
using PrimerParcial.BLL;
using System.Threading.Tasks;


namespace PrimerParcial.BLL

{
    public class GrupoBLL
    {
        public static bool Guardar(Grupos grupos)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.grupos.Add(grupos) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }

                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static bool Modificar(Grupos grupos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(grupos).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                Grupos grupos = contexto.grupos.Find(id);

                contexto.grupos.Remove(grupos);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public static Grupos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Grupos grupos = new Grupos();
            try
            {
                grupos = contexto.grupos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return grupos;
        }


        public static List<Grupos> GetList(Expression<Func<Grupos, bool>> expression)
        {
            List<Grupos> grupos = new List<Grupos>();
            Contexto contexto = new Contexto();
            try
            {
                grupos = contexto.grupos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return grupos;
        }
    }
}

    }

   
