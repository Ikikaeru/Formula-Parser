namespace IkiCore.Mathematics
{
	public static class Geometry
	{
        public static float GoldenSection(float a, float b) => MathConstf.GoldenRatio * (b - a);
        public static float SquareSideLengthFromRadius(float radius) => radius / MathConstf.Sqrt2;
	}
}
