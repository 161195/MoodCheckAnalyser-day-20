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
            string message = "I am in sad mood";
            string expected = "SAD";
            //Act
            moodAnalysis analyser = new moodAnalysis(message);
            string actual = analyser.AnalyseMood(message);
            //Act
            Assert.AreEqual(expected, actual);
        }
    }
}
