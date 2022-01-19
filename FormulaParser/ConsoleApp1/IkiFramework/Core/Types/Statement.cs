using System;
using IkiCore.Mathematics;
namespace IkiCore
{
    public struct Statement : IEquatable<Statement>, IFormattable
    {
        public enum Table
        {
            And,
            Or,
            XOr,
            Less,
            LEqual,
            Greater,
            GEqual,
            Equal
        }
        byte value;
        internal static string[] values = new string[] { "False", "Neutral", "Any", "True" };
        public bool IsBool => value == 0x3 || value == 0x0;
        public bool IsFalse => value == 0x0;
        public bool IsNeutral => value == 0x1;
        public bool IsAny => value == 0x2;
        public bool IsTrue => value == 0x3;
        public Statement(StatementState state)
        {
            value = (byte)state;
        }
        public Statement(Statement state)
        {
            value = state.value;
        }
        public Statement(bool state)
        {
            value = (byte)(state ? 0x2 : 0x0);
        }
        public Statement(int state)
        {
            value = (byte)(state & 0x3);
        }
        public static Statement Neutral
        {
            get
            {
                Statement n;
                n.value = 0x0;
                return n;
            }
        }
        public static Statement Any
        {
            get
            {
                Statement n;
                n.value = 0x3;
                return n;
            }
        }
        public StatementState Get()
        {
            return (StatementState)value;
        }
        public void Set(StatementState state)
        {
            value = (byte)state;
        }
        static Statement Operator_AND(Statement stateA, Statement stateB)
        {
            return stateA && stateB;
        }
        static Statement Operator_OR(Statement stateA, Statement stateB)
        {
            return stateA || stateB;
        }
        static Statement Operator_XOR(Statement stateA, Statement stateB)
        {
            return stateA ^ stateB;
        }
        static Statement Operator_EQUAL(Statement stateA, Statement stateB)
        {
            return stateA == stateB;
        }
        static Statement Operator_LESS(Statement stateA, Statement stateB)
        {
            return stateA < stateB;
        }
        static Statement Operator_GREATER(Statement stateA, Statement stateB)
        {
            return stateA > stateB;
        }
        static Statement Operator_LESSEQUAL(Statement stateA, Statement stateB)
        {
            return stateA <= stateB;
        }
        static Statement Operator_GREATEREQUAL(Statement stateA, Statement stateB)
        {
            return stateA >= stateB;
        }
        public static string WriteOperationTable(Table table)
        {
            Func<Statement, Statement, Statement> f;
            string result;
            string symbl;
            switch (table)
            {
                case Table.And:
                    f = Operator_AND;
                    result = "AND";
                    symbl = "&";
                    break;
                case Table.Or:
                    f = Operator_OR;
                    result = "OR";
                    symbl = "|";
                    break;
                case Table.XOr:
                    f = Operator_XOR;
                    result = "XOR";
                    symbl = "^";
                    break;
                case Table.Less:
                    f = Operator_LESS;
                    result = "LESS";
                    symbl = "<";
                    break;
                case Table.LEqual:
                    f = Operator_LESSEQUAL;
                    result = "LEQUAL";
                    symbl = "<";
                    break;
                case Table.GEqual:
                    f = Operator_GREATEREQUAL;
                    result = "GEQUAL";
                    symbl = ">";
                    break;
                case Table.Greater:
                    f = Operator_GREATER;
                    result = "GREATER";
                    symbl = ">";
                    break;
                case Table.Equal:
                    f = Operator_EQUAL;
                    result = "EQUAL";
                    symbl = "=";
                    break;
                default:
                    return null;
            }
            Statement a, b;
            string[] cellValue = new string[]
            {
                "F",
                "N",
                "A",
                "T"
            };
            result = $"(Row {result} Column)\n-F is False, N is Neutral, A is Any and T is True\n|{symbl}|{cellValue[3]}|{cellValue[2]}|{cellValue[1]}|{cellValue[0]}|\n";
            for (int i = 3; i >= 0; i--)
            {
                b = new Statement(i);
                for (int j = 3; j >= 0; j--)
                {
                    a = new Statement(j);
                    if(j == 3)
                    {
                        result = $"{result}|{cellValue[i]}|";
                    }
                    result = $"{result}{cellValue[(int)f(b, a)]}|";
                }
                result = $"{result}\n";
            }
            return result;
        }
        public static string WriteDatas(Statement state, string name)
        {
            // IS
            // TRUE     S1: {{s == true}}                S2: {{s.IsTrue}}                S3: {{!(s.IsNeutral || s.IsFalse)}}
            // NEUTRAL  S1: {{s != true && s != false}}  S2: {{!s.IsBool}}               S3: {{s.IsNeutral}}                     S4: {{!(s.IsTrue || s.IsFalse)}}
            // FALSE    S1: {{s == false}}               S2: {{s.IsFalse}}               S3: {{!(s.IsNeutral || s.IsTrue)}}
            // IS NOT
            // TRUE     S1: {{s != true}}                S2: {{!s.IsTrue}}               S3: {{s.IsNeutral || s.IsFalse}}
            // NEUTRAL  S1: {{s == true || s == false}}  S2: {{s.IsBool}}                S3: {{s.IsTrue || s.IsFalse}}
            // FALSE    S1: {{s != false}}               S2: {{s.IsNeutral || s.IsTrue}} S3: {{s.IsNeutral || s.IsTrue}}
            return $"Statement {name} is {state}\n\nInvert {name} is: {~state}\nNot {name}: {!state}\n{name} is True: {state.IsTrue}\n{name} is Neutral: {state.IsNeutral}\n{name} is False: {state.IsFalse}\n{name} is not True: {!state.IsTrue}\n{name} is not Neutral: {!state.IsNeutral}\n{name} is not False: {!state.IsFalse}";
        }
        public static string WriteOperationsResults(Statement stateA, string nameA, Statement stateB, string nameB)
        {
            return $"Statement {nameA} is {stateA}\nStatement {nameB} is {stateB}\n{nameA} AND {nameB}: {stateA && stateB}\n{nameA} OR {nameB}: {stateA || stateB}\n{nameA} XOR {nameB}: {stateA ^ stateB}\n{nameA} Equal Equal To {nameB}: {stateA == stateB}\n{nameA} Is Different Than {nameB}: {stateA != stateB}\n{nameA} Is Less Importance Than {nameB}: {stateA < stateB}\n{nameA} Is Less Or Equal Importance Than {nameB}: {stateA <= stateB}\n{nameA} Is Higher Importance Than {nameB}: {stateA > stateB}\n{nameA} Is Higher Or Equal Importance Than {nameB}: {stateA >= stateB}";
        }
        bool IEquatable<Statement>.Equals(Statement other)
        {
            return other.value == value;
        }
        public override bool Equals(object obj) => base.Equals(obj);
        public override int GetHashCode() => base.GetHashCode();
        string IFormattable.ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format(values[value], formatProvider);
        }
        public static Statement operator ~(Statement a)
        {
            a.value = (byte)(0x3 - a.value);
            return a;
        }
        public static Statement operator &(Statement a, Statement b)
        {
            a.value = (byte)Mathematics.Math.Min(a.value, b.value);
            return a;
        }
        public static Statement operator |(Statement a, Statement b)
        {
            a.value = (byte)Mathematics.Math.Max(a.value, b.value);
            return a;
        }
        public static Statement operator ^(Statement a, Statement b)
        {
            a.value = (byte)(a.value - b.value).Abs();
            return a;
        }
        public static bool operator <(Statement a, Statement b)
        {
            return a.value < b.value;
        }
        public static bool operator >(Statement a, Statement b)
        {
            return a.value > b.value;
        }
        public static bool operator <=(Statement a, Statement b)
        {
            return a.value <= b.value;
        }
        public static bool operator >=(Statement a, Statement b)
        {
            return a.value >= b.value;
        }
        public static bool operator ==(Statement a, Statement b)
        {
            return a.value == b.value;
        }
        public static bool operator !=(Statement a, Statement b)
        {
            return a.value != b.value;
        }
        public static Statement operator !(Statement a)
        {
            a.value = (byte)(0x3 - a.value);
            return a;
        }
        public static bool operator true(Statement x) => x.value == 0x3;
        public static bool operator false(Statement x) => x.value == 0x0;
        public static explicit operator bool(Statement x) => x.value == 0x3;
        public static implicit operator Statement(bool a)
        {
            Statement statement;
            statement.value = (byte)(a ? 0x3 : 0x0);
            return statement;
        }
        public static explicit operator byte(Statement a) => a.value;
        public static explicit operator Statement(byte a)
        {
            Statement statement;
            statement.value = (byte)(a & 0x3);
            return statement;
        }
        public static explicit operator char(Statement a) => values[a.value][0];
        public static explicit operator Statement(char a)
        {
            Statement statement;
            statement.value = (byte)((a == 't') ? 0x3 : (a == 'n') ? 0x1 : (a == 'f') ? 0x0 : 0x2);
            return statement;
        }
        public static explicit operator short(Statement a) => a.value;
        public static explicit operator Statement(short a)
        {
            Statement statement;
            statement.value = (byte)(a & 0x3);
            return statement;
        }
        public static explicit operator ushort(Statement a) => a.value;
        public static explicit operator Statement(ushort a)
        {
            Statement statement;
            statement.value = (byte)(a & 0x3);
            return statement;
        }
        public static explicit operator int(Statement a) => a.value;
        public static explicit operator Statement(int a)
        {
            Statement statement;
            statement.value = (byte)(a & 0x3);
            return statement;
        }
        public static explicit operator uint(Statement a) => a.value;
        public static explicit operator Statement(uint a)
        {
            Statement statement;
            statement.value = (byte)(a & 0x3u);
            return statement;
        }
        public static explicit operator long(Statement a) => a.value;
        public static explicit operator Statement(long a)
        {
            Statement statement;
            statement.value = (byte)(a & 0x3L);
            return statement;
        }
        public static explicit operator ulong(Statement a) => a.value;
        public static explicit operator Statement(ulong a)
        {
            Statement statement;
            statement.value = (byte)(a & 0x3ul);
            return statement;
        }
    }
}
