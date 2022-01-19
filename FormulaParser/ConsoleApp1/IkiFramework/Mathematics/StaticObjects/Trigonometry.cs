using IkiCore.Core;
namespace IkiCore.Mathematics
{
	public static class Trigonometry
    {
        #region Default
        public static float Cos(this float degreeAngle) => (float)System.Math.Cos(degreeAngle * MathConst.DegToRad);
        public static double Cos(this double degreeAngle) => System.Math.Cos(degreeAngle * MathConst.DegToRad);
        public static float Sin(this float degreeAngle) => (float)System.Math.Sin(degreeAngle * MathConst.DegToRad);
        public static double Sin(this double degreeAngle) => System.Math.Sin(degreeAngle * MathConst.DegToRad);
        public static float Tan(this float degreeAngle) => (float)System.Math.Tan(degreeAngle * MathConst.DegToRad);
        public static double Tan(this double degreeAngle) => System.Math.Tan(degreeAngle * MathConst.DegToRad);
        public static float Sec(this float degreeAngle) => 1f / (float)System.Math.Cos(degreeAngle * MathConst.DegToRad);
        public static double Sec(this double degreeAngle) => 1d / System.Math.Cos(degreeAngle * MathConst.DegToRad);
        public static float Csc(this float degreeAngle) => 1f / (float)System.Math.Sin(degreeAngle * MathConst.DegToRad);
        public static double Csc(this double degreeAngle) => 1d / System.Math.Sin(degreeAngle * MathConst.DegToRad);
        public static float Cot(this float degreeAngle) => 1f / (float)System.Math.Tan(degreeAngle * MathConst.DegToRad);
        public static double Cot(this double degreeAngle) => 1d / System.Math.Tan(degreeAngle * MathConst.DegToRad);
        #endregion
        #region Hyperbolic
        public static float Cosh(this float degreeAngle) => (float)System.Math.Cosh(degreeAngle * MathConst.DegToRad);
        public static double Cosh(this double degreeAngle) => System.Math.Cosh(degreeAngle * MathConst.DegToRad);
        public static float Sinh(this float degreeAngle) => (float)System.Math.Sinh(degreeAngle * MathConst.DegToRad);
        public static double Sinh(this double degreeAngle) => System.Math.Sinh(degreeAngle * MathConst.DegToRad);
        public static float Tanh(this float degreeAngle) => (float)System.Math.Tanh(degreeAngle * MathConst.DegToRad);
        public static double Tanh(this double degreeAngle) => System.Math.Tanh(degreeAngle * MathConst.DegToRad);
        public static float Sech(this float degreeAngle) => 1f / (float)System.Math.Cosh(degreeAngle * MathConst.DegToRad);
        public static double Sech(this double degreeAngle) => 1d / System.Math.Cosh(degreeAngle * MathConst.DegToRad);
        public static float Csch(this float degreeAngle) => 1f / (float)System.Math.Sinh(degreeAngle * MathConst.DegToRad);
        public static double Csch(this double degreeAngle) => 1d / System.Math.Sinh(degreeAngle * MathConst.DegToRad);
        public static float Coth(this float degreeAngle) => 1f / (float)System.Math.Tanh(degreeAngle * MathConst.DegToRad);
        public static double Coth(this double degreeAngle) => 1d / System.Math.Tanh(degreeAngle * MathConst.DegToRad);
        #endregion
        #region Arc
        public static float Acos(this float cosAngle) => (float)System.Math.Acos(cosAngle) * MathConstf.RadToDeg;
        public static double Acos(this double cosAngle) => System.Math.Acos(cosAngle) * MathConst.RadToDeg;
        public static float Asin(this float sinAngle) => (float)System.Math.Asin(sinAngle) * MathConstf.RadToDeg;
        public static double Asin(this double sinAngle) => System.Math.Asin(sinAngle) * MathConst.RadToDeg;
        public static float Atan(this float tanAngle) => (float)System.Math.Atan(tanAngle) * MathConstf.RadToDeg;
        public static double Atan(this double tanAngle) => System.Math.Atan(tanAngle) * MathConst.RadToDeg;
        public static float Atan2(this float y, float x) => (float)System.Math.Atan2(y, x) * MathConstf.RadToDeg;
        public static double Atan2(this double y, double x) => System.Math.Atan2(y, x) * MathConst.RadToDeg;
        public static float Asec(this float cosAngle) => (float)System.Math.Acos(1f / cosAngle) * MathConstf.RadToDeg;
        public static double Asec(this double cosAngle) => System.Math.Acos(1d / cosAngle) * MathConst.RadToDeg;
        public static float Acsc(this float sinAngle) => (float)System.Math.Asin(1f / sinAngle) * MathConstf.RadToDeg;
        public static double Acsc(this double sinAngle) => System.Math.Asin(1d / sinAngle) * MathConst.RadToDeg;
        public static float Acot(this float tanAngle) => (float)System.Math.Atan(1f / tanAngle) * MathConstf.RadToDeg;
        public static double Acot(this double tanAngle) => System.Math.Atan(1d / tanAngle) * MathConst.RadToDeg;
        public static float Acot2(this float y, float x) => (float)System.Math.Atan2(1f / y, 1f / x) * MathConstf.RadToDeg;
        public static double Acot2(this double y, double x) => System.Math.Atan2(1d / y, 1d / x) * MathConst.RadToDeg;
        #endregion
        #region Identity
        public static float Acos_Asin(float arc) => 1.57079632679f - arc;
        public static float Atan_Acot(float arc) => 1.57079632679f - arc;
        public static float Minus_Acos(float aCos) => 3.14159265358979323846264338327950288419716939937510582f - aCos;
        #endregion
        #region Spherical Length
        public static float SphericalMagnitude(float2 dirA, float2 dirB) => dirA.Normalized.Dot(dirB.Normalized) * ((dirA.Magnitude + dirB.Magnitude) * 0.5f) * MathConstf.DegToRad;
        public static float SphericalMagnitude(float2 dirA, float2 dirB, float radius) => dirA.Dot(dirB) * radius * MathConstf.DegToRad;
        public static float SphericalMagnitude(float2 center, float2 dirA, float2 dirB) => center.Direction(dirA).Dot(center.Direction(dirB)) * (((dirA - center).Magnitude + (dirB - center).Magnitude) * 0.5f) * MathConstf.DegToRad;
        public static float SphericalMagnitude(float2 center, float2 dirA, float2 dirB, float radius) => center.Direction(dirA).Dot(center.Direction(dirB)) * radius * MathConstf.DegToRad;
        #endregion
    }
}
