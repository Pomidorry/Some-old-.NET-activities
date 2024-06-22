using CSharp.Activity.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.Events
{
    public class TrainStation
    {
        public event EventHandler<ArrivalEventArgs> Arrival;

        protected virtual void OnArrival(ArrivalEventArgs arrivalEvent)
        {
            Arrival?.Invoke(this, arrivalEvent);
        }

        public void AnnounceArrival(int train, ArrivalStatus arrivalStatus, DateTime arrivalTime)
        {
            ArrivalEventArgs args = new ArrivalEventArgs(train, arrivalStatus, arrivalTime);
            OnArrival(args);
        }
    }
}
