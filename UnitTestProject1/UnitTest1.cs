using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Trapezoid()
        {
            double X1 = 0;
            
            double X2 = 1;
            

            bool chek;
            if ((X1 - X2) == 0) chek = true;
            else chek = false;

            Trapezoid trapezoid = new Trapezoid(X1, X2);

            Assert.AreEqual(false, chek, "Трапецния может быть создана");
            Assert.AreEqual(3.2725, trapezoid.GetPerimeter(), 0.001, "Perimetr is correct");
            Assert.AreEqual(0.8414, trapezoid.GetArea(), 0.001, "Area is correct");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Cannot create the trapezoid with initial values")]
        public void CreateUncorrectTrap() 
        {
            double X1 = 2;
            double X2 = 2;
           

            bool chek;
            if ((X1 - X2) == 0 ) chek = true;
            else chek = false;

            Trapezoid trapezoid = new Trapezoid(X1, X2);

            Assert.AreEqual(chek, true, "Не удалось создать трапецию!");
        }

        [TestMethod]
        public void Trapezoid1()
        {
            double X1 = 2;
            double X2 = 4;

            bool chek;
            if ( (X2 - X1) == 0) chek = true;
            else chek = false;

            Trapezoid trapezoid = new Trapezoid(X1, X2);

            Assert.AreEqual(false, chek, "Трапецния может быть создана");
            Assert.AreEqual(0.7144, trapezoid.GetPerimeter(), 0.001, "Верный периметр");
            Assert.AreEqual( 1.666, trapezoid.GetArea(), 0.01, "Верная площадь");
        }
    }
}
