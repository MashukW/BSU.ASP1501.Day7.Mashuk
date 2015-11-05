using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public sealed class InfoAboutTimer : EventArgs
    {
        public DateTime dt { get; private set; }

        public InfoAboutTimer(DateTime dateTime)
        {
            if (dateTime == default(DateTime))
                throw new ArgumentException("Invalid parameter value");
            dt = dateTime;
        }
    }
}
