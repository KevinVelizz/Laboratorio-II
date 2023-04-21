using System.Text;

namespace Entidades
{
    public class Creadora
    {
        static DateTime fechaCreacionPrimerObjeto;
        static int contadorObjetosCreados;
        DateTime fechaCreacion;

        public int obtenerCantidadObjetosCreados()
        {
            return contadorObjetosCreados;
        }

        static Creadora()
        {
            Creadora.fechaCreacionPrimerObjeto = DateTime.Now;
            Creadora.contadorObjetosCreados = 0;
        }

        public Creadora()
        {
            fechaCreacion = DateTime.Now;
            Creadora.contadorObjetosCreados++;
        }

        public string ObtenerDiferencia()
        {
            StringBuilder sb = new StringBuilder();

            TimeSpan dif = this.fechaCreacion - Creadora.fechaCreacionPrimerObjeto;

            sb.AppendLine($"diferencia en milisigundos: {dif.Milliseconds}");

            return sb.ToString();
        }
    }
}