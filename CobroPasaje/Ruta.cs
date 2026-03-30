// Clase que representa la ruta del autobús

class Ruta
{
    private string nombre;
    private double distanciaKm;

    public Ruta(string nombre, double distanciaKm)
    {
        this.nombre = nombre;
        this.distanciaKm = distanciaKm;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public double GetDistanciaKm()
    {
        return distanciaKm;
    }
}