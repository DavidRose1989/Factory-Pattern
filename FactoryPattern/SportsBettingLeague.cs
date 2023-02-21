using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class SportsBettingLeague        //This class was created to input switch statement 
    {                                              

        public static ISportsbet PickATeam(int betAmount)    //Create method for user to choose from.
        {                                                    //ISportsbet was used as the return type because all of the classes in the switch statement all conformed to ISportsbet
            switch (betAmount)                                //So in order for the user to be able to pick one of the classes as their selection the return type must be ISportsbet
            {
                case 1:
                    return new BrooklynNets();
                case 2:
                    return new LosAngelosLakers();
                case 3:
                    return new Phoenix_Suns();
                default :
                    return new NewYorkKnicks();
            }
        }

    }
}
