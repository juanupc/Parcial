using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Postgrado : Alumno
    {
        private string programaPostgrado;
        private double promedioSemestre;

        public Postgrado()
        {

        }

        public Postgrado(int noDocumento, string nombre,string apellido,string programaPostgrado,int semestre,double promedioSemestre)
        {
            NoDocumento = noDocumento;
            Nombre = nombre;
            Apellido = apellido;
            this.ProgramaPostgrado = programaPostgrado;
            Semestre = semestre;
            this.PromedioSemestre = promedioSemestre;
        }
        public string ProgramaPostgrado { get => programaPostgrado; set => programaPostgrado = value;}
        public double PromedioSemestre { get => promedioSemestre; set => promedioSemestre = value;}

        public string MuestraAlumnosPostgrado()
        {
            string binnacle = String.Format("Alumno(Postgrado) NoDocumento: {0} » Nombre: {1} » Apellido: {2} » Programa Pregado: {3} » Semestre: {4} » Promedio Semestre: {5}", NoDocumento,Nombre,Apellido, programaPostgrado, Semestre,promedioSemestre);

            return MuestraAlumnosAtrivutos() + "Programa Postgrado " + programaPostgrado + "Promedio semestre " + promedioSemestre;
        }
    }
}