using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer;

namespace ConsoleUITimer
{
    class ConsoleUI
    {
        static void Main(string[] args)
        {
            // Create timer, and set the time for five seconds through the constructor
            CustomerTimer timer = new CustomerTimer(5);

            // Creating a object OVEN without signing up for an event from the constructor
            Oven oven = new Oven();

            // Creating a object WASHING MACHINE with signing up for an event from the constructor
            WashingMachine wm = new WashingMachine(timer);

            // Creating a object ALARM CLOCK with signing up for an event from the constructor
            AlarmClock ac = new AlarmClock(timer);

            //Signing of the object OVEN to the event using interface method
            oven.SubscribeToEventTimerAlarm(timer);

            // Timer start
            timer.StartTimer();

            Console.ReadKey();
        }
    }
}
