using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Archivo
    {
        string ruta_pregrado = "Registro_academico_pregrado.txt";
        string ruta_postgrado = "Registro_academico_posgrado.txt";

        public void GuardarArchivoPregrado(string datos)
        {
            StreamWriter sw = new StreamWriter(ruta_pregrado, true);
            sw.Write(datos);
            sw.Close();
        }
        public void GuardarArchivoPostgrado(string datos)
        {
            StreamWriter sw = new StreamWriter(ruta_postgrado, true);
            sw.Write(datos);
            sw.Close();
        }
    }
}
