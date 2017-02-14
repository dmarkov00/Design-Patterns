using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiskScheduling;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class SchedulingUnitTests
    {

        List<int> testList = new List<int> { 40, 2, 22, 66, 67, 33, 80, 75, 85, 65, 8 };
        private Head head;
        private IScheduler scheduler;

        [TestMethod]
        public void FCFS_Scheuling_After_Two_Calls()
        {
            List<int> expectedList = new List<int> { 22, 66, 67, 33, 80, 75, 85, 65, 8 };
            scheduler = new FCFS();
            head = new Head(scheduler);
            testList = head.ScheduleNextRequstedNumber(testList);
            testList = head.ScheduleNextRequstedNumber(testList);

            CollectionAssert.AreEqual(expectedList, testList);
        }
        [TestMethod]
        public void SSTF_Scheduling_After_Three_Calls()
        {
            List<int> expectedList = new List<int> { 2, 66, 67, 80, 75, 85, 65, 8 };

            scheduler = new SSTF();
            head = new Head(scheduler);
            ((SSTF)scheduler).HeadLocation = 30;
            head.ScheduleNextRequstedNumber(testList);
            head.ScheduleNextRequstedNumber(testList);
            head.ScheduleNextRequstedNumber(testList);

            CollectionAssert.AreEqual(expectedList, testList);
        }
        [TestMethod]
        public void Elevator_Scheduling_After_Five_Calls()
        {

            List<int> expectedList = new List<int> { 66, 67, 80, 75, 85, 65 };

            scheduler = new Elevator();
            head = new Head(scheduler);
            ((Elevator)scheduler).HeadLocation = 30;
            for (int i = 0; i < 5; i++)
            {
                head.ScheduleNextRequstedNumber(testList);
            }

            CollectionAssert.AreEqual(expectedList, testList);

        }
    }
}
