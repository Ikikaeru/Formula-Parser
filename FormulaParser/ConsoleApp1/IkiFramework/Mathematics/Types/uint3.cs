using System;
using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    [Serializable]
    public partial struct uint3 : IEquatable<uint3>
    {
        public const float kEpsilon = 0.00001f;
        public const float kEpsilonNormalSqrt = 1e-15f;
        /// <summary>
        /// X component of the vector.
        /// </summary>
        public uint x;
        /// <summary>
        /// Y component of the vector.
        /// </summary>
        public uint y;
        /// <summary>
        /// Z component of the vector.
        /// </summary>
        public uint z;
        /// <summary>
        /// X component of the vector.
        /// </summary>
        [XmlIgnore]
        public uint r
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
        public uint g
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
        public uint b
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
        public uint2 xx
        {
            get
            {
                uint2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint2 rr
        {
            get
            {
                uint2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint2 xy
        {
            get
            {
                uint2 vec;
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
        public uint2 rg
        {
            get
            {
                uint2 vec;
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
        public uint2 xz
        {
            get
            {
                uint2 vec;
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
        public uint2 rb
        {
            get
            {
                uint2 vec;
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
        public uint2 yx
        {
            get
            {
                uint2 vec;
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
        public uint2 gr
        {
            get
            {
                uint2 vec;
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
        public uint2 yy
        {
            get
            {
                uint2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint2 gg
        {
            get
            {
                uint2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint2 yz
        {
            get
            {
                uint2 vec;
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
        public uint2 gb
        {
            get
            {
                uint2 vec;
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
        public uint2 zx
        {
            get
            {
                uint2 vec;
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
        public uint2 br
        {
            get
            {
                uint2 vec;
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
        public uint2 zy
        {
            get
            {
                uint2 vec;
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
        public uint2 bg
        {
            get
            {
                uint2 vec;
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
        public uint2 zz
        {
            get
            {
                uint2 vec;
                vec.x = z;
                vec.y = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint2 bb
        {
            get
            {
                uint2 vec;
                vec.x = z;
                vec.y = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 xxx
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 rrr
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 xxy
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 rrg
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 xxz
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 rrb
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 xyx
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 rgr
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 xyy
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 rgg
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 xyz
        {
            get
            {
                uint3 vec;
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
        public uint3 rgb
        {
            get
            {
                uint3 vec;
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
        public uint3 xzx
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 rbr
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 xzy
        {
            get
            {
                uint3 vec;
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
        public uint3 rbg
        {
            get
            {
                uint3 vec;
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
        public uint3 xzz
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 rbb
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 yxx
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 grr
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 yxy
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 grg
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 yxz
        {
            get
            {
                uint3 vec;
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
        public uint3 grb
        {
            get
            {
                uint3 vec;
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
        public uint3 yyx
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 ggr
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 yyy
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 ggg
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 yyz
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 ggb
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 yzx
        {
            get
            {
                uint3 vec;
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
        public uint3 gbr
        {
            get
            {
                uint3 vec;
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
        public uint3 yzy
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 gbg
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 yzz
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 gbb
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 zxx
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 brr
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 zxy
        {
            get
            {
                uint3 vec;
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
        public uint3 brg
        {
            get
            {
                uint3 vec;
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
        public uint3 zxz
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 brb
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 zyx
        {
            get
            {
                uint3 vec;
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
        public uint3 bgr
        {
            get
            {
                uint3 vec;
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
        public uint3 zyy
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 bgg
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 zyz
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 bgb
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 zzx
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 bbr
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 zzy
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 bbg
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 zzz
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 bbb
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xxxx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rrrr
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xxxy
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rrrg
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xxxz
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rrrb
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xxyx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rrgr
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xxyy
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rrgg
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xxyz
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rrgb
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xxzx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rrbr
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xxzy
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rrbg
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xxzz
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rrbb
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xyxx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rgrr
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xyxy
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rgrg
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xyxz
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rgrb
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xyyx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rggr
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xyyy
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rggg
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xyyz
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rggb
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xyzx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rgbr
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xyzy
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rgbg
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xyzz
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rgbb
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xzxx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rbrr
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xzxy
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rbrg
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xzxz
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rbrb
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xzyx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rbgr
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xzyy
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rbgg
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xzyz
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rbgb
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xzzx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rbbr
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xzzy
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rbbg
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xzzz
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rbbb
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yxxx
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 grrr
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yxxy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 grrg
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yxxz
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 grrb
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yxyx
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 grgr
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yxyy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 grgg
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yxyz
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 grgb
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yxzx
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 grbr
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yxzy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 grbg
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yxzz
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 grbb
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yyxx
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ggrr
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yyxy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ggrg
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yyxz
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ggrb
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yyyx
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gggr
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yyyy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gggg
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yyyz
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gggb
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yyzx
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ggbr
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yyzy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ggbg
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yyzz
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ggbb
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yzxx
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gbrr
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yzxy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gbrg
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yzxz
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gbrb
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yzyx
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gbgr
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yzyy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gbgg
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yzyz
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gbgb
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yzzx
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gbbr
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yzzy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gbbg
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yzzz
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gbbb
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zxxx
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 brrr
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zxxy
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 brrg
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zxxz
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 brrb
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zxyx
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 brgr
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zxyy
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 brgg
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zxyz
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 brgb
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zxzx
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 brbr
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zxzy
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 brbg
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zxzz
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 brbb
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zyxx
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bgrr
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zyxy
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bgrg
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zyxz
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bgrb
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zyyx
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bggr
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zyyy
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bggg
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zyyz
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bggb
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zyzx
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bgbr
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zyzy
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bgbg
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zyzz
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bgbb
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zzxx
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bbrr
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zzxy
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bbrg
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zzxz
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bbrb
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zzyx
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bbgr
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zzyy
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bbgg
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zzyz
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bbgb
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zzzx
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bbbr
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zzzy
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bbbg
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zzzz
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bbbb
        {
            get
            {
                uint4 vec;
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
        public uint3(uint x = 0u, uint y = 0u, uint z = 0u)
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
        public uint3(uint x, uint2 a)
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
        public uint3(uint2 a, uint z = 0u)
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
        public void Set(uint newX, uint newY, uint newZ)
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
        public uint this[uint index]
        {
            get
            {
                switch (index)
                {
                    case 0u: return x;
                    case 1u: return y;
                    case 2u: return z;
                    default:
                        throw new IndexOutOfRangeException("Invalid uint3 index!");
                }
            }

            set
            {
                switch (index)
                {
                    case 0u: x = value; break;
                    case 1u: y = value; break;
                    case 2u: z = value; break;
                    default:
                        throw new IndexOutOfRangeException("Invalid uint3 index!");
                }
            }
        }
        /// <summary>
        /// Multiplies two vectors component-wise.
        /// </summary>
        /// <param name="scale"></param>
        public void Scale(uint3 scale)
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
            if (!(other is uint3))
            {
                return false;
            }
            return Equals((uint3)other);
        }
        /// <summary>
        /// Returns true if the given vector is exactly equal to this vector.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(uint3 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z);
        }
        /// <summary>
        /// Returns the distance between a and b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float Distance(uint3 a, uint3 b)
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
        public uint SqrMagnitude
        {
            get { return x * x + y * y + z * z; }
        }
        /// <summary>
        /// Returns a vector that is made from the smallest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static uint3 Min(uint3 a, uint3 b)
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
        public static uint3 Max(uint3 a, uint3 b)
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
        public float Distance(uint3 b)
        {
            return (float)System.Math.Sqrt(x * b.x + y * b.y + z * b.z);
        }
        /// <summary>
        /// Returns a vector that is made from the smallest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public uint3 Min(uint3 b)
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
        public uint3 Max(uint3 b)
        {
            b.x = x > b.x ? x : b.x;
            b.y = y > b.y ? y : b.y;
            b.z = z > b.z ? z : b.z;
            return b;
        }
        /// <summary>
        /// Clamps the Vector3uint to the bounds given by min and max.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public uint3 Clamp(uint min, uint max)
        {
            uint3 vec;
            vec.x = x > max ? max : x < min ? min : x;
            vec.y = y > max ? max : y < min ? min : y;
            vec.z = z > max ? max : z < min ? min : z;
            return vec;
        }
        /// <summary>
        /// Clamps the Vector3uint to the bounds given by min and max.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public uint3 Clamp(uint3 min, uint3 max)
        {
            uint3 vec;
            vec.x = x > max.x ? max.x : x < min.x ? min.x : x;
            vec.y = y > max.y ? max.y : y < min.y ? min.y : y;
            vec.z = z > max.z ? max.z : z < min.z ? min.z : z;
            return vec;
        }
        public static uint Convert3DTo1DPosition(uint3 pos, uint width, uint height)
        {
            return pos.x + pos.y * width + pos.z * height * width;
        }
        public uint Convert3DTo1DPosition(uint width, uint height)
        {
            return x + y * width + z * height * width;
        }
        /// <summary>
        /// Shorthand for writing Vector3(0, 0, 0).
        /// </summary>
        [XmlIgnore]
        public static uint3 Zero
        {
            get
            {
                uint3 vec;
                vec.x = 0u;
                vec.y = 0u;
                vec.z = 0u;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(1, 1, 1).
        /// </summary>
        [XmlIgnore]
        public static uint3 One
        {
            get
            {
                uint3 vec;
                vec.x = 1u;
                vec.y = 1u;
                vec.z = 1u;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(0, 0, 1).
        /// </summary>
        [XmlIgnore]
        public static uint3 Forward
        {
            get
            {
                uint3 vec;
                vec.x = 0u;
                vec.y = 0u;
                vec.z = 1u;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(0, 1, 0).
        /// </summary>
        [XmlIgnore]
        public static uint3 Up
        {
            get
            {
                uint3 vec;
                vec.x = 0u;
                vec.y = 1u;
                vec.z = 0u;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(1, 0, 0).
        /// </summary>
        [XmlIgnore]
        public static uint3 Right
        {
            get
            {
                uint3 vec;
                vec.x = 1u;
                vec.y = 0u;
                vec.z = 0u;
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
        public static uint3 operator +(uint3 a, uint3 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            return a;
        }
        public static uint3 operator +(uint3 a, uint2 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            return a;
        }
        public static uint3 operator +(uint2 a, uint3 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            return b;
        }
        public static float3 operator +(uint3 a, float2 b)
        {
            float3 vec;
            vec.x = a.x + b.x;
            vec.y = a.y + b.y;
            vec.z = a.z;
            return vec;
        }
        public static float3 operator +(float2 a, uint3 b)
        {
            float3 vec;
            vec.x = a.x + b.x;
            vec.y = a.y + b.y;
            vec.z = b.z;
            return vec;
        }
        public static float3 operator +(uint3 a, float3 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            b.z = a.z + b.z;
            return b;
        }
        public static float3 operator +(float3 a, uint3 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            return a;
        }
        public static float3 operator +(uint3 a, float b)
        {
            float3 vec;
            vec.x = a.x + b;
            vec.y = a.y + b;
            vec.z = a.z + b;
            return vec;
        }
        public static float3 operator +(float a, uint3 b)
        {
            float3 vec;
            vec.x = b.x + a;
            vec.y = b.y + a;
            vec.z = b.z + a;
            return vec;
        }
        public static uint3 operator +(uint3 a, uint b)
        {
            a.x = a.x + b;
            a.y = a.y + b;
            a.z = a.z + b;
            return a;
        }
        public static uint3 operator +(uint a, uint3 b)
        {
            b.x = a + b.x;
            b.y = a + b.y;
            b.z = a + b.z;
            return b;
        }
        public static uint3 operator -(uint3 a, uint3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return a;
        }
        public static uint3 operator -(uint3 a, uint2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a;
        }
        public static uint3 operator -(uint2 a, uint3 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            return b;
        }
        public static float3 operator -(uint3 a, float2 b)
        {
            float3 vec;
            vec.x = a.x - b.x;
            vec.y = a.y - b.y;
            vec.z = a.z;
            return vec;
        }
        public static float3 operator -(float2 a, uint3 b)
        {
            float3 vec;
            vec.x = a.x - b.x;
            vec.y = a.y - b.y;
            vec.z = b.z;
            return vec;
        }
        public static float3 operator -(uint3 a, float3 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            b.z = a.z - b.z;
            return b;
        }
        public static float3 operator -(float3 a, uint3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return a;
        }
        public static float3 operator -(uint3 a, float b)
        {
            float3 vec;
            vec.x = a.x - b;
            vec.y = a.y - b;
            vec.z = a.z - b;
            return vec;
        }
        public static float3 operator -(float a, uint3 b)
        {
            float3 vec;
            vec.x = b.x - a;
            vec.y = b.y - a;
            vec.z = b.z - a;
            return vec;
        }
        public static uint3 operator -(uint3 a, uint b)
        {
            a.x = a.x - b;
            a.y = a.y - b;
            a.z = a.z - b;
            return a;
        }
        public static uint3 operator -(uint a, uint3 b)
        {
            b.x = a - b.x;
            b.y = a - b.y;
            b.z = a - b.z;
            return b;
        }
        public static uint3 operator *(uint3 a, uint3 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            return a;
        }
        public static uint3 operator *(uint3 a, uint2 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            return a;
        }
        public static uint3 operator *(uint2 a, uint3 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            return b;
        }
        public static float3 operator *(uint3 a, float2 b)
        {
            float3 vec;
            vec.x = a.x * b.x;
            vec.y = a.y * b.y;
            vec.z = a.z;
            return vec;
        }
        public static float3 operator *(float2 a, uint3 b)
        {
            float3 vec;
            vec.x = a.x * b.x;
            vec.y = a.y * b.y;
            vec.z = b.z;
            return vec;
        }
        public static float3 operator *(uint3 a, float3 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            b.z = a.z * b.z;
            return b;
        }
        public static float3 operator *(float3 a, uint3 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            return a;
        }
        public static float3 operator *(uint3 a, float b)
        {
            float3 vec;
            vec.x = a.x * b;
            vec.y = a.y * b;
            vec.z = a.z * b;
            return vec;
        }
        public static float3 operator *(float a, uint3 b)
        {
            float3 vec;
            vec.x = b.x * a;
            vec.y = b.y * a;
            vec.z = b.z * a;
            return vec;
        }
        public static uint3 operator *(uint3 a, uint b)
        {
            a.x = a.x * b;
            a.y = a.y * b;
            a.z = a.z * b;
            return a;
        }
        public static uint3 operator *(uint a, uint3 b)
        {
            b.x = a * b.x;
            b.y = a * b.y;
            b.z = a * b.z;
            return b;
        }
        public static uint3 operator /(uint3 a, uint3 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            return a;
        }
        public static uint3 operator /(uint3 a, uint2 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            return a;
        }
        public static uint3 operator /(uint2 a, uint3 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            return b;
        }
        public static float3 operator /(uint3 a, float2 b)
        {
            float3 vec;
            vec.x = a.x / b.x;
            vec.y = a.y / b.y;
            vec.z = a.z;
            return vec;
        }
        public static float3 operator /(float2 a, uint3 b)
        {
            float3 vec;
            vec.x = a.x / b.x;
            vec.y = a.y / b.y;
            vec.z = b.z;
            return vec;
        }
        public static float3 operator /(uint3 a, float3 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            b.z = a.z / b.z;
            return b;
        }
        public static float3 operator /(float3 a, uint3 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            return a;
        }
        public static float3 operator /(uint3 a, float b)
        {
            float3 vec;
            vec.x = a.x / b;
            vec.y = a.y / b;
            vec.z = a.z / b;
            return vec;
        }
        public static float3 operator /(float a, uint3 b)
        {
            float3 vec;
            vec.x = b.x / a;
            vec.y = b.y / a;
            vec.z = b.z / a;
            return vec;
        }
        public static uint3 operator /(uint3 a, uint b)
        {
            a.x = a.x / b;
            a.y = a.y / b;
            a.z = a.z / b;
            return a;
        }
        public static uint3 operator /(uint a, uint3 b)
        {
            b.x = a / b.x;
            b.y = a / b.y;
            b.z = a / b.z;
            return b;
        }
        public static uint3 operator %(uint3 a, uint3 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            return a;
        }
        public static uint3 operator %(uint3 a, uint2 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            return a;
        }
        public static uint3 operator %(uint2 a, uint3 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            return b;
        }
        public static float3 operator %(uint3 a, float2 b)
        {
            float3 vec;
            vec.x = a.x % b.x;
            vec.y = a.y % b.y;
            vec.z = a.z;
            return vec;
        }
        public static float3 operator %(float2 a, uint3 b)
        {
            float3 vec;
            vec.x = a.x % b.x;
            vec.y = a.y % b.y;
            vec.z = b.z;
            return vec;
        }
        public static float3 operator %(uint3 a, float3 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            b.z = a.z % b.z;
            return b;
        }
        public static float3 operator %(float3 a, uint3 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            return a;
        }
        public static float3 operator %(uint3 a, float b)
        {
            float3 vec;
            vec.x = a.x % b;
            vec.y = a.y % b;
            vec.z = a.z % b;
            return vec;
        }
        public static float3 operator %(float a, uint3 b)
        {
            float3 vec;
            vec.x = b.x % a;
            vec.y = b.y % a;
            vec.z = b.z % a;
            return vec;
        }
        public static uint3 operator %(uint3 a, uint b)
        {
            a.x = a.x % b;
            a.y = a.y % b;
            a.z = a.z % b;
            return a;
        }
        public static uint3 operator %(uint a, uint3 b)
        {
            b.x = a % b.x;
            b.y = a % b.y;
            b.z = a % b.z;
            return b;
        }
        public static uint3 operator &(uint3 a, uint3 b)
        {
            a.x = a.x & b.x;
            a.y = a.y & b.y;
            a.z = a.z & b.z;
            return a;
        }
        public static uint3 operator &(uint3 a, uint2 b)
        {
            a.x = a.x & b.x;
            a.y = a.y & b.y;
            return a;
        }
        public static uint3 operator &(uint2 a, uint3 b)
        {
            b.x = a.x & b.x;
            b.y = a.y & b.y;
            return b;
        }
        public static uint3 operator &(uint3 a, uint b)
        {
            a.x = a.x & b;
            a.y = a.y & b;
            a.z = a.z & b;
            return a;
        }
        public static uint3 operator &(uint a, uint3 b)
        {
            b.x = a & b.x;
            b.y = a & b.y;
            b.z = a & b.z;
            return b;
        }
        public static uint3 operator |(uint3 a, uint3 b)
        {
            a.x = a.x | b.x;
            a.y = a.y | b.y;
            a.z = a.z | b.z;
            return a;
        }
        public static uint3 operator |(uint3 a, uint2 b)
        {
            a.x = a.x | b.x;
            a.y = a.y | b.y;
            return a;
        }
        public static uint3 operator |(uint2 a, uint3 b)
        {
            b.x = a.x | b.x;
            b.y = a.y | b.y;
            return b;
        }
        public static uint3 operator |(uint3 a, uint b)
        {
            a.x = a.x | b;
            a.y = a.y | b;
            a.z = a.z | b;
            return a;
        }
        public static uint3 operator |(uint a, uint3 b)
        {
            b.x = a | b.x;
            b.y = a | b.y;
            b.z = a | b.z;
            return b;
        }
        public static uint3 operator ^(uint3 a, uint3 b)
        {
            a.x = a.x ^ b.x;
            a.y = a.y ^ b.y;
            a.z = a.z ^ b.z;
            return a;
        }
        public static uint3 operator ^(uint3 a, uint2 b)
        {
            a.x = a.x ^ b.x;
            a.y = a.y ^ b.y;
            return a;
        }
        public static uint3 operator ^(uint2 a, uint3 b)
        {
            b.x = a.x ^ b.x;
            b.y = a.y ^ b.y;
            return b;
        }
        public static uint3 operator ^(uint3 a, uint b)
        {
            a.x = a.x ^ b;
            a.y = a.y ^ b;
            a.z = a.z ^ b;
            return a;
        }
        public static uint3 operator ^(uint a, uint3 b)
        {
            b.x = a ^ b.x;
            b.y = a ^ b.y;
            b.z = a ^ b.z;
            return b;
        }
        public static uint3 operator <<(uint3 a, int b)
        {
            a.x = a.x << b;
            a.y = a.y << b;
            a.z = a.z << b;
            return a;
        }
        public static uint3 operator >>(uint3 a, int b)
        {
            a.x = a.x >> b;
            a.y = a.y >> b;
            a.z = a.z >> b;
            return a;
        }
        public static uint3 operator ~(uint3 a)
        {
            a.x = ~a.x;
            a.y = ~a.y;
            a.z = ~a.z;
            return a;
        }
        public static explicit operator bool2(uint3 v)
        {
            bool2 vec;
            vec.x = v.x != 0u;
            vec.y = v.y != 0u;
            return vec;
        }
        public static explicit operator bool3(uint3 v)
        {
            bool3 vec;
            vec.x = v.x != 0u;
            vec.y = v.y != 0u;
            vec.z = v.z != 0u;
            return vec;
        }
        public static explicit operator bool4(uint3 v)
        {
            bool4 vec;
            vec.x = v.x != 0u;
            vec.y = v.y != 0u;
            vec.z = v.z != 0u;
            vec.w = false;
            return vec;
        }
        public static explicit operator uint2(uint3 v)
        {
            uint2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static implicit operator uint4(uint3 v)
        {
            uint4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            vec.w = 0u;
            return vec;
        }
        public static explicit operator float2(uint3 v)
        {
            float2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static implicit operator float3(uint3 v)
        {
            float3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            return vec;
        }
        public static implicit operator float4(uint3 v)
        {
            float4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            vec.w = 0f;
            return vec;
        }
        public static explicit operator double2(uint3 v)
        {
            double2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static implicit operator double3(uint3 v)
        {
            double3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            return vec;
        }
        public static implicit operator double4(uint3 v)
        {
            double4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            vec.w = 0d;
            return vec;
        }
        public static explicit operator int2(uint3 v)
        {
            int2 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            return vec;
        }
        public static explicit operator int3(uint3 v)
        {
            int3 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            vec.z = (int)v.z;
            return vec;
        }
        public static explicit operator int4(uint3 v)
        {
            int4 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            vec.z = (int)v.z;
            vec.w = 0;
            return vec;
        }
        public static bool operator ==(uint3 a, uint3 b)
        {
            return a.x == b.x && a.y == b.y && a.z == b.z;
        }
        public static bool operator !=(uint3 a, uint3 b)
        {
            return a.x != b.x || a.y != b.y || a.z != b.z;
        }
    }
}
