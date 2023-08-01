using System;
using System.Diagnostics;

namespace ShutdownTimerMac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cantidad de minutos para realizar apagado");
            int minutos = int.Parse(Console.ReadLine());

            
            int segundos = minutos * 60;

            
            Process.Start("sudo", $"shutdown -h +{segundos}");

            Console.WriteLine($"La computadora se apagará en {minutos} minutos.");
            Console.WriteLine("Ingrese 'C' para cancelar el apagado.");

            
            string input = Console.ReadLine();
            if (input.ToLower() == "C")
            {
                
                Process.Start("sudo", "killall shutdown");
                Console.WriteLine("El apagado ha sido cancelado.");
            }
        }
    }

}
