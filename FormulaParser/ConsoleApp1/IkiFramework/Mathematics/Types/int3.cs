using System;
using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    [Serializable]
    public partial struct int3 : IEquatable<int3>
    {
        public const float kEpsilon = 0.00001f;
        public const float kEpsilonNormalSqrt = 1e-15f;
        /// <summary>
        /// X component of the vector.
        /// </summary>
        public int x;
        /// <summary>
        /// Y component of the vector.
        /// </summary>
        public int y;
        /// <summary>
        /// Z component of the vector.
        /// </summary>
        public int z;
        /// <summary>
        /// X component of the vector.
        /// </summary>
        [XmlIgnore]
        public int r
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        /// <summary>
        /// Y component of the vector.
        /// </summary>
        [XmlIgnore]
        public int g
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        /// <summary>
        /// Z component of the vector.
        /// </summary>
        [XmlIgnore]
        public int b
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        [XmlIgnore]
        public int2 xx
        {
            get
            {
                int2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int2 rr
        {
            get
            {
                int2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int2 xy
        {
            get
            {
                int2 vec;
                vec.x = x;
                vec.y = y;
                return vec;
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        [XmlIgnore]
        public int2 rg
        {
            get
            {
                int2 vec;
                vec.x = x;
                vec.y = y;
                return vec;
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        [XmlIgnore]
        public int2 xz
        {
            get
            {
                int2 vec;
                vec.x = x;
                vec.y = z;
                return vec;
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        [XmlIgnore]
        public int2 rb
        {
            get
            {
                int2 vec;
                vec.x = x;
                vec.y = z;
                return vec;
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        [XmlIgnore]
        public int2 yx
        {
            get
            {
                int2 vec;
                vec.x = y;
                vec.y = x;
                return vec;
            }
            set
            {
                y = value.x;
                x = value.y;
            }
        }
        [XmlIgnore]
        public int2 gr
        {
            get
            {
                int2 vec;
                vec.x = y;
                vec.y = x;
                return vec;
            }
            set
            {
                y = value.x;
                x = value.y;
            }
        }
        [XmlIgnore]
        public int2 yy
        {
            get
            {
                int2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int2 gg
        {
            get
            {
                int2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int2 yz
        {
            get
            {
                int2 vec;
                vec.x = y;
                vec.y = z;
                return vec;
            }
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        [XmlIgnore]
        public int2 gb
        {
            get
            {
                int2 vec;
                vec.x = y;
                vec.y = z;
                return vec;
            }
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        [XmlIgnore]
        public int2 zx
        {
            get
            {
                int2 vec;
                vec.x = z;
                vec.y = x;
                return vec;
            }
            set
            {
                z = value.x;
                x = value.y;
            }
        }
        [XmlIgnore]
        public int2 br
        {
            get
            {
                int2 vec;
                vec.x = z;
                vec.y = x;
                return vec;
            }
            set
            {
                z = value.x;
                x = value.y;
            }
        }
        [XmlIgnore]
        public int2 zy
        {
            get
            {
                int2 vec;
                vec.x = z;
                vec.y = y;
                return vec;
            }
            set
            {
                z = value.x;
                y = value.y;
            }
        }
        [XmlIgnore]
        public int2 bg
        {
            get
            {
                int2 vec;
                vec.x = z;
                vec.y = y;
                return vec;
            }
            set
            {
                z = value.x;
                y = value.y;
            }
        }
        [XmlIgnore]
        public int2 zz
        {
            get
            {
                int2 vec;
                vec.x = z;
                vec.y = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int2 bb
        {
            get
            {
                int2 vec;
                vec.x = z;
                vec.y = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 xxx
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 rrr
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 xxy
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 rrg
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 xxz
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 rrb
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 xyx
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 rgr
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 xyy
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 rgg
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 xyz
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                return vec;
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        [XmlIgnore]
        public int3 rgb
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                return vec;
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        [XmlIgnore]
        public int3 xzx
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 rbr
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 xzy
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                return vec;
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }
        [XmlIgnore]
        public int3 rbg
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                return vec;
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }
        [XmlIgnore]
        public int3 xzz
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 rbb
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 yxx
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 grr
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 yxy
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 grg
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 yxz
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                return vec;
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        [XmlIgnore]
        public int3 grb
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                return vec;
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        [XmlIgnore]
        public int3 yyx
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 ggr
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 yyy
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 ggg
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 yyz
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 ggb
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 yzx
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                return vec;
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }
        [XmlIgnore]
        public int3 gbr
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                return vec;
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }
        [XmlIgnore]
        public int3 yzy
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 gbg
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 yzz
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 gbb
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 zxx
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 brr
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 zxy
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                return vec;
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }
        [XmlIgnore]
        public int3 brg
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                return vec;
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }
        [XmlIgnore]
        public int3 zxz
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 brb
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 zyx
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                return vec;
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }
        [XmlIgnore]
        public int3 bgr
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                return vec;
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }
        [XmlIgnore]
        public int3 zyy
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 bgg
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 zyz
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 bgb
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 zzx
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 bbr
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 zzy
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 bbg
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 zzz
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 bbb
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xxxx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rrrr
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xxxy
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rrrg
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xxxz
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rrrb
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xxyx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rrgr
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xxyy
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rrgg
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xxyz
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rrgb
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xxzx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rrbr
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xxzy
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rrbg
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xxzz
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rrbb
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xyxx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rgrr
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xyxy
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rgrg
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xyxz
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rgrb
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xyyx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rggr
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xyyy
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rggg
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xyyz
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rggb
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xyzx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rgbr
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xyzy
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rgbg
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xyzz
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rgbb
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xzxx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rbrr
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xzxy
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rbrg
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xzxz
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rbrb
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xzyx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rbgr
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xzyy
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rbgg
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xzyz
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rbgb
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xzzx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rbbr
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xzzy
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rbbg
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xzzz
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rbbb
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yxxx
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 grrr
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yxxy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 grrg
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yxxz
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 grrb
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yxyx
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 grgr
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yxyy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 grgg
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yxyz
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 grgb
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yxzx
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 grbr
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yxzy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 grbg
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yxzz
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 grbb
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yyxx
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ggrr
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yyxy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ggrg
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yyxz
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ggrb
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yyyx
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gggr
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yyyy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gggg
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yyyz
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gggb
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yyzx
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ggbr
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yyzy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ggbg
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yyzz
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ggbb
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yzxx
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gbrr
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yzxy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gbrg
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yzxz
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gbrb
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yzyx
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gbgr
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yzyy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gbgg
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yzyz
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gbgb
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yzzx
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gbbr
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yzzy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gbbg
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yzzz
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gbbb
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zxxx
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 brrr
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zxxy
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 brrg
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zxxz
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 brrb
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zxyx
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 brgr
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zxyy
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 brgg
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zxyz
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 brgb
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zxzx
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 brbr
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zxzy
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 brbg
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zxzz
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 brbb
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zyxx
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bgrr
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zyxy
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bgrg
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zyxz
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bgrb
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zyyx
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bggr
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zyyy
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bggg
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zyyz
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bggb
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zyzx
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bgbr
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zyzy
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bgbg
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zyzz
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bgbb
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zzxx
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bbrr
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zzxy
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bbrg
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zzxz
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bbrb
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zzyx
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bbgr
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zzyy
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bbgg
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zzyz
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bbgb
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zzzx
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bbbr
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zzzy
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bbbg
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zzzz
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bbbb
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        /// <summary>
        /// Creates a new vector with given x, y, z components.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public int3(int x = 0, int y = 0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        /// <summary>
        /// Creates a new vector with given x float and yz float2 components.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="a"></param>
        public int3(int x, int2 a)
        {
            this.x = x;
            y = a.x;
            z = a.y;
        }
        /// <summary>
        /// Creates a new vector with given xy float2 and z float components.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="z"></param>
        public int3(int2 a, int z = 0)
        {
            x = a.x;
            y = a.y;
            this.z = z;
        }
        /// <summary>
        /// Set x, y and z components of an existing Vector3.
        /// </summary>
        /// <param name="newX"></param>
        /// <param name="newY"></param>
        /// <param name="newZ"></param>
        public void Set(int newX, int newY, int newZ)
        {
            x = newX;
            y = newY;
            z = newZ;
        }
        /// <summary>
        /// Access the x, y, z components using [0], [1], [2] respectively.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        [XmlIgnore]
        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    default:
                        throw new IndexOutOfRangeException("Invalid int3 index!");
                }
            }

            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    case 2: z = value; break;
                    default:
                        throw new IndexOutOfRangeException("Invalid int3 index!");
                }
            }
        }
        /// <summary>
        /// Multiplies two vectors component-wise.
        /// </summary>
        /// <param name="scale"></param>
        public void Scale(int3 scale)
        {
            x *= scale.x;
            y *= scale.y;
            z *= scale.z;
        }
        public override int GetHashCode()
        {
            return x.GetHashCode() ^ (y.GetHashCode() << 2) ^ (z.GetHashCode() >> 2);
        }
        /// <summary>
        /// Returns true if the given vector is exactly equal to this vector.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            if (!(other is int3))
            {
                return false;
            }
            return Equals((int3)other);
        }
        /// <summary>
        /// Returns true if the given vector is exactly equal to this vector.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(int3 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z);
        }
        /// <summary>
        /// Returns the distance between a and b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float Distance(int3 a, int3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return (float)System.Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z);
        }
        /// <summary>
        /// Returns the length of this vector (Read Only).
        /// </summary>
        [XmlIgnore]
        public float Magnitude
        {
            get { return (float)System.Math.Sqrt(x * x + y * y + z * z); }
        }
        /// <summary>
        /// Returns the squared length of this vector (Read Only).
        /// </summary>
        [XmlIgnore]
        public int SqrMagnitude
        {
            get { return x * x + y * y + z * z; }
        }
        /// <summary>
        /// Returns a vector that is made from the smallest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int3 Min(int3 a, int3 b)
        {
            a.x = a.x > b.x ? b.x : a.x;
            a.y = a.y > b.y ? b.y : a.y;
            a.z = a.z > b.z ? b.z : a.z;
            return a;
        }
        /// <summary>
        /// Returns a vector that is made from the largest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int3 Max(int3 a, int3 b)
        {
            a.x = a.x > b.x ? a.x : b.x;
            a.y = a.y > b.y ? a.y : b.y;
            a.z = a.z > b.z ? a.z : b.z;
            return a;
        }
        /// <summary>
        /// Returns the distance between a and b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public float Distance(int3 b)
        {
            return (float)System.Math.Sqrt(x * b.x + y * b.y + z * b.z);
        }
        /// <summary>
        /// Returns a vector that is made from the smallest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int3 Min(int3 b)
        {
            b.x = x > b.x ? b.x : x;
            b.y = y > b.y ? b.y : y;
            b.z = z > b.z ? b.z : z;
            return b;
        }
        /// <summary>
        /// Returns a vector that is made from the largest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int3 Max(int3 b)
        {
            b.x = x > b.x ? x : b.x;
            b.y = y > b.y ? y : b.y;
            b.z = z > b.z ? z : b.z;
            return b;
        }
        /// <summary>
        /// Clamps the Vector3Int to the bounds given by min and max.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int3 Clamp(int min, int max)
        {
            int3 vec;
            vec.x = x > max ? max : x < min ? min : x;
            vec.y = y > max ? max : y < min ? min : y;
            vec.z = z > max ? max : z < min ? min : z;
            return vec;
        }
        /// <summary>
        /// Clamps the Vector3Int to the bounds given by min and max.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int3 Clamp(int3 min, int3 max)
        {
            int3 vec;
            vec.x = x > max.x ? max.x : x < min.x ? min.x : x;
            vec.y = y > max.y ? max.y : y < min.y ? min.y : y;
            vec.z = z > max.z ? max.z : z < min.z ? min.z : z;
            return vec;
        }
        public static int Convert3DTo1DPosition(int3 pos, int width, int height)
        {
            return pos.x + pos.y * width + pos.z * height * width;
        }
        public int Convert3DTo1DPosition(int width, int height)
        {
            return x + y * width + z * height * width;
        }
        /// <summary>
        /// Shorthand for writing Vector3(0, 0, 0).
        /// </summary>
        [XmlIgnore]
        public static int3 Zero
        {
            get
            {
                int3 vec;
                vec.x = 0;
                vec.y = 0;
                vec.z = 0;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(1, 1, 1).
        /// </summary>
        [XmlIgnore]
        public static int3 One
        {
            get
            {
                int3 vec;
                vec.x = 1;
                vec.y = 1;
                vec.z = 1;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(0, 0, 1).
        /// </summary>
        [XmlIgnore]
        public static int3 Forward
        {
            get
            {
                int3 vec;
                vec.x = 0;
                vec.y = 0;
                vec.z = 1;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(0, 0, -1).
        /// </summary>
        [XmlIgnore]
        public static int3 Back
        {
            get
            {
                int3 vec;
                vec.x = 0;
                vec.y = 0;
                vec.z = -1;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(0, 1, 0).
        /// </summary>
        [XmlIgnore]
        public static int3 Up
        {
            get
            {
                int3 vec;
                vec.x = 0;
                vec.y = 1;
                vec.z = 0;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(0, -1, 0).
        /// </summary>
        [XmlIgnore]
        public static int3 Down
        {
            get
            {
                int3 vec;
                vec.x = 0;
                vec.y = -1;
                vec.z = 0;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(-1, 0, 0).
        /// </summary>
        [XmlIgnore]
        public static int3 Left
        {
            get
            {
                int3 vec;
                vec.x = -1;
                vec.y = 0;
                vec.z = 0;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(1, 0, 0).
        /// </summary>
        [XmlIgnore]
        public static int3 Right
        {
            get
            {
                int3 vec;
                vec.x = 1;
                vec.y = 0;
                vec.z = 0;
                return vec;
            }
        }
        /// <summary>
        /// Returns a nicely formatted string for this vector.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("({0:F1}, {1:F1}, {2:F1})", x, y, z);
        }
        public static int3 operator +(int3 a, int3 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            return a;
        }
        public static int3 operator +(int3 a, int2 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            return a;
        }
        public static int3 operator +(int2 a, int3 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            return b;
        }
        public static float3 operator +(int3 a, float2 b)
        {
            float3 vec;
            vec.x = a.x + b.x;
            vec.y = a.y + b.y;
            vec.z = a.z;
            return vec;
        }
        public static float3 operator +(float2 a, int3 b)
        {
            float3 vec;
            vec.x = a.x + b.x;
            vec.y = a.y + b.y;
            vec.z = b.z;
            return vec;
        }
        public static float3 operator +(int3 a, float3 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            b.z = a.z + b.z;
            return b;
        }
        public static float3 operator +(float3 a, int3 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            return a;
        }
        public static float3 operator +(int3 a, float b)
        {
            float3 vec;
            vec.x = a.x + b;
            vec.y = a.y + b;
            vec.z = a.z + b;
            return vec;
        }
        public static float3 operator +(float a, int3 b)
        {
            float3 vec;
            vec.x = b.x + a;
            vec.y = b.y + a;
            vec.z = b.z + a;
            return vec;
        }
        public static int3 operator +(int3 a, int b)
        {
            a.x = a.x + b;
            a.y = a.y + b;
            a.z = a.z + b;
            return a;
        }
        public static int3 operator +(int a, int3 b)
        {
            b.x = a + b.x;
            b.y = a + b.y;
            b.z = a + b.z;
            return b;
        }
        public static int3 operator -(int3 a, int3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return a;
        }
        public static int3 operator -(int3 a, int2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a;
        }
        public static int3 operator -(int2 a, int3 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            return b;
        }
        public static float3 operator -(int3 a, float2 b)
        {
            float3 vec;
            vec.x = a.x - b.x;
            vec.y = a.y - b.y;
            vec.z = a.z;
            return vec;
        }
        public static float3 operator -(float2 a, int3 b)
        {
            float3 vec;
            vec.x = a.x - b.x;
            vec.y = a.y - b.y;
            vec.z = b.z;
            return vec;
        }
        public static float3 operator -(int3 a, float3 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            b.z = a.z - b.z;
            return b;
        }
        public static float3 operator -(float3 a, int3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return a;
        }
        public static float3 operator -(int3 a, float b)
        {
            float3 vec;
            vec.x = a.x - b;
            vec.y = a.y - b;
            vec.z = a.z - b;
            return vec;
        }
        public static float3 operator -(float a, int3 b)
        {
            float3 vec;
            vec.x = b.x - a;
            vec.y = b.y - a;
            vec.z = b.z - a;
            return vec;
        }
        public static int3 operator -(int3 a, int b)
        {
            a.x = a.x - b;
            a.y = a.y - b;
            a.z = a.z - b;
            return a;
        }
        public static int3 operator -(int a, int3 b)
        {
            b.x = a - b.x;
            b.y = a - b.y;
            b.z = a - b.z;
            return b;
        }
        public static int3 operator *(int3 a, int3 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            return a;
        }
        public static int3 operator *(int3 a, int2 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            return a;
        }
        public static int3 operator *(int2 a, int3 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            return b;
        }
        public static float3 operator *(int3 a, float2 b)
        {
            float3 vec;
            vec.x = a.x * b.x;
            vec.y = a.y * b.y;
            vec.z = a.z;
            return vec;
        }
        public static float3 operator *(float2 a, int3 b)
        {
            float3 vec;
            vec.x = a.x * b.x;
            vec.y = a.y * b.y;
            vec.z = b.z;
            return vec;
        }
        public static float3 operator *(int3 a, float3 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            b.z = a.z * b.z;
            return b;
        }
        public static float3 operator *(float3 a, int3 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            return a;
        }
        public static float3 operator *(int3 a, float b)
        {
            float3 vec;
            vec.x = a.x * b;
            vec.y = a.y * b;
            vec.z = a.z * b;
            return vec;
        }
        public static float3 operator *(float a, int3 b)
        {
            float3 vec;
            vec.x = b.x * a;
            vec.y = b.y * a;
            vec.z = b.z * a;
            return vec;
        }
        public static int3 operator *(int3 a, int b)
        {
            a.x = a.x * b;
            a.y = a.y * b;
            a.z = a.z * b;
            return a;
        }
        public static int3 operator *(int a, int3 b)
        {
            b.x = a * b.x;
            b.y = a * b.y;
            b.z = a * b.z;
            return b;
        }
        public static int3 operator /(int3 a, int3 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            return a;
        }
        public static int3 operator /(int3 a, int2 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            return a;
        }
        public static int3 operator /(int2 a, int3 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            return b;
        }
        public static float3 operator /(int3 a, float2 b)
        {
            float3 vec;
            vec.x = a.x / b.x;
            vec.y = a.y / b.y;
            vec.z = a.z;
            return vec;
        }
        public static float3 operator /(float2 a, int3 b)
        {
            float3 vec;
            vec.x = a.x / b.x;
            vec.y = a.y / b.y;
            vec.z = b.z;
            return vec;
        }
        public static float3 operator /(int3 a, float3 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            b.z = a.z / b.z;
            return b;
        }
        public static float3 operator /(float3 a, int3 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            return a;
        }
        public static float3 operator /(int3 a, float b)
        {
            float3 vec;
            vec.x = a.x / b;
            vec.y = a.y / b;
            vec.z = a.z / b;
            return vec;
        }
        public static float3 operator /(float a, int3 b)
        {
            float3 vec;
            vec.x = b.x / a;
            vec.y = b.y / a;
            vec.z = b.z / a;
            return vec;
        }
        public static int3 operator /(int3 a, int b)
        {
            a.x = a.x / b;
            a.y = a.y / b;
            a.z = a.z / b;
            return a;
        }
        public static int3 operator /(int a, int3 b)
        {
            b.x = a / b.x;
            b.y = a / b.y;
            b.z = a / b.z;
            return b;
        }
        public static int3 operator %(int3 a, int3 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            return a;
        }
        public static int3 operator %(int3 a, int2 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            return a;
        }
        public static int3 operator %(int2 a, int3 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            return b;
        }
        public static float3 operator %(int3 a, float2 b)
        {
            float3 vec;
            vec.x = a.x % b.x;
            vec.y = a.y % b.y;
            vec.z = a.z;
            return vec;
        }
        public static float3 operator %(float2 a, int3 b)
        {
            float3 vec;
            vec.x = a.x % b.x;
            vec.y = a.y % b.y;
            vec.z = b.z;
            return vec;
        }
        public static float3 operator %(int3 a, float3 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            b.z = a.z % b.z;
            return b;
        }
        public static float3 operator %(float3 a, int3 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            return a;
        }
        public static float3 operator %(int3 a, float b)
        {
            float3 vec;
            vec.x = a.x % b;
            vec.y = a.y % b;
            vec.z = a.z % b;
            return vec;
        }
        public static float3 operator %(float a, int3 b)
        {
            float3 vec;
            vec.x = b.x % a;
            vec.y = b.y % a;
            vec.z = b.z % a;
            return vec;
        }
        public static int3 operator %(int3 a, int b)
        {
            a.x = a.x % b;
            a.y = a.y % b;
            a.z = a.z % b;
            return a;
        }
        public static int3 operator %(int a, int3 b)
        {
            b.x = a % b.x;
            b.y = a % b.y;
            b.z = a % b.z;
            return b;
        }
        public static int3 operator &(int3 a, int3 b)
        {
            a.x = a.x & b.x;
            a.y = a.y & b.y;
            a.z = a.z & b.z;
            return a;
        }
        public static int3 operator &(int3 a, int2 b)
        {
            a.x = a.x & b.x;
            a.y = a.y & b.y;
            return a;
        }
        public static int3 operator &(int2 a, int3 b)
        {
            b.x = a.x & b.x;
            b.y = a.y & b.y;
            return b;
        }
        public static int3 operator &(int3 a, int b)
        {
            a.x = a.x & b;
            a.y = a.y & b;
            a.z = a.z & b;
            return a;
        }
        public static int3 operator &(int a, int3 b)
        {
            b.x = a & b.x;
            b.y = a & b.y;
            b.z = a & b.z;
            return b;
        }
        public static int3 operator |(int3 a, int3 b)
        {
            a.x = a.x | b.x;
            a.y = a.y | b.y;
            a.z = a.z | b.z;
            return a;
        }
        public static int3 operator |(int3 a, int2 b)
        {
            a.x = a.x | b.x;
            a.y = a.y | b.y;
            return a;
        }
        public static int3 operator |(int2 a, int3 b)
        {
            b.x = a.x | b.x;
            b.y = a.y | b.y;
            return b;
        }
        public static int3 operator |(int3 a, int b)
        {
            a.x = a.x | b;
            a.y = a.y | b;
            a.z = a.z | b;
            return a;
        }
        public static int3 operator |(int a, int3 b)
        {
            b.x = a | b.x;
            b.y = a | b.y;
            b.z = a | b.z;
            return b;
        }
        public static int3 operator ^(int3 a, int3 b)
        {
            a.x = a.x ^ b.x;
            a.y = a.y ^ b.y;
            a.z = a.z ^ b.z;
            return a;
        }
        public static int3 operator ^(int3 a, int2 b)
        {
            a.x = a.x ^ b.x;
            a.y = a.y ^ b.y;
            return a;
        }
        public static int3 operator ^(int2 a, int3 b)
        {
            b.x = a.x ^ b.x;
            b.y = a.y ^ b.y;
            return b;
        }
        public static int3 operator ^(int3 a, int b)
        {
            a.x = a.x ^ b;
            a.y = a.y ^ b;
            a.z = a.z ^ b;
            return a;
        }
        public static int3 operator ^(int a, int3 b)
        {
            b.x = a ^ b.x;
            b.y = a ^ b.y;
            b.z = a ^ b.z;
            return b;
        }
        public static int3 operator <<(int3 a, int b)
        {
            a.x = a.x << b;
            a.y = a.y << b;
            a.z = a.z << b;
            return a;
        }
        public static int3 operator >>(int3 a, int b)
        {
            a.x = a.x >> b;
            a.y = a.y >> b;
            a.z = a.z >> b;
            return a;
        }
        public static int3 operator -(int3 a)
        {
            a.x = -a.x;
            a.y = -a.y;
            a.z = -a.z;
            return a;
        }
        public static int3 operator ~(int3 a)
        {
            a.x = ~a.x;
            a.y = ~a.y;
            a.z = ~a.z;
            return a;
        }
        public static explicit operator int2(int3 v)
        {
            int2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static implicit operator int4(int3 v)
        {
            int4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            vec.w = 0;
            return vec;
        }
        public static explicit operator bool2(int3 v)
        {
            bool2 vec;
            vec.x = v.x != 0;
            vec.y = v.y != 0;
            return vec;
        }
        public static explicit operator bool3(int3 v)
        {
            bool3 vec;
            vec.x = v.x != 0;
            vec.y = v.y != 0;
            vec.z = v.z != 0;
            return vec;
        }
        public static explicit operator bool4(int3 v)
        {
            bool4 vec;
            vec.x = v.x != 0;
            vec.y = v.y != 0;
            vec.z = v.z != 0;
            vec.w = false;
            return vec;
        }
        public static implicit operator float2(int3 v)
        {
            float2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static implicit operator float3(int3 v)
        {
            float3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            return vec;
        }
        public static implicit operator float4(int3 v)
        {
            float4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            vec.w = 0f;
            return vec;
        }
        public static bool operator ==(int3 a, int3 b)
        {
            return a.x == b.x && a.y == b.y && a.z == b.z;
        }
        public static bool operator !=(int3 a, int3 b)
        {
            return a.x != b.x || a.y != b.y || a.z != b.z;
        }
    }
}
