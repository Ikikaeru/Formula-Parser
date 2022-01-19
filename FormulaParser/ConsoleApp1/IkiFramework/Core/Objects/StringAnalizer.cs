using System;
using System.Collections.Generic;
using System.Text;
namespace IkiCore
{
    public class StringAnalizer
    {
        public char this[int index]
        {
            get
            {
                if (index >= 0 && index < values.Count)
                {
                    return values[index].Character;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if(index >= 0 && index < values.Count)
                {
                    if (values[index].Character != value)
                    {
                        Checks(values[index].Character, BaseOp.Decrement);
                        if (WordCheck(values[index].PreviousChar, values[index].Character, values[index].NextChar))
                        {
                            WordsCount--;
                        }
                        values[index].Character = value;
                        Checks(values[index].Character, BaseOp.Increment);
                        if (WordCheck(values[index].PreviousChar, values[index].Character, values[index].NextChar))
                        {
                            WordsCount++;
                        }
                        values[index].CorrectLines();
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public int Count { get { return values.Count; } }
        public int LineCount { get; private set; }
        public int WordsCount { get; private set; }
        public int SymbolsCount { get; private set; }
        public int SeparatorCount { get; private set; }
        public int LetterCount { get; private set; }
        public int DigitCount { get; private set; }
        List<ParsedChar> values = new List<ParsedChar>();
        char lastChar { get { return values.Count > 0 ? values[values.Count - 1].Character : ' '; } }
        void LastWordCheck(char input)
        {
            if(WordCheck(lastChar, input, ' '))
            {
                WordsCount++;
            }
        }
        bool WordCheck(char previous, char input, char next)
        {
            bool previousIsEmpty = char.IsWhiteSpace(previous) || char.IsControl(previous);
            bool actualIsEmpty = char.IsWhiteSpace(input) || char.IsControl(input);
            bool nextIsEmpty = char.IsWhiteSpace(next) || char.IsControl(next);
            return (previousIsEmpty ^ actualIsEmpty) && (actualIsEmpty ^ nextIsEmpty); // (true - false - true && false - true - false) == true
        }
        bool WordCheck(int index, char input)
        {
            if(index >= 0 && index < values.Count)
            {
                bool previousIsEmpty = index > 0 ? char.IsWhiteSpace(values[index - 1].Character) || char.IsControl(values[index - 1].Character) : true;
                bool actualIsEmpty = char.IsWhiteSpace(input) || char.IsControl(input);
                bool nextIsEmpty = index + 1 < values.Count ? char.IsWhiteSpace(values[index + 1].Character) || char.IsControl(values[index + 1].Character) : true;
                return (previousIsEmpty ^ actualIsEmpty) && (actualIsEmpty ^ nextIsEmpty); // (true - false - true && false - true - false) == true
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        void TreeBranchingLines(int index, bool checkLines = true)
        {
            if(index < values.Count && index >= 0 && values.Count > 0)
            {
                if(index == 0)
                {
                    values[index].Left = null;
                    values[index].Line = 1;
                    if(values.Count > 1)
                    {
                        values[index].Right = values[index + 1];
                    }
                    if (checkLines)
                    {
                        values[index].CorrectLines();
                    }
                }
                else if(index == values.Count - 1)
                {
                    values[index - 1].Right = values[index];
                    values[index].Left = values[index - 1];
                    values[index].Right = null;
                    if (checkLines)
                    {
                        values[index].Line = values[index].Left.GetNextLine;
                    }
                }
                else
                {
                    values[index - 1].Right = values[index];
                    values[index].Left = values[index - 1];
                    values[index].Right = values[index + 1];
                    values[index + 1].Left = values[index];
                    if (checkLines)
                    {
                        values[index].CorrectLines();
                    }
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        void Checks(char input, BaseOp baseOp)
        {
            LineCount = IfOrIf(input, LineCount, baseOp, IsNewLine);
            DigitCount = IfOrIf(input, DigitCount, baseOp, char.IsDigit);
            LetterCount = IfOrIf(input, LetterCount, baseOp, char.IsLetter);
            SeparatorCount = IfOrIf(input, SeparatorCount, baseOp, char.IsSeparator);
            SymbolsCount = IfOrIf(input, SymbolsCount, baseOp, char.IsPunctuation, char.IsSymbol);
        }
        bool IsNewLine(char input)
        {
            return input == '\n';
        }
        enum BaseOp
        {
            Increment,
            Decrement
        }
        string OverrideValues(char input)
        {
            switch (input)
            {
                case '\n':
                    return "\\n\n";
                case '\r':
                    return "\\r";
                case '\b':
                    return "\\b";
                case '\t':
                    return "\\t";
                case '\f':
                    return "\\f";
                case '\v':
                    return "\\v";
                case '\a':
                    return "\\a";
                default:
                    return input.ToString();
            }
        }
        bool GetEmptyChar(char input)
        {
            return char.IsControl(input) || char.IsWhiteSpace(input) || char.IsSeparator(input);
        }
        bool GetNotEmptyChar(char input)
        {
            return !(char.IsControl(input) || char.IsWhiteSpace(input) || char.IsSeparator(input));
        }
        int IfOrIf(char input, int number, BaseOp baseOp, params Func<char, bool>[] test)
        {
            bool isTrue = false;
            for (int i = 0; i < test.Length; i++)
            {
                isTrue |= test[i](input);
            }
            return isTrue ? (baseOp == BaseOp.Increment ? number + 1 : number - 1) : number;
        }
        bool NotEqualChar(char input, char testChar)
        {
            return input != testChar;
        }
        public StringAnalizer()
        {
            LineCount = 0;
            DigitCount = 0;
            LetterCount = 0;
            SeparatorCount = 0;
            SymbolsCount = 0;
            WordsCount = 0;
        }
        public StringAnalizer(List<ParsedChar> content, bool checkLines = false)
        {
            LineCount = content.Count > 0 ? 1 : 0;
            DigitCount = 0;
            LetterCount = 0;
            SeparatorCount = 0;
            SymbolsCount = 0;
            WordsCount = 0;
            for (int i = 0; i < content.Count; i++)
            {
                Add(content[i], checkLines);
            }
        }
        public StringAnalizer(string content, bool checkLines = true)
        {
            LineCount = content.Length > 0 ? 1 : 0;
            DigitCount = 0;
            LetterCount = 0;
            SeparatorCount = 0;
            SymbolsCount = 0;
            WordsCount = 0;
            for (int i = 0; i < content.Length; i++)
            {
                Add(content[i], checkLines);
            }
        }
        public StringAnalizer(string content, bool checkLines, params char[] skipChars)
        {
            LineCount = content.Length > 0 ? 1 : 0;
            DigitCount = 0;
            LetterCount = 0;
            SeparatorCount = 0;
            SymbolsCount = 0;
            WordsCount = 0;
            bool write;
            for (int i = 0; i < content.Length; i++)
            {
                write = true;
                foreach (var item in skipChars)
                {
                    if (item == content[i])
                    {
                        write = false;
                        break;
                    }
                }
                if (write)
                {
                    Add(content[i], checkLines);
                }
            }
        }
        public ParsedChar GetParsedChar(int index)
        {
            if (index < 0 || index >= values.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return values[index];
        }
        public ParsedChar GetParsedCharCopy(int index)
        {
            if (index < 0 || index >= values.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return new ParsedChar(values[index].Line, values[index].Character);
        }
        public void Add(char input, bool checkLines = true)
        {
            Checks(input, BaseOp.Increment);
            LastWordCheck(input);
            values.Add(new ParsedChar(input));
            TreeBranchingLines(values.Count - 1, checkLines);
        }
        public void Add(char input, int line)
        {
            Checks(input, BaseOp.Increment);
            LastWordCheck(input);
            values.Add(new ParsedChar(line, input));
            TreeBranchingLines(values.Count - 1, false);
        }
        public void Add(ParsedChar input, bool checkLines = true)
        {
            Checks(input.Character, BaseOp.Increment);
            LastWordCheck(input.Character);
            values.Add(input);
            TreeBranchingLines(values.Count - 1, checkLines);
        }
        public void AddCharBeforeChar(char input, char charToTest, bool checkLines = true)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if (charToTest == values[i].Character)
                {
                    InsertAt(i, input, checkLines);
                    i++;
                }
            }
        }
        public void AddCharBeforeTest(char input, Func<char, bool> test, bool checkLines = true)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if(test(values[i].Character))
                {
                    InsertAt(i, input, checkLines);
                    i++;
                }
            }
        }
        public void AddCharBeforeTest(char input, Func<ParsedChar, bool> test, bool checkLines = true)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if (test(values[i]))
                {
                    InsertAt(i, input, checkLines);
                    i++;
                }
            }
        }
        public void AddCharAfterTest(char input, Func<char, bool> test, bool checkLines = true)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if (test(values[i].Character))
                {
                    if(i + 1 < values.Count)
                    {
                        InsertAt(i + 1, input, checkLines);
                    }
                    else
                    {
                        Add(input, checkLines);
                    }
                    i++;
                }
            }
        }
        public void AddCharAfterTest(char input, Func<ParsedChar, bool> test, bool checkLines = true)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if (test(values[i]))
                {
                    if (i + 1 < values.Count)
                    {
                        InsertAt(i + 1, input, checkLines);
                    }
                    else
                    {
                        Add(input, checkLines);
                    }
                    i++;
                }
            }
        }
        public void AddCharAfterChar(char input, char charToTest, bool checkLines = true)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if (charToTest == values[i].Character)
                {
                    if (i + 1 < values.Count)
                    {
                        InsertAt(i + 1, input, checkLines);
                    }
                    else
                    {
                        Add(input, checkLines);
                    }
                    i++;
                }
            }
        }
        public void InsertAt(int index, List<ParsedChar> content, bool checkLines = true)
        {
            if (index >= 0 && index < values.Count)
            {
                int newIndex;
                for (int i = 0; i < content.Count; i++)
                {
                    newIndex = i + index;
                    Checks(content[i].Character, BaseOp.Increment);
                    if (WordCheck(newIndex, content[i].Character))
                    {
                        WordsCount++;
                    }
                    values.Insert(newIndex, content[i]);
                    TreeBranchingLines(newIndex, false);
                }
                if(checkLines)
                {
                    values[index].CorrectLines();
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void InsertAt(int index, char input, bool checkLines = true)
        {
            if (index >= 0 && index < values.Count)
            {
                Checks(input, BaseOp.Increment);
                if (WordCheck(index, input))
                {
                    WordsCount++;
                }
                values.Insert(index, new ParsedChar(input));
                TreeBranchingLines(index, checkLines);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void InsertAt(int index, ParsedChar input, bool checkLines = true)
        {
            if (index >= 0 && index < values.Count)
            {
                Checks(input.Character, BaseOp.Increment);
                if (WordCheck(index, input.Character))
                {
                    WordsCount++;
                }
                values.Insert(index, new ParsedChar(input.Line, input.Character));
                TreeBranchingLines(index, checkLines);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void Remove(char input, bool checkLines = true)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if(values[i].Character == input)
                {
                    RemoveAt(i, checkLines);
                    i--;
                }
            }
        }
        public void Remove(ParsedChar key, bool checkLines = true)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].Equals(key))
                {
                    RemoveAt(i, false);
                    break;
                }
            }
            if(checkLines && values.Count > 0)
            {
                values[0].CorrectLines();
            }
        }
        public void Remove(Func<char, bool> test, bool checkLines = true)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if(test(values[i].Character))
                {
                    RemoveAt(i, false);
                    i--;
                }
            }
            if(checkLines && values.Count > 0)
            {
                values[0].CorrectLines();
            }
        }
        public void Remove(Func<ParsedChar, bool> test, bool checkLines = true)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if (test(values[i]))
                {
                    RemoveAt(i, false);
                    i--;
                }
            }
            if (checkLines && values.Count > 0)
            {
                values[0].CorrectLines();
            }
        }
        public void RemoveAt(int index, bool checkLines = true)
        {
            if (index >= 0 && index < values.Count)
            {
                Checks(values[index].Character, BaseOp.Decrement);
                if (WordCheck(index, values[index].Character))
                {
                    WordsCount--;
                }
                values.RemoveAt(index);
                if(index < values.Count)
                {
                    TreeBranchingLines(index, checkLines);
                }
                else if(index - 1 >= 0)
                {
                    TreeBranchingLines(index - 1, checkLines);
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void RemoveFromTo(int indexA, int indexB, bool checkLines = true)
        {
            if((indexA >= 0 && indexA < values.Count) && (indexB >= 0 && indexB < values.Count))
            {
                int absDiff = indexB - indexA;
                absDiff = absDiff >= 0 ? absDiff : -absDiff;
                if(indexB - indexA >= 0)
                {
                    for (int i = 0; i <= absDiff; i++)
                    {
                        RemoveAt(indexA, false);
                    }
                }
                else
                {
                    for (int i = 0; i <= absDiff; i++)
                    {
                        RemoveAt(indexB, false);
                    }
                }
                if (checkLines && values.Count > 0)
                {
                    values[0].CorrectLines();
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void RemoveFromThisToLeftCount(int index, int count, bool checkLines = true)
        {
            if (index < values.Count && index >= 0)
            {
                for (int i = 0; i < count; i--)
                {
                    if ((index - i) < values.Count)
                    {
                        RemoveAt(index - i, false);
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkLines && values.Count > 0)
                {
                    values[0].CorrectLines();
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void RemoveLeft(int index, bool checkLines = true)
        {
            if (index >= 0 && index < values.Count)
            {
                for (int i = index - 1; i >= 0; i--)
                {
                    RemoveAt(i, false);
                }
                if(checkLines && values.Count > 0)
                {
                    values[0].CorrectLines();
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void RemoveLeftWhile(int index, Func<char, bool> test, bool checkLines = true)
        {
            if (index >= 0 && index < values.Count)
            {
                for (int i = index - 1; i >= 0; i--)
                {
                    if(test(values[i].Character))
                    {
                        RemoveAt(i, false);
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkLines && values.Count > 0)
                {
                    values[0].CorrectLines();
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void RemoveLeftWhile(int index, Func<ParsedChar, bool> test, bool checkLines = true)
        {
            if (index >= 0 && index < values.Count)
            {
                for (int i = index - 1; i >= 0; i--)
                {
                    if (test(values[i]))
                    {
                        RemoveAt(i, false);
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkLines && values.Count > 0)
                {
                    values[0].CorrectLines();
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void RemoveFromToLeftWhile(int index, Func<char, bool> test, bool checkLines = true)
        {
            if (index >= 0 && index < values.Count)
            {
                for (int i = index; i >= 0; i--)
                {
                    if (test(values[i].Character))
                    {
                        RemoveAt(i, false);
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkLines && values.Count > 0)
                {
                    values[0].CorrectLines();
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void RemoveFromToLeftWhile(int index, Func<ParsedChar, bool> test, bool checkLines = true)
        {
            if (index >= 0 && index < values.Count)
            {
                for (int i = index; i >= 0; i--)
                {
                    if (test(values[i]))
                    {
                        RemoveAt(i, false);
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkLines && values.Count > 0)
                {
                    values[0].CorrectLines();
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void RemoveFromThisToRightCount(int index, int count, bool checkLines = true)
        {
            if (index < values.Count && index >= 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (index < values.Count)
                    {
                        RemoveAt(index, false);
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkLines && values.Count > 0)
                {
                    values[0].CorrectLines();
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void RemoveRight(int index)
        {
            if (index >= 0 && index < values.Count)
            {
                while ((index + 1) < values.Count)
                {
                    RemoveAt(index + 1, false);
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void RemoveRightWhile(int index, Func<char, bool> test, bool checkLines = true)
        {
            if (index >= 0 && index < values.Count)
            {
                for (int i = index + 1; i < values.Count; i++)
                {
                    if (test(values[i].Character))
                    {
                        RemoveAt(i, false);
                        i--;
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkLines && values.Count > 0)
                {
                    values[0].CorrectLines();
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void RemoveRightWhile(int index, Func<ParsedChar, bool> test, bool checkLines = true)
        {
            if (index >= 0 && index < values.Count)
            {
                for (int i = index + 1; i < values.Count; i++)
                {
                    if (test(values[i]))
                    {
                        RemoveAt(i, false);
                        i--;
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkLines && values.Count > 0)
                {
                    values[0].CorrectLines();
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void RemoveFromToRightWhile(int index, Func<char, bool> test, bool checkLines = true)
        {
            if (index >= 0 && index < values.Count)
            {
                for (int i = index; i < values.Count; i++)
                {
                    if(test(values[i].Character))
                    {
                        RemoveAt(i, false);
                        i--;
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkLines && values.Count > 0)
                {
                    values[0].CorrectLines();
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void RemoveFromToRightWhile(int index, Func<ParsedChar, bool> test, bool checkLines = true)
        {
            if (index >= 0 && index < values.Count)
            {
                for (int i = index; i < values.Count; i++)
                {
                    if (test(values[i]))
                    {
                        RemoveAt(i, false);
                        i--;
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkLines && values.Count > 0)
                {
                    values[0].CorrectLines();
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public int GetLine(int index)
        {
            if (index >= 0 && index < values.Count)
            {
                return values[index].Line;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public List<ParsedChar> ExtractParsedLine(int line)
        {
            List<ParsedChar> pc = new List<ParsedChar>();
            for (int i = 0; i < values.Count; i++)
            {
                pc.Add(new ParsedChar(values[i].Line, values[i].Character));
            }
            return pc;
        }
        public List<ParsedChar> ExtractParsedFromThisToRightCount(int index, int count)
        {
            if (index < values.Count && index >= 0)
            {
                List<ParsedChar> result = new List<ParsedChar>();
                for (int i = 0; i < count; i++)
                {
                    if(i + index >= values.Count)
                    {
                        break;
                    }
                    result.Add(new ParsedChar(values[index + i].Line, values[index + i].Character));
                }
                return result;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public List<ParsedChar> ExtractParsedRightCount(int index, int count)
        {
            if (index < values.Count && index >= 0)
            {
                List<ParsedChar> result = new List<ParsedChar>();
                for (int i = 1; i <= count; i++)
                {
                    if (i + index >= values.Count)
                    {
                        break;
                    }
                    result.Add(new ParsedChar(values[index + i].Line, values[index + i].Character));
                }
                return result;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public List<ParsedChar> ExtractParsedFromThisToLeftCount(int index, int count)
        {
            if (index >= 0 && index < values.Count)
            {
                List<ParsedChar> result = new List<ParsedChar>();
                for (int i = 0; i < count; i++)
                {
                    if(index - i < 0)
                    {
                        break;
                    }
                    result.Add(new ParsedChar(values[index - i].Line, values[index - i].Character));
                }
                return result;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public List<ParsedChar> ExtractParsedLeftCount(int index, int count)
        {
            if (index >= 0 && index < values.Count)
            {
                List<ParsedChar> result = new List<ParsedChar>();
                for (int i = 1; i <= count; i++)
                {
                    if (index - i < 0)
                    {
                        break;
                    }
                    result.Add(new ParsedChar(values[index - i].Line, values[index - i].Character));
                }
                return result;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public List<ParsedChar> ExtractParsedFromTo(int indexA, int indexB)
        {
            if ((indexA >= 0 && indexB >= 0) && (indexA < values.Count && indexB < values.Count))
            {
                List<ParsedChar> result = new List<ParsedChar>();
                bool increment = (indexB - indexA) >= 0;
                for (int i = indexA; i <= indexB; i = increment ? i + 1 : i - 1)
                {
                    result.Add(new ParsedChar(values[i].Line, values[i].Character));
                }
                return result;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public List<ParsedChar> ExtractParsedBetween(int index, char a, char b)
        {
            List<ParsedChar> results = new List<ParsedChar>();
            for (int i = index - 1; i >= 0; i--)
            {
                if(values[i].Character == a)
                {
                    break;
                }
                if(results.Count > 0)
                {
                    results.Insert(0, new ParsedChar(values[i].Line, values[i].Character));
                }
                else
                {
                    results.Add(new ParsedChar(values[i].Line, values[i].Character));
                }
            }
            for (int i = index; i < values.Count; i++)
            {
                if (values[i].Character == b)
                {
                    break;
                }
                results.Add(new ParsedChar(values[i].Line, values[i].Character));
            }
            return results;
        }
        public List<ParsedChar> ExtractParsedBetween(int index, Func<char, bool> a, Func<char, bool> b)
        {
            List<ParsedChar> results = new List<ParsedChar>();
            for (int i = index - 1; i >= 0; i--)
            {
                if (a(values[i].Character))
                {
                    break;
                }
                if (results.Count > 0)
                {
                    results.Insert(0, new ParsedChar(values[i].Line, values[i].Character));
                }
                else
                {
                    results.Add(new ParsedChar(values[i].Line, values[i].Character));
                }
            }
            for (int i = index; i < values.Count; i++)
            {
                if (b(values[i].Character))
                {
                    break;
                }
                results.Add(new ParsedChar(values[i].Line, values[i].Character));
            }
            return results;
        }
        public List<ParsedChar> ExtractParsedBetween(int index, Func<ParsedChar, bool> a, Func<ParsedChar, bool> b)
        {
            List<ParsedChar> results = new List<ParsedChar>();
            for (int i = index - 1; i >= 0; i--)
            {
                if (a(values[i]))
                {
                    break;
                }
                if (results.Count > 0)
                {
                    results.Insert(0, new ParsedChar(values[i].Line, values[i].Character));
                }
                else
                {
                    results.Add(new ParsedChar(values[i].Line, values[i].Character));
                }
            }
            for (int i = index; i < values.Count; i++)
            {
                if (b(values[i]))
                {
                    break;
                }
                results.Add(new ParsedChar(values[i].Line, values[i].Character));
            }
            return results;
        }
        public List<ParsedChar> ExtractParsedBetween(char a, char b, bool multipleExtract = false)
        {
            List<ParsedChar> results = new List<ParsedChar>();
            bool write = false;
            foreach (var item in values)
            {
                if(item.Character == a && !write)
                {
                    write = true;
                }
                if(write)
                {
                    results.Add(new ParsedChar(item.Line, item.Character));
                    if (item.Character == b)
                    {
                        if(!multipleExtract)
                        {
                            break;
                        }
                        else
                        {
                            write = false;
                        }
                    }
                }
            }
            return results;
        }
        public List<ParsedChar> ExtractParsedBetween(Func<char, bool> a, Func<char, bool> b, bool multipleExtract = false)
        {
            List<ParsedChar> results = new List<ParsedChar>();
            bool write = false;
            foreach (var item in values)
            {
                if (a(item.Character) && !write)
                {
                    write = true;
                }
                if (write)
                {
                    results.Add(new ParsedChar(item.Line, item.Character));
                    if (b(item.Character))
                    {
                        if(!multipleExtract)
                        {
                            break;
                        }
                        else
                        {
                            write = false;
                        }
                    }
                }
            }
            return results;
        }
        public List<ParsedChar> ExtractParsedBetween(Func<ParsedChar, bool> a, Func<ParsedChar, bool> b, bool multipleExtract = false)
        {
            List<ParsedChar> results = new List<ParsedChar>();
            bool write = false;
            foreach (var item in values)
            {
                if (a(item) && !write)
                {
                    write = true;
                }
                if (write)
                {
                    results.Add(new ParsedChar(item.Line, item.Character));
                    if (b(item))
                    {
                        if(!multipleExtract)
                        {
                            break;
                        }
                        else
                        {
                            write = false;
                        }
                    }
                }
            }
            return results;
        }
        public string ExtractLine(int line)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < values.Count; i++)
            {
                if(values[i].Line == line)
                {
                    sb.Append(values[i].Character);
                }
            }
            return sb.ToString();
        }
        public int PreviousLineIndex(int index)
        {
            if (index < values.Count && index >= 0)
            {
                return values[index].PreviousLineIndex(index);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public int NextLineIndex(int index)
        {
            if(index < values.Count && index >= 0)
            {
                return values[index].NextLineIndex(index);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public bool IsPattern(int index, string left, char center, string right)
        {
            if (index >= 0 && index < values.Count)
            {
                return values[index].IsPattern(left, center, right);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public string GetBetweenEmpty(int index)
        {
            if (index >= 0 && index < values.Count)
            {
                return values[index].GetStringExpendedWhile(GetNotEmptyChar);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public string GetBetween(int index, char charToTest)
        {
            if (index >= 0 && index < values.Count)
            {
                return values[index].GetStringExpendedWhile(NotEqualChar, charToTest);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public string GetBetween(int index, Func<char, bool> test)
        {
            if (index >= 0 && index < values.Count)
            {
                return values[index].GetStringExpendedWhile(test);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public string GetBetween(int index, Func<ParsedChar, bool> test)
        {
            if (index >= 0 && index < values.Count)
            {
                return values[index].GetStringExpendedWhile(test);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public int GetPreviousIndexOf(int index, char value)
        {
            return values[index].GetPreviousIndex(index, value);
        }
        public int GetPreviousIndexOf(int index, Func<char, bool> test)
        {
            return values[index].GetPreviousIndex(index, test);
        }
        public int GetPreviousIndexOf(int index, Func<ParsedChar, bool> test)
        {
            return values[index].GetPreviousIndex(index, test);
        }
        public int GetNextIndexOf(int index, char value)
        {
            return values[index].GetNextIndex(index, value);
        }
        public int GetNextIndexOf(int index, Func<char, bool> test)
        {
            return values[index].GetNextIndex(index, test);
        }
        public int GetNextIndexOf(int index, Func<ParsedChar, bool> test)
        {
            return values[index].GetNextIndex(index, test);
        }
        public int GetNextIndex(int index, string input)
        {
            for (int i = index + 1; i < values.Count; i++)
            {
                if(values[i].GetStringFromThisToRight(input.Length) == input)
                {
                    return i;
                }
            }
            return -1;
        }
        public int GetNextEmptyIndex(int index)
        {
            return values[index].GetNextIndex(index, GetEmptyChar);
        }
        public override string ToString()
        {
            return values.Count > 0 ? values[0].GetStringFromThisToRight(values.Count) : "";
        }
        public string ToDebugString()
        {
            return values.Count > 0 ? values[0].GetStringFromThisToRight(values.Count, OverrideValues) : "";
        }
        
    }
}
