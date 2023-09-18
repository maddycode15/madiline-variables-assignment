using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madeline_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("variables");
            Console.WriteLine();
            Console.WriteLine();

                int score; // this line declares a variable as an interger named score
            int enemyvalue;
            int HP;
            int Slash;
            int Enemy_Value;
            int Enemy_Health;
            int Punch;
            string realName;
            string GameName;
            String Studio;
            float percentile;

            // setting up values
           HP  = 100;
            score = 0;
            enemyvalue = 250;
            Slash = -20;
            Enemy_Health = 20;
            realName = "player";
           // score = score + 10;  // because the enemy value is set to 250 using the variable enemyvalue plus score is essentially the same as score plus that number
            GameName = "Adventure Quest";
            Studio = "pixle studios";
            percentile = 85.543f; 

            //pretend gameplay: killed an enemy
           // score = score + enemyvalue; // = means that it gets the value of something, aka saying this is this.

            
            //hud
            Console.WriteLine (GameName + "(" + Studio + ") ");
            // dialog
            //Console.WriteLine("hey");
            // Console.WriteLine("yo,")



            Console.WriteLine("health" + " " + HP + " ");

            Console.WriteLine("score" + ' ' + score); 
 
            Console.WriteLine("enemy uses slash");

            //Console.WriteLine ("health" + HP - Slash); this is not how it works. you need to do the equation that removes the slash damage from the hp and then write the new value of health.

            HP = HP + Slash;

            Console.WriteLine("health" + " " + HP + " ");

            Console.WriteLine("score" + ' ' + score);



            Console.WriteLine();
            Console.WriteLine("press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
