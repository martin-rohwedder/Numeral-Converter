namespace NumeralConverterLib
{
    public class NumeralConverter
    {
        private readonly List<(int Number, string RomanSymbol)> _romanSymbolsList = new List<(int Number, string RomanSymbol)>
        {
            (1000, "M"),
            (500, "D"),
            (100, "C"),
            (50, "L"),
            (10, "X"),
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
        };

        public string ToRomanNumeral(int numeral)
        {
            string romanNumeralString = "";

            foreach (var symbol in _romanSymbolsList)
            {
                while (numeral >= symbol.Number)
                {
                    romanNumeralString += symbol.RomanSymbol;
                    numeral -= symbol.Number;
                }
            }

            return romanNumeralString;
        }
    }
}
