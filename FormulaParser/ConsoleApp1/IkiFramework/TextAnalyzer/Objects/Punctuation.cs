namespace IkiCore.TextAnalyzer.Instructions
{
    public class Punctuation : BaseContent
    {
        public Punctuation()
        {
            Name = "";
        }
        protected Punctuation(string name)
        {
            Name = name;
        }
        public override void AnalyzeText(string content, ref (int, int) i)
        {
            Name = content[i.Item1++].ToString();
        }
        public override IInstruction CopyValue()
        {
            IInstruction v = new Punctuation(Name);
            v.SetAnalyzer(analyzer);
            return v;
        }
        public override string GetStringContent() => $"{nameof(Punctuation)} {Name}";
        public override bool IsContentPattern(string value, ref int i) => char.IsPunctuation(value[i]);
    }
}
