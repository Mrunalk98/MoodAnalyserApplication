
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
        public void GivenHappyShouldReturnHappy()
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

        /// <summary>
        /// TC 4.1 - Given class name Should return object
        /// </summary>
        [TestMethod]
        public void GivenClassNameShouldReturnObject()
        {
            object expected = new MoodAnalyser();
            object actual = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserApplication.MoodAnalyser", "MoodAnalyser");
            expected.Equals(actual);
        }

        /// <summary>
        /// TC 5.1 - Given class name Should return object using parameterized constructor
        /// </summary>
        [TestMethod]
        public void GivenClassNameShouldReturnObjectUsingParameterizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object actual = MoodAnalyserFactory.CreateMoodAnalyseWithParameterizedConstructor("MoodAnalyserApplication.MoodAnalyser", "MoodAnalyser", "HAPPY");
            expected.Equals(actual);
        }

        /// <summary>
        /// TC 6.1 - Given Happy Mood should return happy using invoke method - reflection
        /// </summary>
        [TestMethod]
        public void GivenHappyMoodShouldReturnHappyUsingReflection()
        {
            object expected = "HAPPY";
            object actual = MoodAnalyserFactory.InvokeAnalyseMood("HAPPY", "AnalyseMood");
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 6.2 - Given Happy Mood and wrong method name should throw NO_SUCH_METHOD exception
        /// </summary>
        [TestMethod]
        public void GivenWrongMethodNameShouldThrowException()
        {
            object expected = "HAPPY";
            object actual = MoodAnalyserFactory.InvokeAnalyseMood("HAPPY", "AnalyseMoodWrong");
            Assert.AreEqual(expected, actual);
        }
    }
}