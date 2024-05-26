using NumeralConverterLib;

namespace NumeralConverterTests
{
    [TestFixture]
    internal class NumeralConverterTests
    {
        private NumeralConverter _numeralConverter;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _numeralConverter = new NumeralConverter();
        }

        [TestCase(1, ExpectedResult = "I")]
        [TestCase(2, ExpectedResult = "II")]
        [TestCase(3, ExpectedResult = "III")]
        [TestCase(4, ExpectedResult = "IV")]
        [TestCase(5, ExpectedResult = "V")]
        [TestCase(6, ExpectedResult = "VI")]
        [TestCase(9, ExpectedResult = "IX")]
        [TestCase(10, ExpectedResult = "X")]
        [TestCase(12, ExpectedResult = "XII")]
        [TestCase(20, ExpectedResult = "XX")]
        [TestCase(21, ExpectedResult = "XXI")]
        [TestCase(50, ExpectedResult = "L")]
        [TestCase(67, ExpectedResult = "LXVII")]
        [TestCase(100, ExpectedResult = "C")]
        [TestCase(300, ExpectedResult = "CCC")]
        [TestCase(500, ExpectedResult = "D")]
        [TestCase(600, ExpectedResult = "DC")]
        [TestCase(1000, ExpectedResult = "M")]
        [TestCase(1668, ExpectedResult = "MDCLXVIII")]
        [TestCase(2291, ExpectedResult = "MMCCLXXXXI")]
        public string ConvertToRoman_WhenGivenANumeral_ThenReturnTheNumeralAsRomanString(int numeral)
        {
            //Arrange and Act
            string romanNumeral = _numeralConverter.ToRomanNumeral(numeral);

            // Assert
            return romanNumeral;
        }
    }
}
