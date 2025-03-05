using System;

abstract class Animal
{
    public abstract void Sonido();
}

class Gato : Animal
{
    public override void Sonido()
    {
        Console.WriteLine("El gato maúlla");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Gato miGato = new Gato();
        miGato.Sonido(); // Salida: El gato maúlla
    }
}