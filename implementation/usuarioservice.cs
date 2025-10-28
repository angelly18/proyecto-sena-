using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using mi_proyecto_sena.Data;
using mi_proyecto_sena.Models;
using mi_proyecto_sena.services;

namespace mi_proyecto_sena.implementation
{
    public class usuarioservice : Iusuarioservice
    {
        private readonly DBcontext dBcontext;
        public void crearUsuario(usuarioModel usuario)
        {
            throw new NotImplementedException();
        }
        public usuarioservice(DBcontext dBcontext)
        {
            this.dBcontext = dBcontext;
        }
    }

}