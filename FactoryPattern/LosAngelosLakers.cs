using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class LosAngelosLakers : ISportsbet
    {
        public void Bet()
        {
            Console.WriteLine("Lakers trash but they won still somehow?");
        }
    }
}
