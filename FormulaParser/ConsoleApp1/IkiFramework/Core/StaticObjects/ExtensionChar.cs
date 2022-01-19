namespace IkiCore
{
    public static class ExtensionChar
    {
        /// <summary>
        /// Indicates whether the specified character is a high surrogate.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsHighSurrogate(this char x) => char.IsHighSurrogate(x);
        /// <summary>
        /// Indicates whether the specified character is a low surrogate.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsLowSurrogate(this char x) => char.IsLowSurrogate(x);
        /// <summary>
        /// Indicates whether the specified character has a surrogate code unit.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsSurrogate(this char x) => char.IsSurrogate(x);
        /// <summary>
        /// Return true if the two specified character form a surrogate pair.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool IsSurrogatePair(this char x, char y) => char.IsSurrogatePair(x, y);
        /// <summary>
        /// Return true if the character is considered as a punctuation character.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPunctuation(this char x) => char.IsPunctuation(x);
        /// <summary>
        /// Return true if the character is considered as a separator character.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsSeparator(this char x) => char.IsSeparator(x);
        /// <summary>
        /// Return true if the character is considered as a symbol character.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsSymbol(this char x) => char.IsSymbol(x);
        /// <summary>
        /// Return true if the character is considered as a number character.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsNumber(this char x) => char.IsNumber(x);
        /// <summary>
        /// Return true if the character is considered as a control character.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsControl(this char x) => char.IsControl(x);
        /// <summary>
        /// Return true if the character is considered as a lowercase letter character.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsLower(this char x) => char.IsLower(x);
        /// <summary>
        /// Return true if the character is considered as a uppercase letter character.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsUpper(this char x) => char.IsUpper(x);
        /// <summary>
        /// Return true if the character is considered as a letter character.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsLetter(this char x) => char.IsLetter(x);
        /// <summary>
        /// Return true if the character is considered as a decimal digit or letter character.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsLetterOrDigit(this char x) => char.IsLetterOrDigit(x);
        /// <summary>
        /// Return true if the character is considered as a decimal digit character.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsDigit(this char x) => char.IsDigit(x);
        /// <summary>
        /// Return true if the character is considered as a white space character.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsWhiteSpace(this char x) => char.IsWhiteSpace(x);
    }
}
