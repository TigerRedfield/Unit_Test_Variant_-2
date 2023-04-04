using UnitTestsNS;

namespace UnitTestsMethods
{
    [TestClass]
    public class UnitTestVariant2
    {
        //��������, ���� x + 5 < 0 � c=0
        [TestMethod]
        public void TestMethodNull()
        {
            //������� ��������
            double a = 5;
            double b = 6;
            double c = 0;
            double x = -7;

            //���������
            double F = (1 / a * x) - b; 

            UnitTests2 test = new UnitTests2(a, b, F);

            //Act
            test.Variant2(x, c);

            //Assert
            double actual = test.ret_f;
            Assert.AreEqual(F, actual, "������� �������� ������ ����: x + 5 < 0 � c=0");
        }

        //��������, ���� x + 5 > 0 � c!=0
        [TestMethod]
        public void TestMethodNotNull()
        {
            //������� ��������
            double a = 5;
            double b = 6;
            double c = 5;
            double x = 0;

            //���������
            double F = (x - a) / x - 1;

            UnitTests2 test = new UnitTests2(a, b, F);

            //act
            test.Variant2(x, c);

            //Assert
            double actual = test.ret_f;
            Assert.AreEqual(F, actual, "������� �������� ������ ����: x + 5 > 0 � c!=0");
        }

        //��������, ���� �� x + 5 < 0 � c=0 ��� x + 5 > 0 � c!=0
        [TestMethod]
        public void TestMethodOther()
        {
            //������� ��������
            double a = 5;
            double b = 6;
            double c = 1;
            double x = -10;

            //���������
            double F = (10 * x) / (c - 2);

            UnitTests2 test = new UnitTests2(a, b, F);

            //act
            test.Variant2(x, c);

            //Assert
            double actual = test.ret_f;
            Assert.AreEqual(F, actual, "������� �������� �� ������ ����: x + 5 < 0 � c=0 ��� x + 5 > 0 � c!=0");
        }

        //��������, ���� x + 5 < 0 � c=0 ��� x + 5 > 0 � c!=0
        [TestMethod]
        public void TestMethodAreNotEqual()
        {
            //������� ��������
            double a = 5;
            double b = 6;
            double c = 1;
            double x = 10;

            //���������
            double F = (10 * x) / (c - 2);

            UnitTests2 test = new UnitTests2(a, b, F);

            //act
            test.Variant2(x, c);

            //Assert
            double actual = test.ret_f;
            Assert.AreNotEqual(F, actual, "������� �������� ������ ����: x + 5 < 0 � c=0 ��� x + 5 > 0 � c!=0");
        }

        //�������� ���������� �� ��� double
        [TestMethod]
        public void TestMethodTypeOf()
        {
            //������� ��������
            double a = 5;
            double b = 6;
            double c = 1;
            double x = 10;

            //���������
            double F = (x - a) / x - 1;

            UnitTests2 test = new UnitTests2(a, b, F);

            //act
            test.Variant2(x, c);

            //Assert
            Assert.IsInstanceOfType(F, typeof(double), "������� ��� ������ ���� double");
        }

        //�������� ���������� �� ������ ���, ����� double
        [TestMethod]
        public void TestMethodNotTypeOf()
        {
            //������� ��������
            double a = 5;
            double b = 6;
            double c = 1;
            double x = 10;

            //���������
            double F = (x - a) / x - 1;

            UnitTests2 test = new UnitTests2(a, b, F);

            //act
            test.Variant2(x, c);

            //Assert
            Assert.IsNotInstanceOfType(F, typeof(string), "������� ��� ����� ���� ��� ������ ����� double");
        }
    }
}