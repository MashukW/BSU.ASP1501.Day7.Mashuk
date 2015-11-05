using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    public class CustomerTimer
    {
        private int countdown = 0;

        public event EventHandler<InfoAboutTimer> Alarm = delegate { };

        public CustomerTimer() { }

        public CustomerTimer(int seconds)
        {
            if (seconds > 0)
                countdown = seconds * 1000;
        }

        private void OnAlarm(InfoAboutTimer e)
        {
            EventHandler<InfoAboutTimer> temp = Alarm;

            if (temp != null)
                Alarm(this, e);
        }

        public void SetTime(int second)
        {
            if (second > 0)
                countdown = second * 1000;
        }

        public void StartTimer()
        {
            if (countdown > 0)
            {
                InfoAboutTimer info = new InfoAboutTimer(DateTime.Now);
                Thread.Sleep(countdown);
                OnAlarm(info);
                ResetTimer();
            }
        }

        public void ResetTimer()
        {
            countdown = 0;
        }
    }
}
