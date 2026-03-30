// AutoBus tipo Platinum, hereda de AutoBus

using System;

class AutoBusPlatinum : AutoBus
{
    public AutoBusPlatinum() : base("Auto Bus Platinum", 1000.00, 22) { }

    public override void MostrarInfo()
    {
        Console.WriteLine($"{GetTipo()} | " +
                          $"Pasajeros: {22 - GetAsientosDisponibles()} | " +
                          $"Ventas: {GetTotalVentas():N0} | " +
                          $"Quedan {GetAsientosDisponibles()} asientos disponibles");
    }
}