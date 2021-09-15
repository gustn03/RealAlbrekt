
using System;

namespace RealAlbrekt
{
    class Program
    {
        static void Main(string[] args)
        {
            character Albrekt = new character();
            Console.WriteLine("Döp din Albrekt");
            Albrekt.name = Console.ReadLine();
            Console.WriteLine($"What do you want to do with {name}? (Feed, Hi, Teach, DoNothing");
            
        }
    }
}
