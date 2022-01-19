using IkiCore.Core;
using System.Collections.Generic;
namespace IkiCore.TextAnalyzer.Instructions
{
    public abstract class SimpleContent : BaseInstruction
    {
        public string Begin { get; private set; }
        public string End { get; private set; }
        protected bool notIncluded;
        protected int beginLines;
        protected int endLines;
        public SimpleContent(string name, string begin, string end, bool notIncluded = false)
        {
            Name = name;
            this.Begin = begin;
            this.End = end;
            this.notIncluded = notIncluded;
            Content = new List<IInstruction>();
            beginLines = Analyzer.LineCount(this.Begin);
            endLines = Analyzer.LineCount(this.End);
        }
        public override bool IsContentPattern(string value, ref int i) => Analyzer.IsSamePattern(value, Begin, ref i);
        public virtual bool IsEndContent(string x, int i) => x.IsSamePattern(End, i);
    }
}
