using System;
using System.Collections.Generic;
namespace IkiCore.TextAnalyzer.Instructions
{
    public class BlockContent : SimpleContent
    {
        public bool Sign = true;
        readonly bool ignoreOutOfBound;
        public BlockContent(string name, string begin, string end, bool notIncluded = false, bool ignoreOutOfBound = false) : base(name, begin, end, notIncluded)
        {
            this.ignoreOutOfBound = ignoreOutOfBound;
        }
        public List<IInstruction> GetInstructions() => Content;
        public void SetInstructions(List<IInstruction> instructions) => Content = instructions;
        public override IInstruction CopyValue()
        {
            IInstruction v = new BlockContent(Name, Begin, End, notIncluded, ignoreOutOfBound);
            v.SetAnalyzer(analyzer);
            return v;
        }
        public override void AnalyzeText(string content, ref (int, int) i) // i_1 = index, i_2 = line
        {
            int beginLine = i.Item2;
            i.Item2 += beginLines;
            List<IInstruction> collectInstructions = new List<IInstruction>();
            if (!IsEndContent(content, i.Item1))
            {
                if (i.Item1 >= content.Length && !ignoreOutOfBound)
                {
                    throw new Exception($"Missing one {End} somewhere between line {beginLine} and line {i.Item2}.");
                }
                else
                {
                    collectInstructions.AddRange(analyzer.AnalyzeRecursive(content, ref i, IsEndContent));
                    i.Item1 += End.Length;
                    i.Item2 += endLines;
                }
            }
            else
            {
                i.Item1 += End.Length;
                i.Item2 += endLines;
            }
            if (!notIncluded && collectInstructions.Count > 0)
            {
                this.Content = collectInstructions;
            }
        }
    }
}
