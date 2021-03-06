using FluentScheduler.Tests.UnitTests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FluentScheduler.Tests.UnitTests.ScheduleTests
{
    [TestClass]
    public class DelayFor_ToRunEvery_Tests
    {
        [TestMethod]
        public void Should_Delay_ToRunEvery_For_2_Seconds()
        {
            // Arrange
            var expected = DateTime.Now.AddSeconds(12);

            // Act
            TaskManager.AddTask(
                () => { },
                s => s.WithName("run every 10 seconds and delay for 2 seconds")
                    .ToRunEvery(10).Seconds()
                    .DelayFor(2).Seconds()
            );
            var actual = TaskManager.GetSchedule("run every 10 seconds and delay for 2 seconds").NextRun;

            // Assert
            Assert.AreEqual(expected.WithoutMilliseconds(), actual.WithoutMilliseconds());
        }

        [TestMethod]
        public void Should_Delay_ToRunEvery_For_2_Minutes()
        {
            // Arrange
            var expected = DateTime.Now.AddSeconds(10).AddMinutes(2);

            // Act
            TaskManager.AddTask(
                () => { },
                s => s.WithName("run every 10 seconds and delay for 2 minutes")
                    .ToRunEvery(10).Seconds()
                    .DelayFor(2).Minutes()
            );
            var actual = TaskManager.GetSchedule("run every 10 seconds and delay for 2 minutes").NextRun;

            // Assert
            Assert.AreEqual(expected.WithoutMilliseconds(), actual.WithoutMilliseconds());
        }

        [TestMethod]
        public void Should_Delay_ToRunEvery_For_2_Hours()
        {
            // Arrange
            var expected = DateTime.Now.AddSeconds(10).AddHours(2);

            // Act
            TaskManager.AddTask(
                () => { },
                s => s.WithName("run every 10 seconds and delay for 2 hours")
                    .ToRunEvery(10).Seconds()
                    .DelayFor(2).Hours()
            );
            var actual = TaskManager.GetSchedule("run every 10 seconds and delay for 2 hours").NextRun;

            // Assert
            Assert.AreEqual(expected.WithoutMilliseconds(), actual.WithoutMilliseconds());
        }

        [TestMethod]
        public void Should_Delay_ToRunEvery_For_2_Days()
        {
            // Arrange
            var expected = DateTime.Now.AddSeconds(10).AddDays(2);

            // Act
            TaskManager.AddTask(
                () => { },
                s => s.WithName("run every 10 seconds and delay for 2 days")
                    .ToRunEvery(10).Seconds()
                    .DelayFor(2).Days()
            );
            var actual = TaskManager.GetSchedule("run every 10 seconds and delay for 2 days").NextRun;

            // Assert
            Assert.AreEqual(expected.WithoutMilliseconds(), actual.WithoutMilliseconds());
        }

        [TestMethod]
        public void Should_Delay_ToRunEvery_For_2_Weeks()
        {
            // Arrange
            var expected = DateTime.Now.AddSeconds(10).AddDays(14);

            // Act
            TaskManager.AddTask(
                () => { },
                s => s.WithName("run every 10 seconds and delay for 2 weeks")
                    .ToRunEvery(10).Seconds()
                    .DelayFor(2).Weeks()
            );
            var actual = TaskManager.GetSchedule("run every 10 seconds and delay for 2 weeks").NextRun;

            // Assert
            Assert.AreEqual(expected.WithoutMilliseconds(), actual.WithoutMilliseconds());
        }

        [TestMethod]
        public void Should_Delay_ToRunEvery_For_2_Months()
        {
            // Arrange
            var expected = DateTime.Now.AddSeconds(10).AddMonths(2);

            // Act
            TaskManager.AddTask(
                () => { },
                s => s.WithName("run every 10 seconds and delay for 2 months")
                    .ToRunEvery(10).Seconds()
                    .DelayFor(2).Months()
            );
            var actual = TaskManager.GetSchedule("run every 10 seconds and delay for 2 months").NextRun;

            // Assert
            Assert.AreEqual(expected.WithoutMilliseconds(), actual.WithoutMilliseconds());
        }

        [TestMethod]
        public void Should_Delay_ToRunEvery_For_2_Years()
        {
            // Arrange
            var expected = DateTime.Now.AddSeconds(10).AddYears(2);

            // Act
            TaskManager.AddTask(
                () => { },
                s => s.WithName("run every 10 seconds and delay for 2 years")
                    .ToRunEvery(10).Seconds()
                    .DelayFor(2).Years()
            );
            var actual = TaskManager.GetSchedule("run every 10 seconds and delay for 2 years").NextRun;

            // Assert
            Assert.AreEqual(expected.WithoutMilliseconds(), actual.WithoutMilliseconds());
        }

    }
}
