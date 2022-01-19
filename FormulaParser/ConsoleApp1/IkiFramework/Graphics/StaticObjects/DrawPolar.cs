using System;
using IkiCore.Core;
using IkiCore.Mathematics;
namespace IkiCore.Graphics
{
    public static class DrawPolar
    {
        /// <summary>
        /// Return a point in a custom shape. r is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float2 PolarCoordXY(this float r, Func<float, float> convert)
        {
            float tpr = convert(r);
            float2 vec;
            vec.x = (float)System.Math.Cos(tpr);
            vec.y = (float)System.Math.Sin(tpr);
            return vec;
        }
        /// <summary>
        /// Return a point in a custom shape. r is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float2 PolarCoordXY(this float r, Func<float, float> convertX, Func<float, float> convertY)
        {
            float2 vec;
            vec.x = (float)System.Math.Cos(convertX(r));
            vec.y = (float)System.Math.Sin(convertY(r));
            return vec;
        }
        /// <summary>
        /// Return a point in a custom shape. r is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 PolarCoordXZ(this float r, Func<float, float> convert)
        {
            float tpr = convert(r);
            float3 vec;
            vec.x = (float)System.Math.Cos(tpr);
            vec.y = 0f;
            vec.z = (float)System.Math.Sin(tpr);
            return vec;
        }
        /// <summary>
        /// Return a point in a custom shape. r is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 PolarCoordXZ(this float r, Func<float, float> convertX, Func<float, float> convertZ)
        {
            float3 vec;
            vec.x = (float)System.Math.Cos(convertX(r));
            vec.y = 0f;
            vec.z = (float)System.Math.Sin(convertZ(r));
            return vec;
        }
        /// <summary>
        /// Return a point in a spirale shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 SpiraleOne(this float r)
        {
            float3 vec;
            vec.x = r * (float)System.Math.Cos(r);
            vec.y = -r;
            vec.z = r * (float)System.Math.Sin(r);
            return vec;
        }
        /// <summary>
        /// Return a point in a spirale shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 SpiraleTwo(this float r)
        {
            float tpr = 6.283185307179586476925286766559f * r;
            float a = (float)System.Math.Sin(20f) + (float)System.Math.Sin(r * 0.5f);
            float3 vec;
            vec.x = a * (float)System.Math.Cos(tpr);
            vec.y = 0f;
            vec.z = a * (float)System.Math.Sin(tpr);
            return vec;
        }
        /// <summary>
        /// Return a point in an atom shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 AtomOne(this float r)
        {
            float3 vec;
            vec.x = 2f * (float)System.Math.Cos(r * 0.5f);
            vec.y = 0f;
            vec.z = (float)System.Math.Sin(r * 0.333333333333333333333333f);
            return vec;
        }
        /// <summary>
        /// Return a point in an atom shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 AtomTwo(this float r)
        {
            float3 vec;
            vec.x = (float)System.Math.Sin(r * 4f);
            vec.y = 0f;
            vec.z = (float)System.Math.Cos(r * 6f);
            return vec;
        }
        /// <summary>
        /// Return a point in a heart shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 HeartOne(this float r)
        {
            float3 vec;
            vec.x = (float)System.Math.Sin(r);
            vec.x = ((vec.x * vec.x * vec.x) * 16f) * 0.1f;
            vec.y = 0f;
            vec.z = (13f * (float)System.Math.Cos(r) - 5f * (float)System.Math.Cos(2f * r) - 2f * (float)System.Math.Cos(3f * r) - (float)System.Math.Cos(4f * r)) * 0.1f;
            return vec * 0.1f;
        }
        /// <summary>
        /// Return a point in a heart shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 HeartTwo(this float r)
        {
            float ttr = 3f * r;
            float3 vec;
            vec.x = (12f * (float)System.Math.Sin(r) - 4f * (float)System.Math.Sin(ttr)) * 0.1f;
            vec.y = 0f;
            vec.z = (13f * (float)System.Math.Cos(r) - 5f * (float)System.Math.Cos(r * 2f) - 2f * (float)System.Math.Cos(ttr) - (float)System.Math.Cos(4f * r)) * 0.1f;
            return vec;
        }
        /// <summary>
        /// Return a point in infinity symbol shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 InfinitySymbol(this float r)
        {
            float rcos = (float)System.Math.Cos(r);
            float3 vec;
            vec.x = rcos;
            vec.y = 0f;
            vec.z = (float)System.Math.Sin(r) * rcos;
            return vec;
        }
        /// <summary>
        /// Return a point in a flower shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 Flower(this float r)
        {
            float fivrsin = (float)System.Math.Sin(r * 5f);
            float3 vec;
            vec.x = fivrsin * (float)System.Math.Cos(r);
            vec.y = 0f;
            vec.z = fivrsin * (float)System.Math.Sin(r);
            return vec;
        }
        /// <summary>
        /// Return a point in a diamonds shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 Diamonds(this float r)
        {
            float3 vec;
            vec.x = (float)System.Math.Cos(r);
            vec.x = vec.x * vec.x * vec.x;
            vec.y = 0f;
            vec.z = (float)System.Math.Sin(r);
            vec.z = vec.z * vec.z * vec.z;
            return vec;
        }
        /// <summary>
        /// Return a point in a star shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 Star(this float r)
        {
            float tr = 2 * r;
            float ttr = 3 * r;
            float3 vec;
            vec.x = (-9f * (float)System.Math.Sin(tr) - 5f * (float)System.Math.Sin(ttr)) * 0.1f;
            vec.y = 0f;
            vec.z = (9f * (float)System.Math.Cos(tr) - 5f * (float)System.Math.Cos(ttr)) * 0.1f;
            return vec;
        }
        /// <summary>
        /// Return a point in a cannabis leaf shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 Cannabis(this float r)
        {
            float rSin = (float)System.Math.Sin(r);
            float tot = (1f + 0.9f * (float)System.Math.Cos(8f * r)) * (1f + 0.1f * (float)System.Math.Cos(24f * r)) * (0.9f + 0.05f * (float)System.Math.Cos(200f * r)) * (1f + rSin);
            float3 vec;
            vec.x = tot * (float)System.Math.Cos(r);
            vec.y = 0f;
            vec.z = tot * rSin;
            return vec;
        }
        /// <summary>
        /// Return a point in a butterfly shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 ButterflyOne(this float r)
        {
            float x = (float)System.Math.Sin(r / 12f);
            float p = Mathematics.Math.Pow(2.71828182845904523536028747135266249f, (float)System.Math.Cos(r)) - 2f * (float)System.Math.Cos(r * 4f) + (x * x * x * x * x);
            float3 vec;
            vec.x = p * (float)System.Math.Cos(r);
            vec.y = 0f;
            vec.z = p * (float)System.Math.Sin(r);
            return vec;
        }
        /// <summary>
        /// Return a point in a butterfly shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 ButterflyTwo(this float r)
        {
            float p = -3f * (float)System.Math.Cos(2f * r) + (float)System.Math.Sin(7f * r) - 1f;
            float3 vec;
            vec.x = p * (float)System.Math.Cos(r);
            vec.y = 0f;
            vec.z = p * (float)System.Math.Sin(r);
            return vec;
        }
        /// <summary>
        /// Return a point in a butterfly shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 QuatrefoilCurveOne(this float r)
        {
            float rsin = (float)System.Math.Sin(r);
            float rcos = (float)System.Math.Cos(r);
            float3 vec;
            vec.x = 2f * rsin * rsin * (float)System.Math.Cos(r);
            vec.y = 0f;
            vec.z = 2 * rcos * rcos * rsin;
            return vec;
        }
        /// <summary>
        /// Return a point in a quatrefoil shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 QuatrefoilCurveTwo(this float r)
        {
            float p = (float)System.Math.Sin(2f * r) + ((float)System.Math.Sin(6f * r) * 0.25f);
            float3 vec;
            vec.x = p * (float)System.Math.Cos(r);
            vec.y = 0f;
            vec.z = p * (float)System.Math.Sin(r);
            return vec;
        }
        /// <summary>
        /// Return a point in a quatrefoil shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 QuatrefoilCurveThree(this float r)
        {
            float s3r = (float)System.Math.Sin(3f * r);
            float p = 1 + (float)System.Math.Cos(3f * r) + s3r * s3r;
            float3 vec;
            vec.x = p * (float)System.Math.Cos(r);
            vec.y = 0f;
            vec.z = p * (float)System.Math.Sin(r);
            return vec;
        }
        /// <summary>
        /// Return a point in a quatrefoil shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 QuatrefoilCurveFour(this float r)
        {
            float rsin4 = (float)System.Math.Sin(4f * r);
            float p = 1 + (float)System.Math.Cos(4f * r) + rsin4 * rsin4;
            float3 vec;
            vec.x = p * (float)System.Math.Cos(r);
            vec.y = 0f;
            vec.z = p * (float)System.Math.Sin(r);
            return vec;
        }
        /// <summary>
        /// Return a point in a quatrefoil shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 Fish(this float r)
        {
            float3 vec;
            vec.x = ((float)System.Math.Cos(r) + 3f * (float)System.Math.Cos(r * 0.5f)) * 0.3f;
            vec.y = 0f;
            vec.z = (float)System.Math.Sin(r) * 0.3f;
            return vec;
        }
        /// <summary>
        /// Return a point in a fish shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 Mouth(this float r)
        {
            float rsin = (float)System.Math.Sin(r);
            float3 vec;
            vec.x = (float)System.Math.Cos(r);
            vec.y = 0f;
            vec.z = rsin * rsin * rsin;
            return vec;
        }
        /// <summary>
        /// Return a point in a mouth shape. The float is the radius.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static float3 Dick(this float r)
        {
            float p5 = (1f + (float)System.Math.Sin(r)) * 0.5f;
            float a = 1.7f - (float)System.Math.Sin(3f * r) + (p5 * p5 * p5 * p5 * p5) + ((float)System.Math.Cos(4f * r) * 0.5f);
            float3 vec;
            vec.x = a * (float)System.Math.Cos(r);
            vec.y = 0f;
            vec.z = a * (float)System.Math.Sin(r);
            return vec;
        }
    }
}
