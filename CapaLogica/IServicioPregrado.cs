using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    interface IServicioPregrado
    {
        string Crear(Pregrado alumnoPregrado);

        void Leer();

        string Actualizar(Pregrado alumnoPregrado, int idpregrado);

        string Eliminar(Pregrado alumnoPregrado);
    }
}
