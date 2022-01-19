using System;
using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    [Serializable]
    public partial struct float3 : IEquatable<float3>
    {
        /// <summary>
        /// X component of the vector.
        /// </summary>
        public float x;
        /// <summary>
        /// Y component of the vector.
        /// </summary>
        public float y;
        /// <summary>
        /// Z component of the vector.
        /// </summary>
        public float z;
        /// <summary>
        /// X component of the vector.
        /// </summary>
        [XmlIgnore]
        public float r
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
        public float g
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
        public float b
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
        public float2 xx
        {
            get
            {
                float2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float2 rr
        {
            get
            {
                float2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float2 xy
        {
            get
            {
                float2 vec;
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
        public float2 rg
        {
            get
            {
                float2 vec;
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
        public float2 xz
        {
            get
            {
                float2 vec;
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
        public float2 rb
        {
            get
            {
                float2 vec;
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
        public float2 yx
        {
            get
            {
                float2 vec;
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
        public float2 gr
        {
            get
            {
                float2 vec;
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
        public float2 yy
        {
            get
            {
                float2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float2 gg
        {
            get
            {
                float2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float2 yz
        {
            get
            {
                float2 vec;
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
        public float2 gb
        {
            get
            {
                float2 vec;
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
        public float2 zx
        {
            get
            {
                float2 vec;
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
        public float2 br
        {
            get
            {
                float2 vec;
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
        public float2 zy
        {
            get
            {
                float2 vec;
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
        public float2 bg
        {
            get
            {
                float2 vec;
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
        public float2 zz
        {
            get
            {
                float2 vec;
                vec.x = z;
                vec.y = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float2 bb
        {
            get
            {
                float2 vec;
                vec.x = z;
                vec.y = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 xxx
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 rrr
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 xxy
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 rrg
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 xxz
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 rrb
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 xyx
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 rgr
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 xyy
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 rgg
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 xyz
        {
            get
            {
                float3 vec;
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
        public float3 rgb
        {
            get
            {
                float3 vec;
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
        public float3 xzx
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 rbr
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 xzy
        {
            get
            {
                float3 vec;
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
        public float3 rbg
        {
            get
            {
                float3 vec;
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
        public float3 xzz
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 rbb
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 yxx
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 grr
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 yxy
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 grg
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 yxz
        {
            get
            {
                float3 vec;
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
        public float3 grb
        {
            get
            {
                float3 vec;
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
        public float3 yyx
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 ggr
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 yyy
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 ggg
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 yyz
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 ggb
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 yzx
        {
            get
            {
                float3 vec;
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
        public float3 gbr
        {
            get
            {
                float3 vec;
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
        public float3 yzy
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 gbg
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 yzz
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 gbb
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 zxx
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 brr
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 zxy
        {
            get
            {
                float3 vec;
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
        public float3 brg
        {
            get
            {
                float3 vec;
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
        public float3 zxz
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 brb
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 zyx
        {
            get
            {
                float3 vec;
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
        public float3 bgr
        {
            get
            {
                float3 vec;
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
        public float3 zyy
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 bgg
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 zyz
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 bgb
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 zzx
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 bbr
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 zzy
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 bbg
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 zzz
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 bbb
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xxxx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rrrr
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xxxy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rrrg
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xxxz
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rrrb
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xxyx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rrgr
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xxyy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rrgg
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xxyz
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rrgb
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xxzx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rrbr
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xxzy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rrbg
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xxzz
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rrbb
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xyxx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rgrr
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xyxy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rgrg
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xyxz
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rgrb
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xyyx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rggr
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xyyy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rggg
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xyyz
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rggb
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xyzx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rgbr
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xyzy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rgbg
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xyzz
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rgbb
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xzxx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rbrr
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xzxy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rbrg
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xzxz
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rbrb
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xzyx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rbgr
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xzyy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rbgg
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xzyz
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rbgb
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xzzx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rbbr
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xzzy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rbbg
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xzzz
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rbbb
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yxxx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 grrr
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yxxy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 grrg
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yxxz
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 grrb
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yxyx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 grgr
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yxyy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 grgg
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yxyz
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 grgb
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yxzx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 grbr
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yxzy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 grbg
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yxzz
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 grbb
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yyxx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ggrr
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yyxy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ggrg
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yyxz
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ggrb
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yyyx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gggr
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yyyy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gggg
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yyyz
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gggb
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yyzx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ggbr
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yyzy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ggbg
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yyzz
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ggbb
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yzxx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gbrr
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yzxy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gbrg
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yzxz
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gbrb
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yzyx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gbgr
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yzyy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gbgg
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yzyz
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gbgb
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yzzx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gbbr
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yzzy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gbbg
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yzzz
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gbbb
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zxxx
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 brrr
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zxxy
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 brrg
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zxxz
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 brrb
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zxyx
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 brgr
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zxyy
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 brgg
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zxyz
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 brgb
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zxzx
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 brbr
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zxzy
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 brbg
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zxzz
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 brbb
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zyxx
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bgrr
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zyxy
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bgrg
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zyxz
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bgrb
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zyyx
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bggr
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zyyy
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bggg
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zyyz
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bggb
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zyzx
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bgbr
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zyzy
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bgbg
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zyzz
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bgbb
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zzxx
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bbrr
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zzxy
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bbrg
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zzxz
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bbrb
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zzyx
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bbgr
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zzyy
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bbgg
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zzyz
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bbgb
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zzzx
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bbbr
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zzzy
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bbbg
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zzzz
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bbbb
        {
            get
            {
                float4 vec;
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
        public float3(float xyz)
        {
            x = xyz;
            y = xyz;
            z = xyz;
        }
        /// <summary>
        /// Creates a new vector with given x, y, z components.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public float3(float x, float y, float z = 0f)
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
        public float3(float x, float2 a)
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
        public float3(float2 a, float z = 0f)
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
        public void Set(float newX, float newY, float newZ)
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
        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    default:
                        throw new IndexOutOfRangeException("Invalid float3 index!");
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
                        throw new IndexOutOfRangeException("Invalid float3 index!");
                }
            }
        }
        /// <summary>
        /// Linearly interpolates between two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float3 Lerp(float3 a, float3 b, float t)
        {
            t = t < 0f ? 0f : t > 1f ? 1f : t;
            a.x = a.x + (b.x - a.x) * t;
            a.y = a.y + (b.y - a.y) * t;
            a.z = a.z + (b.z - a.z) * t;
            return a;
        }
        /// <summary>
        /// Normalize a value t to a range a - b. The opposite of lerp.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float3 Unlerp(float3 a, float3 b, float t)
        {
            t = t < 0f ? 0f : t > 1f ? 1f : t;
            a.x = (t - a.x) / (b.x - a.x);
            a.y = (t - a.y) / (b.y - a.y);
            a.z = (t - a.z) / (b.z - a.z);
            return a;
        }
        /// <summary>
        /// Normalize a value t to a range a - b. The opposite of lerp.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float3 Unlerp(float3 b, float t)
        {
            t = t < 0f ? 0f : t > 1f ? 1f : t;
            b.x = (t - x) / (b.x - x);
            b.y = (t - y) / (b.y - y);
            b.z = (t - z) / (b.z - z);
            return b;
        }
        /// <summary>
        /// Lineary interpolates between two vectors and normalize the result.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float3 Nlerp(float3 a, float3 b, float t)
        {
            t = t < 0f ? 0f : t > 1f ? 1f : t;
            a.x = a.x + (b.x - a.x) * t;
            a.y = a.y + (b.y - a.y) * t;
            a.z = a.z + (b.z - a.z) * t;
            float mag = Mathematics.Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z);
            if (mag > 0.00001f)
            {
                a.x = a.x / mag;
                a.y = a.y / mag;
                a.z = a.z / mag;
            }
            else
            {
                a.x = 0f;
                a.y = 0f;
                a.z = 0f;
            }
            return a;
        }
        /// <summary>
        /// Lerp a value between a and c, using b as the bezier between a and c.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static float3 QuadraticBezier(float3 a, float3 b, float3 c, float t)
        {
            t = t > 1f ? 1f : t < 0f ? 0f : t;
            float oneMinusT = 1f - t;
            a.x = oneMinusT * oneMinusT * a.x + 2f * oneMinusT * t * b.x + t * t * c.x;
            a.y = oneMinusT * oneMinusT * a.y + 2f * oneMinusT * t * b.y + t * t * c.y;
            a.z = oneMinusT * oneMinusT * a.z + 2f * oneMinusT * t * b.z + t * t * c.z;
            return a;
        }
        /// <summary>
        /// Return the tangent of the quadratic bezier curve.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static float3 QuadraticBezierTangent(float3 a, float3 b, float3 c, float t)
        {
            t = t > 1f ? 1f : t < 0f ? 0f : t;
            a.x = 2f * (1f - t) * (b.x - a.x) + 2f * t * (c.x - b.x);
            a.y = 2f * (1f - t) * (b.y - a.y) + 2f * t * (c.y - b.y);
            a.z = 2f * (1f - t) * (b.z - a.z) + 2f * t * (c.z - b.z);
            return a;
        }
        /// <summary>
        /// Lerp a value between a and d, using b as the bezier of a and c as the bezier of c.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static float3 CubicBezier(float3 a, float3 b, float3 c, float3 d, float t)
        {
            t = t > 1f ? 1f : t < 0f ? 0f : t;
            float oneMinusT = 1f - t;
            float oneMinusTPow2 = oneMinusT * oneMinusT;
            float t2 = t * t;
            a.x = oneMinusTPow2 * oneMinusT * a.x + 3f * oneMinusTPow2 * t * b.x + 3f * oneMinusT * t2 * c.x + t2 * t * d.x;
            a.y = oneMinusTPow2 * oneMinusT * a.y + 3f * oneMinusTPow2 * t * b.y + 3f * oneMinusT * t2 * c.y + t2 * t * d.y;
            a.z = oneMinusTPow2 * oneMinusT * a.z + 3f * oneMinusTPow2 * t * b.z + 3f * oneMinusT * t2 * c.z + t2 * t * d.z;
            return a;
        }
        /// <summary>
        /// Return the tangent of the cubic bezier curve.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static float3 CubicBezierTangent(float3 a, float3 b, float3 c, float3 d, float t)
        {
            t = t > 1f ? 1f : t < 0f ? 0f : t;
            float oneMinusT = 1f - t;
            a.x = 3f * oneMinusT * oneMinusT * (b.x - a.x) + 6f * oneMinusT * t * (c.x - b.x) + 3f * t * t * (d.x - c.x);
            a.y = 3f * oneMinusT * oneMinusT * (b.y - a.y) + 6f * oneMinusT * t * (c.y - b.y) + 3f * t * t * (d.y - c.y);
            a.z = 3f * oneMinusT * oneMinusT * (b.z - a.z) + 6f * oneMinusT * t * (c.z - b.z) + 3f * t * t * (d.z - c.z);
            return a;
        }
        /// <summary>
        /// Linearly interpolates between two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float3 LerpUnclamped(float3 a, float3 b, float t)
        {
            a.x = a.x + (b.x - a.x) * t;
            a.y = a.y + (b.y - a.y) * t;
            a.z = a.z + (b.z - a.z) * t;
            return a;
        }
        /// <summary>
        /// Normalize a value t to a range a - b. The opposite of lerp.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float3 UnlerpUnclamped(float3 a, float3 b, float t)
        {
            a.x = (t - a.x) / (b.x - a.x);
            a.y = (t - a.y) / (b.y - a.y);
            a.z = (t - a.z) / (b.z - a.z);
            return a;
        }
        /// <summary>
        /// Normalize a value t to a range a - b. The opposite of lerp.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float3 UnlerpUnclamped(float3 b, float t)
        {
            b.x = (t - x) / (b.x - x);
            b.y = (t - y) / (b.y - y);
            b.z = (t - z) / (b.z - z);
            return b;
        }
        /// <summary>
        /// Lineary interpolates between two vectors and normalize the result.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float3 NlerpUnclamped(float3 a, float3 b, float t)
        {
            a.x = a.x + (b.x - a.x) * t;
            a.y = a.y + (b.y - a.y) * t;
            a.z = a.z + (b.z - a.z) * t;
            float mag = Mathematics.Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z);
            if (mag > 0.00001f)
            {
                a.x = a.x / mag;
                a.y = a.y / mag;
                a.z = a.z / mag;
            }
            else
            {
                a.x = 0f;
                a.y = 0f;
                a.z = 0f;
            }
            return a;
        }
        /// <summary>
        /// Lerp a value between a and c, using b as the bezier between a and c.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static float3 QuadraticBezierUnclamped(float3 a, float3 b, float3 c, float t)
        {
            float oneMinusT = 1f - t;
            a.x = oneMinusT * oneMinusT * a.x + 2f * oneMinusT * t * b.x + t * t * c.x;
            a.y = oneMinusT * oneMinusT * a.y + 2f * oneMinusT * t * b.y + t * t * c.y;
            a.z = oneMinusT * oneMinusT * a.z + 2f * oneMinusT * t * b.z + t * t * c.z;
            return a;
        }
        /// <summary>
        /// Return the tangent of the quadratic bezier curve.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static float3 QuadraticBezierTangentUnclamped(float3 a, float3 b, float3 c, float t)
        {
            a.x = 2f * (1f - t) * (b.x - a.x) + 2f * t * (c.x - b.x);
            a.y = 2f * (1f - t) * (b.y - a.y) + 2f * t * (c.y - b.y);
            a.z = 2f * (1f - t) * (b.z - a.z) + 2f * t * (c.z - b.z);
            return a;
        }
        /// <summary>
        /// Lerp a value between a and d, using b as the bezier of a and c as the bezier of c.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static float3 CubicBezierUnclamped(float3 a, float3 b, float3 c, float3 d, float t)
        {
            float oneMinusT = 1f - t;
            float oneMinusTPow2 = oneMinusT * oneMinusT;
            float t2 = t * t;
            a.x = oneMinusTPow2 * oneMinusT * a.x + 3f * oneMinusTPow2 * t * b.x + 3f * oneMinusT * t2 * c.x + t2 * t * d.x;
            a.y = oneMinusTPow2 * oneMinusT * a.y + 3f * oneMinusTPow2 * t * b.y + 3f * oneMinusT * t2 * c.y + t2 * t * d.y;
            a.z = oneMinusTPow2 * oneMinusT * a.z + 3f * oneMinusTPow2 * t * b.z + 3f * oneMinusT * t2 * c.z + t2 * t * d.z;
            return a;
        }
        /// <summary>
        /// Return the tangent of the cubic bezier curve.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static float3 CubicBezierTangentUnclamped(float3 a, float3 b, float3 c, float3 d, float t)
        {
            float oneMinusT = 1f - t;
            a.x = 3f * oneMinusT * oneMinusT * (b.x - a.x) + 6f * oneMinusT * t * (c.x - b.x) + 3f * t * t * (d.x - c.x);
            a.y = 3f * oneMinusT * oneMinusT * (b.y - a.y) + 6f * oneMinusT * t * (c.y - b.y) + 3f * t * t * (d.y - c.y);
            a.z = 3f * oneMinusT * oneMinusT * (b.z - a.z) + 6f * oneMinusT * t * (c.z - b.z) + 3f * t * t * (d.z - c.z);
            return a;
        }
        /// <summary>
        /// Moves a point current in a straight line towards a target point.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="target"></param>
        /// <param name="maxDistanceDelta"></param>
        /// <returns></returns>
        public static float3 MoveTowards(float3 current, float3 target, float maxDistanceDelta)
        {
            float toVectorx = target.x - current.x;
            float toVectory = target.y - current.y;
            float toVectorz = target.z - current.z;
            float dist = Mathematics.Math.Sqrt(toVectorx * toVectorx + toVectory * toVectory + toVectorz * toVectorz);
            if (dist <= maxDistanceDelta || dist < float.Epsilon)
            {
                return target;
            }
            current.x = (current.x + toVectorx) / dist * maxDistanceDelta;
            current.y = (current.y + toVectory) / dist * maxDistanceDelta;
            current.z = (current.z + toVectorz) / dist * maxDistanceDelta;
            return current;
        }
        /// <summary>
        /// Moves a point current in a straight line towards a target point.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="maxDistanceDelta"></param>
        /// <returns></returns>
        public float3 MoveTowards(float3 target, float maxDistanceDelta)
        {
            float toVectorx = target.x - x;
            float toVectory = target.y - y;
            float toVectorz = target.z - z;
            float dist = Mathematics.Math.Sqrt(toVectorx * toVectorx + toVectory * toVectory + toVectorz * toVectorz);
            if (dist <= maxDistanceDelta || dist < float.Epsilon)
            {
                return target;
            }
            target.x = (x + toVectorx) / dist * maxDistanceDelta;
            target.y = (y + toVectory) / dist * maxDistanceDelta;
            target.z = (z + toVectorz) / dist * maxDistanceDelta;
            return target;
        }
        /// <summary>
        /// Return a line to the center of a collision.
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="hitInfoDistance"></param>
        /// <returns></returns>
        public float3 CastCenterOnCollision(float3 direction, float hitInfoDistance)
        {
            float mag = (float)Mathematics.Math.Sqrt(direction.x * direction.x + direction.y * direction.y + direction.z * direction.z);
            if(mag > 0.00001f)
            {
                direction.x = x + (direction.x / mag) * hitInfoDistance;
                direction.y = y + (direction.y / mag) * hitInfoDistance;
                direction.z = z + (direction.z / mag) * hitInfoDistance;
                return direction;
            }
            return this;
        }
        /// <summary>
        /// Check if a target vector is in the range of this position.
        /// </summary>
        /// <param name="targetPosition">Position of the target</param>
        /// <param name="rangeDistance">Detecting range</param>
        /// <returns></returns>
        public bool IsInRange(float3 targetPosition, float rangeDistance)
        {
            targetPosition.x = targetPosition.x - x;
            targetPosition.y = targetPosition.y - y;
            targetPosition.z = targetPosition.z - z;
            return targetPosition.x * targetPosition.x + targetPosition.y * targetPosition.y + targetPosition.z * targetPosition.z < rangeDistance * rangeDistance;
        }
        /// <summary>
        /// Return the distance between two vectors.
        /// </summary>
        /// <param name="actualVector"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public float Distance(float3 target)
        {
            target.x = x - target.x;
            target.y = y - target.y;
            target.z = z - target.z;
            return (float)Mathematics.Math.Sqrt(target.x * target.x + target.y * target.y + target.z * target.z);
        }
        /// <summary>
        /// Cross Product of two vectors.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public float3 Cross(float3 b)
        {
            float3 vec;
            vec.x = y * b.z - z * b.y;
            vec.y = z * b.x - x * b.z;
            vec.z = x * b.y - y * b.x;
            return vec;
        }
        /// <summary>
        /// Return the direction of the targetted vector.
        /// </summary>
        /// <param name="targetPosition">Target direction</param>
        /// <returns></returns>
        public float3 Direction(float3 targetPosition)
        {
            targetPosition.x = targetPosition.x - x;
            targetPosition.y = targetPosition.y - y;
            targetPosition.z = targetPosition.z - z;
            float mag = (float)Mathematics.Math.Sqrt(targetPosition.x * targetPosition.x + targetPosition.y * targetPosition.y + targetPosition.z * targetPosition.z);
            if(mag > 0.00001f)
            {
                targetPosition.x = targetPosition.x / mag;
                targetPosition.y = targetPosition.y / mag;
                targetPosition.z = targetPosition.z / mag;
                return targetPosition;
            }
            targetPosition.x = 0f;
            targetPosition.y = 0f;
            targetPosition.z = 0f;
            return targetPosition;
        }
        /// <summary>
        /// Gradually changes a vector towards a desired goal over time.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="target"></param>
        /// <param name="currentVelocity"></param>
        /// <param name="smoothTime"></param>
        /// <param name="maxSpeed"></param>
        /// <param name="deltaTime"></param>
        /// <returns></returns>
        public static float3 SmoothDamp(float3 current, float3 target, ref float3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
        {
            smoothTime = 0.0001f > smoothTime ? 0.0001f : smoothTime;
            float omega = 2f / smoothTime;
            float x = omega * deltaTime;
            float exp = 1f / (1f + x + 0.48f * x * x + 0.235f * x * x * x);
            float3 change;
            change.x = current.x - target.x;
            change.y = current.y - target.y;
            change.z = current.z - target.z;
            float3 originalTo = target;
            float maxChange = maxSpeed * smoothTime;
            float sqrMag = change.x * change.x + change.y * change.y + change.z * change.z;
            if(sqrMag > maxChange * maxChange)
            {
                sqrMag = (float)Mathematics.Math.Sqrt(sqrMag);
                if(sqrMag > 0.00001f)
                {
                    change.x = change.x / sqrMag;
                    change.y = change.y / sqrMag;
                    change.z = change.z / sqrMag;
                }
                else
                {
                    change.x = 0f;
                    change.y = 0f;
                    change.z = 0f;
                }
            }
            target.x = current.x - change.x;
            target.y = current.y - change.y;
            target.z = current.z - change.z;
            float tempX, tempY, tempZ;
            tempX = (currentVelocity.x + omega * change.x) * deltaTime;
            tempY = (currentVelocity.y + omega * change.y) * deltaTime;
            tempZ = (currentVelocity.z + omega * change.z) * deltaTime;
            currentVelocity.x = (currentVelocity.x - omega * tempX) * exp;
            currentVelocity.y = (currentVelocity.y - omega * tempY) * exp;
            currentVelocity.z = (currentVelocity.z - omega * tempZ) * exp;
            float3 output;
            output.x = target.x + (change.x + tempX) * exp;
            output.y = target.y + (change.y + tempY) * exp;
            output.z = target.z + (change.z + tempZ) * exp;
            float oriCurrX = originalTo.x - current.x;
            float oriCurrY = originalTo.y - current.y;
            float oriCurrZ = originalTo.z - current.z;
            float outOriX = output.x - originalTo.x;
            float outOriY = output.y - originalTo.y;
            float outOriZ = output.z - originalTo.z;
            if ((oriCurrX * outOriX + oriCurrY * outOriY + oriCurrZ * outOriZ) > 0)
            {
                output = originalTo;
                currentVelocity.x = (output.x - originalTo.x) / deltaTime;
                currentVelocity.y = (output.y - originalTo.y) / deltaTime;
                currentVelocity.z = (output.z - originalTo.z) / deltaTime;
            }
            return output;
        }
        /// <summary>
        /// Cross Product of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float3 Cross(float3 a, float3 b)
        {
            float3 vec;
            vec.x = a.y * b.z - a.z * b.y;
            vec.y = a.z * b.x - a.x * b.z;
            vec.z = a.x * b.y - a.y * b.x;
            return vec;
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
            if (!(other is float3))
            {
                return false;
            }
            return Equals((float3)other);
        }
        /// <summary>
        /// Returns true if the given vector is exactly equal to this vector.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(float3 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z);
        }
        /// <summary>
        /// Reflects a vector off the plane defined by a normal.
        /// </summary>
        /// <param name="inDirection"></param>
        /// <param name="inNormal"></param>
        /// <returns></returns>
        public static float3 Reflect(float3 inDirection, float3 inNormal)
        {
            float dotNorm = inNormal.x * inDirection.x + inNormal.y * inDirection.y + inNormal.z * inDirection.z;
            inDirection.x = -2f * dotNorm * inNormal.x + inDirection.x;
            inDirection.y = -2f * dotNorm * inNormal.y + inDirection.y;
            inDirection.z = -2f * dotNorm * inNormal.z + inDirection.z;
            return inDirection;
        }
        /// <summary>
        /// Reflects a vector off the plane defined by a normal.
        /// </summary>
        /// <param name="inNormal"></param>
        /// <returns></returns>
        public float3 Reflect(float3 inNormal)
        {
            float dotNorm = inNormal.x * x + inNormal.y * y + inNormal.z * z;
            inNormal.x = -2f * dotNorm * inNormal.x + x;
            inNormal.y = -2f * dotNorm * inNormal.y + y;
            inNormal.z = -2f * dotNorm * inNormal.z + z;
            return inNormal;
        }
        /// <summary>
        /// Makes this vector have a magnitude of 1.
        /// </summary>
        public void Normalize()
        {
            float mag = (float)Mathematics.Math.Sqrt(x * x + y * y + z * z);
            if (mag > 1e-15f)
            {
                x /= mag;
                y /= mag;
                z /= mag;
            }
            else
            {
                x = 0f;
                y = 0f;
                z = 0f;
            }
        }
        /// <summary>
        /// Returns this vector with a magnitude of 1 (Read Only).
        /// </summary>
        [XmlIgnore]
        public float3 Normalized
        {
            get
            {
                float mag = (float)Mathematics.Math.Sqrt(x * x + y * y + z * z);
                float3 value;
                if (mag > 1e-15f)
                {
                    value.x = x / mag;
                    value.y = y / mag;
                    value.z = z / mag;
                    return value;
                }
                value.x = 0f;
                value.y = 0f;
                value.z = 0f;
                return value;
            }
        }
        /// <summary>
        /// Dot Product of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float Dot(float3 a, float3 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }
        /// <summary>
        /// Dot Product of two vectors.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public float Dot(float3 b)
        {
            return x * b.x + y * b.y + z * b.z;
        }
        /// <summary>
        /// Dot product clamped in the range [-1;1] corresponding to the cosine of the angle of directions.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float DotClamped(float3 a, float3 b)
        {
            float dot_ab = a.x * b.x + a.y * b.y + a.z * b.z;
            if(dot_ab < 1e-15f && dot_ab > -1e-15f)
            {
                return dot_ab;
            }
            return dot_ab / Mathematics.Math.Sqrt((a.x * a.x + a.y * a.y + a.z * a.z) * (b.x * b.x + b.y * b.y + b.z * b.z));
        }
        /// <summary>
        /// Dot product clamped in the range [-1;1] corresponding to the cosine of the angle of directions.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public float DotClamped(float3 b)
        {
            float dot_ab = x * b.x + y * b.y + z * b.z;
            if (dot_ab < 1e-15f && dot_ab > -1e-15f)
            {
                return dot_ab;
            }
            return dot_ab / Mathematics.Math.Sqrt((x * x + y * y + z * z) * (b.x * b.x + b.y * b.y + b.z * b.z));
        }
        /// <summary>
        /// Projects a vector onto another vector.
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="onNormal"></param>
        /// <returns></returns>
        public static float3 Project(float3 vector, float3 onNormal)
        {
            float sqrMag = onNormal.x * onNormal.x + onNormal.y * onNormal.y + onNormal.z * onNormal.z;
            if (sqrMag < 1e-15f)
            {
                return Zero;
            }
            float d = vector.x * onNormal.x + vector.y * onNormal.y + vector.z * onNormal.z;
            onNormal.x = onNormal.x * d / sqrMag;
            onNormal.y = onNormal.y * d / sqrMag;
            onNormal.z = onNormal.z * d / sqrMag;
            return onNormal;
        }
        /// <summary>
        /// Projects a vector onto a plane defined by a normal orthogonal to the plane.
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="planeNormal"></param>
        /// <returns></returns>
        public static float3 ProjectOnPlane(float3 vector, float3 planeNormal)
        {
            float sqrMag = planeNormal.x * planeNormal.x + planeNormal.y * planeNormal.y + planeNormal.z * planeNormal.z;
            if (sqrMag < 1e-15f)
            {
                return Zero;
            }
            float d = vector.x * planeNormal.x + vector.y * planeNormal.y + vector.z * planeNormal.z;
            planeNormal.x = vector.x - (planeNormal.x * d / sqrMag);
            planeNormal.y = vector.y - (planeNormal.y * d / sqrMag);
            planeNormal.z = vector.z - (planeNormal.z * d / sqrMag);
            return planeNormal;
        }
        /// <summary>
        /// Returns the angle in degrees between from and to.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static float Angle(float3 from, float3 to)
        {
            float denominator = (float)Mathematics.Math.Sqrt((from.x * from.x + from.y * from.y + from.z * from.z) * (to.x * to.x + to.y * to.y + to.z * to.z));
            if (denominator < 1e-15f)
            {
                return 0f;
            }
            from.x = (from.x * to.x + from.y * to.y + from.z * to.z) / denominator;
            return (float)System.Math.Acos(from.x < -1f ? -1f : from.x > 1f ? 1f : from.x) * 57.2957795131f;
        }
        /// <summary>
        /// Returns the angle in degrees between from and to.
        /// </summary>
        /// <param name="to"></param>
        /// <returns></returns>
        public float AngleBetweenDirections(float3 to)
        {
            float denominator = Mathematics.Math.Sqrt((x * x + y * y + z * z) * (to.x * to.x + to.y * to.y + to.z * to.z));
            if (denominator < 1e-15f)
            {
                return 0f;
            }
            to.x = (x * to.x + y * to.y + z * to.z) / denominator;
            return (float)System.Math.Acos(to.x < -1f ? -1f : to.x > 1f ? 1f : to.x) * 57.2957795131f;
        }
        /// <summary>
        /// Returns the signed angle in degrees between from and to.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="axis"></param>
        /// <returns></returns>
        public static float SignedAngle(float3 from, float3 to, float3 axis)
        {
            float unsignedAngle;
            float denominator = Mathematics.Math.Sqrt((from.x * from.x + from.y * from.y + from.z * from.z) * (to.x * to.x + to.y * to.y + to.z * to.z));
            if (denominator < 1e-15f)
            {
                unsignedAngle = 0f;
            }
            else
            {
                float val = (from.x * to.x + from.y * to.y + from.z * to.z) / denominator;
                float dot = val < -1f ? -1f : val > 1f ? 1f : val;
                unsignedAngle = (float)System.Math.Acos(dot) * 57.2957795131f;
            }
            float3 vec;
            vec.x = from.y * to.z - from.z * to.y;
            vec.y = from.z * to.x - from.x * to.z;
            vec.z = from.x * to.y - from.y * to.x;
            return unsignedAngle * ((axis.x * vec.x + axis.y * vec.y + axis.z * vec.z) < 0f ? -1f : 1f);
        }
        /// <summary>
        /// Returns the signed angle in degrees between from and to.
        /// </summary>
        /// <param name="to"></param>
        /// <param name="axis"></param>
        /// <returns></returns>
        public float SignedAngle(float3 to, float3 axis)
        {
            float unsignedAngle;
            float denominator = (float)Mathematics.Math.Sqrt((x * x + y * y + z * z) * (to.x * to.x + to.y * to.y + to.z * to.z));
            if (denominator < 1e-15f)
            {
                unsignedAngle = 0f;
            }
            else
            {
                float val = (x * to.x + y * to.y + z * to.z) / denominator;
                float dot = val < -1f ? -1f : val > 1f ? 1f : val;
                unsignedAngle = (float)System.Math.Acos(dot) * 57.2957795131f;
            }
            float3 vec;
            vec.x = y * to.z - z * to.y;
            vec.y = z * to.x - x * to.z;
            vec.z = x * to.y - y * to.x;
            return unsignedAngle * ((axis.x * vec.x + axis.y * vec.y + axis.z * vec.z) < 0f ? -1f : 1f);
        }
        /// <summary>
        /// Return the dot product angle of both vectors.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public float DotProductAngle(float3 target)
        {
            float3 normThis = Normalized;
            target.Normalize();
            normThis.x = normThis.x * target.x + normThis.y * target.y + normThis.z * target.z;
            normThis.x = normThis.x > 1f ? 1f : normThis.x < -1f ? -1f : normThis.x;
            return (float)System.Math.Acos(normThis.x);
        }
        /// <summary>
        /// Returns the distance between a and b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float Distance(float3 a, float3 b)
        {
            float vecx = a.x - b.x;
            float vecy = a.y - b.y;
            float vecz = a.z - b.z;
            return Mathematics.Math.Sqrt(vecx * vecx + vecy * vecy + vecz * vecz);
        }
        /// <summary>
        /// Returns the direction of b from a.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float3 Direction(float3 a, float3 b)
        {
            float3 dir;
            dir.x = b.x - a.x;
            dir.y = b.y - a.y;
            dir.z = b.z - a.z;
            float mag = Mathematics.Math.Sqrt(dir.x * dir.x + dir.y * dir.y + dir.z * dir.z);
            if(mag > 0.00001f)
            {
                dir.x = dir.x / mag;
                dir.y = dir.y / mag;
                dir.z = dir.z / mag;
                return dir;
            }
            dir.x = 0f;
            dir.y = 0f;
            dir.z = 0f;
            return dir;
        }
        /// <summary>
        /// Return the float raised to the power.
        /// </summary>
        /// <param name="power"></param>
        /// <returns></returns>
        public float3 Pow(float3 power)
        {
            float3 vec;
            vec.x = Mathematics.Math.Pow(x, power.x);
            vec.y = Mathematics.Math.Pow(y, power.y);
            vec.z = Mathematics.Math.Pow(z, power.z);
            return vec;
        }
        /// <summary>
        /// Return the sinus of each vector's components.
        /// </summary>
        [XmlIgnore]
        public float3 Sin
        {
            get
            {
                float3 vec;
                vec.x = (float)System.Math.Sin(x);
                vec.y = (float)System.Math.Sin(y);
                vec.z = (float)System.Math.Sin(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the cosine of each vector's components.
        /// </summary>
        [XmlIgnore]
        public float3 Cos
        {
            get
            {
                float3 vec;
                vec.x = (float)System.Math.Cos(x);
                vec.y = (float)System.Math.Cos(y);
                vec.z = (float)System.Math.Cos(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the tangent of each vector's components.
        /// </summary>
        [XmlIgnore]
        public float3 Tan
        {
            get
            {
                float3 vec;
                vec.x = (float)System.Math.Tan(x);
                vec.y = (float)System.Math.Tan(y);
                vec.z = (float)System.Math.Tan(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the arc sinus of each vector's components.
        /// </summary>
        [XmlIgnore]
        public float3 Asin
        {
            get
            {
                float3 vec;
                vec.x = (float)System.Math.Asin(x);
                vec.y = (float)System.Math.Asin(y);
                vec.z = (float)System.Math.Asin(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the arc cosine of each vector's components.
        /// </summary>
        [XmlIgnore]
        public float3 Acos
        {
            get
            {
                float3 vec;
                vec.x = (float)System.Math.Acos(x);
                vec.y = (float)System.Math.Acos(y);
                vec.z = (float)System.Math.Acos(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the arc tangent of each vector's components.
        /// </summary>
        [XmlIgnore]
        public float3 Atan
        {
            get
            {
                float3 vec;
                vec.x = (float)System.Math.Atan(x);
                vec.y = (float)System.Math.Atan(y);
                vec.z = (float)System.Math.Atan(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the hyperbolic sinus of each vector's components.
        /// </summary>
        [XmlIgnore]
        public float3 Sinh
        {
            get
            {
                float3 vec;
                vec.x = (float)System.Math.Sinh(x);
                vec.y = (float)System.Math.Sinh(y);
                vec.z = (float)System.Math.Sinh(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the hyperbolic cosine of each vector's components.
        /// </summary>
        [XmlIgnore]
        public float3 Cosh
        {
            get
            {
                float3 vec;
                vec.x = (float)System.Math.Cosh(x);
                vec.y = (float)System.Math.Cosh(y);
                vec.z = (float)System.Math.Cosh(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the hyperbolic tangent of each vector's components.
        /// </summary>
        [XmlIgnore]
        public float3 Tanh
        {
            get
            {
                float3 vec;
                vec.x = (float)System.Math.Tanh(x);
                vec.y = (float)System.Math.Tanh(y);
                vec.z = (float)System.Math.Tanh(z);
                return vec;
            }
        }
        /// <summary>
        /// Returns a copy of vector with its magnitude clamped to maxLength.
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        public static float3 ClampMagnitude(float3 vector, float maxLength)
        {
            float sqrMag = vector.x * vector.x + vector.y * vector.y + vector.z * vector.z;
            if (sqrMag > maxLength * maxLength)
            {
                sqrMag = Mathematics.Math.Sqrt(sqrMag);
                vector.x = vector.x / sqrMag;
                vector.y = vector.y / sqrMag;
                vector.z = vector.z / sqrMag;
                return vector * maxLength;
            }
            return vector;
        }
        /// <summary>
        /// Returns the length of this vector (Read Only).
        /// </summary>
        [XmlIgnore]
        public float Magnitude
        {
            get
            {
                return Mathematics.Math.Sqrt(x * x + y * y + z * z);
            }
        }
        /// <summary>
        /// Returns the squared length of this vector (Read Only).
        /// </summary>
        [XmlIgnore]
        public float SqrMagnitude
        {
            get
            {
                return x * x + y * y + z * z;
            }
        }
        /// <summary>
        /// Returns a vector that is made from the smallest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float3 Min(float3 a, float3 b)
        {
            float3 vec;
            vec.x = a.x > b.x ? b.x : a.x;
            vec.y = a.y > b.y ? b.y : a.y;
            vec.z = a.z > b.z ? b.z : a.z;
            return vec;
        }
        /// <summary>
        /// Returns a vector that is made from the largest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float3 Max(float3 a, float3 b)
        {
            float3 vec;
            vec.x = a.x > b.x ? a.x : b.x;
            vec.y = a.y > b.y ? a.y : b.y;
            vec.z = a.z > b.z ? a.z : b.z;
            return vec;
        }
        /// <summary>
        /// Returns a vector that is made from the smallest components of two vectors.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public float3 Min(float3 b)
        {
            float3 vec;
            vec.x = x > b.x ? b.x : x;
            vec.y = y > b.y ? b.y : y;
            vec.z = z > b.z ? b.z : z;
            return vec;
        }
        /// <summary>
        /// Returns a vector that is made from the largest components of two vectors.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public float3 Max(float3 b)
        {
            float3 vec;
            vec.x = x > b.x ? x : b.x;
            vec.y = y > b.y ? y : b.y;
            vec.z = z > b.z ? z : b.z;
            return vec;
        }
        /// <summary>
        /// Return the minimum value of this vector's component and the float.
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public float3 Min(float w)
        {
            float3 vec;
            vec.x = x > w ? w : x;
            vec.y = y > w ? w : y;
            vec.z = z > w ? w : z;
            return vec;
        }
        /// <summary>
        /// Return the maximum value of this vector's component and the float.
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public float3 Max(float w)
        {
            float3 vec;
            vec.x = x > w ? x : w;
            vec.y = y > w ? y : w;
            vec.z = z > w ? z : w;
            return vec;
        }
        /// <summary>
        /// Rounds down each component of the vector.
        /// </summary>
        [XmlIgnore]
        public float3 Floor
        {
            get
            {
                float3 vec;
                vec.x = Mathematics.Math.Floor(x);
                vec.y = Mathematics.Math.Floor(y);
                vec.z = Mathematics.Math.Floor(z);
                return vec;
            }
        }
        /// <summary>
        /// Return if both vectors are opposed to each other.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsOppositeDirection(float3 b)
        {
            return x * b.x + y * b.y + z * b.z < 0f;
        }
        /// <summary>
        /// Return if both vectors are perpendicular to each other.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsPerpendicular(float3 b)
        {
            return x * b.x + y * b.y + z * b.z == 0f;
        }
        /// <summary>
        /// Return if botch vectors are in the same direction.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsSimilarDirection(float3 b)
        {
            return x * b.x + y * b.y + z * b.z > 0f;
        }
        /// <summary>
        /// Spherically interpolate direction vector. It doesn't work with point in space like slerp.
        /// </summary>
        /// <param name="actualVector"></param>
        /// <param name="targetVector"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float3 Nslerp(float3 actualVector, float3 targetVector, float t)
        {
            t = t > 1f ? 1f : t < 0f ? 0f : t;
            float startMag = Mathematics.Math.Sqrt(actualVector.x * actualVector.x + actualVector.y * actualVector.y + actualVector.z * actualVector.z);
            startMag = startMag + (Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z) - startMag) * t;
            float dot = actualVector.x * targetVector.x + actualVector.y * targetVector.y + actualVector.z * targetVector.z;
            float theta = (float)System.Math.Acos(dot) * t;
            float c = (float)System.Math.Cos(theta);
            float s = (float)System.Math.Sin(theta);
            targetVector.x = targetVector.x - actualVector.x * dot;
            targetVector.y = targetVector.y - actualVector.y * dot;
            targetVector.z = targetVector.z - actualVector.z * dot;
            float normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.00001f)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0f;
                targetVector.y = 0f;
                targetVector.z = 0f;
            }
            actualVector.x = (actualVector.x * c + targetVector.x * s) * startMag;
            actualVector.y = (actualVector.y * c + targetVector.y * s) * startMag;
            actualVector.z = (actualVector.z * c + targetVector.z * s) * startMag;
            return actualVector;
        }
        /// <summary>
        /// Spherically interpolate direction vector. It doesn't work with point in space like slerp.
        /// </summary>
        /// <param name="actualVector"></param>
        /// <param name="targetVector"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float3 Nslerp(float3 targetVector, float t)
        {
            t = t > 1f ? 1f : t < 0f ? 0f : t;
            float3 actualVector;
            actualVector.x = x;
            actualVector.y = y;
            actualVector.z = z;
            float startMag = Mathematics.Math.Sqrt(actualVector.x * actualVector.x + actualVector.y * actualVector.y + actualVector.z * actualVector.z);
            startMag = startMag + (Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z) - startMag) * t;
            float dot = actualVector.x * targetVector.x + actualVector.y * targetVector.y + actualVector.z * targetVector.z;
            float theta = (float)System.Math.Acos(dot) * t;
            float c = (float)System.Math.Cos(theta);
            float s = (float)System.Math.Sin(theta);
            targetVector.x = targetVector.x - actualVector.x * dot;
            targetVector.y = targetVector.y - actualVector.y * dot;
            targetVector.z = targetVector.z - actualVector.z * dot;
            float normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.00001f)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0f;
                targetVector.y = 0f;
                targetVector.z = 0f;
            }
            actualVector.x = (actualVector.x * c + targetVector.x * s) * startMag;
            actualVector.y = (actualVector.y * c + targetVector.y * s) * startMag;
            actualVector.z = (actualVector.z * c + targetVector.z * s) * startMag;
            return actualVector;
        }
        /// <summary>
        /// Spherically interpolate direction vector. It doesn't work with point in space like slerp.
        /// </summary>
        /// <param name="actualVector"></param>
        /// <param name="targetVector"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float3 NslerpUnclamped(float3 targetVector, float t)
        {
            float3 actualVector;
            actualVector.x = x;
            actualVector.y = y;
            actualVector.z = z;
            float startMag = Mathematics.Math.Sqrt(actualVector.x * actualVector.x + actualVector.y * actualVector.y + actualVector.z * actualVector.z);
            startMag = startMag + (Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z) - startMag) * t;
            float dot = actualVector.x * targetVector.x + actualVector.y * targetVector.y + actualVector.z * targetVector.z;
            float theta = (float)System.Math.Acos(dot) * t;
            float c = (float)System.Math.Cos(theta);
            float s = (float)System.Math.Sin(theta);
            targetVector.x = targetVector.x - actualVector.x * dot;
            targetVector.y = targetVector.y - actualVector.y * dot;
            targetVector.z = targetVector.z - actualVector.z * dot;
            float normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.00001f)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0f;
                targetVector.y = 0f;
                targetVector.z = 0f;
            }
            actualVector.x = (actualVector.x * c + targetVector.x * s) * startMag;
            actualVector.y = (actualVector.y * c + targetVector.y * s) * startMag;
            actualVector.z = (actualVector.z * c + targetVector.z * s) * startMag;
            return actualVector;
        }
        /// <summary>
        /// Spherically interpolate direction vector. It doesn't work with point in space like slerp.
        /// </summary>
        /// <param name="actualVector"></param>
        /// <param name="targetVector"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float3 NslerpUnclamped(float3 actualVector, float3 targetVector, float t)
        {
            float startMag = Mathematics.Math.Sqrt(actualVector.x * actualVector.x + actualVector.y * actualVector.y + actualVector.z * actualVector.z);
            startMag = startMag + (Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z) - startMag) * t;
            float dot = actualVector.x * targetVector.x + actualVector.y * targetVector.y + actualVector.z * targetVector.z;
            float theta = (float)System.Math.Acos(dot) * t;
            float c = (float)System.Math.Cos(theta);
            float s = (float)System.Math.Sin(theta);
            targetVector.x = targetVector.x - actualVector.x * dot;
            targetVector.y = targetVector.y - actualVector.y * dot;
            targetVector.z = targetVector.z - actualVector.z * dot;
            float normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.00001f)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0f;
                targetVector.y = 0f;
                targetVector.z = 0f;
            }
            actualVector.x = (actualVector.x * c + targetVector.x * s) * startMag;
            actualVector.y = (actualVector.y * c + targetVector.y * s) * startMag;
            actualVector.z = (actualVector.z * c + targetVector.z * s) * startMag;
            return actualVector;
        }
        /// <summary>
        /// Spherical interpolation between vectors.
        /// </summary>
        /// <param name="targetVector"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float3 Slerp(float3 targetVector, float t)
        {
            t = t > 1f ? 1f : t < 0f ? 0f : t;
            float3 vec;
            float startMag = Mathematics.Math.Sqrt(x * x + y * y + z * z);
            if (startMag > 0.00001f)
            {
                vec.x = x / startMag;
                vec.y = y / startMag;
                vec.z = z / startMag;
            }
            else
            {
                vec.x = 0f;
                vec.y = 0f;
                vec.z = 0f;
            }
            float normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.00001f)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0f;
                targetVector.y = 0f;
                targetVector.z = 0f;
            }
            startMag = startMag + (normalizedMag - startMag) * t;
            float dot = vec.x * targetVector.x + vec.y * targetVector.y + vec.z * targetVector.z;
            float theta = (float)System.Math.Acos(dot) * t;
            float c = (float)System.Math.Cos(theta);
            float s = (float)System.Math.Sin(theta);
            targetVector.x = targetVector.x - vec.x * dot;
            targetVector.y = targetVector.y - vec.y * dot;
            targetVector.z = targetVector.z - vec.z * dot;
            normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.00001f)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0f;
                targetVector.y = 0f;
                targetVector.z = 0f;
            }
            vec.x = (vec.x * c + targetVector.x * s) * startMag;
            vec.y = (vec.y * c + targetVector.y * s) * startMag;
            vec.z = (vec.z * c + targetVector.z * s) * startMag;
            return vec;
        }
        /// <summary>
        /// Spherical interpolation between vectors.
        /// </summary>
        /// <param name="actualVector"></param>
        /// <param name="targetVector"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float3 Slerp(float3 actualVector, float3 targetVector, float t)
        {
            t = t > 1f ? 1f : t < 0f ? 0f : t;
            float startMag = Mathematics.Math.Sqrt(actualVector.x * actualVector.x + actualVector.y * actualVector.y + actualVector.z * actualVector.z);
            if(startMag > 0.00001f)
            {
                actualVector.x = actualVector.x / startMag;
                actualVector.y = actualVector.y / startMag;
                actualVector.z = actualVector.z / startMag;
            }
            else
            {
                actualVector.x = 0f;
                actualVector.y = 0f;
                actualVector.z = 0f;
            }
            float normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if(normalizedMag > 0.00001f)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0f;
                targetVector.y = 0f;
                targetVector.z = 0f;
            }
            startMag = startMag + (normalizedMag - startMag) * t;
            float dot = actualVector.x * targetVector.x + actualVector.y * targetVector.y + actualVector.z * targetVector.z;
            float theta = (float)System.Math.Acos(dot) * t;
            float c = (float)System.Math.Cos(theta);
            float s = (float)System.Math.Sin(theta);
            targetVector.x = targetVector.x - actualVector.x * dot;
            targetVector.y = targetVector.y - actualVector.y * dot;
            targetVector.z = targetVector.z - actualVector.z * dot;
            normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if(normalizedMag > 0.00001f)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0f;
                targetVector.y = 0f;
                targetVector.z = 0f;
            }
            actualVector.x = (actualVector.x * c + targetVector.x * s) * startMag;
            actualVector.y = (actualVector.y * c + targetVector.y * s) * startMag;
            actualVector.z = (actualVector.z * c + targetVector.z * s) * startMag;
            return actualVector;
        }
        /// <summary>
        /// Spherical interpolation between vectors.
        /// </summary>
        /// <param name="targetVector"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float3 SlerpUnclamped(float3 targetVector, float t)
        {
            float3 vec;
            float startMag = Mathematics.Math.Sqrt(x * x + y * y + z * z);
            if (startMag > 0.00001f)
            {
                vec.x = x / startMag;
                vec.y = y / startMag;
                vec.z = z / startMag;
            }
            else
            {
                vec.x = 0f;
                vec.y = 0f;
                vec.z = 0f;
            }
            float normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.00001f)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0f;
                targetVector.y = 0f;
                targetVector.z = 0f;
            }
            startMag = startMag + (normalizedMag - startMag) * t;
            float dot = vec.x * targetVector.x + vec.y * targetVector.y + vec.z * targetVector.z;
            float theta = (float)System.Math.Acos(dot) * t;
            float c = (float)System.Math.Cos(theta);
            float s = (float)System.Math.Sin(theta);
            targetVector.x = targetVector.x - vec.x * dot;
            targetVector.y = targetVector.y - vec.y * dot;
            targetVector.z = targetVector.z - vec.z * dot;
            normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.00001f)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0f;
                targetVector.y = 0f;
                targetVector.z = 0f;
            }
            vec.x = (vec.x * c + targetVector.x * s) * startMag;
            vec.y = (vec.y * c + targetVector.y * s) * startMag;
            vec.z = (vec.z * c + targetVector.z * s) * startMag;
            return vec;
        }
        /// <summary>
        /// Spherical interpolation between vectors.
        /// </summary>
        /// <param name="actualVector"></param>
        /// <param name="targetVector"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float3 SlerpUnclamped(float3 actualVector, float3 targetVector, float t)
        {
            float startMag = Mathematics.Math.Sqrt(actualVector.x * actualVector.x + actualVector.y * actualVector.y + actualVector.z * actualVector.z);
            if (startMag > 0.00001f)
            {
                actualVector.x = actualVector.x / startMag;
                actualVector.y = actualVector.y / startMag;
                actualVector.z = actualVector.z / startMag;
            }
            else
            {
                actualVector.x = 0f;
                actualVector.y = 0f;
                actualVector.z = 0f;
            }
            float normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.00001f)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0f;
                targetVector.y = 0f;
                targetVector.z = 0f;
            }
            startMag = startMag + (normalizedMag - startMag) * t;
            float dot = actualVector.x * targetVector.x + actualVector.y * targetVector.y + actualVector.z * targetVector.z;
            float theta = (float)System.Math.Acos(dot) * t;
            float c = (float)System.Math.Cos(theta);
            float s = (float)System.Math.Sin(theta);
            targetVector.x = targetVector.x - actualVector.x * dot;
            targetVector.y = targetVector.y - actualVector.y * dot;
            targetVector.z = targetVector.z - actualVector.z * dot;
            normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.00001f)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0f;
                targetVector.y = 0f;
                targetVector.z = 0f;
            }
            actualVector.x = (actualVector.x * c + targetVector.x * s) * startMag;
            actualVector.y = (actualVector.y * c + targetVector.y * s) * startMag;
            actualVector.z = (actualVector.z * c + targetVector.z * s) * startMag;
            return actualVector;
        }
        /// <summary>
        /// Clamp the vector between a min and a max value, then, return it.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public float3 Clamp(float min, float max)
        {
            float3 vec;
            vec.x = x < min ? min : x > max ? max : x;
            vec.y = y < min ? min : y > max ? max : y;
            vec.z = z < min ? min : z > max ? max : z;
            return vec;
        }
        /// <summary>
        /// Clamp the vector between a min and a max vector value, then, return it.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public float3 Clamp(float3 min, float3 max)
        {
            float3 vec;
            vec.x = x < min.x ? min.x : x > max.x ? max.x : x;
            vec.y = y < min.y ? min.y : y > max.y ? max.y : y;
            vec.z = z < min.z ? min.z : z > max.z ? max.z : z;
            return vec;
        }
        /// <summary>
        /// Clamp the vector between 0 and 1.
        /// </summary>
        [XmlIgnore]
        public float3 Saturate
        {
            get
            {
                float3 vec;
                vec.x = x < 0f ? 0f : x > 1f ? 1f : x;
                vec.y = y < 0f ? 0f : y > 1f ? 1f : y;
                vec.z = z < 0f ? 0f : z > 1f ? 1f : z;
                return vec;
            }
        }
        /// <summary>
        /// Return the absolute value of the vector.
        /// </summary>
        [XmlIgnore]
        public float3 Abs
        {
            get
            {
                float3 vec;
                vec.x = x < 0f ? -x : x;
                vec.y = y < 0f ? -y : y;
                vec.z = z < 0f ? -z : z;
                return vec;
            }
        }
        /// <summary>
        /// Returns a int3 that contains the largest integer smaller to or equal to f.
        /// </summary>
        [XmlIgnore]
        public int3 FloorToInt
        {
            get
            {
                int3 vec;
                vec.x = (int)x;
                vec.y = (int)y;
                vec.z = (int)z;
                return vec;
            }
        }
        /// <summary>
        /// Returns a int3 that contains the smallest integer greater to or equal to f.
        /// </summary>
        [XmlIgnore]
        public int3 CeilToInt
        {
            get
            {
                int3 vec;
                vec.x = (int)Mathematics.Math.Ceil(x);
                vec.y = (int)Mathematics.Math.Ceil(y);
                vec.z = (int)Mathematics.Math.Ceil(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the float raised to the power.
        /// </summary>
        /// <param name="power"></param>
        /// <returns></returns>
        public float3 Pow(float power)
        {
            float3 vec;
            vec.x = Mathematics.Math.Pow(x, power);
            vec.y = Mathematics.Math.Pow(y, power);
            vec.z = Mathematics.Math.Pow(z, power);
            return vec;
        }
        /// <summary>
        /// Do a smoothstep from vectors value.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public float3 SmoothStep(float3 b, float x)
        {
            float3 vec;
            vec.x = (x - this.x) / (b.x - this.x);
            vec.x = vec.x > 1f ? 1f : (vec.x < 0f ? 0f : vec.x);
            vec.x = vec.x * vec.x * (3f - 2f * vec.x);
            vec.y = (x - y) / (b.y - y);
            vec.y = vec.y > 1f ? 1f : (vec.y < 0f ? 0f : vec.y);
            vec.y = vec.y * vec.y * (3f - 2f * vec.y);
            vec.z = (x - z) / (b.z - z);
            vec.z = vec.z > 1f ? 1f : (vec.z < 0f ? 0f : vec.z);
            vec.z = vec.z * vec.z * (3f - 2f * vec.z);
            return vec;
        }
        /// <summary>
        /// Do a smoothstep from vectors value.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public float3 SmoothStep(float3 b, float3 x)
        {
            float3 vec;
            vec.x = (x.x - this.x) / (b.x - this.x);
            vec.x = vec.x > 1f ? 1f : (vec.x < 0f ? 0f : vec.x);
            vec.x = vec.x * vec.x * (3f - 2f * vec.x);
            vec.y = (x.y - y) / (b.y - y);
            vec.y = vec.y > 1f ? 1f : (vec.y < 0f ? 0f : vec.y);
            vec.y = vec.y * vec.y * (3f - 2f * vec.y);
            vec.z = (x.z - z) / (b.z - z);
            vec.z = vec.z > 1f ? 1f : (vec.z < 0f ? 0f : vec.z);
            vec.z = vec.z * vec.z * (3f - 2f * vec.z);
            return vec;
        }
        /// <summary>
        /// Return the square root of each component.
        /// </summary>
        [XmlIgnore]
        public float3 Sqrt
        {
            get
            {
                float3 vec;
                vec.x = Mathematics.Math.Sqrt(x);
                vec.y = Mathematics.Math.Sqrt(y);
                vec.z = Mathematics.Math.Sqrt(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the smallest integer greater to or equal to f
        /// </summary>
        [XmlIgnore]
        public float3 Ceil
        {
            get
            {
                float3 vec;
                vec.x = Mathematics.Math.Ceil(x);
                vec.y = Mathematics.Math.Ceil(y);
                vec.z = Mathematics.Math.Ceil(z);
                return vec;
            }
        }
        /// <summary>
        /// Returns a int3 that contains f rounded to the nearest integer.
        /// </summary>
        [XmlIgnore]
        public int3 RoundToInt
        {
            get
            {
                int3 vec;
                vec.x = (int)Mathematics.Math.Round(x);
                vec.y = (int)Mathematics.Math.Round(y);
                vec.z = (int)Mathematics.Math.Round(z);
                return vec;
            }
        }
        /// <summary>
        /// Return f rounded to the nearest integer
        /// </summary>
        [XmlIgnore]
        public float3 Round
        {
            get
            {
                float3 vec;
                vec.x = Mathematics.Math.Round(x);
                vec.y = Mathematics.Math.Round(y);
                vec.z = Mathematics.Math.Round(z);
                return vec;
            }
        }
        /// <summary>
        /// A step function returning 1 if a component is greater or equal to x, otherwise 0 is returned.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public float3 Step(float3 x)
        {
            float3 vec;
            vec.x = this.x >= x.x ? 1f : 0f;
            vec.y = y >= x.y ? 1f : 0f;
            vec.z = z >= x.z ? 1f : 0f;
            return vec;
        }
        /// <summary>
        /// Returns the fractional portion of each vector component.
        /// </summary>
        [XmlIgnore]
        public float3 Fract
        {
            get
            {
                float3 vec;
                vec.x = x - Mathematics.Math.Floor(x);
                vec.y = y - Mathematics.Math.Floor(y);
                vec.z = z - Mathematics.Math.Floor(z);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-e exponential of each component.
        /// </summary>
        [XmlIgnore]
        public float3 Exp
        {
            get
            {
                float3 vec;
                vec.x = Mathematics.Math.Exp(x);
                vec.y = Mathematics.Math.Exp(y);
                vec.z = Mathematics.Math.Exp(z);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-2 exponential of each component.
        /// </summary>
        [XmlIgnore]
        public float3 Exp2
        {
            get
            {
                float3 vec;
                vec.x = Mathematics.Math.Exp(x * 0.69314718f);
                vec.y = Mathematics.Math.Exp(y * 0.69314718f);
                vec.z = Mathematics.Math.Exp(z * 0.69314718f);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-10 exponential of each component.
        /// </summary>
        [XmlIgnore]
        public float3 Exp10
        {
            get
            {
                float3 vec;
                vec.x = Mathematics.Math.Exp(x * 2.30258509f);
                vec.y = Mathematics.Math.Exp(y * 2.30258509f);
                vec.z = Mathematics.Math.Exp(z * 2.30258509f);
                return vec;
            }
        }
        /// <summary>
        /// Returns the natural logarithm of each component.
        /// </summary>
        [XmlIgnore]
        public float3 Ln
        {
            get
            {
                float3 vec;
                vec.x = Mathematics.Math.Ln(x);
                vec.y = Mathematics.Math.Ln(y);
                vec.z = Mathematics.Math.Ln(z);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-2 logarithm of each component.
        /// </summary>
        [XmlIgnore]
        public float3 Log2
        {
            get
            {
                float3 vec;
                vec.x = Mathematics.Math.Log(x, 2f);
                vec.y = Mathematics.Math.Log(y, 2f);
                vec.z = Mathematics.Math.Log(z, 2f);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-10 logarithm of each component.
        /// </summary>
        [XmlIgnore]
        public float3 Log10
        {
            get
            {
                float3 vec;
                vec.x = Mathematics.Math.Log(x);
                vec.y = Mathematics.Math.Log(y);
                vec.z = Mathematics.Math.Log(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the sign of each component.
        /// </summary>
        [XmlIgnore]
        public float3 Sign
        {
            get
            {
                float3 vec;
                vec.x = x < 0f ? -1f : 1f;
                vec.y = y < 0f ? -1f : 1f;
                vec.z = z < 0f ? -1f : 1f;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(0, 0, 0).
        /// </summary>
        [XmlIgnore]
        public static float3 Zero
        {
            get
            {
                float3 vec;
                vec.x = 0f;
                vec.y = 0f;
                vec.z = 0f;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(0.5, 0.5, 0.5).
        /// </summary>
        [XmlIgnore]
        public static float3 Half
        {
            get
            {
                float3 vec;
                vec.x = 0.5f;
                vec.y = 0.5f;
                vec.z = 0.5f;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(1, 1, 1).
        /// </summary>
        [XmlIgnore]
        public static float3 One
        {
            get
            {
                float3 vec;
                vec.x = 1f;
                vec.y = 1f;
                vec.z = 1f;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(0, 0, 1).
        /// </summary>
        [XmlIgnore]
        public static float3 Forward
        {
            get
            {
                float3 vec;
                vec.x = 0f;
                vec.y = 0f;
                vec.z = 1f;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(0, 0, -1).
        /// </summary>
        [XmlIgnore]
        public static float3 Back
        {
            get
            {
                float3 vec;
                vec.x = 0f;
                vec.y = 0f;
                vec.z = -1f;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(0, 1, 0).
        /// </summary>
        [XmlIgnore]
        public static float3 Up
        {
            get
            {
                float3 vec;
                vec.x = 0f;
                vec.y = 1f;
                vec.z = 0f;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(0, -1, 0).
        /// </summary>
        [XmlIgnore]
        public static float3 Down
        {
            get
            {
                float3 vec;
                vec.x = 0f;
                vec.y = -1f;
                vec.z = 0f;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(-1, 0, 0).
        /// </summary>
        [XmlIgnore]
        public static float3 Left
        {
            get
            {
                float3 vec;
                vec.x = -1f;
                vec.y = 0f;
                vec.z = 0f;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(1, 0, 0).
        /// </summary>
        [XmlIgnore]
        public static float3 Right
        {
            get
            {
                float3 vec;
                vec.x = 1f;
                vec.y = 0f;
                vec.z = 0f;
                return vec;
            }
        }
        /// <summary>
        /// Return true if the distance between 2 points in less than the desired distance
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public static bool CompareDistance(float3 a, float3 b, float distance)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z < distance * distance;
        }
        /// <summary>
        /// Return true if the distance between 2 points in less than the desired distance
        /// </summary>
        /// <param name="b"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public bool CompareDistance(float3 b, float distance)
        {
            return x * b.x + y * b.y + z * b.z < distance * distance;
        }
        /// <summary>
        /// Shorthand for writing Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity).
        /// </summary>
        [XmlIgnore]
        public static float3 PositiveInfinity
        {
            get
            {
                float3 vec;
                vec.x = float.PositiveInfinity;
                vec.y = float.PositiveInfinity;
                vec.z = float.PositiveInfinity;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity).
        /// </summary>
        [XmlIgnore]
        public static float3 NegativeInfinity
        {
            get
            {
                float3 vec;
                vec.x = float.NegativeInfinity;
                vec.y = float.NegativeInfinity;
                vec.z = float.NegativeInfinity;
                return vec;
            }
        }
        /// <summary>
        /// Freeze the position of desired component of the vector to 0.
        /// </summary>
        /// <param name="freezeAxis"></param>
        /// <returns></returns>
        public float3 FreezeVector(bool3 freezeAxis)
        {
            float3 vec;
            vec.x = freezeAxis.x ? 0f : x;
            vec.y = freezeAxis.y ? 0f : y;
            vec.z = freezeAxis.z ? 0f : z;
            return vec;
        }
        /// <summary>
        /// Return the refraction vector from the incident vector i, the normal vector n and the refraction index.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="n"></param>
        /// <param name="refractionIndex"></param>
        /// <returns></returns>
        public static float3 Refract(float3 i, float3 n, float refractionIndex)
        {
            float dt = n.x * i.x + n.y * i.y + n.z * i.z;
            float k = 1f - refractionIndex * refractionIndex * (1f - dt * dt);
            if (k >= 0f)
            {
                k = Mathematics.Math.Sqrt(k);
                n.x = refractionIndex * i.x - (refractionIndex * dt + k) * n.x;
                n.y = refractionIndex * i.y - (refractionIndex * dt + k) * n.y;
                n.z = refractionIndex * i.z - (refractionIndex * dt + k) * n.z;
                return n;
            }
            n.x = 0f;
            n.y = 0f;
            n.z = 0f;
            return n;
        }
        /// <summary>
        /// Return the refraction vector from the incident vector, the normal vector n and the refraction index.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="indexRegraction"></param>
        /// <returns></returns>
        public float3 Refract(float3 n, float refractionIndex)
        {
            float dt = n.x * x + n.y * y + n.z * z;
            float k = 1f - refractionIndex * refractionIndex * (1f - dt * dt);
            if (k >= 0f)
            {
                k = Mathematics.Math.Sqrt(k);
                n.x = refractionIndex * x - (refractionIndex * dt + k) * n.x;
                n.y = refractionIndex * y - (refractionIndex * dt + k) * n.y;
                n.z = refractionIndex * z - (refractionIndex * dt + k) * n.z;
                return n;
            }
            n.x = 0f;
            n.y = 0f;
            n.z = 0f;
            return n;
        }
        /// <summary>
        /// Remap the value of the vector from the old value to the new one.
        /// </summary>
        /// <param name="minOldValue"></param>
        /// <param name="maxOldValue"></param>
        /// <param name="minNewValue"></param>
        /// <param name="maxNewValue"></param>
        /// <returns></returns>
        public float3 Remap(float minOldValue, float maxOldValue, float minNewValue, float maxNewValue)
        {
            maxOldValue = maxOldValue - minOldValue;
            maxNewValue = maxNewValue - minNewValue;
            float3 vec;
            vec.x = minNewValue + (x - minOldValue) * maxNewValue / maxOldValue;
            vec.y = minNewValue + (y - minOldValue) * maxNewValue / maxOldValue;
            vec.z = minNewValue + (z - minOldValue) * maxNewValue / maxOldValue;
            return vec;
        }
        /// <summary>
        /// Remap the value of the vector from the old value to the new one.
        /// </summary>
        /// <param name="minOldValue"></param>
        /// <param name="maxOldValue"></param>
        /// <param name="minNewValue"></param>
        /// <param name="maxNewValue"></param>
        /// <returns></returns>
        public float3 Remap(float3 minOldValue, float3 maxOldValue, float3 minNewValue, float3 maxNewValue)
        {
            float3 vec;
            vec.x = minNewValue.x + (x - minOldValue.x) * (maxNewValue.x - minNewValue.x) / (maxOldValue.x - minOldValue.x);
            vec.y = minNewValue.y + (y - minOldValue.y) * (maxNewValue.y - minNewValue.y) / (maxOldValue.y - minOldValue.y);
            vec.z = minNewValue.z + (z - minOldValue.z) * (maxNewValue.z - minNewValue.z) / (maxOldValue.z - minOldValue.z);
            return vec;
        }
        /// <summary>
        /// Return the nearest point on a line from a desired point position.
        /// </summary>
        /// <param name="lineOrigin"></param>
        /// <param name="lineDirection"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        public static float3 NearestPointOnLine(float3 lineOrigin, float3 lineDirection, float3 point)
        {
            float length = Mathematics.Math.Sqrt(lineDirection.x * lineDirection.x + lineDirection.y * lineDirection.y + lineDirection.z * lineDirection.z);
            if (length > 0.000001f)
            {
                lineDirection.x = lineDirection.x / length;
                lineDirection.y = lineDirection.y / length;
                lineDirection.z = lineDirection.z / length;
            }
            else
            {
                lineDirection.x = 0f;
                lineDirection.y = 0f;
                lineDirection.z = 0f;
            }
            point = point - lineOrigin;
            float dot = point.x * lineDirection.x + point.y * lineDirection.y + point.z * lineDirection.z;
            dot = dot > length ? length : dot < 0f ? 0f : dot;
            return lineOrigin + lineDirection * dot;
        }
        /// <summary>
        /// Returns a nicely formatted string for this vector.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("({0:F1}, {1:F1}, {2:F1})", x, y, z);
        }
        public static float3 operator +(float3 a, float3 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            return a;
        }
        public static float3 operator +(float3 a, float2 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            return a;
        }
        public static float3 operator +(float2 a, float3 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            return b;
        }
        public static float3 operator +(float3 a, float b)
        {
            a.x = a.x + b;
            a.y = a.y + b;
            a.z = a.z + b;
            return a;
        }
        public static float3 operator +(float a, float3 b)
        {
            b.x = a + b.x;
            b.y = a + b.y;
            b.z = a + b.z;
            return b;
        }
        public static float3 operator -(float3 a, float3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return a;
        }
        public static float3 operator -(float3 a, float2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a;
        }
        public static float3 operator -(float2 a, float3 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            return b;
        }
        public static float3 operator -(float3 a, float b)
        {
            a.x = a.x - b;
            a.y = a.y - b;
            a.z = a.z - b;
            return a;
        }
        public static float3 operator -(float a, float3 b)
        {
            b.x = a - b.x;
            b.y = a - b.y;
            b.z = a - b.z;
            return b;
        }
        public static float3 operator *(float3 a, float3 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            return a;
        }
        public static float3 operator *(float3 a, float2 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            return a;
        }
        public static float3 operator *(float2 a, float3 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            return b;
        }
        public static float3 operator *(float3 a, float b)
        {
            a.x = a.x * b;
            a.y = a.y * b;
            a.z = a.z * b;
            return a;
        }
        public static float3 operator *(float a, float3 b)
        {
            b.x = a * b.x;
            b.y = a * b.y;
            b.z = a * b.z;
            return b;
        }
        public static float3 operator %(float3 a, float3 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            return a;
        }
        public static float3 operator %(float3 a, float2 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            return a;
        }
        public static float3 operator %(float2 a, float3 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            return b;
        }
        public static float3 operator %(float3 a, float b)
        {
            a.x = a.x % b;
            a.y = a.y % b;
            a.z = a.z % b;
            return a;
        }
        public static float3 operator %(float a, float3 b)
        {
            b.x = a % b.x;
            b.y = a % b.y;
            b.z = a % b.z;
            return b;
        }
        public static float3 operator /(float3 a, float3 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            return a;
        }
        public static float3 operator /(float3 a, float2 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            return a;
        }
        public static float3 operator /(float2 a, float3 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            return b;
        }
        public static float3 operator /(float3 a, float b)
        {
            a.x = a.x / b;
            a.y = a.y / b;
            a.z = a.z / b;
            return a;
        }
        public static float3 operator /(float a, float3 b)
        {
            b.x = a / b.x;
            b.y = a / b.y;
            b.z = a / b.z;
            return b;
        }
        public static float3 operator -(float3 a)
        {
            a.x = -a.x;
            a.y = -a.y;
            a.z = -a.z;
            return a;
        }
        public static implicit operator double3(float3 v)
        {
            double3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            return vec;
        }
        public static implicit operator double2(float3 v)
        {
            double2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static explicit operator float2(float3 v)
        {
            float2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static implicit operator double4(float3 v)
        {
            double4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            vec.w = 0d;
            return vec;
        }
        public static implicit operator float4(float3 v)
        {
            float4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            vec.w = 0f;
            return vec;
        }
        public static implicit operator int2(float3 v)
        {
            int2 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            return vec;
        }
        public static explicit operator int3(float3 v)
        {
            int3 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            vec.z = (int)v.z;
            return vec;
        }
        public static explicit operator bool2(float3 v)
        {
            bool2 vec;
            vec.x = v.x > 0f;
            vec.y = v.y > 0f;
            return vec;
        }
        public static explicit operator bool3(float3 v)
        {
            bool3 vec;
            vec.x = v.x > 0f;
            vec.y = v.y > 0f;
            vec.z = v.z > 0f;
            return vec;
        }
        public static explicit operator bool4(float3 v)
        {
            bool4 vec;
            vec.x = v.x > 0f;
            vec.y = v.y > 0f;
            vec.z = v.z > 0f;
            vec.w = false;
            return vec;
        }
        public static explicit operator int4(float3 v)
        {
            int4 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            vec.z = (int)v.z;
            vec.w = 0;
            return vec;
        }
        public static bool operator ==(float3 a, float3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return a.x * a.x + a.y * a.y + a.z * a.z < 0.0000000001f;
        }
        public static bool operator !=(float3 a, float3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return a.x * a.x + a.y * a.y + a.z * a.z >= 0.0000000001f;
        }
    }
}
