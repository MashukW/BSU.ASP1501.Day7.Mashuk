using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public interface IEventTimerAlarm
    {
        void SubscribeToEventTimerAlarm(CustomerTimer timer);
        void UnsubscribeToEventTimerAlarm(CustomerTimer timer);
    }
}
