using System;
using System.Windows.Input;

namespace FireSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid obj = new Grid(21, 21);
            obj.displayForrest();
            Console.WriteLine();
            Console.WriteLine("Press enter to watch next burning step or press any other key to exit the program");
            ConsoleKeyInfo keyEntered;
            while (true)
            {
                keyEntered = Console.ReadKey();
                if (keyEntered.Key == ConsoleKey.Enter)
                {
                    obj.startSimulation(21,21);
                   // obj.displayForrest();
                    Console.WriteLine("Press enter to watch next burning step or press any other key to exit the program");
                }
                else
                {
                    return;
                }
            }
        }
    }
}
