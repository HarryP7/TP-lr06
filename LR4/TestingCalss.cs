using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;
using NUnit.Framework;
using System;
using System.Text.RegularExpressions;

namespace LR4
{
    [TestFixture]
    public class TestFixture1
    {
        [Test]
        public void TestGetDayOfWeekName()
        {
            NUnit.Framework.Assert.AreEqual("Понедельник", WeekDayConverter.GetNameByDay(1));
            NUnit.Framework.Assert.AreEqual("Вторник", WeekDayConverter.GetNameByDay(2));
            NUnit.Framework.Assert.AreEqual("Среда", WeekDayConverter.GetNameByDay(3));
            NUnit.Framework.Assert.AreEqual("Четверг", WeekDayConverter.GetNameByDay(4));
            NUnit.Framework.Assert.AreEqual("Пятница", WeekDayConverter.GetNameByDay(5));
            NUnit.Framework.Assert.AreEqual("Суббота", WeekDayConverter.GetNameByDay(6));
            NUnit.Framework.Assert.AreEqual("Воскресенье", WeekDayConverter.GetNameByDay(7));
        }
        [Test, ExpectedException(typeof(ArgumentException))]
        public void TestGetDayOfWeekNameInvalidArgument()
        {
            WeekDayConverter.GetNameByDay(8);
        }
        [Test]
        public void TestSumMult()
        {
            double x = 10000000000000000000,
                   y = 10000000000000000000;
            String res = Class1.SumFunc(x, y);
            double Sum = x + y;
            double Mult = x * y;
            String expectedResult = "Summ = " + Sum + " Multiply = " + Mult;
            NUnit.Framework.Assert.That(expectedResult, Is.EqualTo(res));
        }
        [Test]
        public void TestPlaseWork()
        {
            NUnit.Framework.Assert.AreEqual("Фирма корректна", Castomer.chekPlaseWork("OOO Континент"));
            NUnit.Framework.Assert.AreEqual("Фирма корректна", Castomer.chekPlaseWork("ПАО Лукойл"));
            NUnit.Framework.Assert.AreEqual("Фирма корректна", Castomer.chekPlaseWork("ПАО МегаФон"));
            NUnit.Framework.Assert.AreEqual("Фирма не существует\nПовтотрите ввод", Castomer.chekPlaseWork("ffff"));
            NUnit.Framework.Assert.AreEqual("Фирма корректна", Castomer.chekPlaseWork("ООО Трансстрой"));
            NUnit.Framework.Assert.AreEqual("Фирма не существует\nПовтотрите ввод", Castomer.chekPlaseWork("Фирма"));
            NUnit.Framework.Assert.AreEqual("Фирма не существует\nПовтотрите ввод", Castomer.chekPlaseWork("??dd"));
        }
        [Test]
        public void TestLogin()
        {
            NUnit.Framework.Assert.AreEqual("Введите корректный E-mail, более 4х символов.", Password.chekLogin
                         ("sdc"));
            NUnit.Framework.Assert.AreEqual("Введите корректный E-mail, более 4х символов.", Password.chekLogin
                        ("gri@gmail.com"));
            NUnit.Framework.Assert.AreEqual("", Password.chekLogin
                        ("grcdi@gmail.com"));
            NUnit.Framework.Assert.AreEqual("", Password.chekLogin
                        ("grm"));
        }
    }
}
