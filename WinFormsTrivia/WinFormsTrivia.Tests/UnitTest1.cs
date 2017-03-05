using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WinFormsTrivia.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void shuffle_list()
        {
            //Arrange
            List<string> orderedAnswerList = new List<string>()
            {
                "no1",
                "no2",
                "no3"
            };
            StaticVariables.Answers = new List<string>()
            {
                "no1",
                "no2",
                "no3"
            };
            //Act
            StaticVariables.Answers.Shuffle();
            //Assert
            CollectionAssert.AreNotEqual(StaticVariables.Answers, orderedAnswerList);
        }
    }
}
