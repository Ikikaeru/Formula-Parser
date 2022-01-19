namespace IkiCore.Mathematics
{
    /// <summary> Library to ease any float value. </summary>
    public static class Easing
    {
        /// <summary> Get a smooth step value. </summary>
        /// <param name="t">Value to smooth step.</param>
        public static float SmoothStep(float t) => t * t * (3f - 2f * t);
        /// <summary> Get a better smooth step value. </summary>
        /// <param name="t">Value to smoother step.</param>
        public static float SmootherStep(float t) => t * t * t * (t * (t * 6f - 15f) + 10f);
        /// <summary> Get a quadratic in value. </summary>
        /// <param name="t">Value to quadratic in.</param>
        public static float QuadraticIn(float t) => t * t;
        /// <summary> Get a quadratic out value. </summary>
        /// <param name="t">Value to quadratic out.</param>
        public static float QuadraticOut(float t) => t * (2f - t);
        /// <summary> Get a cubic in value. </summary>
        /// <param name="t">Value to cubic in.</param>
        public static float CubicIn(float t) => t * t * t;
        /// <summary> Get a cubic out value. </summary>
        /// <param name="t">Value to cubic out.</param>
        public static float CubicOut(float t) => 1f + ((t -= 1f) * t * t);
        /// <summary> Get a quartic in value. </summary>
        /// <param name="t">Value to quartic in.</param>
        public static float QuarticIn(float t) => t * t * t * t;
        /// <summary> Get a quartic out value. </summary>
        /// <param name="t">Value to quartic out.</param>
        public static float QuarticOut(float t) => 1f - ((t -= 1f) * t * t * t);
        /// <summary> Get a quintic in value. </summary>
        /// <param name="t">Value to quintic in.</param>
        public static float QuinticIn(float t) => t * t * t * t * t;
        /// <summary> Get a quintic out value. </summary>
        /// <param name="t">Value to quintic out.</param>
        public static float QuinticOut(float t) => 1f + ((t -= 1f) * t * t * t * t);
        /// <summary> Get a sinusoidal in value. </summary>
        /// <param name="t">Value to sinusoidal in.</param>
        public static float SinusoidalIn(float t) => 1f - (float)System.Math.Cos(t * 1.5707963267948966192313216916398f);
        /// <summary> Get a sinusoidal out value. </summary>
        /// <param name="t">Value to sinusoidal out.</param>
        public static float SinusoidalOut(float t) => (float)System.Math.Sin(t * 1.5707963267948966192313216916398f);
        /// <summary> Get an exponential in value. </summary>
        /// <param name="t">Value to exponential in.</param>
        public static float ExponentialIn(float t) => t >= 0f - float.Epsilon && t <= 0f + float.Epsilon ? 0f : (float)System.Math.Pow(1024f, t - 1f);
        /// <summary> Get an exponential out value. </summary>
        /// <param name="t">Value to exponential out.</param>
        public static float ExponentialOut(float t) => t >= 1f - float.Epsilon && t <= 1f + float.Epsilon ? 1f : 1f - (float)System.Math.Pow(2f, -10f * t);
        /// <summary> Get a circular in value. </summary>
        /// <param name="t">Value to circular in.</param>
        public static float CircularIn(float t) => 1f - (float)System.Math.Sqrt(1f - t * t);
        /// <summary> Get a circular out value. </summary>
        /// <param name="t">Value to circular out.</param>
        public static float CircularOut(float t) => (1f - (float)System.Math.Sqrt((t -= 1f) * t));
        /// <summary> Get an elastic value. </summary>
        /// <param name="t">Value to elastic.</param>
        public static float Elastic(float t)
        {
            if (t >= 0f - float.Epsilon && t <= 0f + float.Epsilon)
            {
                return 0;
            }
            else if (t >= 1f - float.Epsilon && t <= 1f + float.Epsilon)
            {
                return 1;
            }
            else
            {
                return (float)System.Math.Pow(2f, -10f * t) * (float)System.Math.Sin((t - 0.1f) * 6.283185307179586476925286766559f / 0.4f) + 1f;
            }
        }
        /// <summary> Get a back in value. </summary>
        /// <param name="t">Value to back in.</param>
        public static float BackIn(float t) => t * t * (2.70158f * t - 1.70158f);
        /// <summary> Get a back out value. </summary>
        /// <param name="t">Value to back out.</param>
        public static float BackOut(float t) => (t -= 1f) * t * (2.70158f * t + 1.70158f) + 1f;
        /// <summary> Get a bounce in value. </summary>
        /// <param name="t">Value to bounce in.</param>
        public static float BounceIn(float t)
        {
            float t2 = 1f - t;
            if (t < (1f / 2.75f))
            {
                t2 = 7.5625f * t * t;
            }
            else if (t < (2f / 2.75f))
            {
                t2 = 7.5625f * (t -= (1.5f / 2.75f)) * t + 0.75f;
            }
            else if (t < (2.5f / 2.75f))
            {
                t2 = 7.5625f * (t -= (2.25f / 2.75f)) * t + 0.9375f;
            }
            else
            {
                t2 = 7.5625f * (t -= (2.625f / 2.75f)) * t + 0.984375f;
            }
            return 1f - t2;
        }
        /// <summary> Get a bounce out value. </summary>
        /// <param name="t">Value to bounce out.</param>
        public static float BounceOut(float t)
        {
            if (t < (1f / 2.75f))
            {
                return 7.5625f * t * t;
            }
            else if (t < (2f / 2.75f))
            {
                return 7.5625f * (t -= (1.5f / 2.75f)) * t + 0.75f;
            }
            else if (t < (2.5f / 2.75f))
            {
                return 7.5625f * (t -= (2.25f / 2.75f)) * t + 0.9375f;
            }
            else
            {
                return 7.5625f * (t -= (2.625f / 2.75f)) * t + 0.984375f;
            }
        }
        public static float PingPong(this float value, float length)
        {
            value = value.Repeat(length * 2f);
            return length - (value - length).Abs();
        }
        public static double PingPong(this double value, double length)
        {
            value = value.Repeat(length * 2d);
            return length - (value - length).Abs();
        }
    }
}
