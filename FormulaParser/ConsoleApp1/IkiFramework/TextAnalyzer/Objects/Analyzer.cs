using IkiCore.TextAnalyzer.Instructions;
using System;
using System.Collections.Generic;
using System.Text;
namespace IkiCore.TextAnalyzer
{
    public class Analyzer
    {
        readonly List<IInstruction> Synthax = new List<IInstruction>();
        readonly List<IInstruction> Default = new List<IInstruction>();
        public List<IInstruction> Content { get; private set; }
        public Analyzer(List<IInstruction> synthax, List<IInstruction> defaultValues)
        {
            Synthax = synthax;
            Default = defaultValues;
            int i;
            for (i = 0; i < Synthax.Count; i++)
            {
                Synthax[i].SetAnalyzer(this);
            }
            for (i = 0; i < Default.Count; i++)
            {
                Default[i].SetAnalyzer(this);
            }
        }
        public static int LineCount(string x)
        {
            if (x == null)
            {
                return 0;
            }
            int l = 0;
            foreach (var i in x)
            {
                if (i == '\n')
                {
                    l++;
                }
            }
            return l;
        }
        public static bool IsSamePattern(string x, string pattern, ref int i)
        {
            if (x == null || pattern == null || i + pattern.Length > x.Length || i < 0 || x.Substring(i, pattern.Length) != pattern)
            {
                return false;
            }
            i += pattern.Length;
            return true;
        }
        public static bool IsWhiteSpace(char x) => char.IsWhiteSpace(x) || char.IsControl(x) || char.IsSeparator(x);
        public List<IInstruction> AnalyzeRoot(string content)
        {
            List<IInstruction> body = new List<IInstruction>();
            (int, int) i = (0, 0);
            int j;
            bool founded;
            while (i.Item1 < content.Length)
            {
                founded = false;
                for (j = 0; j < Synthax.Count; j++)
                {
                    if (Synthax[j].IsContentPattern(content, ref i.Item1))
                    {
                        IInstruction iinstr = Synthax[j].CopyValue();
                        iinstr.AnalyzeText(content, ref i);
                        if (!iinstr.IsEmpty)
                        {
                            body.Add(iinstr);
                        }
                        j = Synthax.Count;
                        founded = true;
                    }
                }
                if (!founded)
                {
                    IInstruction iinst = AnalyzeInstruction(content, ref i); // Problem
                    if (iinst != null && !iinst.IsEmpty)
                    {
                        body.Add(iinst);
                    }
                }
            }
            return body;
        }
        public List<IInstruction> AnalyzeRecursive(string content, ref (int, int) i, Func<string, int, bool> endSynthax)
        {
            List<IInstruction> body = new List<IInstruction>();
            bool founded;
            while (i.Item1 < content.Length)
            {
                founded = false;
                if (endSynthax(content, i.Item1))
                {
                    break;
                }
                else
                {
                    for (int j = 0; j < Synthax.Count; j++)
                    {
                        if (Synthax[j].IsContentPattern(content, ref i.Item1))
                        {
                            IInstruction iinstr = Synthax[j].CopyValue();
                            iinstr.AnalyzeText(content, ref i);
                            if (!iinstr.IsEmpty)
                            {
                                body.Add(iinstr);
                            }
                            j = Synthax.Count;
                            founded = true;
                        }
                    }
                }
                if (!founded)
                {
                    IInstruction iinst = AnalyzeInstruction(content, ref i);
                    if (iinst != null && !iinst.IsEmpty)
                    {
                        body.Add(iinst);
                    }
                }
            }
            return body;
        }
        public IInstruction AnalyzeInstruction(string content, ref (int, int) i)
        {
            if (i.Item1 >= content.Length)
            {
                return null;
            }
            return DefaultInstruction(content, ref i);
        }
        IInstruction DefaultInstruction(string content, ref (int, int) i)
        {
            for (int j = 0; j < Default.Count; j++)
            {
                if (Default[j].IsContentPattern(content, ref i.Item1))
                {
                    IInstruction iinstr = Default[j].CopyValue();
                    iinstr.AnalyzeText(content, ref i);
                    return iinstr;
                }
            }
            i.Item1++;
            return null;
        }
        public void Analyze(string content) => this.Content = AnalyzeRoot(content);
        public string GetStringContent()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Content.Count; i++)
            {
                sb.Append(Content[i].GetStringContent());
                sb.Append('\n');
            }
            return sb.ToString();
        }
    }
}
