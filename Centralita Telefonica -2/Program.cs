using System;
using System.Collections.Generic;

namespace CentralitaTelefonica
{
    
    public abstract class Llamada
    {
        public string NumOrigen { get; set; }
        public string NumDestino { get; set; }
        public double Duracion { get; set; }

        public Llamada(string numOrigen, string numDestino, double duracion)
        {
            NumOrigen = numOrigen;
            NumDestino = numDestino;
            Duracion = duracion;
        }

        public abstract double CalculatePrecio();
    }

    
    public class LlamadaLocal : Llamada
    {
        private const double PrecioPorSegundo = 0.15;

        public LlamadaLocal(string numOrigen, string numDestino, double duracion)
            : base(numOrigen, numDestino, duracion)
        {
        }

        public override double CalculatePrecio()
        {
            return Duracion * PrecioPorSegundo;
        }

        public override string ToString()
        {
            return $"Llamada Local - Origen: {NumOrigen}, Destino: {NumDestino}, Duración: {Duracion} segundos, Coste: {CalculatePrecio()} euros";
        }
    }

    
    public class LlamadaProvincial : Llamada
    {
        private static readonly double[] PreciosPorFranja = { 0.20, 0.25, 0.30 };
        public int Franja { get; set; }

        public LlamadaProvincial(string numOrigen, string numDestino, double duracion, int franja)
            : base(numOrigen, numDestino, duracion)
        {
            Franja = franja;
        }

        public override double CalculatePrecio()
        {
            if (Franja < 1 || Franja > 3)
            {
                throw new ArgumentException("La franja debe ser 1, 2 o 3.");
            }
            return Duracion * PreciosPorFranja[Franja - 1];
        }

        public override string ToString()
        {
            return $"Llamada Provincial - Origen: {NumOrigen}, Destino: {NumDestino}, Duración: {Duracion} segundos, Franja: {Franja}, Coste: {CalculatePrecio()} euros";
        }
    }

    
    public class Centralita
    {
        private int contadorLlamadas;
        private double facturacionTotal;
        private List<Llamada> llamadas;

        public Centralita()
        {
            llamadas = new List<Llamada>();
        }

        public void RegistrarLlamada(Llamada llamada)
        {
            llamadas.Add(llamada);
            contadorLlamadas++;
            facturacionTotal += llamada.CalculatePrecio();
        }

        public int GetTotalLlamadas()
        {
            return contadorLlamadas;
        }

        public double GetTotalFacturacion()
        {
            return facturacionTotal;
        }

        public void MostrarLlamadas()
        {
            foreach (var llamada in llamadas)
            {
                Console.WriteLine(llamada.ToString());
            }
        }
    }

    
    class Practica2
    {
        static void Main(string[] args)
        {
            Centralita centralita = new Centralita();

            
            centralita.RegistrarLlamada(new LlamadaLocal("325674564", "745997231", 120));
            centralita.RegistrarLlamada(new LlamadaProvincial("123456789", "987654321", 180, 1));
            centralita.RegistrarLlamada(new LlamadaProvincial("324587195", "657884357", 240, 2));

            
            centralita.MostrarLlamadas();

        
            Console.WriteLine($"Total de llamadas: {centralita.GetTotalLlamadas()}");
            Console.WriteLine($"Facturación total: {centralita.GetTotalFacturacion()} euros");
        }
    }
}