using System.Text;
namespace IkiCore.Mathematics
{
    public static class ScientistNotation
    {
        public static string FloatToScientific(float value, uint digits = 0u)
        {
            string input = value.ToString($"E{digits}");
            StringBuilder sb = new StringBuilder();
            bool deletingZeros = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (deletingZeros && (char.IsDigit(input[i]) || input[i] == '+'))
                {
                    if (input[i] == '0' || input[i] == '+')
                    {
                        continue;
                    }
                    deletingZeros = false;
                }
                else if (input[i] == 'E')
                {
                    sb.Append(" * 10^");
                    deletingZeros = true;
                    continue;
                }
                sb.Append(input[i]);
            }
            return sb.ToString();
        }
        public static string DoubleToScientific(double value, uint digits = 0u)
        {
            string input = value.ToString($"E{digits.ToString()}");
            StringBuilder sb = new StringBuilder();
            bool deletingZeros = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (deletingZeros && (char.IsDigit(input[i]) || input[i] == '+'))
                {
                    if (input[i] == '0' || input[i] == '+')
                    {
                        continue;
                    }
                    deletingZeros = false;
                }
                else if (input[i] == 'E')
                {
                    sb.Append(" * 10^");
                    deletingZeros = true;
                    continue;
                }
                sb.Append(input[i]);
            }
            return sb.ToString();
        }
        public static string DecimalToScientific(decimal value, uint digits = 0u)
        {
            string input = value.ToString($"E{digits.ToString()}");
            StringBuilder sb = new StringBuilder();
            bool deletingZeros = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (deletingZeros && (char.IsDigit(input[i]) || input[i] == '+'))
                {
                    if (input[i] == '0' || input[i] == '+')
                    {
                        continue;
                    }
                    deletingZeros = false;
                }
                else if (input[i] == 'E')
                {
                    sb.Append(" * 10^");
                    deletingZeros = true;
                    continue;
                }
                sb.Append(input[i]);
            }
            return sb.ToString();
        }
    }
}
