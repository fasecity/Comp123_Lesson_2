using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Comp123_Lesson_2.Program;
namespace Lesson_1_unitTest
{
    /**
     This class is used to make lesson 1
     * * */
    [TestClass]
    public class UnitTest1
    {
        /*
         unit test for outputstringToconsole
             */
        [TestMethod]
        public void OutputstringToConsoleTEst()
        {
            // Arrange
            string outputString ="Enter UserName";
            bool hasNewLine = false;
            string expected = "Enter UserName";
            string Actualresult;

            //act
            Actualresult = Comp123_Lesson_2.Program.OutputstringToConsole(outputString, hasNewLine);
            //Assert
            Assert.AreEqual(expected, Actualresult);
        }
    }
}
