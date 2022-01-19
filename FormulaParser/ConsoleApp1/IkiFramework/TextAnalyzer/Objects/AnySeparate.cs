using System.Text;
namespace IkiCore.TextAnalyzer.Instructions
{
    public class AnySeparate : BaseContent
    {
        public AnySeparate()
        {
            Name = "";
        }
        protected AnySeparate(string name)
        {
            Name = name;
        }
        public override void AnalyzeText(string content, ref (int, int) i)
        {
            StringBuilder sb = new StringBuilder();
            for (; i.Item1 < content.Length; i.Item1++)
            {
                if(Analyzer.IsWhiteSpace(content[i.Item1]))
                {
                    break;
                }
                sb.Append(content[i.Item1]);
            }
            Name = sb.ToString();
        }
        public override IInstruction CopyValue()
        {
            IInstruction v = new AnySeparate(Name);
            v.SetAnalyzer(analyzer);
            return v;
        }
        public override string GetStringContent() => $"{nameof(AnySeparate)} {Name}";
        public override bool IsContentPattern(string value, ref int i) => !Analyzer.IsWhiteSpace(value[i]);
    }
}
