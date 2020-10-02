using System;
using static System.Console;

namespace grasp.events_and_delegates
{
    public class UsingEvents
    {
        public event EventHandler<float> Pass;

        /// <summary>
        /// Event handler that follows the standard signature for a .NET event delegate
        /// </summary>
        public event EventHandler<PassArgs> PassDetailed;

        public void PassTheBall(float ballSpeed)
        {
            WriteLine("Ball was passed. Triggering events... If any exists");

            Pass?.Invoke(this, ballSpeed);
            PassDetailed?.Invoke(this, new PassArgs(ballSpeed));
        }

        public class PassArgs : EventArgs
        {
            public float BallSpeed { get; }

            public PassArgs(float ballSpeed)
            {
                BallSpeed = ballSpeed;
            }
        }
    }
}
