namespace IkiCore.TextAnalyzer.Instructions
{
    public class Separator : BaseContent
    {
        public Separator()
        {
            Name = "";
        }
        protected Separator(string name)
        {
            Name = name;
        }
        public override void AnalyzeText(string content, ref (int, int) i)
        {
            Name = content[i.Item1++].ToString();
        }
        public override IInstruction CopyValue()
        {
            IInstruction v = new Separator(Name);
            v.SetAnalyzer(analyzer);
            return v;
        }
        public override string GetStringContent() => $"{nameof(Separator)} {Name}";
        public override bool IsContentPattern(string value, ref int i) => char.IsSeparator(value[i]) && !char.IsWhiteSpace(value[i]);
    }
}
