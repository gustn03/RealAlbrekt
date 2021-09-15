using System;
using System.Collections.Generic;

namespace RealAlbrekt
{
    public class character
    {
        private int hunger;
        private int boredom;
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

        private bool isAlive;
        private Random generator;
        public string name;
        public void feed(){
            hunger = hunger-3;
            if (hunger < 0){
                hunger = 0;

            } 
        }
        public void Hi(){
            Console.WriteLine(name,": Hello!");
        }
        public void Teach(){
            Console.WriteLine();
        }

    }
}