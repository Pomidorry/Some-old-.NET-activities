using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.Events
{


    public class ArrivalEventArgs : EventArgs
    {
        public ArrivalEventArgs(int trainNumber, ArrivalStatus status, DateTime time)
        {
            TrainNumber = trainNumber;
            ArrivalStatus = status;
            ArrivalTime = time;
        }

        public int TrainNumber { get; private set; }
        public ArrivalStatus ArrivalStatus { get; private set; }
        public DateTime ArrivalTime { get; private set; }
    }
}
