// AutoBus tipo Gold, hereda de AutoBus

using System;

class AutoBusGold : AutoBus
{
    public AutoBusGold() : base("Auto Bus Gold", 1333.00, 15) { }

    public override void MostrarInfo()
    {
        Console.WriteLine($"{GetTipo()} | " +
                          $"Pasajeros: {15 - GetAsientosDisponibles()} | " +
                          $"Ventas: {GetTotalVentas():N0} | " +
                          $"Quedan {GetAsientosDisponibles()} asientos disponibles");
    }
}