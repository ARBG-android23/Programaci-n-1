using System;
using System.Collections.Generic;

class Llamada
{
    public string NumeroOrigen { get; set; }
    public string NumeroDestino { get; set; }
    public int Duracion { get; set; }
    public double Costo { get; set; }
    
    public Llamada(string numeroOrigen, string numeroDestino, int duracion, double costo)
    {
        NumeroOrigen = numeroOrigen;
        NumeroDestino = numeroDestino;
        Duracion = duracion;
        Costo = costo;
    }
}

class Centralita
{
    private List<Llamada> llamadas = new List<Llamada>();
    
    public void RegistrarLlamada(string origen, string destino, int duracion, double costo)
    {
        if (string.IsNullOrWhiteSpace(origen) || string.IsNullOrWhiteSpace(destino) || duracion <= 0 || costo < 0)
        {
            Console.WriteLine("Error: Datos inválidos para la llamada.");
            return;
        }
        
        Llamada nuevaLlamada = new Llamada(origen, destino, duracion, costo);
        llamadas.Add(nuevaLlamada);
        Console.WriteLine("Llamada registrada exitosamente.");
    }
    
    public void MostrarLlamadas()
    {
        if (llamadas.Count == 0)
        {
            Console.WriteLine("No hay llamadas registradas.");
            return;
        }

        Console.WriteLine("Registro de llamadas:");
        foreach (var llamada in llamadas)
        {
            Console.WriteLine($"Origen: {llamada.NumeroOrigen}, Destino: {llamada.NumeroDestino}, Duración: {llamada.Duracion} segundos, Costo: ${llamada.Costo:F2}");
        }
    }
}

class Program
{
    static void Main()
    {
        Centralita centralita = new Centralita();
        
        centralita.RegistrarLlamada("8091234567", "8297654321", 120, 5.75);
        centralita.RegistrarLlamada("8499876543", "8291122334", 90, 4.25);
        centralita.RegistrarLlamada("", "8291122334", 90, 4.25); 
        
        centralita.MostrarLlamadas();
    }
}
