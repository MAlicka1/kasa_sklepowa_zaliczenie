using System;

namespace kasa_sklepowa_zaliczenie
{
    internal partial class Program
    {
        public class Message
        {
            //wyświetlanie początkowego tekstu
            public void DisplayWelcome()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("WYBIERZ OPCJĘ:");
                Console.WriteLine();
                Console.WriteLine("1 => LISTA WSZYSTKICH PRODUKTÓW");
                Console.WriteLine("2 => ZAKUPY");
                Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
                Console.WriteLine();
                Console.WriteLine("WYBIERZ 1, 2 LUB 3:");

            }


        }
    }
}
