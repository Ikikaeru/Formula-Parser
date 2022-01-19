using System.Text;
namespace IkiCore.TextAnalyzer.Instructions
{
    public class Word : BaseContent
    {
        public Word()
        {
            Name = "";
        }
        protected Word(string name)
        {
            Name = name;
        }
        public override string GetStringContent() => $"{nameof(Word)} {Name}";
        public override void AnalyzeText(string content, ref (int, int) i)
        {
            StringBuilder sb = new StringBuilder();
            while(i.Item1 < content.Length)
            {
                if (char.IsLetter(content[i.Item1]))
                {
                    sb.Append(content[i.Item1++]);
                }
                else
                {
                    break;
                }
            }
            Name = sb.ToString();
        }
        public override IInstruction CopyValue()
        {
            IInstruction v = new Word(Name);
            v.SetAnalyzer(analyzer);
            return v;
        }
        public override bool IsContentPattern(string value, ref int i)
        {
            if (i >= value.Length)
            {
                return false;
            }
            int j = i;
            for (; j < value.Length; j++)
            {
                if (!char.IsLetter(value[j]))
                {
                    if ((!char.IsSeparator(value[j]) || Analyzer.IsWhiteSpace(value[j])) && j != i)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
