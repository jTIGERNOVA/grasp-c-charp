using static System.Console;

namespace grasp.strings
{
    /// <summary>
    /// Demonstrate the use of strings in many different of ways
    /// </summary>
    public class UsingStrings
    {
        /// <summary>
        /// Prints simple strings
        /// </summary>
        public void SimpleStrings()
        {
            WriteLine("Hello World!");
            //new lines can be done with just Console.WriteLine()
            WriteLine();
            
            //a new line can also be denoted via \n
            WriteLine("Hello World!\n");

            //writing strings on the same line can also be useful
            Write("--------------------");
            Write("SimpleStrings DONE");
            Write("--------------------");
            WriteLine();
        }

        /// <summary>
        /// Prints strings with the use of variables
        /// </summary>
        public void StringVariables()
        {
            var player1 = "Michael Jordan";
            var player1Number = 23;

            string player2 = "Lebron James";
            byte player2Number = 23;

            WriteLine("Player: " + player1 + " has number: " + player1Number);
            WriteLine("Player: {0} has number: {1}", player2, player2Number);

            var sameNumber = (player1Number == player2Number);

            WriteLine($"Do both players have the same number? {sameNumber}");
        }
    }
}
