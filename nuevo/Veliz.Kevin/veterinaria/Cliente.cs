using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria
{
    public class Cliente
    {
        string nombre;
        string apellido;
        string domicilio;
        int telefono;
        List<Mascota> mascotas = new List<Mascota>();


        public Cliente(string nombre, string apellido, string domicilio, int telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetApellido()
        {
            return apellido;
        }

        public string GetDomicilio()
        {
            return domicilio;
        }

        public int GetTelefono()
        {
            return telefono;
        }

        public void GetMascotas()
        {
            foreach (Mascota mascota in mascotas)
            {
                Console.WriteLine(mascota.Mostrar());
            }
        }

        public void AgregarMascotas(Mascota mascota)
        {
            mascotas.Add(mascota);
        }

        public string Mostrar()
        {
            return $"Nombre: {GetNombre()}\nApellido: {GetApellido()}\nDomicilio: {GetDomicilio()} Telefono: {GetTelefono()}";
        }
    
    }
}
