using System;

class Animal
{
    public void Hablar()
    {
        Console.WriteLine("Este animal hace un sonido");
    }
}

class Perro : Animal
{
    public void Hablar()
    {
        Console.WriteLine("El perro ladra");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Perro miPerro = new Perro();
        miPerro.Hablar(); // Salida: El perro ladra
    }
}