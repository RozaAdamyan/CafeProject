using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
     class WorkingHours
    {
        public  int StartTime { get; private set; }
        public int EndTime { get; private set; }
        public string InputWeekDay { get;  set; }
        public WorkingHours (string inputWeekDay)
        {
            InputWeekDay = inputWeekDay;
        }

        private void SetWorkingHours()
        {
            switch (InputWeekDay)
            {
                case "Mondey":
                case "Thuesday":
                case " Wednesday":
                case "Thursday":
                case " Friday ":
                    StartTime = 9;
                    EndTime = 20;
                    break;
                case "Saturday":
                case "Sunday":
                    StartTime = 9;
                    EndTime = 22;
                    break;
                default:
                    Console.WriteLine("Please enter Day Of Week:");
                    break;
            }
        }
        public void GetWorkingHours()
        {
            SetWorkingHours();
            Console.WriteLine("In {0} we work at{1} to {2}", InputWeekDay, StartTime, EndTime);
        }

    }
}
