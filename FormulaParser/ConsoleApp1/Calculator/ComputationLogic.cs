using IkiCore.TextAnalyzer.Instructions;
using System;
using System.Collections.Generic;
using System.Text;

namespace IkiCustom.Calculator
{
    public static class ComputationLogic
    {
        public static string GetStringContent(List<IInstruction> elements)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < elements.Count; i++)
            {
                sb.Append(elements[i].GetStringContent());
                sb.Append('\n');
            }
            return sb.ToString();
        }
        public static string GetConcatenatedContent(List<IInstruction> elements)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < elements.Count; i++)
            {
                if(elements[i] is BlockContent sCont)
                {
                    if(sCont.Name == "Parenthesis")
                    {
                        if (!sCont.Sign)
                        {
                            sb.Append('-');
                        }
                        sb.Append(sCont.Begin);
                        sb.Append(GetConcatenatedContent(sCont.Content));
                        sb.Append(sCont.End);
                        if (i != elements.Count - 1)
                        {
                            sb.Append(' ');
                        }
                    }
                }
                else if(elements[i] is Number numbr)
                {
                    sb.Append(numbr.GetActualNumber().ToString());
                    if (i != elements.Count - 1)
                    {
                        sb.Append(' ');
                    }
                }
                else if(elements[i] is Function f)
                {
                    sb.Append(f.Name);
                    sb.Append("(");
                    sb.Append(GetConcatenatedContent(f.Content));
                    sb.Append(")");
                    if (i != elements.Count - 1)
                    {
                        sb.Append(' ');
                    }
                }
                else
                {
                    sb.Append(elements[i].Name);
                    if(i != elements.Count - 1)
                    {
                        sb.Append(' ');
                    }
                }
            }
            return sb.ToString();
        }
        public static List<IInstruction> Cleanup(List<IInstruction> elements)
        {
            bool nextExist = false, previousExist = false;
            for (int i = 0; i < elements.Count; i++)
            {
                if(i < 0)
                {
                    i = -1;
                    continue;
                }
                UpdateElementTestingValues(i, elements.Count, ref previousExist, ref nextExist);
                switch (elements[i])
                {
                    case Word word:
                        switch(word.Name)
                        {
                            case "pi":
                                elements[i] = new Number("3.14159265358979323846264338327950288419716939937510582");
                                i -= 3;
                                break;
                            case "e":
                                elements[i] = new Number("2.71828182845904523536028747135266249");
                                i -= 3;
                                break;
                            case "tau":
                                elements[i] = new Number("6.283185307179586476925286766559");
                                i -= 3;
                                break;
                            case "omega":
                                elements[i] = new Number("0.56714329040978387299996866221035554");
                                i -= 3;
                                break;
                            case "min":
                            case "max":
                            case "abs":
                            case "round":
                            case "floor":
                            case "ceil":
                            case "sign":
                            case "sqrt":
                            case "exp":
                            case "lb":
                            case "ln":
                            case "log":
                            case "lambertW":
                            case "gcd":
                            case "lcm":
                            case "mod":
                            case "prime":
                            case "cos":
                            case "sin":
                            case "tan":
                            case "sec":
                            case "csc":
                            case "cot":
                            case "acos":
                            case "asin":
                            case "atan":
                            case "atan2":
                            case "cosh":
                            case "sinh":
                            case "tanh":
                            case "arcosh":
                            case "arsinh":
                            case "artanh":
                            case "csch":
                            case "sech":
                            case "coth":
                            case "arcsch":
                            case "arsech":
                            case "arcoth":
                            case "coeffbin":
                            case "root":
                                break;
                            default:
                                elements.RemoveAt(i);
                                i -= 3;
                                break;
                        }
                        break;
                    case BlockContent block:
                        if(block.Name == "Parenthesis")
                        {
                            List<IInstruction> x = Cleanup(block.GetInstructions());
                            if (i - 1 >= 0 && elements[i - 1] is Word w)
                            {
                                var f = new Function(w.Name, x);
                                f.Sign = block.Sign;
                                elements[i - 1] = f;
                                elements.RemoveAt(i);
                                i -= 3;
                            }
                            else if (x.Count == 1)
                            {
                                switch (x[0])
                                {
                                    case BlockContent bc2:
                                        if(bc2.Name == "Parenthesis")
                                        {
                                            block.SetInstructions(bc2.Content);
                                            elements[i--] = block;
                                        }
                                        break;
                                    case Number nbr:
                                        elements[i--] = nbr;
                                        break;
                                }
                            }
                            else
                            {
                                block.SetInstructions(x);
                                elements[i] = block;
                            }
                        }
                        break;
                    case Symbol sym:
                        switch (sym.Name)
                        {
                            case "°":
                                Symbol mul = new Symbol("*") { Order = 2 };
                                Number num = new Number("0.01745329251");
                                elements.RemoveAt(i);
                                elements.Insert(i, num);
                                elements.Insert(i, mul);
                                i--;
                                break;
                            case ",":
                                break;
                            case "!":
                                if(previousExist && (elements[i - 1] is Function || elements[i - 1] is Number || (elements[i - 1] is BlockContent blc && blc.Name == "Parenthesis"))) // [Num/Prts][!]...
                                {
                                    int exlamationCount = 1;
                                    for (int j = i + 1; j < elements.Count; j++)
                                    {
                                        if(elements[j] is Symbol tmp && tmp.Name == "!")
                                        {
                                            exlamationCount++;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    sym.Order = -exlamationCount; // Factorial order is the abs
                                    elements[i] = sym;
                                }
                                else
                                {
                                    elements.RemoveAt(i--);
                                }
                                break;
                            case "^":
                                sym.Order = 1;
                                elements[i] = sym;
                                break;
                            case "*":
                            case "/":
                                sym.Order = 2;
                                elements[i] = sym;
                                break;
                            case "+":
                                sym.Order = 3;
                                elements[i] = sym;
                                if (nextExist) // ...[+][???]...
                                {
                                    if (previousExist) // ...[???][+][???]...
                                    {
                                        if(elements[i + 1] is Symbol sym3 && (sym3.Name == "+" || sym3.Name == "-")) // ...[???][+][±]...
                                        {
                                            elements.RemoveAt(i);
                                            i -= 3;
                                        }
                                        else if(elements[i - 1] is Symbol previ && !(elements[i + 1] is Symbol) && (previ.Order < sym.Order && previ.Order > 0))// ...[Symbol][+][!Symbol]... AND |Symbol| > |+|
                                        {
                                            elements.RemoveAt(i);
                                            i -= 3;
                                        }
                                    }
                                    else // |[+][???]...
                                    {
                                        elements.RemoveAt(i);
                                        i -= 3;
                                    }
                                }
                                else // ...[+]|
                                {
                                    elements.RemoveAt(i);
                                    i -= 3;
                                }
                                break;
                            case "-":
                                sym.Order = 3;
                                elements[i] = sym;
                                if (nextExist) // ...[+][???]...
                                {
                                    if (previousExist) // ...[???][+][???]...
                                    {
                                        if (elements[i + 1] is Symbol sym3) // ...[???][-][±]...
                                        {
                                            if(sym3.Name == "+")
                                            {
                                                elements.RemoveAt(i + 1);
                                                i -= 3;
                                            }
                                            else if (sym3.Name == "-")
                                            {
                                                elements[i] = new Symbol("+") { Order = 3};
                                                elements.RemoveAt(i + 1);
                                                i -= 3;
                                            }
                                        }
                                        else if (elements[i - 1] is Symbol previ && !(elements[i + 1] is Symbol) && (previ.Order < sym.Order && previ.Order > 0))// ...[Symbol][+][!Symbol]... AND |Symbol| > |+|
                                        {
                                            if (elements[i + 1] is Number negNum)
                                            {
                                                negNum.Sign = !negNum.Sign;
                                                elements[i + 1] = negNum;
                                                elements.RemoveAt(i);
                                                i -= 3;
                                            }
                                            else if(elements[i + 1] is BlockContent blcC && blcC.Name == "Parenthesis")
                                            {
                                                blcC.Sign = !blcC.Sign;
                                                elements[i + 1] = blcC;
                                                elements.RemoveAt(i);
                                                i -= 3;
                                            }
                                            else if(elements[i + 1] is Function f)
                                            {
                                                f.Sign = !f.Sign;
                                                elements[i + 1] = f;
                                                elements.RemoveAt(i);
                                                i -= 3;
                                            }
                                        }
                                    }
                                    else // |[-][???]...
                                    {
                                        if (!(elements[i + 1] is Symbol))// ...[Symbol][-][!Symbol]... AND |Symbol| > |-|
                                        {
                                            if (elements[i + 1] is Number negNum)
                                            {
                                                negNum.Sign = !negNum.Sign;
                                                elements[i + 1] = negNum;
                                                elements.RemoveAt(i);
                                                i--;
                                            }
                                            else if (elements[i + 1] is BlockContent blcC && blcC.Name == "Parenthesis")
                                            {
                                                blcC.Sign = !blcC.Sign;
                                                elements[i + 1] = blcC;
                                                elements.RemoveAt(i);
                                                i--;
                                            }
                                            else if (elements[i + 1] is Function f)
                                            {
                                                f.Sign = !f.Sign;
                                                elements[i + 1] = f;
                                                elements.RemoveAt(i);
                                                i--;
                                            }
                                        }
                                        else if (elements[i + 1] is Symbol sym3)
                                        {
                                            if (sym3.Name == "+")
                                            {
                                                elements.RemoveAt(i + 1);
                                                i--;
                                            }
                                            else if (sym3.Name == "-")
                                            {
                                                elements[i] = new Symbol("+") { Order = 3 };
                                                elements.RemoveAt(i + 1);
                                                i--;
                                            }
                                        }
                                    }
                                }
                                else // ...[-]|
                                {
                                    elements.RemoveAt(i--);
                                }
                                break;
                            default:
                                elements.RemoveAt(i--);
                                break;
                        }
                        break;
                }
            }
            return elements;
        }
        static void UpdateElementTestingValues(int i, int count, ref bool previousExist, ref bool nextExist)
        {
            previousExist = i - 1 >= 0;
            nextExist = i + 1 < count;
        }
        public static List<IInstruction> Operators(List<IInstruction> elements, int order = 3)
        {
            List<IInstruction> result;
            // Recover values
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] is BlockContent sc && sc.Name == "Parenthesis")
                {
                    result = Operators(sc.Content);
                    if (result.Count == 1)
                    {
                        if (result[0] is Number resNum)
                        {
                            if (!sc.Sign)
                            {
                                resNum.Sign = !resNum.Sign;
                            }
                            elements[i] = resNum;
                        }
                        else if(result[0] is Function fNum)
                        {
                            if (!sc.Sign)
                            {
                                fNum.Sign = !fNum.Sign;
                            }
                            elements[i] = fNum;
                        }
                        else
                        {
                            sc.Content = result;
                            elements[i] = sc;
                        }
                    }
                    else
                    {
                        sc.Content = result;
                        elements[i] = sc;
                    }
                }
                else if(elements[i] is Function fn)
                {
                    List<List<IInstruction>> param = new List<List<IInstruction>>();
                    param.Add(new List<IInstruction>());
                    int paramIndex = 0;
                    for (int j = 0; j < fn.Content.Count; j++)
                    {
                        if(fn.Content[j] is Symbol sbl && sbl.Name == ",")
                        {
                            param.Add(new List<IInstruction>());
                            paramIndex++;
                        }
                        else
                        {
                            param[paramIndex].Add(fn.Content[j]);
                        }
                    }
                    bool canExecute = true;
                    for (int j = 0; j < param.Count; j++)
                    {
                        param[j] = Operators(param[j]);
                        canExecute &= param[j].Count == 1 && param[j][0] is Number;
                    }
                    if(canExecute)
                    {
                        switch(fn.Name)
                        {
                            case "coeffbin":
                                if (paramIndex == 1 && param[0][0] is Number nn && param[1][0] is Number kk)
                                {
                                    nn.SetActualNumber((double)IkiCore.Mathematics.CombinatorialAnalysis.BinomialCoefficient((long)nn.GetActualNumber(), (long)kk.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        nn.Sign = !nn.Sign;
                                    }
                                    elements[i] = nn;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "arcoth":
                                if (paramIndex == 0 && param[0][0] is Number acoth)
                                {
                                    acoth.SetActualNumber(Math.Atanh(1.0 / acoth.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        acoth.Sign = !acoth.Sign;
                                    }
                                    elements[i] = acoth;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "arsech":
                                if (paramIndex == 0 && param[0][0] is Number asech)
                                {
                                    asech.SetActualNumber(Math.Acosh(1.0 / asech.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        asech.Sign = !asech.Sign;
                                    }
                                    elements[i] = asech;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "arcsch":
                                if (paramIndex == 0 && param[0][0] is Number acsch)
                                {
                                    acsch.SetActualNumber(Math.Asinh(1.0 / acsch.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        acsch.Sign = !acsch.Sign;
                                    }
                                    elements[i] = acsch;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "coth":
                                if (paramIndex == 0 && param[0][0] is Number coth)
                                {
                                    coth.SetActualNumber(1.0 / Math.Tanh(coth.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        coth.Sign = !coth.Sign;
                                    }
                                    elements[i] = coth;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "sech":
                                if (paramIndex == 0 && param[0][0] is Number sech)
                                {
                                    sech.SetActualNumber(1.0 / Math.Cosh(sech.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        sech.Sign = !sech.Sign;
                                    }
                                    elements[i] = sech;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "csch":
                                if (paramIndex == 0 && param[0][0] is Number csch)
                                {
                                    csch.SetActualNumber(1.0 / Math.Sinh(csch.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        csch.Sign = !csch.Sign;
                                    }
                                    elements[i] = csch;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "artanh":
                                if (paramIndex == 0 && param[0][0] is Number atanh)
                                {
                                    atanh.SetActualNumber(Math.Atanh(atanh.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        atanh.Sign = !atanh.Sign;
                                    }
                                    elements[i] = atanh;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "arsinh":
                                if (paramIndex == 0 && param[0][0] is Number asinh)
                                {
                                    asinh.SetActualNumber(Math.Asinh(asinh.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        asinh.Sign = !asinh.Sign;
                                    }
                                    elements[i] = asinh;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "arcosh":
                                if (paramIndex == 0 && param[0][0] is Number acosh)
                                {
                                    acosh.SetActualNumber(Math.Acosh(acosh.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        acosh.Sign = !acosh.Sign;
                                    }
                                    elements[i] = acosh;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "tanh":
                                if (paramIndex == 0 && param[0][0] is Number tanh)
                                {
                                    tanh.SetActualNumber(Math.Tanh(tanh.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        tanh.Sign = !tanh.Sign;
                                    }
                                    elements[i] = tanh;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "sinh":
                                if (paramIndex == 0 && param[0][0] is Number sinh)
                                {
                                    sinh.SetActualNumber(Math.Sinh(sinh.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        sinh.Sign = !sinh.Sign;
                                    }
                                    elements[i] = sinh;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "cosh":
                                if (paramIndex == 0 && param[0][0] is Number cosh)
                                {
                                    cosh.SetActualNumber(Math.Cosh(cosh.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        cosh.Sign = !cosh.Sign;
                                    }
                                    elements[i] = cosh;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "acot":
                                if (paramIndex == 0 && param[0][0] is Number acot)
                                {
                                    double n = acot.GetActualNumber();
                                    acot.SetActualNumber(Math.Acos(n / Math.Sqrt(1 + n * n)));
                                    if (!fn.Sign)
                                    {
                                        acot.Sign = !acot.Sign;
                                    }
                                    elements[i] = acot;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "acsc":
                                if (paramIndex == 0 && param[0][0] is Number acsc)
                                {
                                    acsc.SetActualNumber(Math.Asin(1.0 / acsc.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        acsc.Sign = !acsc.Sign;
                                    }
                                    elements[i] = acsc;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "asec":
                                if (paramIndex == 0 && param[0][0] is Number asec)
                                {
                                    asec.SetActualNumber(Math.Acos(1.0 / asec.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        asec.Sign = !asec.Sign;
                                    }
                                    elements[i] = asec;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "cot":
                                if (paramIndex == 0 && param[0][0] is Number cot)
                                {
                                    cot.SetActualNumber(1.0 / Math.Tan(cot.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        cot.Sign = !cot.Sign;
                                    }
                                    elements[i] = cot;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "csc":
                                if (paramIndex == 0 && param[0][0] is Number csc)
                                {
                                    csc.SetActualNumber(1.0 / Math.Sin(csc.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        csc.Sign = !csc.Sign;
                                    }
                                    elements[i] = csc;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "sec":
                                if (paramIndex == 0 && param[0][0] is Number sec)
                                {
                                    sec.SetActualNumber(1.0 / Math.Cos(sec.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        sec.Sign = !sec.Sign;
                                    }
                                    elements[i] = sec;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "atan2":
                                if (paramIndex == 1 && param[0][0] is Number atanX && param[1][0] is Number atanY)
                                {
                                    atanX.SetActualNumber(Math.Atan2(atanX.GetActualNumber(), atanY.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        atanX.Sign = !atanX.Sign;
                                    }
                                    elements[i] = atanX;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "atan":
                                if (paramIndex == 0 && param[0][0] is Number atan)
                                {
                                    atan.SetActualNumber(Math.Atan(atan.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        atan.Sign = !atan.Sign;
                                    }
                                    elements[i] = atan;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "asin":
                                if (paramIndex == 0 && param[0][0] is Number asin)
                                {
                                    asin.SetActualNumber(Math.Asin(asin.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        asin.Sign = !asin.Sign;
                                    }
                                    elements[i] = asin;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "acos":
                                if (paramIndex == 0 && param[0][0] is Number acos)
                                {
                                    acos.SetActualNumber(Math.Acos(acos.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        acos.Sign = !acos.Sign;
                                    }
                                    elements[i] = acos;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "tan":
                                if (paramIndex == 0 && param[0][0] is Number tan)
                                {
                                    tan.SetActualNumber(Math.Tan(tan.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        tan.Sign = !tan.Sign;
                                    }
                                    elements[i] = tan;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "sin":
                                if (paramIndex == 0 && param[0][0] is Number sin)
                                {
                                    sin.SetActualNumber(Math.Sin(sin.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        sin.Sign = !sin.Sign;
                                    }
                                    elements[i] = sin;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "cos":
                                if (paramIndex == 0 && param[0][0] is Number cos)
                                {
                                    cos.SetActualNumber(Math.Cos(cos.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        cos.Sign = !cos.Sign;
                                    }
                                    elements[i] = cos;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "prime":
                                if (paramIndex == 0 && param[0][0] is Number p)
                                {
                                    p.SetActualNumber(IkiCore.Mathematics.Math.IsPrime((long)p.GetActualNumber()) ? 1 : 0);
                                    if (!fn.Sign)
                                    {
                                        p.Sign = !p.Sign;
                                    }
                                    elements[i] = p;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "ceil":
                                if (paramIndex == 0 && param[0][0] is Number ceilNum)
                                {
                                    ceilNum.SetActualNumber(IkiCore.Mathematics.Math.Ceil(ceilNum.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        ceilNum.Sign = !ceilNum.Sign;
                                    }
                                    elements[i] = ceilNum;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "round":
                                if (paramIndex == 0 && param[0][0] is Number roundNum)
                                {
                                    roundNum.SetActualNumber(IkiCore.Mathematics.Math.Round(roundNum.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        roundNum.Sign = !roundNum.Sign;
                                    }
                                    elements[i] = roundNum;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "floor":
                                if (paramIndex == 0 && param[0][0] is Number floorNum)
                                {
                                    floorNum.SetActualNumber(IkiCore.Mathematics.Math.Floor(floorNum.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        floorNum.Sign = !floorNum.Sign;
                                    }
                                    elements[i] = floorNum;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "abs":
                                if (paramIndex == 0 && param[0][0] is Number absNum)
                                {
                                    absNum.SetActualNumber(IkiCore.Mathematics.Math.Abs(absNum.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        absNum.Sign = !absNum.Sign;
                                    }
                                    elements[i] = absNum;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "sign":
                                if (paramIndex == 0 && param[0][0] is Number signNum)
                                {
                                    signNum.SetActualNumber(IkiCore.Mathematics.Math.Sign(signNum.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        signNum.Sign = !signNum.Sign;
                                    }
                                    elements[i] = signNum;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "sqrt":
                                if (paramIndex == 0 && param[0][0] is Number sqrNum)
                                {
                                    sqrNum.SetActualNumber(IkiCore.Mathematics.Math.Sqrt(sqrNum.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        sqrNum.Sign = !sqrNum.Sign;
                                    }
                                    elements[i] = sqrNum;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "exp":
                                if (paramIndex == 0 && param[0][0] is Number expNum)
                                {
                                    expNum.SetActualNumber(IkiCore.Mathematics.Math.Exp(expNum.GetActualNumber()));
                                    if(!fn.Sign)
                                    {
                                        expNum.Sign = !expNum.Sign;
                                    }
                                    elements[i] = expNum;
                                }
                                else // exp don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "lb":
                                if (paramIndex == 0 && param[0][0] is Number lbNum)
                                {
                                    lbNum.SetActualNumber(IkiCore.Mathematics.Math.Lb(lbNum.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        lbNum.Sign = !lbNum.Sign;
                                    }
                                    elements[i] = lbNum;
                                }
                                else // ln don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "ln":
                                if(paramIndex == 0 && param[0][0] is Number lnNum)
                                {
                                    lnNum.SetActualNumber(IkiCore.Mathematics.Math.Ln(lnNum.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        lnNum.Sign = !lnNum.Sign;
                                    }
                                    elements[i] = lnNum;
                                }
                                else // ln don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "lambertW":
                                if (paramIndex == 0 && param[0][0] is Number lWNum)
                                {
                                    lWNum.SetActualNumber(IkiCore.Mathematics.Math.LambertW(lWNum.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        lWNum.Sign = !lWNum.Sign;
                                    }
                                    elements[i] = lWNum;
                                }
                                else // ln don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "root":
                                if (paramIndex == 1 && param[0][0] is Number rootBsNum && param[1][0] is Number xNumbr)
                                {
                                    rootBsNum.SetActualNumber(IkiCore.Mathematics.Math.Pow(xNumbr.GetActualNumber(), 1.0 / rootBsNum.GetActualNumber()));
                                    rootBsNum.Sign = true;
                                    if (!fn.Sign)
                                    {
                                        rootBsNum.Sign = !rootBsNum.Sign;
                                    }
                                    elements[i] = rootBsNum;
                                }
                                else // ln don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "log":
                                if (paramIndex == 0 && param[0][0] is Number logNum)
                                {
                                    logNum.SetActualNumber(IkiCore.Mathematics.Math.Log(logNum.GetActualNumber()));
                                    if (!fn.Sign)
                                    {
                                        logNum.Sign = !logNum.Sign;
                                    }
                                    elements[i] = logNum;
                                }
                                else if (paramIndex == 1 && param[0][0] is Number logBNum && param[1][0] is Number logNumbr)
                                {
                                    logBNum.SetActualNumber(IkiCore.Mathematics.Math.Log(logNumbr.GetActualNumber(), logBNum.GetActualNumber()));
                                    logBNum.Sign = true;
                                    if (!fn.Sign)
                                    {
                                        logBNum.Sign = !logBNum.Sign;
                                    }
                                    elements[i] = logBNum;
                                }
                                else // ln don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "min":
                                if (paramIndex == 1 && param[0][0] is Number minANum && param[1][0] is Number minBNum)
                                {
                                    minANum.SetActualNumber(IkiCore.Mathematics.Math.Min(minANum.GetActualNumber(), minBNum.GetActualNumber()));
                                    minANum.Sign = true;
                                    if (!fn.Sign)
                                    {
                                        minANum.Sign = !minANum.Sign;
                                    }
                                    elements[i] = minANum;
                                }
                                else // ln don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "max":
                                if (paramIndex == 1 && param[0][0] is Number maxANum && param[1][0] is Number maxBNum)
                                {
                                    maxANum.SetActualNumber(IkiCore.Mathematics.Math.Max(maxANum.GetActualNumber(), maxBNum.GetActualNumber()));
                                    maxANum.Sign = true;
                                    if (!fn.Sign)
                                    {
                                        maxANum.Sign = !maxANum.Sign;
                                    }
                                    elements[i] = maxANum;
                                }
                                else // ln don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "gcd":
                                if (paramIndex == 1 && param[0][0] is Number l && param[1][0] is Number r)
                                {
                                    l.SetActualNumber(IkiCore.Mathematics.Math.GreatestCommonDivisor((long)l.GetActualNumber(), (long)r.GetActualNumber()));
                                    l.Sign = true;
                                    if (!fn.Sign)
                                    {
                                        l.Sign = !l.Sign;
                                    }
                                    elements[i] = l;
                                }
                                else // ln don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "lcm":
                                if (paramIndex == 1 && param[0][0] is Number left && param[1][0] is Number right)
                                {
                                    left.SetActualNumber(IkiCore.Mathematics.Math.LeastCommonMultiple((long)left.GetActualNumber(), (long)right.GetActualNumber()));
                                    left.Sign = true;
                                    if (!fn.Sign)
                                    {
                                        left.Sign = !left.Sign;
                                    }
                                    elements[i] = left;
                                }
                                else // ln don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "mod":
                                if (paramIndex == 1 && param[0][0] is Number leftM && param[1][0] is Number rightM)
                                {
                                    leftM.SetActualNumber(IkiCore.Mathematics.Math.Modulo(leftM.GetActualNumber(), rightM.GetActualNumber()));
                                    leftM.Sign = true;
                                    if (!fn.Sign)
                                    {
                                        leftM.Sign = !leftM.Sign;
                                    }
                                    elements[i] = leftM;
                                }
                                else // ln don't support multiples parameters
                                {
                                    elements.RemoveAt(i);
                                    i--;
                                }
                                break;
                            default:
                                elements[i] = fn;
                                break;
                        }
                    }
                    else
                    {
                        fn.Content = new List<IInstruction>();
                        for (int j = 0; j < param.Count; j++)
                        {
                            fn.Content.AddRange(param[j]);
                        }
                        elements[i] = fn;
                    }
                }
            }
            bool previousExist = false, nextExist = false;
            if (order <= 0) // Root of all evil
            {
                for (int i = 0; i < elements.Count; i++)
                {
                    UpdateElementTestingValues(i, elements.Count, ref previousExist, ref nextExist);
                    if(elements[i] is Number n && nextExist && elements[i + 1] is Symbol s && s.Name == "!") // k th factorial
                    {
                        switch(s.Order)
                        {
                            case -1:
                                n.SetActualNumber(IkiCore.Mathematics.CombinatorialAnalysis.Factorial(n.GetActualNumber()));
                                elements.RemoveAt(i + 1);
                                i--;
                                break;
                            default:
                                elements.RemoveAt(i + 1);
                                i--;
                                break;
                        }
                    }
                }
                if(elements.Count > 1)
                {
                    return new List<IInstruction>
                    {
                        new BlockContent("Parenthesis", "(", ")")
                        {
                            Content = elements
                        }
                    };
                }
                else
                {
                    return elements;
                }
            }
            else // Any order > than 0
            {
                // Priority Ordering
                for (int i = 0; i < elements.Count; i++) 
                {
                    UpdateElementTestingValues(i, elements.Count, ref previousExist, ref nextExist);
                    // Inferior Order
                    if (elements[i] is Symbol sym && sym.Order < order)
                    {
                        int startIndex;
                        int count;
                        if (previousExist)
                        {
                            startIndex = i - 1;
                            count = 2;
                        }
                        else
                        {
                            startIndex = i;
                            count = 1;
                        }
                        for (int j = i + 1; j < elements.Count; j++)
                        {
                            if (elements[j] is Symbol symbl && symbl.Order >= order) // Not supposed to be greater but whatever..
                            {
                                break;
                            }
                            count++;
                        }
                        result = Operators(elements.GetRange(startIndex, count), order - 1);
                        elements.RemoveRange(startIndex, count);
                        elements.InsertRange(startIndex, result);
                        i = startIndex + result.Count - 1;
                    }
                }
                // Computation
                for (int i = 0; i < elements.Count; i++)
                {
                    UpdateElementTestingValues(i, elements.Count, ref previousExist, ref nextExist);
                    if (previousExist && nextExist && elements[i] is Symbol s && s.Order == order) //[???][Symbol][???]
                    {
                        if(elements[i - 1] is Number left && elements[i + 1] is Number right) //[Number][Symbol][Number]
                        {
                            switch (s.Name)
                            {
                                case "^":
                                    left.SetActualNumber(Math.Pow(left.GetActualNumber(), right.GetActualNumber()));
                                    left.Sign = true;
                                    elements.RemoveRange(i, 2);
                                    elements[i - 1] = left;
                                    i -= 2;
                                    break;
                                case "*":
                                    left.SetActualNumber(left.GetActualNumber() * right.GetActualNumber());
                                    left.Sign = true;
                                    elements.RemoveRange(i, 2);
                                    elements[i - 1] = left;
                                    i -= 2;
                                    break;
                                case "/":
                                    left.SetActualNumber(left.GetActualNumber() / right.GetActualNumber());
                                    left.Sign = true;
                                    elements.RemoveRange(i, 2);
                                    elements[i - 1] = left;
                                    i -= 2;
                                    break;
                                case "+":
                                    left.SetActualNumber(left.GetActualNumber() + right.GetActualNumber());
                                    left.Sign = true;
                                    elements.RemoveRange(i, 2);
                                    elements[i - 1] = left;
                                    i -= 2;
                                    break;
                                case "-":
                                    left.SetActualNumber(left.GetActualNumber() - right.GetActualNumber());
                                    left.Sign = true;
                                    elements.RemoveRange(i, 2);
                                    elements[i - 1] = left;
                                    i -= 2;
                                    break;
                            }
                        }
                    }
                }
                if(elements.Count > 1)
                {
                    return new List<IInstruction>
                    {
                        new BlockContent("Parenthesis", "(", ")")
                        {
                            Content = elements
                        }
                    };
                }
                else
                {
                    return elements;
                }
            }
        }
    }
}
