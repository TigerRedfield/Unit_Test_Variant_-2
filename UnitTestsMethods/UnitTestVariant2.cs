using UnitTestsNS;

namespace UnitTestsMethods
{
    [TestClass]
    public class UnitTestVariant2
    {
        //проверка, если x + 5 < 0 и c=0
        [TestMethod]
        public void TestMethodNull()
        {
            //входные значени€
            double a = 5;
            double b = 6;
            double c = 0;
            double x = -7;

            //результат
            double F = (1 / a * x) - b; 

            UnitTests2 test = new UnitTests2(a, b, F);

            //Act
            test.Variant2(x, c);

            //Assert
            double actual = test.ret_f;
            Assert.AreEqual(F, actual, "¬ходные значени€ должны быть: x + 5 < 0 и c=0");
        }

        //проверка, если x + 5 > 0 и c!=0
        [TestMethod]
        public void TestMethodNotNull()
        {
            //входные значени€
            double a = 5;
            double b = 6;
            double c = 5;
            double x = 0;

            //результат
            double F = (x - a) / x - 1;

            UnitTests2 test = new UnitTests2(a, b, F);

            //act
            test.Variant2(x, c);

            //Assert
            double actual = test.ret_f;
            Assert.AreEqual(F, actual, "¬ходные значени€ должны быть: x + 5 > 0 и c!=0");
        }

        //проверка, если не x + 5 < 0 и c=0 или x + 5 > 0 и c!=0
        [TestMethod]
        public void TestMethodOther()
        {
            //входные значени€
            double a = 5;
            double b = 6;
            double c = 1;
            double x = -10;

            //результат
            double F = (10 * x) / (c - 2);

            UnitTests2 test = new UnitTests2(a, b, F);

            //act
            test.Variant2(x, c);

            //Assert
            double actual = test.ret_f;
            Assert.AreEqual(F, actual, "¬ходные значени€ не должны быть: x + 5 < 0 и c=0 или x + 5 > 0 и c!=0");
        }

        //проверка, если x + 5 < 0 и c=0 или x + 5 > 0 и c!=0
        [TestMethod]
        public void TestMethodAreNotEqual()
        {
            //входные значени€
            double a = 5;
            double b = 6;
            double c = 1;
            double x = 10;

            //результат
            double F = (10 * x) / (c - 2);

            UnitTests2 test = new UnitTests2(a, b, F);

            //act
            test.Variant2(x, c);

            //Assert
            double actual = test.ret_f;
            Assert.AreNotEqual(F, actual, "¬ходные значени€ должны быть: x + 5 < 0 и c=0 или x + 5 > 0 и c!=0");
        }

        //проверка результата на тип double
        [TestMethod]
        public void TestMethodTypeOf()
        {
            //входные значени€
            double a = 5;
            double b = 6;
            double c = 1;
            double x = 10;

            //результат
            double F = (x - a) / x - 1;

            UnitTests2 test = new UnitTests2(a, b, F);

            //act
            test.Variant2(x, c);

            //Assert
            Assert.IsInstanceOfType(F, typeof(double), "¬ходной тип должен быть double");
        }

        //проверка результата на другой тип, кроме double
        [TestMethod]
        public void TestMethodNotTypeOf()
        {
            //входные значени€
            double a = 5;
            double b = 6;
            double c = 1;
            double x = 10;

            //результат
            double F = (x - a) / x - 1;

            UnitTests2 test = new UnitTests2(a, b, F);

            //act
            test.Variant2(x, c);

            //Assert
            Assert.IsNotInstanceOfType(F, typeof(string), "¬ходной тип может быть чем угодно кроме double");
        }
    }
}