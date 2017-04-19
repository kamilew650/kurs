using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSkonsola.CSharp_Udemy
{
    class Stopwatch
    {
        private DateTime StartTime;
        private DateTime StopTime;
        private bool EnableToStart;
        private TimeSpan Diff;
        public TimeSpan Difference
        {
            get
            {
                if (Diff != null)
                    return Diff;
                else
                    throw new InvalidOperationException();
            }
        }

        Stopwatch()
        {
            EnableToStart = true;
        }

        public void Start()
        {
            if (EnableToStart == false)
                throw new InvalidOperationException();
            else
                EnableToStart = false;

            StartTime = DateTime.Now;
        }

        public void Stop()
        {
            if (EnableToStart == false)
            {
                StopTime = DateTime.Now;

                Diff = StopTime - StartTime;

                Console.WriteLine(Difference);

                EnableToStart = true;
            }
          

        }

    }
}
