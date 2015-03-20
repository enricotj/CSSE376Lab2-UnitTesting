using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{
		//TODO Task 7 items go here
        private readonly DateTime StartDate = new DateTime(2009, 11, 1);
        private readonly DateTime EndDate = new DateTime(2009, 11, 11);

        [Test()]
        public void TestThatFlightInitializes()
        {
            var target = new Flight(StartDate, EndDate, 0);
            Assert.IsNotNull(target);
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForOneDay()
        {
            var target = new Flight(StartDate, new DateTime(2009, 11, 2), 0);
            Assert.AreEqual(220, target.getBasePrice());
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForTwoDays()
        {
            var target = new Flight(StartDate, new DateTime(2009, 11, 3), 0);
            Assert.AreEqual(240, target.getBasePrice());
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForTenDays()
        {
            var target = new Flight(StartDate, EndDate, 0);
            Assert.AreEqual(400, target.getBasePrice());
        }

        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatFlightThrowsOnEndDateBeforeStartDate()
        {
            new Flight(EndDate, StartDate, 0);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestThatFlightThrowsOnNegativeMiles()
        {
            new Flight(StartDate, EndDate, -1000);
        }
	}
}
