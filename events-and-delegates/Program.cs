using System;
using static grasp.events_and_delegates.UsingEvents;
using static System.Console;

namespace grasp.events_and_delegates
{
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

            usingDelegates.Simple((string message) => WriteLine(message));

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

        static void AnotherPrintMessage(string message)
        {
            WriteLine("A custom delegate");
            WriteLine(message);
        }
    }
}
