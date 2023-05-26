using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        int codigoUsuario;
        string userName;


        public Usuario(string userName, int codigoUsuario)
        {
            this.userName = userName;
            this.codigoUsuario = codigoUsuario;
        }

        public int CodigoUsuario
        {
            get { return codigoUsuario; }
        }

        public override string ToString()
        {
            return $"{userName}";
        }
    }
}
