using System;

namespace HelloWorld.exercise
{
    partial class Program
    {
        public class Stopwatch
        {
            private DateTime _start;
            private DateTime _end;
            private TimeSpan _duration;
            public Stopwatch()
            {
                OnIntilize();
            }

            private void OnIntilize()
            {
                _start = DateTime.MinValue;
            }

            public void Start()
            {
                if (_start != DateTime.MinValue)
                {
                    Console.WriteLine("Its already started ");
                }
                else{
                    _start = DateTime.Now;
                }
            }

            public TimeSpan Stop()
            {
               if (_start == DateTime.MinValue)
                {
                    Console.WriteLine("STop watch has not been stareted");
                   
                }
                _end = DateTime.Now;

                _duration =   _end - _start;
                OnIntilize();
                return _duration;

            }

        }

    }
}
