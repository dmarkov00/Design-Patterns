using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiskScheduling;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class DiskSchedulingTests
    {
        List<int> testList = new List<int> { 40, 2, 22, 66, 67, 33, 80, 75, 85, 65, 8 };
        private Head head;
        private IScheduler scheduler;
        [TestMethod]
        private void FCFS_Scheuling_After_Two_Calls()
        {
            List<int> expectedList = new List<int> { 22, 66, 67, 33, 80, 75, 85, 65, 8 };

            scheduler = new FCFS();
            head = new Head(scheduler);
            testList = head.ScheduleDisc(testList);
            testList = head.ScheduleDisc(testList);

            CollectionAssert.AreEqual(expectedList, testList);

        }
    }
}
