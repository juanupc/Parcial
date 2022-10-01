using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Alumno
    {
        public static int contador = 0;

        private int id;
        private int noDocumento;
        private string nombre;
        private string apellido;
        private int semestre;


        public Alumno()
        {
            ++contador;
            this.id = contador;
        }
        
        public Alumno(int id,int noDocumento,string nombre, string apellido, int semestre)
        {
            this.Id = id;
            this.NoDocumento = noDocumento;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Semestre = semestre;
        }

        public int Id {get => id; set => id = value; }
        public int NoDocumento { get => noDocumento; set => noDocumento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Semestre { get => semestre; set => semestre = value; }

        public string MuestraAlumnosAtrivutos()
        {
            return "Id: " + this.id + " NoDocumento: " + this.noDocumento + " Nombre: " + this.Nombre + " Apellido: " + this.apellido + " Semestre: " + this.semestre;
        }
    }
}
