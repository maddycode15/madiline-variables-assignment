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
            string realName;
            String GamerTag;
            float percentile;

            // setting up values
           HP  = 100;
            score = 0;
            enemyvalue = 250;
           // score = score + 10;  // because the enemy value is set to 250 using the variable enemyvalue plus score is essentially the same as score plus that number
            realName = "Adventure Quest";
            GamerTag = "pixle studios";
            percentile = 85.543f; 

            //pretend gameplay: killed an enemy
           // score = score + enemyvalue; // = means that it gets the value of something, aka saying this is this.

            
            //hud
            Console.WriteLine (realName + "(" + GamerTag + ") ");
            // dialog
            Console.WriteLine("hey");
            // Console.WriteLine("yo,")

            Console.WriteLine("health"); Console.WriteLine(HP);

            Console.WriteLine(score);

            Console.WriteLine("enemy uses slash");

            Console.WriteLine();
            Console.WriteLine("press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
