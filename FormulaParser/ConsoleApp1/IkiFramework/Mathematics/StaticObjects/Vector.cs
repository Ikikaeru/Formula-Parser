using System;
namespace IkiCore.Mathematics
{
    public static class Vector
    {
        public static float ManhattanDistance(IVector a)
        {
            float x = 0f;
            for (int i = 0; i < a.Dimension; i++)
            {
                x += Math.Abs(a[i]);
            }
            return x;
        }
        public static float DotProduct(IVector a, IVector b)
        {
            if (a.Dimension != b.Dimension)
            {
                throw new Exception("Vectors doesn't have the same length.");
            }
            float sum = 0f;
            for (int i = 0; i < a.Dimension; i++)
            {
                sum += a[i] * b[i];
            }
            return sum;
        }
        public static IVector Normalized(IVector a)
        {
            float length = a.Magnitude;
            if (length > float.Epsilon)
            {
                length = 1f / length;
                for (int i = 0; i < a.Dimension; i++)
                {
                    a[i] *= length;
                }
                return a;
            }
            return new float1xN(a.Dimension);
        }
        public static IVector SetValue(IVector a, float v)
        {
            for (int i = 0; i < a.Dimension; i++)
            {
                a[i] = v;
            }
            return a;
        }
        public static IVector Lerp(IVector a, IVector b, float t) => IVec.Add(a, IVec.Mul(IVec.Sub(b, a), t));
        public static IVector Unlerp(IVector a, IVector b, float t) => IVec.Div(IVec.Sub(t, a), IVec.Sub(b, a));
        public static IVector Nlerp(IVector a, IVector b, float t)
        {
            a = IVec.Add(a, IVec.Mul(IVec.Sub(b, a), t));
            float mag = Mathematics.Math.Sqrt(DotProduct(a, a));
            if (mag > 0.00001f)
            {
                mag = 1f / mag;
                a = IVec.Mul(a, mag);
            }
            else
            {
                a = SetValue(a, 0f);
            }
            return a;
        }
        public static float Distance(IVector a, IVector b)
        {
            a = IVec.Sub(a, b);
            return (float)Mathematics.Math.Sqrt(Mathematics.Math.Sqrt(DotProduct(a, a)));
        }
        public static IVector QuadraticBezier(IVector a, IVector b, IVector c, float t)
        {
            float oneMinusT = 1f - t;
            return IVec.Add(IVec.Add(IVec.Mul(oneMinusT * oneMinusT, a), IVec.Mul(2f * oneMinusT * t, b)), IVec.Mul(c, t * t));
        }
        public static IVector QuadraticBezierTangent(IVector a, IVector b, IVector c, float t) => IVec.Add(IVec.Mul(2f * (1f - t), IVec.Sub(b, a)), IVec.Mul(2f * t, IVec.Sub(c, b)));
        public static IVector CubicBezier(IVector a, IVector b, IVector c, IVector d, float t)
        {
            float oneMinusT = 1f - t;
            float oneMinusTPow2 = oneMinusT * oneMinusT;
            float t2 = t * t;
            return IVec.Add(IVec.Mul(oneMinusTPow2 * oneMinusT, a), IVec.Add(IVec.Mul(3f * oneMinusTPow2 * t, b), IVec.Add(IVec.Mul(3f * oneMinusT * t2, c), IVec.Mul(t2 * t, d))));
        }
        public static IVector CubicBezierTangent(IVector a, IVector b, IVector c, IVector d, float t)
        {
            float oneMinusT = 1f - t;
            return IVec.Add(IVec.Mul(3f * oneMinusT * oneMinusT, IVec.Sub(b, a)), IVec.Add(IVec.Mul(6f * oneMinusT * t, IVec.Sub(c, b)), IVec.Mul(3f * t * t, IVec.Sub(d, c))));
        }
        public static IVector MoveTowards(IVector current, IVector target, float maxDistanceDelta)
        {
            IVector toVec = IVec.Sub(target, current);
            float dist = Mathematics.Math.Sqrt(DotProduct(toVec, toVec));
            if (dist <= maxDistanceDelta || dist < float.Epsilon)
            {
                return target;
            }
            dist = 1f / dist;
            return IVec.Mul(IVec.Add(current, toVec), dist * maxDistanceDelta);
        }
        public static float Angle(IVector from, IVector to)
        {
            float denominator = (float)Mathematics.Math.Sqrt(DotProduct(from, from) * DotProduct(to, to));
            if (denominator < 1e-15f)
            {
                return 0f;
            }
            float angle = DotProduct(from, to) / denominator;
            return (float)System.Math.Acos(angle < -1f ? -1f : angle > 1f ? 1f : angle) * 57.2957795131f;
        }
        public static IVector Nslerp(IVector actualVector, IVector targetVector, float t)
        {
            float startMag = Math.Sqrt(DotProduct(actualVector, actualVector));
            startMag += (Math.Sqrt(DotProduct(targetVector, targetVector)) - startMag) * t;
            float dot = DotProduct(actualVector, actualVector);
            float theta = (float)System.Math.Acos(dot) * t;
            float c = (float)System.Math.Cos(theta);
            float s = (float)System.Math.Sin(theta);
            targetVector = IVec.Sub(targetVector, IVec.Mul(actualVector, dot));
            float normalizedMag = Math.Sqrt(DotProduct(targetVector, targetVector));
            if (normalizedMag > 0.00001f)
            {
                normalizedMag = 1f / normalizedMag;
                targetVector = IVec.Mul(targetVector, normalizedMag);
            }
            else
            {
                targetVector = Vector.SetValue(targetVector, 0f);
            }
            return IVec.Mul(IVec.Add(IVec.Mul(actualVector, c), IVec.Mul(targetVector, s)), startMag);
        }
        public static IVector Slerp(IVector actualVector, IVector targetVector, float t)
        {
            IVector vec;
            float startMag = Math.Sqrt(DotProduct(actualVector, actualVector));
            if (startMag > 0.00001f)
            {
                startMag = 1f / startMag;
                vec = IVec.Mul(actualVector, startMag);
            }
            else
            {
                vec = SetValue(actualVector, 0f);
            }
            float normalizedMag = Math.Sqrt(DotProduct(targetVector, targetVector));
            if (normalizedMag > 0.00001f)
            {
                normalizedMag = 1f / normalizedMag;
                targetVector = IVec.Mul(targetVector, normalizedMag);
            }
            else
            {
                vec = SetValue(targetVector, 0f);
            }
            startMag += (normalizedMag - startMag) * t;
            float dot = DotProduct(vec, targetVector);
            float theta = (float)System.Math.Acos(dot) * t;
            float c = (float)System.Math.Cos(theta);
            float s = (float)System.Math.Sin(theta);
            targetVector = IVec.Sub(targetVector, IVec.Mul(vec, dot));
            normalizedMag = Math.Sqrt(DotProduct(targetVector, targetVector));
            if (normalizedMag > 0.00001f)
            {
                normalizedMag = 1f / normalizedMag;
                targetVector = IVec.Mul(targetVector, normalizedMag);
            }
            else
            {
                targetVector = SetValue(actualVector, 0f);
            }
            return IVec.Mul(IVec.Add(IVec.Mul(vec, c), IVec.Mul(targetVector, s)), startMag);
        }
    }
}
