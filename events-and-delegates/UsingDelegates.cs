using System;
using static System.Console;

namespace grasp.events_and_delegates
{
    public class UsingDelegates
    {
        public delegate void PrintMessage(string message);

        public void Simple(PrintMessage printDelegate)
        {
            WriteLine("--UsingDelegates.Simple--");
            var myMessage = $"Message printed at {DateTime.Now:MM-dd-yyyy HH:mm:ss.fff}";

            if (printDelegate != null)
                printDelegate.Invoke(message: myMessage);

            printDelegate?.Invoke(message: myMessage);
        }
    }
}
