using static System.Console;

namespace grasp.strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = new UsingStrings();

            strings.SimpleStrings();

            WriteLine("--");

            strings.StringVariables();
        }
    }
}
