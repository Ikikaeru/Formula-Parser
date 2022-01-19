using static IkiCore.Mathematics.VectorConstructor;
using IkiCore.Mathematics;
namespace IkiCore.Graphics
{
    public static partial class Noise
    {
        public static float DomainWarping(float2 p)
        {
            float t = FractionalBrownianMotion(p);
            float2 t2;
            t2.x = t + p.x;
            t2.y = t + p.y;
            t = FractionalBrownianMotion(t2);
            t2.x = t + p.x;
            t2.y = t + p.y;
            return FractionalBrownianMotion(t2);
        }
        public static float DomainWarping2(float2 p)
        {
            float2 q;
            q.x = FractionalBrownianMotion(p);
            q.y = FractionalBrownianMotion(p + float2(5.2f, 1.3f));
            float2 r;
            r.x = FractionalBrownianMotion(p + 4f * q + float2(1.7f, 9.2f));
            r.y = FractionalBrownianMotion(p + 4f * q + float2(8.3f, 2.8f));
            return FractionalBrownianMotion(p + 4f * r);
        }
        public static float Signed(float3 p)
        {
            float3 s = (p + (p.x * 0.3333333f + p.y * 0.3333333f + p.z * 0.3333333f)).Floor;
            float3 x = p - s + (s.x * 0.1666667f + s.y * 0.1666667f + s.z * 0.1666667f);
            float3 e = Mathematics.float3.Zero.Step(x - x.yzx);
            float3 i1 = e * (1.0f - e.zxy);
            float3 i2 = 1.0f - e.zxy * (1.0f - e);
            float3 x1 = x - i1 + 0.1666667f;
            float3 x2 = x - i2 + 2.0f * 0.1666667f;
            float3 x3 = x - 1.0f + 3.0f * 0.1666667f;
            float4 w, d;
            w.x = x.x * x.x + x.y * x.y + x.z * x.z;
            w.y = x1.x * x1.x + x1.y * x1.y + x1.z * x1.z;
            w.z = x2.x * x2.x + x2.y * x2.y + x2.z * x2.z;
            w.w = x3.x * x3.x + x3.y * x3.y + x3.z * x3.z;
            w = float4.Zero.Max(0.6f - w);
            e = Random3(s);
            d.x = x.x * e.x + x.y * e.y + x.z * e.z;
            e = Random3(s + i1);
            d.y = x1.x * e.x + x1.y * e.y + x1.z * e.z;
            e = Random3(s + i2);
            d.z = x2.x * e.x + x2.y * e.y + x2.z * e.z;
            e = Random3(s + 1.0f);
            d.w = x3.x * e.x + x3.y * e.y + x3.z * e.z;
            w *= w;
            w *= w;
            d *= w;
            return d.x * 52.0f + d.y * 52.0f + d.z * 52.0f + d.w * 52.0f;
        }
        public static float SFractal(float3 m)
        {
            return 0.5333333f * Signed(m) + 0.2666667f * Signed(2f * m) + 0.1333333f * Signed(4f * m) + 0.0666667f * Signed(8f * m);
        }
        public static float FractionalBrownianMotion(float2 x)
        {
            float v = 0f;
            float a = 0.5f;
            for(int i = 0; i < 6; i++)
            {
                v = v + (a * Basic(x.x, x.y));
                x.x = x.x * 2f;
                x.y = x.y * 2f;
                a = a * 0.5f;
            }
            return v;
        }
        public static float Turbulence(float2 x)
        {
            float v = 0f;
            float a = 0.5f;
            float simpNoise;
            for (int i = 0; i < 3; i++)
            {
                simpNoise = Simplex(x.x, x.y);
                v = v + (a * (simpNoise > 0f ? simpNoise : -simpNoise));
                x.x = x.x * 2f;
                x.y = x.y * 2f;
                a = a * 0.5f;
            }
            return v;
        }
        /*
        public static float SmoothBasic(float x, float y)
        {
            float val = 0f;
            float2x2 v4;
            v4.rc00 = 1.6f;
            v4.rc10 = 1.2f;
            v4.rc01 = -1.2f;
            v4.rc11 = 1.6f;
            float2 coord;
            coord.x = x;
            coord.y = y;
            float multiply = 0.5f;
            for (int i = 0; i < 4; i++)
            {
                if (i != 0)
                {
                    coord = coord * v4;
                    multiply = multiply * 0.5f;
                }
                val = val + (multiply * Basic(coord.x, coord.y));
            }
            return val;
        }*/
        public static float Wood(float x, float y)
        {
            float2 pos;
            pos.x = x * 10f;
            pos.y = y * 10f;
            float n = Basic(x, y);
            n = (float)System.Math.Cos(n) * pos.x + -(float)System.Math.Sin(n) * pos.y;
            n = (((float)System.Math.Sin(n * 10f * 3.14159265358979323846264338327950288419716939937510582f) + 1f)) * 0.5f;
            n = n > 0f ? n : -n;
            n = n / (0.5f + 0.25f * 0.5f);
            n = n > 1f ? 1f : n < 0f ? 0f : n;
            return n * n * (3f - 2f * n);
        }
        public static float Simplex(float xx, float y)
        {
            float2 v;
            v.x = xx;
            v.y = y;
            float2 i = (v + (v.x * 0.366025403784439f + v.y * 0.366025403784439f)).Floor;
            float2 x0 = v - i + (i.x * 0.211324865405187f + i.y * 0.211324865405187f);
            v = (x0.x > x0.y) ? Mathematics.float2.Right : Mathematics.float2.Up;
            float2 x1 = x0.xy + 0.211324865405187f - v;
            float2 x2 = x0.xy + (-0.577350269189626f);
            i = Mod289(i);
            float3 p = Permute(Permute(i.y + float3(0.0f, v.y, 1.0f)) + i.x + float3(0.0f, v.x, 1.0f));
            float3 m = Mathematics.float3.Zero.Max(0.5f - float3(x0.x * x0.x + x0.y * x0.y, x1.x * x1.x + x1.y * x1.y, x2.x * x2.x + x2.y * x2.y));
            m = m * m;
            m = m * m;
            p = 2.0f * (p * 0.024390243902439f).Fract - 1.0f;
            float3 h = p.Abs - 0.5f;
            p = p - (p + 0.5f).Floor;
            m = m * (1.79284291400159f - 0.85373472095314f * (p * p + h * h));
            p.x = p.x * x0.x + h.x * x0.y;
            p.y = p.y * x1.x + h.y * x1.y;
            p.z = p.z * x2.x + h.z * x2.y;
            return 130.0f * (m.x * p.x + m.y * p.y + m.z * p.z);
        }
        static float2 Mod289(this float2 v)
        {
            float2 vec;
            vec.x = v.x - (float)System.Math.Floor(v.x * (1f / 289f)) * 289f;
            vec.y = v.y - (float)System.Math.Floor(v.y * (1f / 289f)) * 289f;
            return vec;
        }
        static float Random(this float2 v)
        {
            float r = (float)System.Math.Sin(v.x * 12.9898f + v.y * 78.233f) * 43758.5453123f;
            return r - (float)System.Math.Floor(r);
        }
        static float Random(this float2 v, float l)
        {
            float r = (float)System.Math.Sin(v.x * 12.9898f + v.y * 78.233f) * 43758.5453123f;
            r = (float)System.Math.Sin((r - System.Math.Floor(r)) * 12.9898f + l * 78.233f) * 43758.5453123f;
            return r - (float)System.Math.Floor(r);
        }
        static float4 Mod289(this float4 v)
        {
            float4 vec;
            vec.x = v.x - (float)System.Math.Floor(v.x * 0.00346020761245674740484429065744f) * 289.0f;
            vec.y = v.y - (float)System.Math.Floor(v.y * 0.00346020761245674740484429065744f) * 289.0f;
            vec.z = v.z - (float)System.Math.Floor(v.z * 0.00346020761245674740484429065744f) * 289.0f;
            vec.w = v.w - (float)System.Math.Floor(v.w * 0.00346020761245674740484429065744f) * 289.0f;
            return vec;
        }
        static float4 Permute(this float4 v)
        {
            float4 vec;
            vec.x = (((v.x * 34.0f) + 1.0f) * v.x) % 289.0f;
            vec.y = (((v.y * 34.0f) + 1.0f) * v.y) % 289.0f;
            vec.z = (((v.z * 34.0f) + 1.0f) * v.z) % 289.0f;
            vec.w = (((v.w * 34.0f) + 1.0f) * v.w) % 289.0f;
            return vec;
        }
        public static float Basic(float x, float y)
        {
            float2 i;
            i.x = (float)System.Math.Floor(x);
            i.y = (float)System.Math.Floor(y);
            float2 f;
            f.x = x - i.x;
            f.y = y - i.y;
            float a = i.Random();
            float b = (i + Mathematics.float2.Right).Random();
            float2 u;
            u.x = f.x * (f.x * (3f - 2f * f.x));
            u.y = f.y * (f.y * (3f - 2f * f.y));
            return (a + u.x * (b - a)) + ((i + Mathematics.float2.Up).Random() - a) * u.y * (1.0f - u.x) + ((i + Mathematics.float2.One).Random() - b) * u.x * u.y;
        }
        public static float Voronoi(float x, float y)
        {
            float2 p;
            p.x = (float)System.Math.Floor(x);
            p.y = (float)System.Math.Floor(y);
            float2 f;
            f.x = x - p.x;
            f.y = y - p.y;
            float res = 0.0f;
            for (int j = -1; j <= 1; j++)
            {
                for (int i = -1; i <= 1; i++)
                {
                    float2 b;
                    b.x = i;
                    b.y = j;
                    b = b - f + (p + b).Random2();
                    float d = b.x * b.x + b.y * b.y;
                    d = d * d * d * d * d * d * d * d;
                    res = res + (1f / d);
                }
            }
            return (float)System.Math.Pow(1f / res, 1d / 16d);
        }
        static float2 Random2(this float2 v)
        {
            float2 rnd;
            rnd.x = (float)System.Math.Sin(v.x * 127.1f + v.y * 311.7f) * 43758.5453f;
            rnd.x = rnd.x - (float)System.Math.Floor(rnd.x);
            rnd.y = (float)System.Math.Sin(v.x * 269.5f + v.y * 183.3f) * 43758.5453f;
            rnd.y = rnd.y - (float)System.Math.Floor(rnd.y);
            return rnd;
        }
        static float3 Permute(this float3 v)
        {
            float3 x;
            x.x = (v.x * 34.0f + 1f) * v.x;
            x.y = (v.y * 34.0f + 1f) * v.y;
            x.z = (v.z * 34.0f + 1f) * v.z;
            x.x = x.x - (float)System.Math.Floor(x.x * (1f / 289f)) * 289f;
            x.y = x.y - (float)System.Math.Floor(x.y * (1f / 289f)) * 289f;
            x.z = x.z - (float)System.Math.Floor(x.z * (1f / 289f)) * 289f;
            return x;
        }
        static float3 ManDist(float3 x, float3 y, bool manhattanDistance)
        {
            return manhattanDistance ? x.Abs + y.Abs : (x * x + y * y);
        }
        static float3 Random3(this float3 v)
        {
            float j = 4096f * (float)System.Math.Sin(v.x * 17f + v.y * 59.4f + v.z * 15f);
            float3 r;
            float frac = 512f * j;
            r.z = (frac - (float)System.Math.Floor(frac)) - 0.5f;
            j = j * 0.125f;
            frac = 512f * j;
            r.x = (frac - (float)System.Math.Floor(frac)) - 0.5f;
            j = j * 0.125f;
            frac = 512f * j;
            r.y = (frac - (float)System.Math.Floor(frac)) - 0.5f;
            return r;
        }
        static float3 Mod289(this float3 v)
        {
            float3 vec;
            vec.x = v.x - (float)System.Math.Floor(v.x * 0.00346020761245674740484429065744f) * 289f;
            vec.y = v.y - (float)System.Math.Floor(v.y * 0.00346020761245674740484429065744f) * 289f;
            vec.z = v.z - (float)System.Math.Floor(v.z * 0.00346020761245674740484429065744f) * 289f;
            return vec;
        }
        public static float Voronoise(float x, float y, float GridControl, float metricController)
        {
            float2 p;
            p.x = (float)System.Math.Floor(x);
            p.y = (float)System.Math.Floor(y);
            float2 f;
            f.x = x - p.x;
            f.y = y - p.y;
            float k = 1f - metricController;
            k = k * k * k * k;
            k = k * 63f + 1f;
            float va = 0f;
            float wt = 0f;
            int i, j;
            for (j = -2; j < 3; j++)
            {
                for (i = -2; i < 3; i++)
                {
                    float2 g;
                    g.x = i;
                    g.y = j;
                    float3 o;
                    o = (p + g).Hash3();
                    o.xy = o.xy * GridControl;
                    g.x = g.x - f.x + o.x;
                    g.y = g.y - f.y + o.y;
                    float w = (float)System.Math.Sqrt(g.x * g.x + g.y * g.y);
                    w = w / 1.414f;
                    w = w > 1f ? 1f : w;
                    w = w * w * (3f - (2f * w));
                    w = (float)System.Math.Pow(1f - w, k);
                    va = va + (w * o.z);
                    wt = wt + w;
                }
            }
            return va / wt;
        }
        public static float Perlin(float x, float y)
        {
            int X = (int)x & 0xff;
            int Y = (int)y & 0xff;
            x = x - (float)System.Math.Floor(x);
            y = y - (float)System.Math.Floor(y);
            float u = x * x * x * (x * (x * 6f - 15f) + 10f);
            int A = (perm[X] + Y) & 0xff;
            int B = (perm[X + 1] + Y) & 0xff;
            float gradA = Grad(perm[A], x, y);
            float gradB = Grad(perm[B], x - 1, y);
            gradA = gradA + u * (gradB - gradA);
            float gradC = Grad(perm[A + 1], x, y - 1);
            gradB = Grad(perm[B + 1], x - 1, y - 1);
            return gradA + (y * y * y * (y * (y * 6f - 15f) + 10f)) * ((gradC + u * (gradB - gradC)) - gradA);
        }
        public static float Perlin2(float x, float y)
        {
            x = x > 0f ? x : -x;
            y = y > 0f ? y : -y;
            int ix0, iy0, ix1, iy1;
            float fx0, fy0, t, nx0, n0, n1;
            ix0 = (int)x;
            iy0 = (int)y;
            fx0 = x - ix0;
            fy0 = y - iy0;
            ix1 = (ix0 + 1) % 255;
            iy1 = (iy0 + 1) % 255;
            ix0 = ix0 % 255;
            iy0 = iy0 % 255;
            t = (fy0 * fy0 * fy0 * (fy0 * (fy0 * 6f - 15f) + 10f));
            nx0 = Grad(perm[(ix0 + perm[(iy0 + 1) % 255] + 1) % 255], fx0, fy0);
            n0 = nx0 + t * (Grad(perm[(ix0 + perm[(iy1 + 1) % 255] + 1) % 255], fx0, fy0 - 1.0f) - nx0);
            nx0 = Grad(perm[(ix1 + perm[(iy0 + 1) % 255] + 1) % 255], fx0 - 1.0f, fy0);
            n1 = 0.5f * (1f + (n0 + (fx0 * fx0 * fx0 * (fx0 * (fx0 * 6f - 15f) + 10f)) * ((nx0 + t * (Grad(perm[(ix1 + perm[(iy1 + 1) % 255] + 1) % 255], fx0 - 1.0f, fy0 - 1.0f) - nx0)) - n0)));
            return n1 > 1f ? 1f : n1 < 0f ? 0f : n1;
        }
        static float Grad(int hash, float x, float y)
        {
            return ((hash & 1) == 0 ? x : -x) + ((hash & 2) == 0 ? y : -y);
        }
        static int[] perm =
        {
            151,160,137,91,90,15,
            131,13,201,95,96,53,194,233,7,225,140,36,103,30,69,142,8,99,37,240,21,10,23,
            190, 6,148,247,120,234,75,0,26,197,62,94,252,219,203,117,35,11,32,57,177,33,
            88,237,149,56,87,174,20,125,136,171,168, 68,175,74,165,71,134,139,48,27,166,
            77,146,158,231,83,111,229,122,60,211,133,230,220,105,92,41,55,46,245,40,244,
            102,143,54, 65,25,63,161, 1,216,80,73,209,76,132,187,208, 89,18,169,200,196,
            135,130,116,188,159,86,164,100,109,198,173,186, 3,64,52,217,226,250,124,123,
            5,202,38,147,118,126,255,82,85,212,207,206,59,227,47,16,58,17,182,189,28,42,
            223,183,170,213,119,248,152, 2,44,154,163, 70,221,153,101,155,167, 43,172,9,
            129,22,39,253, 19,98,108,110,79,113,224,232,178,185, 112,104,218,246,97,228,
            251,34,242,193,238,210,144,12,191,179,162,241, 81,51,145,235,249,14,239,107,
            49,192,214, 31,181,199,106,157,184, 84,204,176,115,121,50,45,127, 4,150,254,
            138,236,205,93,222,114,67,29,24,72,243,141,128,195,78,66,215,61,156,180,
            151
        };
        public static float ClassicPerlin(float x, float y)
        {
            float2 p;
            p.x = x;
            p.y = y;
            float4 Pi;
            Pi = p.xyxy.Floor;
            Pi.zw = Pi.zw + 1f;
            float4 Pf;
            Pf = p.xyxy.Fract;
            Pf.zw = Pf.zw - 1f;
            Pi = Pi % 289.0f;
            float4 gx;
            gx = 2.0f * ((Pi.xzxz.Permute() + Pi.yyww).Permute() * 0.0243902439f).Fract - 1.0f;
            Pi = gx.Abs - 0.5f;
            gx = gx - (gx + 0.5f).Floor;
            float2 g00;
            g00.x = gx.x;
            g00.y = Pi.x;
            float2 g10;
            g10.x = gx.y;
            g10.y = Pi.y;
            float2 g01;
            g01.x = gx.z;
            g01.y = Pi.z;
            float2 g11;
            g11.x = gx.w;
            g11.y = Pi.w;
            float4 norm;
            norm.x = 1.79284291400159f - 0.85373472095314f * (gx.x * gx.x + Pi.x * Pi.x);
            norm.y = 1.79284291400159f - 0.85373472095314f * (gx.z * gx.z + Pi.z * Pi.z);
            norm.z = 1.79284291400159f - 0.85373472095314f * (gx.y * gx.y + Pi.y * Pi.y);
            norm.w = 1.79284291400159f - 0.85373472095314f * (gx.w * gx.w + Pi.w * Pi.w);
            g00 *= norm.x;
            g01 *= norm.y;
            g10 *= norm.z;
            g11 *= norm.w;
            float n00 = g00.x * Pf.x + g00.y * Pf.y;
            float n01 = g01.x * Pf.x + g01.y * Pf.w;
            p.x = Pf.x * Pf.x * Pf.x * (Pf.x * (Pf.x * 6.0f - 15.0f) + 10.0f);
            p.y = Pf.y * Pf.y * Pf.y * (Pf.y * (Pf.y * 6.0f - 15.0f) + 10.0f);
            float2 n_x;
            n_x.x = n00 + ((g10.x * Pf.z + g10.y * Pf.y) - n00) * p.x;
            n_x.y = n01 + ((g11.x * Pf.z + g11.y * Pf.w) - n01) * p.x;
            return 2.3f * (n_x.x + p.y * (n_x.y - n_x.x));
        }
        static float3 Hash3(this float2 v)
        {
            float3 vec;
            vec.x = (float)System.Math.Sin(v.x * 127.1f + v.y * 311.7f) * 43758.5453f;
            vec.x = vec.x - (float)System.Math.Floor(vec.x);
            vec.y = (float)System.Math.Sin(v.x * 269.5f + v.y * 183.3f) * 43758.5453f;
            vec.y = vec.y - (float)System.Math.Floor(vec.y);
            vec.z = (float)System.Math.Sin(v.x * 419.2f + v.y * 371.9f) * 43758.5453f;
            vec.z = vec.z - (float)System.Math.Floor(vec.z);
            return vec;
        }
        public static float Worley(float x, float y, float jitter = 1.0f, bool manhattanDistance = false)
        {
            float2 P;
            P.x = x;
            P.y = y;
            float2 Pi = P.Floor % 289.0f;
            float2 Pf = P.Fract;
            float3 oi;
            oi.x = -1f;
            oi.y = 0f;
            oi.z = 1f;
            float3 of;
            of.x = -0.5f;
            of.y = 0.5f;
            of.z = 1.5f;
            float3 px = Permute(Pi.x + oi);
            float3 p = Permute(px.x + Pi.y + oi);
            float3 ox = (p * 0.142857142857f).Fract - 0.428571428571f;
            float3 oy = ((p * 0.142857142857f).Floor % 7.0f) * 0.142857142857f - 0.428571428571f;
            float3 dx = Pf.x + 0.5f + jitter * ox;
            float3 dy = Pf.y - of + jitter * oy;
            float3 d1 = ManDist(dx, dy, manhattanDistance);
            p = Permute(px.y + Pi.y + oi);
            ox = (p * 0.142857142857f).Fract - 0.428571428571f;
            oy = ((p * 0.142857142857f).Floor % 7.0f) * 0.142857142857f - 0.428571428571f;
            dx = Pf.x - 0.5f + jitter * ox;
            dy = Pf.y - of + jitter * oy;
            float3 d2 = ManDist(dx, dy, manhattanDistance);
            p = Permute(px.z + Pi.y + oi);
            ox = (p * 0.142857142857f).Fract - 0.428571428571f;
            oy = ((p * 0.142857142857f).Floor % 7.0f) * 0.142857142857f - 0.428571428571f;
            dx = Pf.x - 1.5f + jitter * ox;
            dy = Pf.y - of + jitter * oy;
            ox = ManDist(dx, dy, manhattanDistance);
            oy = d1.Min(d2);
            d2 = d1.Max(d2);
            d2 = d2.Min(ox);
            d1 = oy.Min(d2);
            d2 = oy.Max(d2);
            d1.xy = (d1.x < d1.y) ? d1.xy : d1.yx;
            d1.xz = (d1.x < d1.z) ? d1.xz : d1.zx;
            d1.yz = d1.yz.Min(d2.yz);
            d1.y = d1.y.Min(d1.y, d1.z);
            d1.y = d1.y.Min(d2.x);
            return d1.y.Sqrt() - d1.x.Sqrt();
        }
    }
}
