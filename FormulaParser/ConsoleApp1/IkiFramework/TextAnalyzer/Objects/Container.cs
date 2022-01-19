using System;
using System.Text;
using IkiCore.Core;
namespace IkiCore.TextAnalyzer.Instructions
{
    public class Container : IInstruction
    {
        protected Analyzer analyzer;
        string content;
        readonly string begin;
        readonly string end;
        readonly bool notIncluded;
        readonly int beginLines;
        readonly int endLines;
        readonly bool ignoreOutOfBounds;
        public Container(string name, string begin, string end, bool notIncluded = false, bool ignoreOutOfBounds = false)
        {
            this.begin = begin;
            this.end = end;
            this.notIncluded = notIncluded;
            this.ignoreOutOfBounds = ignoreOutOfBounds;
            Name = name;
            beginLines = Analyzer.LineCount(this.begin);
            endLines = Analyzer.LineCount(this.end);
        }
        public string Name { get; protected set; }
        public IInstruction CopyValue()
        {
            IInstruction v = new Container(Name, begin, end, notIncluded, ignoreOutOfBounds);
            v.SetAnalyzer(analyzer);
            return v;
        }
        public bool IsEmpty => content == null || content.Length == 0;
        public bool IsContentPattern(string value, ref int i) => Analyzer.IsSamePattern(value, begin, ref i);
        public bool IsEndContent(string x, int i) => x.IsSamePattern(end, i);
        public void AnalyzeText(string content, ref (int, int) i)
        {
            i.Item2 += beginLines;
            StringBuilder sb = new StringBuilder();
            int idx = i.Item1;
            while (idx < content.Length)
            {
                if (idx + end.Length <= content.Length)
                {
                    if (IsEndContent(content, idx))
                    {
                        i.Item1 = idx + end.Length;
                        i.Item2 += endLines;
                        break;
                    }
                    else
                    {
                        sb.Append(content[idx]);
                        if (content[idx] == '\n')
                        {
                            i.Item2++;
                        }
                        idx++;
                    }
                }
                else if (!ignoreOutOfBounds)
                {
                    throw new Exception($"Missing {end} between line {i.Item1} and line {idx}.");
                }
            }
            if (!notIncluded)
            {
                this.content = content.Substring(i.Item1, content.Length - i.Item1);
            }
        }
        public string GetStringContent() => Name;
        public void SetAnalyzer(Analyzer analyzer)
        {
            this.analyzer = analyzer;
        }
    }
}
