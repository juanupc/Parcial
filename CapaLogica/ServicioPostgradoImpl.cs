using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ServicioPostgradoImpl : IServicioPostgrado
    {
        public static List<Postgrado> AlumnosPostgrado = new List<Postgrado>();

        public string Crear(Postgrado alumnoPostgrado)
        {
            AlumnosPostgrado.Add(alumnoPostgrado);
            return "Contacto creado exitosamente";
        }
        public string Eliminar(Postgrado alumnoPostgrado)
        {
            AlumnosPostgrado.Remove(alumnoPostgrado);
            return "Contacto Eliminado exitosamente";
        }
        public void Leer()
        {
            foreach(var item in AlumnosPostgrado)
            {
                Console.WriteLine(item.MuestraAlumnosPostgrado());
            }
        }
        public string Actualizar(Postgrado alumnoPostgrado, int idpostgrado)
        {
            string mensaje = "";

            if(idpostgrado == alumnoPostgrado.Id)
            {
                AlumnosPostgrado.Remove(alumnoPostgrado);
                mensaje = "Alumno actualizado exitosamente";
            }
            else
            {
                mensaje = "El alumno no se encuentra registrado en nuestro sistema";
            }
            return mensaje;
        }
        
    }
}
