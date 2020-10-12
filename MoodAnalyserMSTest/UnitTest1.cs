
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserApplication;

namespace MoodAnalyserMSTest
{
    [TestClass]
    public class UnitTest1
    {
        // TC 1.1, 1.2, 2.1
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string expected = "HAPPY";
            string message = "I am happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            // Act
            string actual = moodAnalyser.AnalyseMood();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // TC 3.1
        [TestMethod]
        public void GivenNullShouldThrowException()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string actual = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalysisCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }

        // TC 3.2
        [TestMethod]
        public void GivenEmptyShouldThrowException()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string actual = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalysisCustomException e)
            {
                Assert.AreEqual("Mood should not be empty string", e.Message);
            }
        }

    }
}