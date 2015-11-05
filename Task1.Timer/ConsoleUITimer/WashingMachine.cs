using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer;

namespace ConsoleUITimer
{
    class WashingMachine : IEventTimerAlarm
    {
        public WashingMachine() { }

        public WashingMachine(CustomerTimer timer)
        {
            if (timer != null)
                SubscribeToEventTimerAlarm(timer);
        }

        public void SubscribeToEventTimerAlarm(CustomerTimer timer)
        {
            if (timer == null)
                throw new ArgumentNullException("Timer is null");
            timer.Alarm += ProcessingEventAlarmClassWashingMachine;
        }

        public void UnsubscribeToEventTimerAlarm(CustomerTimer timer)
        {
            if (timer == null)
                throw new ArgumentNullException("Timer is null");
            timer.Alarm -= ProcessingEventAlarmClassWashingMachine;
        }

        private void ProcessingEventAlarmClassWashingMachine(object sender, InfoAboutTimer e)
        {
            Console.WriteLine("The timer is completed!");
            Console.WriteLine("Things washed!");
            Console.WriteLine("Now you will find the Ironing)");
        }
    }
}
