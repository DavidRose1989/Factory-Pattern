using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Phoenix_Suns : ISportsbet
    {
        public void Bet()
        {
            Console.WriteLine("The Suns win because they have KD now!");
        }
    }
}
