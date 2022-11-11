using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentServiceLib;

namespace ClassTest
{
    [TestClass]
    public class TestCase
    {
        [TestMethod]
        public void ScoreIs8_Grade_A()
        {
            Student s = new Student();
            s.Score = 8;
            char letter = s.getLetterScore();

            Assert.AreEqual('A', letter);
        }
        [TestMethod]
        public void ScoreIs10_Grade_A()
        {
            Student s = new Student();
            s.Score = 10;
            char letter = s.getLetterScore();

            Assert.AreEqual('A', letter);
        }

        // [7,8)
        [TestMethod]
        public void ScoreIsHigherEqual_7_Grade_B()
        {
            Student s = new Student();
            s.Score = 7;
            char letter = s.getLetterScore();

            Assert.AreEqual('B', letter);
        }


        [TestMethod]
        public void ScoreIsLower_8_Grade_B()
        {
            Student s = new Student();
            s.Score = 7.9;
            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        // [5,7)
        [TestMethod]
        public void ScoreIsHigherEqual_5_Grade_C()
        {
            Student s = new Student();
            s.Score = 5;
            char letter = s.getLetterScore();

            Assert.AreEqual('C', letter);
        }
        [TestMethod]
        public void ScoreIsHigherLower_7_Grade_C()
        {
            Student s = new Student();
            s.Score = 6.5;
            char letter = s.getLetterScore();

            Assert.AreEqual('C', letter);
        }

        //[3.5,5)
        [TestMethod]
        public void ScoreIsHigherEqual_3phay5_Grade_D()
        {
            Student s = new Student();
            s.Score = 3.5;
            char letter = s.getLetterScore();

            Assert.AreEqual('D', letter);
        }
        [TestMethod]
        public void ScoreIsLower_5_Grade_D()
        {
            Student s = new Student();
            s.Score = 4.9;
            char letter = s.getLetterScore();

            Assert.AreEqual('D', letter);
        }

        // Nhỏ hơn 3.5
        [TestMethod]
        public void ScoreIsLower_3Phay5_Grade_E()
        {
            Student s = new Student();
            s.Score = 3.4;
            char letter = s.getLetterScore();

            Assert.AreEqual('E', letter);
        }
    }
}