using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class BrooklynNets : ISportsbet    //Conforming the Interface
    {
        public void Bet()
        {
            Console.WriteLine("Even without KD and Kyrie Nets took it home");   //If user picks the Nets this will display to the console. 
        }
    }
}
