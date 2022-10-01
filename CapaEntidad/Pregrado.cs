using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pregrado : Alumno
    {
        private string programaPregrado;
        private double promedioCorte1;
        private double promedioCorte2;
        private double promedioCorte3;
        public Pregrado()
        {

        }

        public Pregrado(int noDocumento,string nombre,string apellido,string programaPregrado, int semestre ,double promedioCorte1, double promedioCorte2, double promedioCorte3)
        {
            NoDocumento = noDocumento;
            Nombre = nombre;
            Apellido = apellido;
            this.ProgramaPregrado = programaPregrado;
            Semestre = semestre;
            this.PromedioCorte1 = promedioCorte1;
            this.PromedioCorte2 = promedioCorte2;
            this.PromedioCorte3 = promedioCorte3;
        }

        public string ProgramaPregrado { get => programaPregrado; set => programaPregrado = value;}
        public double PromedioCorte1 { get => promedioCorte1; set => promedioCorte1 = value; }
        public double PromedioCorte2 { get => promedioCorte2; set => promedioCorte2 = value; }
        public double PromedioCorte3 { get => promedioCorte3; set => promedioCorte3 = value; }

        public string MuestraAlumnosPregados()
        {
            string binnacle = String.Format("Alumno(Pregrado) NoDocumento:{0} » Nombre: {1} » Apellido: {2} » ProgramaPregrado: {3} » Semestre: {4} » PromedioCorte1: {5} » PromedioCorte2: {6} » PromedioCorte3: {7}", NoDocumento,Nombre,Apellido, programaPregrado, Semestre,promedioCorte1,promedioCorte2,promedioCorte3);
            new CapaDatos.Archivo().GuardarArchivoPregrado(binnacle);

            return MuestraAlumnosAtrivutos() + "Programa pregrado: " + programaPregrado + "Promedio Corte 1: " + promedioCorte1 + "Promedio Corte 2: " + promedioCorte2 + "Promedio Corte 3: " + promedioCorte3;
        }
    }
}
    