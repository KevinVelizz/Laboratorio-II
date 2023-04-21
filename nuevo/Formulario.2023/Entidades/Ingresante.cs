using System.Text;

namespace Entidades
{
    public class Ingresante
    {
        string[] cursos;
        string direccion;
        double edad;
        string genero;
        string nombre;
        string pais;

        public Ingresante(string[] cursos, string direccion, double edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }       

        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"Nombre: {this.nombre}");
            mensaje.AppendLine($"Dirección: {this.direccion}");
            mensaje.AppendLine($"Edad: {this.edad}");
            mensaje.AppendLine($"Género: {this.genero}");
            mensaje.AppendLine($"País: {this.pais}");
            mensaje.AppendLine($"Curso/s:");

            for ( int i = 0;  i < cursos.Length; i++ )
            {
                mensaje.AppendLine($"{this.cursos[i]}");
            }
            return mensaje.ToString();
        }
    }
}