using IkiCore.TextAnalyzer.Instructions;
namespace IkiCustom.Calculator
{
    public class Symbol : BaseContent
    {
        public int Order = 0;
        public Symbol()
        {
            Name = "";
        }
        public Symbol(string name)
        {
            Name = name;
        }
        public override void AnalyzeText(string content, ref (int, int) i)
        {
            Name = content[i.Item1++].ToString();
        }
        public override IInstruction CopyValue()
        {
            IInstruction v = new Symbol(Name);
            v.SetAnalyzer(analyzer);
            return v;
        }
        public override string GetStringContent() => $"{nameof(Symbol)} {Name}";
        public override bool IsContentPattern(string value, ref int i)
        {
            switch(value[i])
            {
                case '_':
                case ',':
                case '+':
                case '-':
                case '*':
                case '/':
                case '!':
                case '.':
                case '~':
                case '|':
                case '&':
                case '#':
                case '%':
                case '^':
                case '$':
                case '@':
                case '=':
                case '?':
                case ':':
                case ';':
                case '<':
                case '>':
                case '°':
                    return true;
                default:
                    return false;
            }
        }
    }
}
