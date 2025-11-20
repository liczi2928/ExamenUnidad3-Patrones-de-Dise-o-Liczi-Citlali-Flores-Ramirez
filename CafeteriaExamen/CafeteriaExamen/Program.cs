using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CafeteriaExamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " Simulador de Cafe ";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== CAFE EXPRESS  ===\n");

            ICafe miCafe = new CafeSimple();
            bool continuar = true;

            while (continuar)
            {
                Console.ForegroundColor = ConsoleColor.Magenta ;
                Console.WriteLine($"\nTu café actual es: {miCafe.Descripcion()}");
                Console.WriteLine($"Costo actual: ${miCafe.Costo():0.00} pesos");
                Console.Write("\n¿Deseas agregar algún ingrediente? (s/n): ");
                string respuesta = Console.ReadLine()?.ToLower();

                if (respuesta == "s")
                {
                    Console.WriteLine("\n Ingredientes Adicionales  ");
                    Console.WriteLine("1. Agregar leche ($10)");
                    Console.WriteLine("2. Agregar caramelo ($12)");
                    Console.WriteLine("3. Agregar azúcar ($5)");
                    Console.WriteLine("4. Agregar canela ($8)");
                    Console.WriteLine("5. Finalizar pedido");

                    Console.Write("\nSelecciona una opción: ");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1": miCafe = new CafeConLeche(miCafe); break;
                        case "2": miCafe = new CafeConCaramelo(miCafe); break;
                        case "3": miCafe = new CafeConAzucar(miCafe); break;
                        case "4": miCafe = new CafeConCanela(miCafe); break;
                        case "5": continuar = false; break;
                        default: Console.WriteLine("Opción no válida."); break;
                    }
                }
                else
                {
                    continuar = false;
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("            ORDEN FINAL ");
            Console.WriteLine("═══════════════════════════════════════\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Tu pedido: {miCafe.Descripcion()}");
            Console.WriteLine($"Total en pesos: ${miCafe.Costo():0.00}");

            ISistemaPrecios adaptador = new AdaptadorSistemaPrecios();
            double totalDolares = adaptador.ObtenerPrecioEnDolares(miCafe.Costo());
            Console.WriteLine($"Total en dólares: ${totalDolares:0.00} USD");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     ¡Gracias por tu compra! ");
            Console.ResetColor();

            Console.ReadKey();
        }

    }
        

    
}
    



    