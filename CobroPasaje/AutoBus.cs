// Clase base que representa un autobús genérico

using System;

abstract class AutoBus
{
    private string tipo;
    private double precioPasaje;
    private int asientosDisponibles;
    private double totalVentas;

    public AutoBus(string tipo, double precioPasaje, int asientosDisponibles)
    {
        this.tipo = tipo;
        this.precioPasaje = precioPasaje;
        this.asientosDisponibles = asientosDisponibles;
        this.totalVentas = 0;
    }

    // Vende pasajes y acumula el total de ventas
    public void VenderPasaje(int cantidad)
    {
        if (cantidad > asientosDisponibles)
        {
            Console.WriteLine($"No hay suficientes asientos disponibles en {tipo}.");
            return;
        }

        asientosDisponibles -= cantidad;
        totalVentas += cantidad * precioPasaje;
    }

    public string GetTipo()
    {
        return tipo;
    }

    public double GetTotalVentas()
    {
        return totalVentas;
    }

    public int GetAsientosDisponibles()
    {
        return asientosDisponibles;
    }

    public abstract void MostrarInfo();
}