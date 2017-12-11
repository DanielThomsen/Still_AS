using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Database;
using Moq;
using System.Collections.Generic;


namespace UnitTestProjects
{
    [TestClass]
    public class UnitTest1
    {
        IDatabase DBR = new DatabaseRepository();
        //DatabaseRepository DBR = new DatabaseRepository();

        [TestMethod]
        public void TestMethod1()
        {

            //arrange
            List<string> data = new List<string>();
            data.Add("1");
            data.Add("2");

            Maskine et = new Maskine();
            et.DemoNummer = "1";
            Maskine to = new Maskine();
            to.DemoNummer = "2";

            stillasEntities se = new stillasEntities();
            se.Maskines.Add(et);
            se.Maskines.Add(to);
  
            Mock<stillasEntities> mock = new Mock<stillasEntities>();
            mock.Setup(x => x.Maskines).Returns(se.Maskines);
            Mock<IDatabase> m = new Mock<IDatabase>();
            m.Setup(x => x.GetAllDemoNumbers()).Returns(mock.Object);
            //mock.Setup(x => x.GetAllDemoNumbers()).Returns(data);

            var actual = data;
            //  actual[0] = "3";
            //act
            var Result = DBR.GetAllDemoNumbers();

            //Assert
            Assert.AreEqual(actual, Result);
        }
    }
}
