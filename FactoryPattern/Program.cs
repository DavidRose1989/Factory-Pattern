namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick 1 for the Nets \n Pick 2 for Lakers \n Pick 3 for Suns \n Pick 4 for Knicks?"); //This gets pushed to console for user
            int betCount;                                                                                           //have to initialize variable
            var input = int.TryParse(Console.ReadLine(), out betCount);                                             //takes var input from user. Then takes the string and tries to turn in to integer if it can.
                                                                                                                    //Then takes the integer and out puts whatever the value is. For example "3" eqauls Suns output.


            var bigBet = SportsBettingLeague.PickATeam(betCount);                                                   //the var bigBet is used as the variable to call the bet method.
            bigBet.Bet();                                                                                           //the Bet method is tied to all of the selection choices that the user can input. 
        }                                                                                                           //To call the method you must write out class.method name with the variable as an arguement
    }                                                                                                               //betCount is the variable that the TryParse will convert the string into if it can 
}
