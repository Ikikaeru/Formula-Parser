namespace IkiCore.TextAnalyzer.Instructions
{
    public class Number : BaseContent
    {
        readonly bool pointOverComa;
        readonly bool exponent;
        public Number(bool pointOverComa = false, bool exponent = false)
        {
            Name = "";
            this.pointOverComa = pointOverComa;
            this.exponent = exponent;
        }
        protected Number(string name, bool pointOverComa = false, bool exponent = false)
        {
            Name = name;
            this.pointOverComa = pointOverComa;
            this.exponent = exponent;
        }
        public override void AnalyzeText(string content, ref (int, int) i)
        {
            int p = 0;
            Name = GetNumberWhile(ref i.Item1, content, ref p);
        }
        string GetNumberWhile(ref int i, string content, ref int p, bool pointOverComma = true, bool acceptExponent = false)
        {
            if (i >= content.Length || i < 0)
            {
                return "";
            }
            else if (char.IsDigit(content[i]))
            {
                return $"{content[i++]}{GetNumberWhile(ref i, content, ref p, pointOverComma, acceptExponent)}";
            }
            else if ((pointOverComma && content[i] == '.') || (!pointOverComma && content[i] == ','))
            {
                if (p <= 1 && (i + 1 < content.Length) && ((pointOverComma && content[i + 1] == '.') || (!pointOverComma && content[i + 1] == ',')))
                {
                    return "";
                }
                p++;
                if (p > 1)
                {
                    return "";
                }
                return $"{content[i++]}{GetNumberWhile(ref i, content, ref p, pointOverComma, acceptExponent)}";
            }
            else if (char.IsLetter(content[i]) && acceptExponent && (content[i] == 'E' || content[i] == 'e') && i + 2 < content.Length && (content[i + 1] == '+' || content[i + 1] == '-') && char.IsDigit(content[i + 2]))
            {
                return $"{content[i++]}{content[i++]}{GetNumberWhile(ref i, content, ref p, pointOverComma)}";
            }
            return "";
        }
        public override IInstruction CopyValue()
        {
            IInstruction v = new Number(Name, pointOverComa, exponent);
            v.SetAnalyzer(analyzer);
            return v;
        }
        public override string GetStringContent() => $"{nameof(Number)} {Name}";
        public override bool IsContentPattern(string value, ref int i)
        {
            if(!char.IsDigit(value[i]))
            {
                return value[i] == '.' && i + 1 < value.Length && char.IsDigit(value[i + 1]);
            }
            return true;
        }
    }
}
