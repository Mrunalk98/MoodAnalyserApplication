using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserApplication;

namespace MoodAnalyserMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string expected = "HAPPY";
            string message = "I am Any";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            // Act
            string actual = moodAnalyser.AnalyseMood();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
