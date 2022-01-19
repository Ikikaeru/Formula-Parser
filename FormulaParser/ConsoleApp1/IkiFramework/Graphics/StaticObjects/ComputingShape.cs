using IkiCore.Mathematics;
namespace IkiCore.Graphics
{
    /// <summary>
    /// A bunch of usefull shape operations when computing things.
    /// </summary>
    public static class ComputingShape
    {
        /// <summary>
        /// Draw a vertice in a circle shape. Resolution is the number of vertices to draw.
        /// 3 = Triangle
        /// 4 = Square
        /// </summary>
        /// <param name="actualPoint">Actual vertice to draw</param>
        /// <param name="pointsLength">Number of vertices to draw</param>
        /// <returns></returns>
        public static float2 CircleShape(int actualPoint, int pointsLength)
        {
            float angle = 6.283185307179586476925286766559f * actualPoint / pointsLength;
            float2 vec;
            vec.x = (float)System.Math.Sin(angle);
            vec.y = (float)System.Math.Cos(angle);
            return vec;
        }
        /// <summary>
        /// Draw a vertice in a fish shape. Resolution is the number of vertices to draw.
        /// </summary>
        /// <param name="actualPoint">Actual vertice to draw</param>
        /// <param name="pointsLength">Number of vertices to draw</param>
        /// <returns></returns>
        public static float2 FishShape(int actualPoint, int pointsLength)
        {
            float angle = 6.283185307179586476925286766559f * actualPoint / pointsLength;
            float2 vec;
            vec.x = (float)System.Math.Cos(angle) + 3f * (float)System.Math.Cos(angle / 2f);
            vec.y = (float)System.Math.Sin(angle);
            return vec;
        }
        /// <summary>
        /// Draw a vertice in a weed leaf shape. Resolution is the number of vertices to draw.
        /// </summary>
        /// <param name="actualPoint">Actual vertice to draw</param>
        /// <param name="pointsLength">Number of vertices to draw</param>
        /// <returns></returns>
        public static float2 WeedShape(int actualPoint, int pointsLength)
        {
            float angle = -(6.283185307179586476925286766559f * actualPoint / pointsLength);
            float sinAngle = (float)System.Math.Sin(angle);
            float heightAngleCos = (1f + 0.9f * (float)System.Math.Cos(angle * 8f)); 
            float tfourAngleCos = (1f + 0.1f * (float)System.Math.Cos(angle * 24f));
            float thCos = (0.9f + 0.05f * (float)System.Math.Cos(angle * 200f));
            float2 vec;
            vec.x = heightAngleCos * tfourAngleCos * thCos * (1f + sinAngle) * (float)System.Math.Cos(angle);
            vec.y = heightAngleCos * tfourAngleCos * thCos * (1f + sinAngle) * sinAngle;
            return vec;
        }
        /// <summary>
        /// Draw a vertice in a star shape. Resolution is the number of vertices to draw.
        /// </summary>
        /// <param name="actualPoint">Actual vertice to draw</param>
        /// <param name="pointsLength">Number of vertices to draw</param>
        /// <returns></returns>
        public static float2 StarShape(int actualPoint, int pointsLength)
        {
            float angle = -(6.283185307179586476925286766559f * actualPoint / pointsLength);
            float twoAngle = angle * 2f;
            float threeAngle = angle * 3f;
            float2 vec;
            vec.x = -9f * (float)System.Math.Sin(twoAngle) - 5f * (float)System.Math.Sin(threeAngle);
            vec.y = 9f * (float)System.Math.Cos(twoAngle) - 5f * (float)System.Math.Cos(threeAngle);
            return vec;
        }
        /// <summary>
        /// Draw a vertice in a heart shape. Resolution is the number of vertices to draw.
        /// </summary>
        /// <param name="actualPoint">Actual vertice to draw</param>
        /// <param name="pointsLength">Number of vertices to draw</param>
        /// <returns></returns>
        public static float2 HeartShape(int actualPoint, int pointsLength)
        {
            float angle = 6.283185307179586476925286766559f * actualPoint / pointsLength;
            float2 vec;
            vec.x = 16f * (float)System.Math.Pow(System.Math.Sin(angle), 3.0);
            vec.y = 13f * (float)System.Math.Cos(angle) - 5f * (float)System.Math.Cos(2f * angle) - 2f * (float)System.Math.Cos(3f * angle) - (float)System.Math.Cos(4f * angle);
            return vec;
        }
        /// <summary>
        /// Draw a vertice in a diamond shape. Resolution is the number of vertices to draw.
        /// </summary>
        /// <param name="actualPoint">Actual vertice to draw</param>
        /// <param name="pointsLength">Number of vertices to draw</param>
        /// <returns></returns>
        public static float2 DiamondShape(int actualPoint, int pointsLength)
        {
            float angle = -(6.283185307179586476925286766559f * actualPoint / pointsLength);
            float2 vec;
            vec.x = (float)System.Math.Pow(System.Math.Cos(angle), 3.0);
            vec.y = (float)System.Math.Pow(System.Math.Sin(angle), 3.0);
            return vec;
        }
        /// <summary>
        /// Draw a vertice in a quatrefoil leaf shape. Resolution is the number of vertices to draw.
        /// </summary>
        /// <param name="actualPoint">Actual vertice to draw</param>
        /// <param name="pointsLength">Number of vertices to draw</param>
        /// <returns></returns>
        public static float2 QuatrefoilShape(int actualPoint, int pointsLength)
        {
            float angle = 6.283185307179586476925286766559f * actualPoint / pointsLength;
            float sinAngle = (float)System.Math.Sin(angle);
            float cosAngle = (float)System.Math.Cos(angle);
            float2 vec;
            vec.x = (2f * (float)System.Math.Pow(sinAngle, 2.0)) * cosAngle;
            vec.y = (2f * (float)System.Math.Pow(cosAngle, 2.0)) * sinAngle;
            return vec;
        }
        /// <summary>
        /// Draw a vertice in a quatrefoil leaf shape. Resolution is the number of vertices to draw.
        /// </summary>
        /// <param name="actualPoint">Actual vertice to draw</param>
        /// <param name="pointsLength">Number of vertices to draw</param>
        /// <returns></returns>
        public static float2 QuatrefoilShapeTwo(int actualPoint, int pointsLength)
        {
            float angle = -(6.283185307179586476925286766559f * actualPoint / pointsLength);
            float twoSinAngle = (float)System.Math.Sin(2f * angle);
            float sixSinAngle = (float)System.Math.Sin(6f * angle);
            float2 vec;
            vec.x = (twoSinAngle + (sixSinAngle / 4f)) * (float)System.Math.Cos(angle);
            vec.y = (twoSinAngle + (sixSinAngle / 4f)) * (float)System.Math.Sin(angle);
            return vec;
        }
        /// <summary>
        /// Draw a vertice in a quatrefoil leaf shape. Resolution is the number of vertices to draw.
        /// </summary>
        /// <param name="actualPoint">Actual vertice to draw</param>
        /// <param name="pointsLength">Number of vertices to draw</param>
        /// <returns></returns>
        public static float2 QuatrefoilShapeThree(int actualPoint, int pointsLength)
        {
            float angle = -(6.283185307179586476925286766559f * actualPoint / pointsLength);
            float threeCosAngle = (float)System.Math.Cos(3f * angle);
            float threesinpowangle = (float)System.Math.Pow(System.Math.Sin(3f * angle), 2.0);
            float2 vec;
            vec.x = (1f + threeCosAngle + threesinpowangle) * (float)System.Math.Cos(angle);
            vec.y = (1f + threeCosAngle + threesinpowangle) * (float)System.Math.Sin(angle);
            return vec;
        }
        /// <summary>
        /// Draw a vertice in a quatrefoil leaf shape. Resolution is the number of vertices to draw.
        /// </summary>
        /// <param name="actualPoint">Actual vertice to draw</param>
        /// <param name="pointsLength">Number of vertices to draw</param>
        /// <returns></returns>
        public static float2 QuatrefoilShapeFour(int actualPoint, int pointsLength)
        {
            float angle = -(6.283185307179586476925286766559f * actualPoint / pointsLength);
            float fourCosAngle = (float)System.Math.Cos(4f * angle);
            float fourAngleSinPow = (float)System.Math.Pow(System.Math.Sin(4 * angle), 2.0);
            float2 vec;
            vec.x = (1 + fourCosAngle + fourAngleSinPow) * (float)System.Math.Cos(angle);
            vec.y = (1 + fourCosAngle + fourAngleSinPow) * (float)System.Math.Sin(angle);
            return vec;
        }
    }
}
