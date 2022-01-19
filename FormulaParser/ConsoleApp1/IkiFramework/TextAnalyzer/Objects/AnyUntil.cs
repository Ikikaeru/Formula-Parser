using System.Text;
namespace IkiCore.TextAnalyzer.Instructions
{
    class AnyUntil : BaseContent
    {
        protected string end;
        public AnyUntil()
        {
            Name = "";
        }
        protected AnyUntil(string name, string end)
        {
            Name = name;
            this.end = end;
        }
        public override void AnalyzeText(string content, ref (int, int) i)
        {
            StringBuilder sb = new StringBuilder();
            for (; i.Item1 < content.Length; i.Item1++)
            {
                if (i.Item1 + end.Length <= content.Length && content.Substring(i.Item1, end.Length) == end)
                {
                    i.Item1 += end.Length;
                    break;
                }
                sb.Append(content[i.Item1]);
            }
            Name = sb.ToString();
        }
        public override IInstruction CopyValue()
        {
            IInstruction v = new AnyUntil(Name, end);
            v.SetAnalyzer(analyzer);
            return v;
        }
        public override string GetStringContent() => $"{nameof(AnyUntil)} {Name}";
        public override bool IsContentPattern(string value, ref int i) => true;
    }
}
