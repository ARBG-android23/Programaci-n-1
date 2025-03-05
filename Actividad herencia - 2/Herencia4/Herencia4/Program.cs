using System;

class Figura
{
    public virtual void Dibujar()
    {
        Console.WriteLine("Dibujando una figura genérica");
    }
}

class Circulo : Figura
{
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un círculo");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Figura miFigura = new Circulo();
        miFigura.Dibujar(); // Salida: Dibujando un círculo
    }
}