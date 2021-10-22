using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeatroRbD.Data;

namespace TeatroRbD.Controller
{
    class CUsuario
    {

        public static DataTable Validar_acceso(string usuario, string contraseña)
        {
            return new DUsuario().Validar_acceso(usuario, contraseña);
        }

    }
}
