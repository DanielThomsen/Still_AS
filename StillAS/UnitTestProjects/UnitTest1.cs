using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Database;
using Moq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace UnitTestProjects
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {

            //arrange
            var data = new List<Maskine>
            {
                new Maskine { DemoNummer = "1"},
                new Maskine { DemoNummer = "2"}
            }.AsQueryable();

            var Mockset = new Mock<DbSet<Maskine>>();
            Mockset.As<IQueryable<Maskine>>().Setup(x => x.Provider).Returns(data.Provider);
            Mockset.As<IQueryable<Maskine>>().Setup(x => x.Expression).Returns(data.Expression);
            Mockset.As<IQueryable<Maskine>>().Setup(x => x.ElementType).Returns(data.ElementType);
            Mockset.As<IQueryable<Maskine>>().Setup(x => x.GetEnumerator()).Returns((IEnumerator<Maskine>)data.GetEnumerator());

            Mock<stillasEntities> m = new Mock<stillasEntities>();
            m.Setup(x => x.Maskines).Returns(Mockset.Object);

            DatabaseRepository DBR = new DatabaseRepository(m.Object);

            List<string> ex = new List<string>();
            foreach(Maskine mask in data)
            {
                ex.Add(mask.DemoNummer);
            }
            var actual = ex;
            //act
            var Result = DBR.GetAllDemoNumbers();

            //Assert
            Assert.AreEqual(actual[0], Result[0]);
            Assert.AreEqual(actual[1], Result[1]);
        }
    }
}
