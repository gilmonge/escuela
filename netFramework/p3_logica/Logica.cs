using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace p3_logica
{
    public class Logica
    {

        public static string getEstudiantes()
        {
            List<p1_Entity.Estudiante> estudiantes = p2_conexion.Conexion.GetEstudiantes();

            string jsonString = JsonConvert.SerializeObject(estudiantes, Formatting.Indented);

            return jsonString;
        }
        public static string getEstudiante(int id)
        {
            p1_Entity.Estudiante estudiante = p2_conexion.Conexion.GetEstudiante(id);

            string jsonString = JsonConvert.SerializeObject(estudiante, Formatting.Indented);

            return jsonString;
        }
        public static void postEstudiante(p1_Entity.EstudiantePutPost estudianteJson)
        {

            p1_Entity.Estudiante estudiante = new p1_Entity.Estudiante();

            estudiante.nombre = estudianteJson.nombre;
            estudiante.primer_apellido = estudianteJson.primer_apellido;
            estudiante.segundo_apellido = estudianteJson.segundo_apellido;
            estudiante.edad = estudianteJson.edad;

            p2_conexion.Conexion.PostEstudiante(estudiante);
        }
        public static void putEstudiante(int id, p1_Entity.EstudiantePutPost estudianteJson)
        {
            p1_Entity.Estudiante estudiante = p2_conexion.Conexion.GetEstudiante(id);

            estudiante.nombre = estudianteJson.nombre;
            estudiante.primer_apellido = estudianteJson.primer_apellido;
            estudiante.segundo_apellido = estudianteJson.segundo_apellido;
            estudiante.edad = estudianteJson.edad;

            p2_conexion.Conexion.PutEstudiante(estudiante);
        }
        public static void deleteEstudiante(int id)
        {
            p2_conexion.Conexion.DeleteEstudiante(id);
        }
    }
}
