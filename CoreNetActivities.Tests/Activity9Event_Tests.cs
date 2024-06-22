using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Activity.Events;

namespace Activity9Events.Tests
{
    [TestClass]
    public class TrainStationTests
    {
        [TestMethod]
        public void TestAnnounceArrival()
        {
            // Arrange
            TrainStation trainStation = new TrainStation();

            int expectedTrainNumber = 123;
            ArrivalStatus expectedArrivalStatus = ArrivalStatus.Arriving;
            DateTime expectedArrivalTime = DateTime.Now;

            int actualTrainNumber = 0;
            ArrivalStatus actualArrivalStatus = ArrivalStatus.Cancelled;
            DateTime actualArrivalTime = DateTime.MinValue;

            trainStation.Arrival += (sender, args) =>
            {
                actualTrainNumber = args.TrainNumber;
                actualArrivalStatus = args.ArrivalStatus;
                actualArrivalTime = args.ArrivalTime;
            };

            // Act
            trainStation.AnnounceArrival(expectedTrainNumber, expectedArrivalStatus, expectedArrivalTime);

            // Assert
            Assert.AreEqual(expectedTrainNumber, actualTrainNumber);
            Assert.AreEqual(expectedArrivalStatus, actualArrivalStatus);
            Assert.AreEqual(expectedArrivalTime, actualArrivalTime, TimeSpan.FromSeconds(1).ToString());
        }
    }
}
