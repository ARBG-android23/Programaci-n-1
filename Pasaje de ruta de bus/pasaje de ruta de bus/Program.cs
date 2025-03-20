using System;

namespace CobroPasajes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datos del Auto Bus Platinum
            string nombrePlatinum = "Auto Bus Platinum";
            int capacidadPlatinum = 22;
            double precioPlatinum = 1000.0;
            int pasajerosPlatinum = 0;
            double ventasPlatinum = 0.0;

            // Datos del Auto Bus Gold
            string nombreGold = "Auto Bus Gold";
            int capacidadGold = 15;
            double precioGold = 800.0;
            int pasajerosGold = 0;
            double ventasGold = 0.0;

            // Vender pasajes en el Auto Bus Platinum
            Console.WriteLine($"\nVendiendo pasajes para {nombrePlatinum}...");
            int pasajesVendidosPlatinum = 5;
            if (pasajesVendidosPlatinum <= (capacidadPlatinum - pasajerosPlatinum))
            {
                pasajerosPlatinum += pasajesVendidosPlatinum;
                ventasPlatinum += pasajesVendidosPlatinum * precioPlatinum;
                Console.WriteLine($"Se vendieron {pasajesVendidosPlatinum} pasajes en {nombrePlatinum}.");
            }
            else
            {
                Console.WriteLine("No hay suficientes asientos disponibles.");
            }

            // Vender pasajes en el Auto Bus Gold
            Console.WriteLine($"\nVendiendo pasajes para {nombreGold}...");
            int pasajesVendidosGold = 3;
            if (pasajesVendidosGold <= (capacidadGold - pasajerosGold))
            {
                pasajerosGold += pasajesVendidosGold;
                ventasGold += pasajesVendidosGold * precioGold;
                Console.WriteLine($"Se vendieron {pasajesVendidosGold} pasajes en {nombreGold}.");
            }
            else
            {
                Console.WriteLine("No hay suficientes asientos disponibles.");
            }

            // Mostrar el estado de los autobuses
            Console.WriteLine("\n--- Estado de los autobuses ---");
            Console.WriteLine($"{nombrePlatinum}:");
            Console.WriteLine($"  Pasajeros: {pasajerosPlatinum}");
            Console.WriteLine($"  Ventas: {ventasPlatinum}");
            Console.WriteLine($"  Asientos disponibles: {capacidadPlatinum - pasajerosPlatinum}");

            Console.WriteLine($"{nombreGold}:");
            Console.WriteLine($"  Pasajeros: {pasajerosGold}");
            Console.WriteLine($"  Ventas: {ventasGold}");
            Console.WriteLine($"  Asientos disponibles: {capacidadGold - pasajerosGold}");
        }
    }
}
