using System;
using System.Collections.Generic;

namespace RealAlbrekt
{
    public class character
    {
        private int hunger = 0;
        private int boredom = 0;
        private List<string> words  = new List<string>(){
            "4",
            "Dates",
            "Daily",
            "No",
            "Weaknes",
            "TWISTED PELIS?",
            "DO THIS!",
            "Floppy infant",
            "Looks floppy",
            "#ADAM"
        };

        private bool isAlive = true;
        private Random generator = new Random();
        public string name;
        public void feed(){
            hunger = hunger-2;
            if (hunger < 0){
                hunger = 0;

            } 
        }
        public void Hi(){
            int word = generator.Next(0,words.Count);
            Console.WriteLine($"{name}: {words[word]}");
            ReduceBoredom();
        }
        public void Teach(){
            Console.WriteLine($"What would you like to teach {name}?");
            string svar = Console.ReadLine();
            words.Add(svar);
            ReduceBoredom();
        }
        public void Tick(){
            hunger++;
            boredom++;
            if (hunger > 10 || boredom > 10){
                isAlive = false;
            }
        }
        public void PrintStats(){
            Console.WriteLine($"Hunger: {hunger}");
            Console.WriteLine($"Bordeom: {boredom}");
        }
        public bool GetAlive()
        {
            return isAlive;
        }

        private void ReduceBoredom(){
            boredom = boredom-2;
            if (boredom < 0){
                boredom = 0;
            }
        }

    }
}