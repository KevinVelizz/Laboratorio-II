namespace Entidades
{
    public delegate void DelegadoString(string msg);

    public class Persona
    {
        private string nombre;
        private string apellido;
        public event DelegadoString EventoString;
        
        public Persona()
        {
            
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; this.EventoString("Guardó correctamente los datos."); }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public string Mostrar()
        {
            return $"{this.nombre} {this.apellido}";
        }
    }
}