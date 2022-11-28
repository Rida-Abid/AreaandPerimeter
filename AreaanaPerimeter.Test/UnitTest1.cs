using AreaandPerimeter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaanaPerimeter.Test
{
    [TestClass]
    public class UnitTest1
    {
        #region Square
        [TestMethod]
        public void TestwithNormalParametersinPerimeterofSquare()
        {
            var uut = new Logic();
            var values = uut.perimeterofsquare(12.2 );
            Assert.IsNotNull(values);
            Assert.AreEqual(48.8,values);
        }

        [TestMethod]
        public void TestwithNormalParametersinAreaofSquare()
        {
            var uut = new Logic();
            var values = uut.areaofsquare(12.2);
            Assert.IsNotNull(values);
            Assert.AreEqual(24.4, values);
        }

        public void TestwithParametersLessthan0inPerimeterofSquare()
        {
            var uut = new Logic();
            var values = uut.perimeterofsquare(0);
            Assert.IsNotNull(values);
            Assert.AreEqual(0, values);
        }

        public void TestwithParametersLessthan0inAreaofSquare()
        {
            var uut = new Logic();
            var values = uut.areaofsquare(12.2);
            Assert.IsNotNull(values);
            Assert.AreEqual(0, values);
        }
        #endregion

        #region Rectangle

        [TestMethod]
        public void TestwithNormalParametersinPerimeterofRectangle()
        {
            var uut = new Logic();
            var values = uut.perimeterofrectangle(12.2, 13.3);
            Assert.IsNotNull(values);
            Assert.AreEqual(51, values);
        }

        public void TestwithNormalParametersinAreaofRectangle()
        {
            var uut = new Logic();
            var values = uut.areaofrectangle(12.2, 13.3);
            Assert.IsNotNull(values);
            Assert.AreEqual(162.26, values);
        }

        [TestMethod]
        public void TestwithParametersLessThan0inPerimeterofRectangle()
        {
            var uut = new Logic();
            var values = uut.perimeterofrectangle(12.2, 0);
            Assert.IsNotNull(values);
            Assert.AreEqual(24.4, values);
        }


        [TestMethod]
        public void TestwithParametersLessThan0inAreaofRectangle()
        {
            var uut = new Logic();
            var values = uut.areaofrectangle(0, 13.3);
            Assert.IsNotNull(values);
            Assert.AreEqual(13.3, values);
        }




        #endregion

        #region Triangle
        [TestMethod]
        public void TestwithNormalParametersinPerimeterofTriangle()
        {
            var uut = new Logic();
            var values = uut.perimeteroftriangle(12.2, 13.3, 14.4);
            Assert.IsNotNull(values);
            Assert.AreEqual(39.9, values);
        }

        [TestMethod]
        public void TestwithNormalParametersinAreaofTriangle()
        {
            var uut = new Logic();
            var values = uut.areaoftriangle(12.2, 13.3);
            Assert.IsNotNull(values);
            Assert.AreEqual(12.75, values);
        }

        [TestMethod]
        public void TestwithParametersLessThan0inPerimeterofTriangle()
        {
            var uut = new Logic();
            var values = uut.perimeteroftriangle(12.2, 13.3, 0);
            Assert.IsNotNull(values);
            Assert.AreEqual(25.5, values);
        }

        [TestMethod]
        public void TestwithParametersLessThan0inAreaofTriangle()
        {
            var uut = new Logic();
            var values = uut.areaoftriangle(12.2, 0);
            Assert.IsNotNull(values);
            Assert.AreEqual(6.1, values);
        }

        #endregion
    }
}