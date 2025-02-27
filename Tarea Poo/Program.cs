using System;

class Motor
{
    private int litros_de_aceite;
    private int potencia;

    public Motor(int potencia)
    {
        this.potencia = potencia;
        this.litros_de_aceite = 0;
    }

    public int GetLitrosDeAceite() => litros_de_aceite;
    public int GetPotencia() => potencia;
    public void SetLitrosDeAceite(int litros) => litros_de_aceite = litros;
    public void SetPotencia(int potencia) => this.potencia = potencia;
}

class Coche
{
    private Motor motor;
    private string marca;
    private string modelo;
    private double precioAcumulado;

    public Coche(string marca, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.motor = new Motor(100); // Motor con potencia predeterminada
        this.precioAcumulado = 0;
    }

    public string GetMarca() => marca;
    public string GetModelo() => modelo;
    public double GetPrecioAcumulado() => precioAcumulado;
    public Motor GetMotor() => motor; // Getter para el motor
    public void AcumularAveria(double importe) => precioAcumulado += importe;
}

class Garaje
{
    private Coche? coche; // Permitir valores nulos
    private string? averia;
    private int cochesAtendidos;

    public Garaje()
    {
        coche = null;
        averia = null;
        cochesAtendidos = 0;
    }

    public bool AceptarCoche(Coche nuevoCoche, string nuevaAveria)
    {
        if (coche != null) return false; // Si ya hay un coche, no se acepta otro

        coche = nuevoCoche;
        averia = nuevaAveria;
        cochesAtendidos++;

        // Si la avería es "aceite", incrementar los litros de aceite en 10
        if (nuevaAveria == "aceite")
        {
            coche.GetMotor().SetLitrosDeAceite(coche.GetMotor().GetLitrosDeAceite() + 10);
        }

        return true;
    }

    public void DevolverCoche()
    {
        coche = null;
        averia = null;
    }
}

class PracticaPOO
{
    static void Main()
    {
        Garaje garaje = new Garaje();
        Coche coche1 = new Coche("Toyota", "Corolla");
        Coche coche2 = new Coche("Honda", "Civic");

        Random rand = new Random();

        // Coche 1 entra dos veces al garaje
        if (garaje.AceptarCoche(coche1, "aceite"))
        {
            coche1.AcumularAveria(rand.Next(50, 200));
        }
        garaje.DevolverCoche();

        if (garaje.AceptarCoche(coche1, "frenos"))
        {
            coche1.AcumularAveria(rand.Next(50, 200));
        }
        garaje.DevolverCoche();

        // Coche 2 entra dos veces al garaje
        if (garaje.AceptarCoche(coche2, "motor"))
        {
            coche2.AcumularAveria(rand.Next(50, 200));
        }
        garaje.DevolverCoche();

        if (garaje.AceptarCoche(coche2, "aceite"))
        {
            coche2.AcumularAveria(rand.Next(50, 200));
        }
        garaje.DevolverCoche();

        // Mostrar información de los coches
        Console.WriteLine($"{coche1.GetMarca()} {coche1.GetModelo()} - Averías: {coche1.GetPrecioAcumulado()} USD - Litros de aceite: {coche1.GetMotor().GetLitrosDeAceite()}");
        Console.WriteLine($"{coche2.GetMarca()} {coche2.GetModelo()} - Averías: {coche2.GetPrecioAcumulado()} USD - Litros de aceite: {coche2.GetMotor().GetLitrosDeAceite()}");
    }
}