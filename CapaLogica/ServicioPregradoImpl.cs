using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaLogica
{
    public class ServicioPregradoImpl : IServicioPregrado
    {
        public static List<Pregrado> AlumnosPregrado = new List<Pregrado>();

        public string Crear(Pregrado alumnoPregrado)
        {
            AlumnosPregrado.Add(alumnoPregrado);
            return "Alumno agregado exitosamente";
        }
        public string Eliminar(Pregrado alumnoPregrado)
        {
            AlumnosPregrado.Remove(alumnoPregrado);
            return "Alumno agregado exitosamente";
        }
        public void Leer()
        {
            foreach (var item in AlumnosPregrado)
            {
                Console.WriteLine(item.MuestraAlumnosPregados());
            }
        }
        public string Actualizar(Pregrado alumnoPregrado, int idpregrado)
        {
            string mensaje = "";

            if(idpregrado == alumnoPregrado.Id)
            {
                AlumnosPregrado.Remove(alumnoPregrado);
                mensaje = "Alumno actualizado exitosamente";
            }
            else
            {
                mensaje = "El alumno no se pudo encontrar en el sistema";
            }
            return mensaje;
        }
    }
}
