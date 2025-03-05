// See httpusing System;

class Vehiculo
{
    public string Marca { get; set; }

    public Vehiculo(string marca)
    {
        Marca = marca;
    }

    public void Arrancar()
    {
        Console.WriteLine("El vehículo ha arrancado");
    }
}

class Coche : Vehiculo
{
    public Coche(string marca) : base(marca) { }

    public void Arrancar()
    {
        base.Arrancar();
        Console.WriteLine("El coche está en movimiento");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Coche miCoche = new Coche("Toyota");
        miCoche.Arrancar(); // Salida: El vehículo ha arrancado \n El coche está en movimiento
    }
}