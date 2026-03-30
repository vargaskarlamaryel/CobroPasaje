using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Creamos la ruta
        Ruta ruta = new Ruta("Santo Domingo - Santiago", 155.0);

        // Creamos los dos autobuses
        AutoBusPlatinum platinum = new AutoBusPlatinum();
        AutoBusGold gold = new AutoBusGold();

        // Vendemos pasajes
        platinum.VenderPasaje(5);
        gold.VenderPasaje(3);

        // Mostramos el resultado
        Console.WriteLine($"Ruta: {ruta.GetNombre()} | Distancia: {ruta.GetDistanciaKm()} km");
        Console.WriteLine();
        platinum.MostrarInfo();
        gold.MostrarInfo();

        Console.ReadKey();
    }
}