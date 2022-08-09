using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_conexion
{
    public class Conexion
    {
        public static List<p1_Entity.Estudiante> GetEstudiantes()
        {
            using (p1_Entity.EscuelaEntities db = new p1_Entity.EscuelaEntities())
            {
                return db.Estudiantes.ToList();
            }
        }
        public static p1_Entity.Estudiante GetEstudiante(int id)
        {
            using (p1_Entity.EscuelaEntities db = new p1_Entity.EscuelaEntities())
            {
                try
                {
                    return db.Estudiantes.Where(d => d.estudiante_id == id).First();
                }
                catch
                {
                    return new p1_Entity.Estudiante();
                }
            }
        }
        public static void PostEstudiante(p1_Entity.Estudiante estudiante)
        {
            using (p1_Entity.EscuelaEntities db = new p1_Entity.EscuelaEntities())
            {
                db.Estudiantes.Add(estudiante);
                db.SaveChanges();
            }
        }
        public static void PutEstudiante(p1_Entity.Estudiante estudiante)
        {
            using (p1_Entity.EscuelaEntities db = new p1_Entity.EscuelaEntities())
            {
                db.Entry(estudiante).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public static void DeleteEstudiante(int id)
        {
            using (p1_Entity.EscuelaEntities db = new p1_Entity.EscuelaEntities())
            {
                p1_Entity.Estudiante estudiante = GetEstudiante(id);
                db.Entry(estudiante).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
