using IkiCore.TextAnalyzer.Instructions;
using System.Collections.Generic;
namespace IkiCore.TextAnalyzer
{
    public class AnalyzeObjects
    {
        public Analyzer Analyzer { get; private set; }
        public AnalyzeObjects(string content, List<IInstruction> synthax, List<IInstruction> defaultValues)
        {
            Analyzer = new Analyzer(synthax, defaultValues);
            Analyzer.Analyze(content);
        }
    }
}
