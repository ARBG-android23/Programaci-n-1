using System;
using System.Collections.Generic;

class Hamburguesa
{
    public string TipoPan { get; private set; }
    public string TipoCarne { get; private set; }
    public double PrecioBase { get; private set; }
    protected List<(string, double)> IngredientesAdicionales;
    protected int MaxIngredientes;
    
    public Hamburguesa(string tipoPan, string tipoCarne, double precioBase, int maxIngredientes = 4)
    {
        TipoPan = tipoPan;
        TipoCarne = tipoCarne;
        PrecioBase = precioBase;
        MaxIngredientes = maxIngredientes;
        IngredientesAdicionales = new List<(string, double)>();
    }
    
    public bool AgregarIngrediente(string nombre, double precio)
    {
        if (IngredientesAdicionales.Count < MaxIngredientes)
        {
            IngredientesAdicionales.Add((nombre, precio));
            return true;
        }
        return false;
    }
    
    public virtual void MostrarPrecioFinal()
    {
        double total = PrecioBase;
        Console.WriteLine($"Hamburguesa con pan {TipoPan} y carne {TipoCarne}");
        Console.WriteLine($"Precio base: {PrecioBase:C}");
        if (IngredientesAdicionales.Count > 0)
        {
            Console.WriteLine("Ingredientes adicionales:");
            foreach (var ingrediente in IngredientesAdicionales)
            {
                Console.WriteLine($"- {ingrediente.Item1}: {ingrediente.Item2:C}");
                total += ingrediente.Item2;
            }
        }
        Console.WriteLine($"Total a pagar: {total:C}\n");
    }
}

class HamburguesaSaludable : Hamburguesa
{
    public HamburguesaSaludable(string tipoCarne, double precioBase) 
        : base("Integral", tipoCarne, precioBase, 6) { }
}

class HamburguesaPremium : Hamburguesa
{
    public HamburguesaPremium(string tipoCarne, double precioBase) 
        : base("Brioche", tipoCarne, precioBase, 0)
    {
        IngredientesAdicionales.Add(("Papitas", 2.00));
        IngredientesAdicionales.Add(("Bebida", 3.00));
    }
}

class Program
{
    static void Main()
    {
        Hamburguesa clasica = new Hamburguesa("Blanco", "Res", 5.00);
        clasica.AgregarIngrediente("Lechuga", 0.50);
        clasica.AgregarIngrediente("Tomate", 0.75);
        clasica.MostrarPrecioFinal();
        
        HamburguesaSaludable saludable = new HamburguesaSaludable("Pollo", 6.50);
        saludable.AgregarIngrediente("Aguacate", 1.50);
        saludable.AgregarIngrediente("Espinaca", 1.00);
        saludable.MostrarPrecioFinal();
        
        HamburguesaPremium premium = new HamburguesaPremium("Angus", 8.00);
        premium.MostrarPrecioFinal();
    }
}

