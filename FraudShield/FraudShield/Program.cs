using System;
using FraudShield.Generador;

namespace FraudShield
{
    class Program
    {
        static void Main()
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("SISTEMA DETECTOR DE FRAUDE BANCARIO");
                Console.WriteLine("==========================================");
                Console.WriteLine("1. Generar archivo CSV");
                Console.WriteLine("2. Leer archivo CSV");
                Console.WriteLine("3. Ejecutar versión secuencial");
                Console.WriteLine("4. Ejecutar versión paralela");
                Console.WriteLine("5. Comparar resultados");
                Console.WriteLine("6. Mostrar estadísticas");
                Console.WriteLine("7. Salir");
                Console.WriteLine("Seleccione una opción:");

                string? opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("¿Cuántas transacciones desea generar?");
                        string? totalInput = Console.ReadLine();
                        int total = int.TryParse(totalInput, out int t) ? t : 0;

                        Console.WriteLine("¿Cuántas transacciones fraudulentas desea generar?");
                        string? fraudInput = Console.ReadLine();
                        int fraudulentas = int.TryParse(fraudInput, out int f) ? f : 0;

                        if (total <= 0 || fraudulentas < 0 || fraudulentas > total)
                        {
                            Console.WriteLine("⚠️ Valores inválidos. Intente de nuevo.");
                            break;
                        }

                        var generador = new GeneradorCSV();
                        var ruta = "transacciones.csv"; // puedes cambiar a src/Data si prefieres
                        generador.GenerarArchivo(total, fraudulentas, ruta);
                        break;

                    case "2":
                        Console.WriteLine("👉 Aquí irá la lógica para leer el CSV (LectorCSV).");
                        break;

                    case "3":
                        Console.WriteLine("👉 Aquí irá la ejecución secuencial.");
                        break;

                    case "4":
                        Console.WriteLine("👉 Aquí irá la ejecución paralela.");
                        break;

                    case "5":
                        Console.WriteLine("👉 Aquí irá la comparación de resultados.");
                        break;

                    case "6":
                        Console.WriteLine("👉 Aquí irá la visualización de estadísticas.");
                        break;

                    case "7":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("⚠️ Opción inválida.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}