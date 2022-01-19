using System.Collections.Generic;
using System.Text;
namespace IkiCore.TextAnalyzer.Instructions
{
    public abstract class BaseInstruction : IInstruction
    {
        protected Analyzer analyzer;
        public List<IInstruction> Content = new List<IInstruction>();
        public string Name { get; protected set; }
        public bool IsEmpty => Content.Count == 0;
        public abstract void AnalyzeText(string content, ref (int, int) i);
        public abstract IInstruction CopyValue();
        public virtual string GetStringContent()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name}\n");
            int j;
            for (int i = 0; i < Content.Count; i++)
            {
                sb.Append('\t');
                string tmpC = Content[i].GetStringContent();
                for (j = 0; j < tmpC.Length; j++)
                {
                    sb.Append(tmpC[j]);
                    if (tmpC[j] == '\n' && j + 1 < tmpC.Length)
                    {
                        sb.Append('\t');
                    }
                }
                if (i + 1 < Content.Count)
                {
                    sb.Append('\n');
                }
            }
            return sb.ToString();
        }
        public abstract bool IsContentPattern(string value, ref int i);
        public void SetAnalyzer(Analyzer analyzer)
        {
            this.analyzer = analyzer;
        }
    }
}
