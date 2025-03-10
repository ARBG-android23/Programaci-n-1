using System;

namespace AvesPolimorfismo
{
    
    class Ave
    {
        public string Nombre { get; set; }
        public string Color { get; set; }

        public Ave(string nombre, string color)
        {
            Nombre = nombre;
            Color = color;
        }

        
        public virtual void HacerSonido()
        {
            Console.WriteLine("El ave hace un sonido.");
        }
    }

    
    class Gallina : Ave
    {
        public Gallina(string nombre, string color) : base(nombre, color) { }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} (Gallina) hace: ¡Coc, coc!");
        }
    }

    class Pato : Ave
    {
        public Pato(string nombre, string color) : base(nombre, color) { }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} (Pato) hace: ¡Cuac, cuac!");
        }
    }

    class Cotorra : Ave
    {
        public Cotorra(string nombre, string color) : base(nombre, color) { }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} (Cuervo) hace: ¡garg, grag!");
        }
    }

    class Guinea : Ave
    {
        public Guinea(string nombre, string color) : base(nombre, color) { }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} (Guinea) hace: ¡Kikirikí!");
        }
    }

    class PavoReal : Ave
    {
        public PavoReal(string nombre, string color) : base(nombre, color) { }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} (Pavo Real) hace: ¡Ah-ah-ah!");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            
            Ave[] aves = {
                new Gallina("Clara", "Blanco"),
                new Pato("Lucas", "Verde"),
                new Cotorra("Pepe", "Verde y amarillo"),
                new Guinea("Tito", "Gris"),
                new PavoReal("Rey", "Azul y verde")
            };

            foreach (var ave in aves)
            {
                ave.HacerSonido();
            }
        }
    }
}