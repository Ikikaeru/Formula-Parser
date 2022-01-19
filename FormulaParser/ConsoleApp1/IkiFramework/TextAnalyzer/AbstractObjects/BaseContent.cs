namespace IkiCore.TextAnalyzer.Instructions
{
    public abstract class BaseContent : IInstruction
    {
        protected Analyzer analyzer;
        public string Name { get; protected set; }
        public bool IsEmpty => Name == null || Name.Length == 0;
        public BaseContent()
        {
            Name = "";
        }
        protected BaseContent(string name)
        {
            Name = name;
        }
        public abstract bool IsContentPattern(string value, ref int i);
        public abstract void AnalyzeText(string content, ref (int, int) i);
        public abstract IInstruction CopyValue();
        public abstract string GetStringContent();
        public void SetAnalyzer(Analyzer analyzer) => this.analyzer = analyzer;
    }
}
