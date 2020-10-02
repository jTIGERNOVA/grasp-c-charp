using System;
using static System.Console;

namespace grasp.events_and_delegates
{
    /// <summary>
    /// Uses events
    /// </summary>
    public class UsingEvents
    {
        /// <summary>
        /// Define "pass" event handler with decimal value for ball speed
        /// </summary>
        public event EventHandler<float> Pass;

        /// <summary>
        /// Event handler that follows the standard signature for a .NET event delegate
        /// </summary>
        public event EventHandler<PassArgs> PassDetailed;

        /// <summary>
        /// Passes a ball
        /// </summary>
        /// <param name="ballSpeed">Speed of ball, in m/s (meters per second)</param>
        public void PassTheBall(float ballSpeed)
        {
            WriteLine("Ball was passed. Triggering events... If any exists");

            Pass?.Invoke(this, ballSpeed);
            PassDetailed?.Invoke(this, new PassArgs(ballSpeed));
        }

        /// <summary>
        /// Pass event arguments
        /// </summary>
        public class PassArgs : EventArgs
        {
            /// <summary>
            /// Speed of ball, in m/s (meters per second)
            /// </summary>
            public float BallSpeed { get; }

            public PassArgs(float ballSpeed)
            {
                BallSpeed = ballSpeed;
            }
        }
    }
}
