using System;

namespace StopWatchExercise
{
    public class Stopwatch
    {
        private DateTime _start;
        private DateTime _stop;

        private bool _isRunning;


        public void OnOff()
        {
            if (_isRunning)
            {
                this.Stop();
            }
            else
            {
                this.Start();
            }
                
        }

        private void Start()
        {
            _start = DateTime.Now;
            Console.WriteLine("Starting Stopwatch Timer " + _start );
            _isRunning = true;

        }

        private void Stop()
        {
            _stop = DateTime.Now;
            Console.WriteLine("Stopping Timer - Time elapsed (secs) - " + (_stop - _start).TotalSeconds);
            _isRunning = false;

        }
    }
}
