using PasswordGenerator.Other.Enums;

namespace PasswordGenerator.Other
{
    public class PasswordParameters
    {
        public int PasswordLength { get; set; }

        public Amount NumbersAmount { get; set; }
        public Amount LowerEnglishAlphabetAmount { get; set; }
        public Amount UpperEnglishAlphabetAmount { get; set; }
        public Amount SpecialCharactersAmount { get; set; }

        public int ExactNumbersCount { get; set; }
        public int ExactLowerAlphabetCount { get; set; }
        public int ExactUpperAlphabetCount { get; set; }
        public int ExactSpecialCharactersCount { get; set; }
    }
}
