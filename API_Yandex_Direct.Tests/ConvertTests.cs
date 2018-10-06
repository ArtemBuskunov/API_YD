using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace API_Yandex_Direct.Tests
{
    [TestClass]
    public class ConvertTests
    {
        #region EnumArrayToStringArray()
        enum en { test1, test2, test3, test4, test5, test6, test7 };
        enum en2 { test1en2, test2en2, test3en2, test4en2, test5en2, test6en2, test7en2 };
        [TestMethod]
        public void EnumArrayToStringArrayBase()
        {
            // Arrang
            en[] enums = { en.test1, en.test2, en.test3 };
            string[] expected = { "test1", "test2", "test3" };
            // Act
            string[] vs = API_Yandex_Direct.Convert.EnumArrayToStringArray(enums);
            // Assert
            CollectionAssert.AreEqual(expected, vs);
        }
        [TestMethod]
        public void EnumArrayToStringArrayBase2()
        {
            // Arrang
            en[] enums = { en.test1, en.test2, en.test3 };
            en[] enums2 = { en.test4, en.test5, en.test3 };
            string[] expected = { "test1", "test2", "test3" };
            string[] expected2 = { "test4", "test5", "test3" };
            // Act
            string[] vs = API_Yandex_Direct.Convert.EnumArrayToStringArray(enums);
            string[] vs2 = API_Yandex_Direct.Convert.EnumArrayToStringArray(enums2);
            // Assert
            CollectionAssert.AreEqual(expected, vs);
            CollectionAssert.AreEqual(expected2, vs2);
        }
        [TestMethod]
        public void EnumArray2ToStringArrayBase2()
        {
            // Arrang
            en[] enums = { en.test1, en.test2, en.test3 };
            en2[] enums2 = { en2.test3en2, en2.test1en2, en2.test5en2 };
            string[] expected = { "test1", "test2", "test3" };
            string[] expected2 = { "test3en2", "test1en2", "test5en2" };
            // Act
            string[] vs = API_Yandex_Direct.Convert.EnumArrayToStringArray(enums);
            string[] vs2 = API_Yandex_Direct.Convert.EnumArrayToStringArray(enums2);
            // Assert
            CollectionAssert.AreEqual(expected, vs);
            CollectionAssert.AreEqual(expected2, vs2);
        }
        [TestMethod]
        public void EnumArrayToStringArrayNotNull()
        {
            // Arrang
            Enum[] enums = null;
            string[] expected = { };
            // Act
            string[] vs = API_Yandex_Direct.Convert.EnumArrayToStringArray(enums);
            // Assert
            CollectionAssert.AreEqual(expected, vs);
        }
        #endregion
        #region  BitToСurrency()
        [TestMethod]
        public void BitToСurrencyBase_51055000()
        {
            // Arrang
            double expected = 51.055;
            long LongV = 51055000;
            // Act
            double vs = API_Yandex_Direct.Convert.BitToСurrency(LongV);
            // Assert
            Assert.AreEqual(expected, vs);
        }
        #endregion
        #region  СurrencyToBit()
        [TestMethod]
        public void СurrencyToBitBase_double51055000()
        {
            // Arrang
            double doubleV = 51.055;
            long expected = 51055000;
            // Act
            double vs = API_Yandex_Direct.Convert.СurrencyToBit(doubleV);
            // Assert
            Assert.AreEqual(expected, vs);
        }
        [TestMethod]
        public void СurrencyToBitBase_doubleIsNaN()
        {
            // Arrang
            double doubleV = Double.NaN;
            long expected = 0;
            // Act
            double vs = API_Yandex_Direct.Convert.СurrencyToBit(doubleV);
            // Assert
            Assert.AreEqual(expected, vs);
        }
        [TestMethod]
        public void СurrencyToBitBase_string51055000()
        {
            // Arrang
            string doubleV = "51.055";
            long expected = 51055000;
            string doubleV1 = "51,055";
            string doubleV2 = "";
            long expected2 = 0;
            // Act
            double vs = API_Yandex_Direct.Convert.СurrencyToBit(doubleV);
            double vs1 = API_Yandex_Direct.Convert.СurrencyToBit(doubleV1);
            double vs2 = API_Yandex_Direct.Convert.СurrencyToBit(doubleV2);
            // Assert
            Assert.AreEqual(expected, vs);
            Assert.AreEqual(expected, vs1);
            Assert.AreEqual(expected2, vs2);
        }
        [TestMethod]
        public void СurrencyToBitBase_stringIsNull()
        {
            // Arrang
            string doubleV = null;
            long expected = 0;
            // Act
            double vs = API_Yandex_Direct.Convert.СurrencyToBit(doubleV);
            // Assert
            Assert.AreEqual(expected, vs);
        }
        #endregion 
    }
}
