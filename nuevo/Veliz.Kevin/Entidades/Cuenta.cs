using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuenta
    {
        string titular;
        decimal cantidad;
        
        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string obtenerValorTitular()
        {
            return titular;
        }

        public decimal obtenerValorCantidad()
        {
            return cantidad;
        }

        public string mostrar()
        {
            return $"Nombre: {obtenerValorTitular()} | Cantidad: ${this.obtenerValorCantidad()}";
        }

        public bool ingresar(int monto)
        {
            bool retorno = false;

            if(monto > 0 )
            {
                this.cantidad += monto;
                retorno = true;
            }
            return retorno;
        }


        public bool retirar(int monto) 
        {
            this.cantidad -= monto;

            return true;
        }


    }
}
