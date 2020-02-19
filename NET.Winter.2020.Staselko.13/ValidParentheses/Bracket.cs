namespace ValidParentheses
{
    /// <summary>
    /// Class Bracket.
    /// </summary>
    public class Bracket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bracket"/> class.
        /// </summary>
        /// <param name="openBracket">OpenBracket.</param>
        /// <param name="closeBracket">CloseBracket.</param>
        public Bracket(char openBracket, char closeBracket)
        {
            this.OpenBracket = openBracket;
            this.CloseBracket = closeBracket;
        }

        /// <summary>
        /// Gets property.
        /// </summary>
        /// <value>
        /// OpenBracket symbol.
        /// </value>
        public char OpenBracket { get; private set; }

        /// <summary>
        /// Gets property.
        /// </summary>
        /// <value>
        /// CloseBracket symbol.
        /// </value>
        public char CloseBracket { get; private set; }

        /// <summary>
        /// Method that checks is the symbol a bracket.
        /// </summary>
        /// <param name="symbol">Input sybmol.</param>
        /// <returns>True if sybmol is bracket; false otherwise.</returns>
        public bool Contains(char symbol)
        {
            return symbol == this.OpenBracket || symbol == this.CloseBracket;
        }

        /// <summary>
        /// Method that checks is the symbol a closebracket.
        /// </summary>
        /// <param name="symbol">Input sybmol.</param>
        /// <returns>True if sybmol is closebracket; false otherwise.</returns>
        public bool IsClose(char symbol)
        {
            return symbol == this.CloseBracket;
        }

        /// <summary>
        /// Method that checks is the symbol a openbracket.
        /// </summary>
        /// <param name="symbol">Input sybmol.</param>
        /// <returns>True if sybmol is openbracket; false otherwise.</returns>
        public bool IsOpen(char symbol)
        {
            return symbol == this.OpenBracket;
        }
    }
}
