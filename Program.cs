using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_SEMANA4
{

    class Program
    {
        static double saldo = 1000.00;

        static void Main()
        {
            MostrarMenu();
        }

        static void MostrarMenu()
        {
            int opcion = 0;

            while (opcion != 5)
            {
                Console.WriteLine("\n--- CAJERO AUTOMÁTICO ---");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Retirar");
                Console.WriteLine("4. Mostrar números");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Error: Ingreso no válido. Solo se permiten números enteros.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        ConsultarSaldo();
                        break;
                    case 2:
                        Depositar();
                        break;
                    case 3:
                        Retirar();
                        break;
                    case 4:
                        MostrarNumeros();
                        break;
                    case 5:
                        Console.WriteLine("Sistema cerrado. ¡Gracias!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void ConsultarSaldo()
        {
            Console.WriteLine("Saldo actual: S/ " + saldo);
        }

        static void Depositar()
        {
            Console.Write("Ingrese el monto a depositar: S/ ");
            double deposito;

            if (!double.TryParse(Console.ReadLine(), out deposito))
            {
                Console.WriteLine("Error: Ingrese un monto numérico válido.");
                return;
            }

            if (deposito > 0)
            {
                saldo += deposito;
                Console.WriteLine("Depósito realizado.");
                Console.WriteLine("Nuevo saldo: S/ " + saldo);
            }
            else
            {
                Console.WriteLine("El monto debe ser mayor a cero.");
            }
        }

        static void Retirar()
        {
            Console.Write("Ingrese el monto a retirar: S/ ");
            double retiro;

            if (!double.TryParse(Console.ReadLine(), out retiro))
            {
                Console.WriteLine("Error: Ingrese un monto numérico válido.");
                return;
            }

            if (retiro > 0 && retiro <= saldo)
            {
                saldo -= retiro;
                Console.WriteLine("Retiro realizado.");
                Console.WriteLine("Nuevo saldo: S/ " + saldo);
            }
            else
            {
                Console.WriteLine("Monto inválido o saldo insuficiente.");
            }
        }

        static void MostrarNumeros()
        {
            Console.Write("Ingrese el límite: ");
            int limite;

            if (!int.TryParse(Console.ReadLine(), out limite))
            {
                Console.WriteLine("Error: Ingrese un número entero válido.");
                return;
            }

            for (int i = 1; i <= limite; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}