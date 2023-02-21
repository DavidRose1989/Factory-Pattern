using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class NewYorkKnicks : ISportsbet
    {
        public void Bet()
        {
            Console.WriteLine(" How about them Knicks baby let's gooooooooooo!!!! ");
        }
    }
}
