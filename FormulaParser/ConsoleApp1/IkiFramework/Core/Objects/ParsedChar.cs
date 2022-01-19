using System;
using System.Text;
namespace IkiCore
{
    public class ParsedChar
    {
        public ParsedChar Left = null;
        public ParsedChar Right = null;
        public int Line;
        public char Character;
        public char PreviousChar { get { return Left == null ? ' ' : Left.Character; } }
        public char NextChar { get { return Right == null ? ' ' : Right.Character; } }
        public bool IsDigit { get { return char.IsDigit(Character); } }
        public bool IsWhiteSpace { get { return char.IsWhiteSpace(Character); } }
        public bool IsControl { get { return char.IsControl(Character); } }
        public bool IsLetter { get { return char.IsLetter(Character); } }
        public bool IsLetterOrDigit { get { return char.IsLetterOrDigit(Character); } }
        public bool IsLower { get { return char.IsLower(Character); } }
        public bool IsUpper { get { return char.IsUpper(Character); } }
        public bool IsPunctuation { get { return char.IsPunctuation(Character); } }
        public bool IsSymbol { get { return char.IsSymbol(Character); } }
        public bool IsAnySymbol { get { return char.IsSymbol(Character) || char.IsPunctuation(Character); } }
        public bool IsSeparator { get { return char.IsSeparator(Character); } }
        public bool IsEmpty { get { return char.IsControl(Character) || char.IsWhiteSpace(Character) || char.IsSeparator(Character); } }
        public bool IsNewLine { get { return Character == '\n'; } }
        public int GetNextLine { get { return Character == '\n' ? Line + 1 : Line; } }
        public ParsedChar(char character)
        {
            Line = 1;
            Character = character;
        }
        public ParsedChar(string text, int nextIndex = 0, ParsedChar left = null)
        {
            if(text.Length == 0 || text == null || nextIndex < 0)
            {
                Character = ' ';
                Line = -1;
                return;
            }
            if(left == null)
            {
                nextIndex = 0;
                Character = text[nextIndex];
                Line = 1;
                nextIndex++;
                if (nextIndex < text.Length)
                {
                    Right = new ParsedChar(text, nextIndex, this);
                }
            }
            else
            {
                Left = left;
                Character = text[nextIndex];
                Line = Left.GetNextLine;
                nextIndex++;
                if (nextIndex < text.Length)
                {
                    Right = new ParsedChar(text, nextIndex, this);
                }
            }
        }
        public ParsedChar(int line, char character)
        {
            Line = line;
            Character = character;
        }
        public ParsedChar CopyValues()
        {
            return new ParsedChar(Line, Character);
        }
        public string GetStringFromThisToLeft(int count)
        {
            StringBuilder sb = new StringBuilder();
            Previous(Left, sb, count - 1);
            if (count > 0)
            {
                sb.Append(Character);
            }
            return sb.ToString();
        }
        public string GetStringFromThisToLeft(int count, Func<char, string> changeCharacter)
        {
            StringBuilder sb = new StringBuilder();
            Previous(Left, sb, count - 1, changeCharacter);
            if (count > 0)
            {
                sb.Append(changeCharacter(Character));
            }
            return sb.ToString();
        }
        public string GetStringFromThisToLeft(int count, Func<ParsedChar, string> changeCharacter)
        {
            StringBuilder sb = new StringBuilder();
            Previous(Left, sb, count - 1, changeCharacter);
            if (count > 0)
            {
                sb.Append(changeCharacter(this));
            }
            return sb.ToString();
        }
        public string GetStringFromThisToRight(int count)
        {
            StringBuilder sb = new StringBuilder();
            if (count > 0)
            {
                sb.Append(Character);
            }
            if (Right != null)
            {
                Next(Right, sb, count - 1);
            }
            return sb.ToString();
        }
        public string GetStringFromThisToRight(int count, Func<char, string> changeCharacter)
        {
            StringBuilder sb = new StringBuilder();
            if (count > 0)
            {
                sb.Append(changeCharacter(Character));
            }
            if (Right != null)
            {
                Next(Right, sb, count - 1, changeCharacter);
            }
            return sb.ToString();
        }
        public string GetStringFromThisToRight(int count, Func<ParsedChar, string> changeCharacter)
        {
            StringBuilder sb = new StringBuilder();
            if (count > 0)
            {
                sb.Append(changeCharacter(this));
            }
            if (Right != null)
            {
                Next(Right, sb, count - 1, changeCharacter);
            }
            return sb.ToString();
        }
        public string GetLeftString(int count)
        {
            StringBuilder sb = new StringBuilder();
            Previous(Left, sb, count);
            return sb.ToString();
        }
        public string GetLeftString(int count, Func<char, string> changeCharacter)
        {
            StringBuilder sb = new StringBuilder();
            Previous(Left, sb, count, changeCharacter);
            return sb.ToString();
        }
        public string GetLeftString(int count, Func<ParsedChar, string> changeCharacter)
        {
            StringBuilder sb = new StringBuilder();
            Previous(Left, sb, count, changeCharacter);
            return sb.ToString();
        }
        public string GetLeftStringWhile(Func<char, bool> test)
        {
            StringBuilder sb = new StringBuilder();
            PreviousWhile(Left, sb, test);
            return sb.ToString();
        }
        public string GetLeftStringWhile(Func<ParsedChar, bool> test)
        {
            StringBuilder sb = new StringBuilder();
            PreviousWhile(Left, sb, test);
            return sb.ToString();
        }
        public string GetRightString(int count)
        {
            StringBuilder sb = new StringBuilder();
            Next(Right, sb, count);
            return sb.ToString();
        }
        public string GetRightString(int count, Func<char, string> changeCharacter)
        {
            StringBuilder sb = new StringBuilder();
            Next(Right, sb, count, changeCharacter);
            return sb.ToString();
        }
        public string GetRightString(int count, Func<ParsedChar, string> changeCharacter)
        {
            StringBuilder sb = new StringBuilder();
            Next(Right, sb, count, changeCharacter);
            return sb.ToString();
        }
        public string GetRightStringWhile(Func<char, bool> test)
        {
            StringBuilder sb = new StringBuilder();
            NextWhile(Right, sb, test);
            return sb.ToString();
        }
        public string GetRightStringWhile(Func<ParsedChar, bool> test)
        {
            StringBuilder sb = new StringBuilder();
            NextWhile(Right, sb, test);
            return sb.ToString();
        }
        public string GetStringExpended(int count)
        {
            StringBuilder sb = new StringBuilder();
            if (count > 0)
            {
                Previous(Left, sb, count - 1);
                sb.Append(Character);
                Next(Right, sb, count - 1);
            }
            return sb.ToString();
        }
        public string GetStringExpendedWhile(Func<char, bool> test)
        {
            StringBuilder sb = new StringBuilder();
            if(test(Character))
            {
                PreviousWhile(Left, sb, test);
                sb.Append(Character);
                NextWhile(Right, sb, test);
            }
            return sb.ToString();
        }
        public string GetStringExpendedWhile(Func<char, char, bool> test, char charToTest)
        {
            StringBuilder sb = new StringBuilder();
            if (test(Character, charToTest))
            {
                PreviousWhile(Left, sb, test, charToTest);
                sb.Append(Character);
                NextWhile(Right, sb, test, charToTest);
            }
            return sb.ToString();
        }
        public string GetStringExpendedWhile(Func<ParsedChar, bool> test)
        {
            StringBuilder sb = new StringBuilder();
            if (test(this))
            {
                PreviousWhile(Left, sb, test);
                sb.Append(Character);
                NextWhile(Right, sb, test);
            }
            return sb.ToString();
        }
        public bool IsValueFromThisToLeft(string testInput)
        {
            return testInput == GetStringFromThisToLeft(testInput.Length);
        }
        public bool IsValueFromThisToRight(string testInput)
        {
            return testInput == GetStringFromThisToRight(testInput.Length);
        }
        public bool IsPattern(string left, char center, string right)
        {
            return left == GetLeftString(left.Length) && center == Character && right == GetRightString(right.Length);
        }
        public bool IsPattern(string left, char center, string right, Func<char, bool> leftTest, Func<char, bool> rightTest)
        {
            return left == GetLeftStringWhile(leftTest) && center == Character && right == GetLeftStringWhile(rightTest);
        }
        public bool IsPattern(string left, char center, string right, Func<ParsedChar, bool> leftTest, Func<ParsedChar, bool> rightTest)
        {
            return left == GetLeftStringWhile(leftTest) && center == Character && right == GetLeftStringWhile(rightTest);
        }
        public int GetPreviousIndex(int index, char value)
        {
            index--;
            if (Left != null)
            {
                if (PreviousChar == value)
                {
                    return index;
                }
                return Left.GetPreviousIndex(index, value);
            }
            return -1;
        }
        public int GetPreviousIndex(int index, Func<char, bool> test)
        {
            index--;
            if (Left != null)
            {
                if (test(NextChar))
                {
                    return index;
                }
                return Left.GetPreviousIndex(index, test);
            }
            return -1;
        }
        public int GetPreviousIndex(int index, Func<ParsedChar, bool> test)
        {
            index--;
            if (Left != null)
            {
                if (test(Left))
                {
                    return index;
                }
                return Left.GetPreviousIndex(index, test);
            }
            return -1;
        }
        public int GetNextIndex(int index, char value)
        {
            index++;
            if (Right != null)
            {
                if (NextChar == value)
                {
                    return index;
                }
                return Right.GetNextIndex(index, value);
            }
            return -1;
        }
        public int GetNextIndex(int index, Func<char, bool> test)
        {
            index++;
            if (Right != null)
            {
                if(test(NextChar))
                {
                    return index;
                }
                return Right.GetNextIndex(index, test);
            }
            return -1;
        }
        public int GetNextIndex(int index, Func<ParsedChar, bool> test)
        {
            index++;
            if (Right != null)
            {
                if (test(Right))
                {
                    return index;
                }
                return Right.GetNextIndex(index, test);
            }
            return -1;
        }
        public int NextLineIndex(int index, int line = -1)
        {
            if(line == -1)
            {
                line = Line;
            }
            if(Right != null)
            {
                if(Right.Line != line)
                {
                    return index;
                }
                return Right.NextLineIndex(index + 1, line);
            }
            return -1;
        }
        public int PreviousLineIndex(int index, int line = -1)
        {
            if (line == -1)
            {
                line = Line;
            }
            if (Left != null)
            {
                if (Left.Line != line)
                {
                    return index;
                }
                return Left.PreviousLineIndex(index - 1, line);
            }
            return -1;
        }
        public void CorrectLines(bool childIncluded = true)
        {
            if (Left != null)
            {
                Line = Left.GetNextLine;
                if (Right != null && childIncluded)
                {
                    Right.CorrectLines(childIncluded);
                }
            }
            else
            {
                Line = 1;
            }
        }
        void Previous(ParsedChar actualKey, StringBuilder sb, int count)
        {
            if (count <= 0 || actualKey == null)
            {
                return;
            }
            Previous(actualKey.Left, sb, count - 1);
            sb.Append(actualKey.Character);
        }
        void Previous(ParsedChar actualKey, StringBuilder sb, int count, Func<char, string> replace)
        {
            if (count <= 0 || actualKey == null)
            {
                return;
            }
            Previous(actualKey.Left, sb, count - 1, replace);
            sb.Append(replace(actualKey.Character));
        }
        void Previous(ParsedChar actualKey, StringBuilder sb, int count, Func<ParsedChar, string> replace)
        {
            if (count <= 0 || actualKey == null)
            {
                return;
            }
            Previous(actualKey.Left, sb, count - 1, replace);
            sb.Append(replace(actualKey));
        }
        void PreviousWhile(ParsedChar actualKey, StringBuilder sb, Func<char, bool> test)
        {
            if (actualKey == null)
            {
                return;
            }
            if (test(actualKey.Character))
            {
                PreviousWhile(actualKey.Left, sb, test);
                sb.Append(actualKey.Character);
            }
        }
        void PreviousWhile(ParsedChar actualKey, StringBuilder sb, Func<char, char, bool> test, char charToTest)
        {
            if (actualKey == null)
            {
                return;
            }
            if (test(actualKey.Character, charToTest))
            {
                PreviousWhile(actualKey.Left, sb, test, charToTest);
                sb.Append(actualKey.Character);
            }
        }
        void PreviousWhile(ParsedChar actualKey, StringBuilder sb, Func<ParsedChar, bool> test)
        {
            if (actualKey == null)
            {
                return;
            }
            if (test(actualKey))
            {
                PreviousWhile(actualKey.Left, sb, test);
                sb.Append(actualKey.Character);
            }
        }
        void Next(ParsedChar actualKey, StringBuilder sb, int count)
        {
            if (count <= 0 || actualKey == null)
            {
                return;
            }
            sb.Append(actualKey.Character);
            Next(actualKey.Right, sb, count - 1);
        }
        void Next(ParsedChar actualKey, StringBuilder sb, int count, Func<char, string> replace)
        {
            if (count <= 0 || actualKey == null)
            {
                return;
            }
            sb.Append(replace(actualKey.Character));
            Next(actualKey.Right, sb, count - 1, replace);
        }
        void Next(ParsedChar actualKey, StringBuilder sb, int count, Func<ParsedChar, string> replace)
        {
            if (count <= 0 || actualKey == null)
            {
                return;
            }
            sb.Append(replace(actualKey));
            Next(actualKey.Right, sb, count - 1, replace);
        }
        void NextWhile(ParsedChar actualKey, StringBuilder sb, Func<char, bool> test)
        {
            if (actualKey == null)
            {
                return;
            }
            if (test(actualKey.Character))
            {
                sb.Append(actualKey.Character);
                NextWhile(actualKey.Right, sb, test);
            }
        }
        void NextWhile(ParsedChar actualKey, StringBuilder sb, Func<char, char, bool> test, char charToTest)
        {
            if (actualKey == null)
            {
                return;
            }
            if (test(actualKey.Character, charToTest))
            {
                sb.Append(actualKey.Character);
                NextWhile(actualKey.Right, sb, test, charToTest);
            }
        }
        void NextWhile(ParsedChar actualKey, StringBuilder sb, Func<ParsedChar, bool> test)
        {
            if (actualKey == null)
            {
                return;
            }
            if (test(actualKey))
            {
                sb.Append(actualKey.Character);
                NextWhile(actualKey.Right, sb, test);
            }
        }
    }
}
