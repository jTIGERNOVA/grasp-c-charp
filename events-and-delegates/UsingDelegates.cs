using System;
using static System.Console;

namespace grasp.events_and_delegates
{
    /// <summary>
    /// Uses delegates
    /// </summary>
    public class UsingDelegates
    {
        /// <summary>
        /// Delegate (method reference) to print a message
        /// </summary>
        /// <param name="message">Message that needs to be printed</param>
        /// <returns>True if the message was printed, false if it was not</returns>
        public delegate bool PrintMessage(string message);

        /// <summary>
        /// Delegate (method reference) to print a message
        /// </summary>
        /// <param name="id">Message ID</param>
        /// <param name="message">Message that needs to be printed</param>
        /// <returns>True if the message was printed, false if it was not</returns>
        public delegate void PrintMessageWithID(int id, string message);

        /// <summary>
        /// Simply executes a delegate
        /// </summary>
        /// <param name="printDelegate">Print delegate</param>
        public void Simple(PrintMessage printDelegate)
        {
            WriteLine("--UsingDelegates.Simple--");
            var myMessage = $"Message printed at {DateTime.Now:MM-dd-yyyy HH:mm:ss.fff}";

            //consider checking for null
            if (printDelegate != null)
                printDelegate.Invoke(message: myMessage);

            //OR reduce 2 lines of code into 1 with the nullable reference operator '?'
            //very commonly used with delegates and events
            printDelegate?.Invoke(message: myMessage);
        }

        /// <summary>
        /// Simply executes a delegate
        /// </summary>
        /// <param name="printDelegate">Print delegate</param>
        public void Simple(PrintMessageWithID printDelegate)
        {
            WriteLine("--UsingDelegates.Simple (PrintMessageWithID)--");
            var myMessage = $"Message printed at {DateTime.Now:MM-dd-yyyy HH:mm:ss.fff}";
            var id = 2;

            //consider checking for null
            if (printDelegate != null)
                printDelegate.Invoke(message: myMessage, id: id);

            //OR reduce 2 lines of code into 1 with the nullable reference operator '?'
            //very commonly used with delegates and events
            printDelegate?.Invoke(message: myMessage, id: id);
        }
    }
}
