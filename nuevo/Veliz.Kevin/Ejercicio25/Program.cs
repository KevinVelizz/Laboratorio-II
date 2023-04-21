using veterinaria;
internal class Program
{
    private static void Main(string[] args)
    {
        Cliente cliente = new Cliente("Kevin", "Veliz", "45 e/ 123 y 124 n°5029", 1159308534);
        Mascota mascota = new Mascota("caniche", "Franco", DateTime.Now);
        Mascota mascota2 = new Mascota("bull dog", "Tomas", DateTime.Now);

        cliente.AgregarMascotas(mascota);
        cliente.AgregarMascotas(mascota2);

        mascota.AgregarVacunas("Antitetanica");

        Console.WriteLine(cliente.Mostrar());
        cliente.GetMascotas();
    }
}