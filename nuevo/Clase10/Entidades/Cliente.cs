namespace Entidades
{
    public class Cliente
    {
        string _nombre;
        int _numero;


        public string Nombre
        {
            get { return this._nombre; }
        }

        public int Numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }


        public Cliente(int numero)
        {
            this._numero = numero;
        }

        public Cliente(int numero, string nombre) :this(numero)
        {
            this._nombre = nombre;  
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1._numero == c2._numero;
        }
    }
}