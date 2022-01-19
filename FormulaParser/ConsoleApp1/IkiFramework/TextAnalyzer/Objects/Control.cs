namespace IkiCore.TextAnalyzer.Instructions
{
    public class Control : BaseContent
    {
        public Control()
        {
            Name = "";
        }
        protected Control(string name)
        {
            Name = name;
        }
        public override void AnalyzeText(string content, ref (int, int) i)
        {
            if(content[i.Item1] == '\n')
            {
                i.Item2++;
            }
            Name = content[i.Item1++].ToString();
        }
        public override IInstruction CopyValue()
        {
            IInstruction v = new Control(Name);
            v.SetAnalyzer(analyzer);
            return v;
        }
        public override string GetStringContent() => $"{nameof(Control)} {Name}";
        public override bool IsContentPattern(string value, ref int i) => char.IsControl(value[i]);
    }
}
