using System.Text;

namespace Entidades
{
    public class Jugador
    {

        int dni;
        string nombre;
        int partidoJugados;
        float promedioDeGoles;
        float totalGoles;


        private Jugador()
        {
            this.dni = 0;
            this.partidoJugados = 0;
            this.totalGoles = 0;
            this.promedioDeGoles = 0;
        }   

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
       
        public Jugador(int dni, string nombre, int totalGoles, int partidoJugados) : this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidoJugados = partidoJugados; 
        }
        
        public float GetPromedioGoles()
        {
            if(partidoJugados == 0)
            {
                this.promedioDeGoles = 0;
            }
            else
            {
                this.promedioDeGoles = this.totalGoles / partidoJugados;
            }
            return this.promedioDeGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"DNI: {this.dni}");
            mensaje.AppendLine($"Nombre: {this.nombre}");
            mensaje.AppendLine($"Total Goles: {this.totalGoles}");
            mensaje.AppendLine($"Partidos Jugados: {this.partidoJugados}");
            mensaje.AppendLine($"Promedio de goles: {this.GetPromedioGoles()}");

            return mensaje.ToString();
        }

        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            return jugador1.dni == jugador2.dni;
        }

        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2); 
        }
    
        
        
    
    
    }

}