using static System.Console;

namespace grasp.events_and_delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var usingDelegates = new UsingDelegates();

            usingDelegates.Simple((string message) => WriteLine(message));

            usingDelegates.Simple(AnotherPrintMessage);
        }

        static void AnotherPrintMessage(string message)
        {
            WriteLine("A custom delegate");
            WriteLine(message);
        }
    }
}
