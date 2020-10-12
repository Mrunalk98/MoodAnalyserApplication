
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserApplication;

namespace MoodAnalyserMSTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC 1.1, 1.2, 2.1 - Given I'm SAD/HAPPY should return SAD/HAPPY 
        /// </summary>
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

        /// <summary>
        /// TC 3.1 - Given NULL Mood Should Throw MoodAnalysisCustomException type NULL_MESSAGE
        /// </summary>
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

        /// <summary>
        /// TC 3.2 - Given EMPTY Mood Should Throw MoodAnalysisCustomException type EMPTY_MESSAGE
        /// </summary>
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