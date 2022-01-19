using IkiCore.TextAnalyzer.Instructions;
using System.Globalization;
using System.Text;
namespace IkiCustom.Calculator
{
    public class Number : BaseContent
    {
        readonly bool pointOverComa;
        readonly bool exponent;
        public bool Sign = true;
        public Number(bool pointOverComa = false, bool exponent = false)
        {
            Name = "";
            this.pointOverComa = pointOverComa;
            this.exponent = exponent;
        }
        public Number(string name, bool pointOverComa = false, bool exponent = false)
        {
            Name = name;
            this.pointOverComa = pointOverComa;
            this.exponent = exponent;
        }
        public override void AnalyzeText(string content, ref (int, int) i)
        {
            StringBuilder sb = new StringBuilder();
            bool havePoint = false;
            bool haveExponent = false;
            for (; i.Item1 < content.Length; i.Item1++)
            {
                if(!char.IsDigit(content[i.Item1]))
                {
                    if(content[i.Item1] == '.')
                    {
                        if(havePoint)
                        {
                            break;
                        }
                        havePoint = true;
                    }
                    else if(content[i.Item1] == 'E')
                    {
                        if (haveExponent)
                        {
                            break;
                        }
                        else if (i.Item1 + 2 < content.Length && (content[i.Item1 + 1] == '+' || content[i.Item1 + 1] == '-') && char.IsDigit(content[i.Item1 + 2]))
                        {
                            haveExponent = true;
                            havePoint = true;
                            sb.Append(content[i.Item1++]);
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                sb.Append(content[i.Item1]);
            }
            Name = sb.ToString();
        }
        public override IInstruction CopyValue()
        {
            IInstruction v = new Number(Name, pointOverComa, exponent);
            v.SetAnalyzer(analyzer);
            return v;
        }
        string generateSign => Sign ? "" : "-";
        public override string GetStringContent() => $"{nameof(Number)} {GetActualNumber()}";
        public override bool IsContentPattern(string value, ref int i)
        {
            if (!char.IsDigit(value[i]))
            {
                return value[i] == '.' && i + 1 < value.Length && char.IsDigit(value[i + 1]);
            }
            return true;
        }
        public double GetActualNumber() => Sign ? double.Parse(Name, CultureInfo.InvariantCulture) : -double.Parse(Name, CultureInfo.InvariantCulture);
        public void SetActualNumber(double x) => Name = x.ToString(CultureInfo.InvariantCulture);
    }
}
