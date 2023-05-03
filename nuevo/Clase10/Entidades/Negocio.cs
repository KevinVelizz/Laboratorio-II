using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        PuestoAtencion _caja;
        List<Cliente> _clientes;
        string _nombre;


        Negocio()
        {
            this._clientes = new List<Cliente>();
            this._caja = new PuestoAtencion(Puesto.Caja1);
        }

        public Negocio(string nombre)
        {
            this._nombre = nombre;
        }


        public static bool operator ==(Negocio n, Cliente c)
        {
            return n.Cliente == c;
            
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;

            if (n == c)
            {
                n._clientes.Add(c);
                retorno = true;
            }

            return retorno;
        }

        public Cliente Cliente
        {
            get
            {
                Cliente? aux = null;

                if (this._clientes.Count != 0)
                {
                    foreach (Cliente cliente in this._clientes)
                    {
                        return cliente;
                    }
                }
                return aux;
            }
            set
            {
                foreach (Cliente cliente in this._clientes)
                {
                    if (cliente == value)
                    {
                        this._clientes.Add(value);
                    }
                }
            }
        }
    }
}

