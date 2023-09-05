using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CodeWars.LogWithoutDatesTest
{
    public static class LogWithoutDatesTest
    {
        public static int CheckLogs(string[] log)
        {
            if (log.Length == 0)
            {
                return 0;
            }

            var list = new List<TimeSpan>();
            foreach (var logItem in log)
            {
                list.Add(TimeSpan.Parse(logItem));
            }

            var lastTime = TimeSpan.MinValue;
            var days = 1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= lastTime)
                {
                    days += 1;
                }
                lastTime = list[i];
            }

            return days;
        }
    }

    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void SampleTest()
        {
            Assert.AreEqual(1, LogWithoutDatesTest.CheckLogs(new[] { "12:12:12" }));
            Assert.AreEqual(1, LogWithoutDatesTest.CheckLogs(new[] { "00:00:00", "00:01:11", "02:15:59", "23:59:58", "23:59:59" }));
            Assert.AreEqual(2, LogWithoutDatesTest.CheckLogs(new[] { "12:00:00", "23:59:59", "00:00:00" }));
            Assert.AreEqual(3, LogWithoutDatesTest.CheckLogs(new[] { "12:00:00", "12:00:00", "00:00:00" }));
            Assert.AreEqual(5, LogWithoutDatesTest.CheckLogs(new[] { "00:00:00", "00:00:00", "00:00:00", "00:00:00", "00:00:00" }));
            Assert.AreEqual(1, LogWithoutDatesTest.CheckLogs(new[] { "10:10:10", "11:11:11", "12:12:12", "13:13:13", "14:14:14", "15:15:15", "16:16:16" }));
            Assert.AreEqual(2, LogWithoutDatesTest.CheckLogs(new[] { "23:59:59", "00:00:00" }));
            Assert.AreEqual(2, LogWithoutDatesTest.CheckLogs(new[] { "00:00:00", "00:00:01", "00:00:01" }));
            Assert.AreEqual(0, LogWithoutDatesTest.CheckLogs(Array.Empty<string>()));
        }
    }
}
