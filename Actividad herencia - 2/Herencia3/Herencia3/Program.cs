using System;

class Persona
{
    public string Nombre { get; set; }

    public Persona(string nombre)
    {
        Nombre = nombre;
    }

    public void Presentarse()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre}");
    }
}

class Estudiante : Persona
{
    public string Grado { get; set; }

    public Estudiante(string nombre, string grado) : base(nombre)
    {
        Grado = grado;
    }

    public void Presentarse()
    {
        base.Presentarse();
        Console.WriteLine($"Estoy en el semestre {Grado}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Estudiante estudiante = new Estudiante("Aarón", "cinco");
        estudiante.Presentarse(); // Salida: Hola, mi nombre es Aarón \n Estoy en el semestre cinco
    }
}