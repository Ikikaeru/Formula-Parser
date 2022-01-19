using IkiCore.TextAnalyzer;
using IkiCore.TextAnalyzer.Instructions;
using System.Collections.Generic;
namespace IkiCustom.Calculator
{
    public class Function : IInstruction
    {
        public string Name { get; private set; }
        public bool Sign = true;
        public bool IsEmpty => Content.Count == 0;
        public List<IInstruction> Content = new List<IInstruction>();
        public Function(string name, List<IInstruction> content)
        {
            Name = name;
            Content = content;
        }
        public void AnalyzeText(string content, ref (int, int) i)
        {
            return;
        }
        public IInstruction CopyValue() => new Function(Name, Content);
        public string GetStringContent() => $"{nameof(Function)} {Name}";
        public bool IsContentPattern(string value, ref int i) => false;
        public void SetAnalyzer(Analyzer analyze)
        {

        }
    }
}
