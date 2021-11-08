using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodCheckProgram20;

namespace moodAnalysisTest
{

    [TestClass]
    public class MoodTestCase
    {
        [TestMethod]
        public void TestMethod1()
        {
            //TEST CASE-1

            //Arrange
            string message = null;
            string expected = "Happy";

            //Act
            moodAnalysis analyser = new moodAnalysis(message);
            string actual = analyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
