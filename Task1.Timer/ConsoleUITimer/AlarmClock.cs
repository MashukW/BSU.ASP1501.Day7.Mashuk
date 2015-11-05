using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer;

namespace ConsoleUITimer
{
    class AlarmClock : IEventTimerAlarm
    {
        public AlarmClock() { }

        public AlarmClock(CustomerTimer timer)
        {
            if (timer != null)
                SubscribeToEventTimerAlarm(timer);
        }

        public void SubscribeToEventTimerAlarm(CustomerTimer timer)
        {
            if (timer == null)
                throw new ArgumentNullException("Timer is null");
            timer.Alarm += ProcessingEventAlarmClassAlarmClock;
        }

        public void UnsubscribeToEventTimerAlarm(CustomerTimer timer)
        {
            if (timer == null)
                throw new ArgumentNullException("Timer is null");
            timer.Alarm -= ProcessingEventAlarmClassAlarmClock;
        }

        private void ProcessingEventAlarmClassAlarmClock(object sender, InfoAboutTimer e)
        {
            TimeSpan time = DateTime.Now - e.dt;

            Console.WriteLine("{0:D}:{1:D}:{2:D} - passed since start of timer", time.Hours, time.Minutes, time.Seconds);
        }
    }
}
