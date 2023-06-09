﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lavadero
    {
        List<Vehiculo> vehiculos;
        float precioAuto;
        float precioCamion;
        float precioMoto;

        private Lavadero()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto) :this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }

        public string Detalle()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Precio auto: {this.precioAuto}");
            mensaje.AppendLine($"Precio camion: {this.precioCamion}");
            mensaje.AppendLine($"Precio moto: {this.precioMoto}");
            foreach (Vehiculo vehiculo in  vehiculos)
            {
                vehiculo.ToString();
                //if (vehiculo is Auto)
                //{
                //    ((Auto)vehiculo).MostrarAuto(); 
                //}
                //else if (vehiculo is Moto)
                //{
                //    ((Moto)vehiculo).MostrarMoto();
                //}
                //else if (vehiculo is Camion)
                //{
                //    ((Camion)vehiculo).MostrarCamion();
                //}
            }
            return mensaje.ToString();
        }

        public List<Vehiculo> Vehiculos
        {
            get { return vehiculos; }
        }

        public double MostrarTotalFacturado()
        {
            double total = 0;
   
            foreach (Vehiculo vehiculo in this.vehiculos)
            {
                if (vehiculo is Auto)
                {
                    total += this.precioAuto;
                }
                else if(vehiculo is Camion)
                {
                    total += this.precioCamion;
                }
                else
                {
                    total += this.precioMoto;
                }
            }
            return total;
        }

        public double MostrarTotalFacturado(EVehiculos eVehiculos)
        {
            double total = 0;
            foreach (Vehiculo vehiculo in this.vehiculos)
            {
                if (vehiculo is Auto && eVehiculos == EVehiculos.Auto)
                {
                    total += this.precioAuto;
                }
                else if (vehiculo is Camion && eVehiculos == EVehiculos.Camion)
                {
                    total += this.precioCamion;
                }
                else if (vehiculo is Moto && eVehiculos == EVehiculos.Moto)
                {
                    total += this.precioMoto;
                }
            }
            return total;
        }

        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            bool encontro = false;
            foreach (Vehiculo vehiculoLav in lavadero.Vehiculos)
            {
                if(vehiculoLav == vehiculo)
                {
                    encontro = true;
                    break;
                }
            }
            return encontro;
        }

        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {
            return !(lavadero == vehiculo);
        }

        public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
        {
            if(lavadero != vehiculo)
            {
                lavadero.vehiculos.Add(vehiculo);
            }
            return lavadero;
        }

        public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            if(lavadero == vehiculo)
            {
                lavadero.vehiculos.Remove(vehiculo);
            }
            return lavadero;
        }

        //public static int operator |(Lavadero lavadero, Vehiculo vehiculo)
        //{
        //    int index = -1;
        //    foreach (Vehiculo vehiculoLav in lavadero.Vehiculos)
        //    {
        //        index++;
        //        if (vehiculoLav == vehiculo)
        //        {
        //            lavadero.vehiculos[index] = vehiculo;
        //        }
        //    }  
        //    return index;
        //}

        public static int OrdenarVehiculosPorPatente(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return String.Compare(vehiculo1.Patente, vehiculo2.Patente);
        }

        public static int OrdenarVehiculoPorMarca(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            string marca1 = vehiculo1.Marca.ToString();
            string marca2 = vehiculo2.Marca.ToString();
            return String.Compare(marca1, marca2);
        }

    }
}
