using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserApplication;

namespace MoodAnalyserMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("I am Sad")]
        [DataRow("I am Happy")]
        // TC 1.1, 1.2
        public void TestMethod1(string message)
        {
            // Arrange
            string expected = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            // Act
            string actual = moodAnalyser.AnalyseMood();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
