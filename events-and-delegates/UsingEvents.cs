using System;
using static System.Console;

namespace grasp.events_and_delegates
{
    public class UsingEvents
    {
        public event EventHandler<float> Pass;

        public void PassTheBall(float ballSpeed)
        {
            WriteLine("Ball was passed. Triggering events... If any exists");

            Pass?.Invoke(this, ballSpeed);
        }
    }
}
