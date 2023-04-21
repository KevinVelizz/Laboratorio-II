namespace veterinaria
{
    public class Mascota
    {
        string especie;
        string nombre;
        DateTime fechaDeNacimiento;
        List<string> historialVacunacion = new List<string>();


        public Mascota(string especie, string nombre, DateTime fechaDeNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }


        public string GetEspecie()
        {
            return this.especie;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public DateTime GetFechaDeNacimiento()
        {
            return fechaDeNacimiento;
        }

        public string GetHistoriaLVacunacion()
        {
            string retorno = "";

            for (int i = 0; i < this.historialVacunacion.LongCount(); i++)
            {
                retorno += historialVacunacion[i] + "\n";
            }

            return retorno;
        }

        public void AgregarVacunas(string vacuna)
        {
            historialVacunacion.Add(vacuna);
        }

        public string Mostrar()
        {
            return $"Nombre: {GetNombre()}\nEspecie: {GetEspecie()}\nFecha de Nacimiento: {GetFechaDeNacimiento()}\nHistorial de Vacunación: {GetHistoriaLVacunacion()}";
        }
    }
}