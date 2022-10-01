using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    interface IServicioPostgrado
    {
        string Crear(Postgrado alumnoPostgrado);

        void Leer();

        string Actualizar(Postgrado alumnoPostgrado, int idpostgrado);

        string Eliminar(Postgrado alumnoPostgrado);
    }
}
