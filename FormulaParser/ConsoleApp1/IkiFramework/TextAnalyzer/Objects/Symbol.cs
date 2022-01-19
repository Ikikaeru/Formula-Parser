namespace IkiCore.TextAnalyzer.Instructions
{
    class Symbol : BaseContent
    {
        readonly bool charSymbolOnly;
        public Symbol(bool charSymbolOnly = false)
        {
            Name = "";
            this.charSymbolOnly = charSymbolOnly;
        }
        protected Symbol(string name, bool charSymbolOnly = false)
        {
            Name = name;
            this.charSymbolOnly = charSymbolOnly;
        }
        public override void AnalyzeText(string content, ref (int, int) i)
        {
            Name = content[i.Item1++].ToString();
        }
        public override IInstruction CopyValue()
        {
            IInstruction v = new Symbol(Name, charSymbolOnly);
            v.SetAnalyzer(analyzer);
            return v;
        }
        public override string GetStringContent() => $"{nameof(Symbol)} {Name}";
        public override bool IsContentPattern(string value, ref int i) => charSymbolOnly ? char.IsSymbol(value[i]) : char.IsSymbol(value[i]) || char.IsPunctuation(value[i]);
    }
}