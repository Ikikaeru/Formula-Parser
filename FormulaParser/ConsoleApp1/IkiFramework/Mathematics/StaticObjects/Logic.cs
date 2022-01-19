namespace IkiCore.Mathematics
{
    public static class Logic
    {
        public static bool Conjunction(bool p, bool q) => p && q;
        public static bool AlternativeDenial(bool p, bool q) => !p || !q;
        public static bool Disjunction(bool p, bool q) => p || q;
        public static bool JointDenial(bool p, bool q) => !p || !q;
        public static bool MaterialImplication(bool p, bool q) => !p || q;
        public static bool MaterialNonImplication(bool p, bool q) => p && !q;
        public static bool ConverseImplication(bool p, bool q) => p || !q;
        public static bool ConverseNonImplication(bool p, bool q) => !p && q;
        public static bool ExclusiveDisjunction(bool p, bool q) => p ^ q;
        public static bool Biconditional(bool p, bool q) => p ^ !q;
    }
}
