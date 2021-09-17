
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

            while (Albrekt.GetAlive() == true){
                string svar = "";
                Albrekt.PrintStats();

                Console.WriteLine($"What do you want to do with {Albrekt.name}? (Feed, Hi, Teach, Do Nothing)");

                svar = Console.ReadLine();

                svar.ToLower();

                if (svar == "feed"){
                    Albrekt.Tick();
                    Albrekt.feed();
                    Console.Clear();
                }

                else if (svar == "hi"){
                    Console.Clear();
                    Albrekt.Hi();
                    Albrekt.Tick();
                }

                else if (svar == "teach"){
                    Albrekt.Teach();
                    Albrekt.Tick();
                    Console.Clear();
                }

                else if (svar == "do nothing"){
                    Albrekt.Tick();
                    Console.Clear();
                }

                else{
                    Console.Clear();
                    Console.WriteLine("Välj ett av alternativen");
                }
            }
            
            Console.WriteLine($"Där dog ju {Albrekt.name}");
            Console.WriteLine("Tryck enter för att stänga av");
            Console.ReadLine();
            
        }
    }
}
