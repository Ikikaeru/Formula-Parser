namespace IkiCore.TextAnalyzer.Instructions
{
    public interface IInstruction
    {
        string Name { get; }
        bool IsEmpty { get; }
        void SetAnalyzer(Analyzer analyze);
        bool IsContentPattern(string value, ref int i);
        void AnalyzeText(string content, ref (int, int) i);
        IInstruction CopyValue();
        string GetStringContent();
    }
}
