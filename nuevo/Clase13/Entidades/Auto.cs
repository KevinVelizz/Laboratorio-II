namespace Entidades
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public Auto (string color, string marca)
        {
            _color = color;
            _marca = marca;
        }

        public string _Color
        {
            get { return _color; }
        }

        public string _Marca
        {
            get { return _marca; }
        }

        public static bool operator ==(Auto a, Auto b)
        {
            return a._Marca == b._Marca && a._Color == b._Color;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Auto)
            {
                if (this == (Auto)obj)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            return $"Marca: {this._color} - Color: {this._marca}";
        }

    }
}