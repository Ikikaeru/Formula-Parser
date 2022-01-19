namespace IkiCore.TextAnalyzer.Instructions
{
    public class WhiteSpace : BaseContent
    {
        public WhiteSpace()
        {
            Name = "";
        }
        protected WhiteSpace(string name)
        {
            Name = name;
        }
        public override void AnalyzeText(string content, ref (int, int) i)
        {
            Name = content[i.Item1++].ToString();
        }
        public override IInstruction CopyValue()
        {
            IInstruction v = new WhiteSpace(Name);
            v.SetAnalyzer(analyzer);
            return v;
        }
        public override string GetStringContent() => $"{nameof(WhiteSpace)} {Name}";
        public override bool IsContentPattern(string value, ref int i) => char.IsWhiteSpace(value[i]);
    }
}
