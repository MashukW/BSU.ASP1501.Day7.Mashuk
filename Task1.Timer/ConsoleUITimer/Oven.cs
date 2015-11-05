using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Timer;

namespace ConsoleUITimer
{
    class Oven : IEventTimerAlarm
    {
        public Oven() { }

        public Oven(CustomerTimer timer)
        {
            if (timer != null)
                SubscribeToEventTimerAlarm(timer);
        }

        public void SubscribeToEventTimerAlarm(CustomerTimer timer)
        {
            if (timer == null)
                throw new ArgumentNullException("CustomerTimer is null");
            timer.Alarm += ProcessingEventAlarmClassOven;
        }

        public void UnsubscribeToEventTimerAlarm(CustomerTimer timer)
        {
            if (timer == null)
                throw new ArgumentNullException("CustomerTimer is null");
            timer.Alarm -= ProcessingEventAlarmClassOven;
        }

        private void ProcessingEventAlarmClassOven(object sender, InfoAboutTimer e)
        {
            Console.WriteLine("The timer is completed!");
            Console.WriteLine("Your food is ready, Sir!");
        }
    }
}
