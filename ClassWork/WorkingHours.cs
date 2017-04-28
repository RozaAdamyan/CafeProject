using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class WorkingHours
    {
        string startTime;
        string endTime;
        public string InputWeekDay { get; private set; }
         public WorkingHours()
        {
           
          /*  if (WeekDays.Saturday == InputWeekDay || WeekDays.Sunday == InputWeekDay)
            {
                startTime = "09:00";
                endTime = "22:00";
            }
            else
            {
                startTime = "09:00";
                endTime = "20:00";
            }*/
        }

        enum WeekDays
        {
            Monday,
            Thuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,

        }
    }
}
