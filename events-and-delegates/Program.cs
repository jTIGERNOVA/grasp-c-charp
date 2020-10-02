using System;
using static grasp.events_and_delegates.UsingEvents;
using static System.Console;

namespace grasp.events_and_delegates
{
    /// <summary>
    /// Main Program
    /// 
    /// <remarks>
    /// <para>
    /// Delegates and events in C# are very similar.
    /// Both delegates and events offer a late binding scenario: 
    /// they enable scenarios where a component communicates by calling a method that is 
    /// only known at runtime. They both support single and multiple subscriber methods. 
    /// You may find this referred to as singlecast and multicast support. 
    /// They both support similar syntax for adding and removing handlers. 
    /// Finally, raising an event and calling a delegate use exactly the same method call syntax. 
    /// They even both support the same <code>Invoke()</code> method syntax for use with the <c>?</c> operator.
    /// </para>
    ///  <para>
    /// **
    /// The most important consideration in determining which language feature 
    /// to use is whether or not there must be an attached subscriber. 
    /// If your code must call the code supplied by the subscriber, 
    /// you should use a design based on delegates when you need to implement callback. 
    /// If your code can complete all its work without calling any subscribers, 
    /// you should use a design based on events.
    /// </para>
    ///  <para>
    /// **
    /// Another consideration is the method prototype you would want for your delegate method. 
    /// As you've seen, the delegates used for events all have a void return type.
    /// </para>
    ///  <para>
    /// Classes other than the one in which an event is contained can only add and 
    /// remove event listeners; only the class containing the event can invoke the event. 
    /// Events are typically public class members. By comparison, delegates are 
    /// often passed as parameters and stored as private class members, if they are stored at all.
    /// </para>
    ///  <para>
    /// Within C# UI frameworks, you will see events used over delegates.
    /// </para>
    /// </remarks>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DoDelegates();

            WriteLine("\n\n---\n\n\n");

            DoEvents();
        }

        private static void DoEvents()
        {
            var usingEvents = new UsingEvents();

            var ballSpeed = 2.6F; //2.6 m/s (meters per second)

            //on the first pass, no events are triggered
            usingEvents.PassTheBall(ballSpeed);

            WriteLine("\n\n");

            EventHandler<float> onPassEventHandler = (object sender, float speed) =>
            {
                WriteLine($"EVENT-1... A pass was thrown at a speed of {speed}m/s");
            };

            //let's hook up some events
            usingEvents.Pass += OnPass;
            usingEvents.Pass += onPassEventHandler;
            usingEvents.PassDetailed += OnPassDetailed;
            usingEvents.PassDetailed += (object sender, PassArgs args) =>
            {
                WriteLine($"Anonymous event handler with data: {args.BallSpeed}");
            };

            //events are triggered
            usingEvents.PassTheBall(ballSpeed);

            //remember, we can also remove events if we no longer need them
            usingEvents.Pass -= OnPass;
            usingEvents.Pass -= onPassEventHandler;

            WriteLine("\n\n");

            //on the final pass, no events are triggered
            usingEvents.PassTheBall(ballSpeed);
        }

        private static void DoDelegates()
        {
            var usingDelegates = new UsingDelegates();

            usingDelegates.Simple((int id, string message) => WriteLine(message));

            usingDelegates.Simple(AnotherPrintMessage);
        }

        private static void OnPass(object sender, float speed)
        {
            WriteLine($"EVENT-2... A pass was thrown at a speed of {speed}m/s");
        }

        private static void OnPassDetailed(object sender, PassArgs args)
        {
            WriteLine($"EVENT-3... A detailed pass was thrown at a speed of {args.BallSpeed}m/s");
        }

        static bool AnotherPrintMessage(string message)
        {
            WriteLine("A custom delegate");
            WriteLine(message);

            return true;//message was printed so let's return true
        }
    }
}
