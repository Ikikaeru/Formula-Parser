namespace IkiCore.Mathematics
{
	public static class Probability
	{
        public static float EventProbability(int issues, float eventIssues)
        {
            return eventIssues / issues;
        }
        /// <summary>
        /// Return how many times an event happen with the same probability whenever the time we observe and for the same amount of time.
        /// </summary>
        /// <param name="wantToObserve"></param>
        /// <param name="averagePerUnit"></param>
        public static float PoissonRule(float wantToObserve, float averagePerUnit)
        {
            return (MathConstf.E.Pow(-averagePerUnit) * averagePerUnit.Pow(wantToObserve) / CombinatorialAnalysis.Factorial(wantToObserve));
        }
        public static float Density(float start, float end)
        {
            return 1f / (end - start);
        }
        public static float NormalDistribution(float value)
        {
            return MathConstf.E.Pow(-(value * value) * 0.5f) / MathConstf.Tau.Sqrt();
        }
        public static float CumulativeDistribution(float start, float end, float value)
        {
            if(value < start)
            {
                return 0f;
            }
            else if(value > end)
            {
                return 1f;
            }
            return (value - start) / (end - value);
        }
    }
}
