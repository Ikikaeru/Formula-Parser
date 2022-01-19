using System;
using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    [Serializable]
    public partial struct float4 : IEquatable<float4>
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
        /// W component of the vector.
        /// </summary>
        public float w;
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
        /// <summary>
        /// W component of the vector.
        /// </summary>
        [XmlIgnore]
        public float a
        {
            get
            {
                return w;
            }
            set
            {
                w = value;
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
        public float2 xw
        {
            get
            {
                float2 vec;
                vec.x = x;
                vec.y = w;
                return vec;
            }
            set
            {
                x = value.x;
                w = value.y;
            }
        }
        [XmlIgnore]
        public float2 ra
        {
            get
            {
                float2 vec;
                vec.x = x;
                vec.y = w;
                return vec;
            }
            set
            {
                x = value.x;
                w = value.y;
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
        public float2 yw
        {
            get
            {
                float2 vec;
                vec.x = y;
                vec.y = w;
                return vec;
            }
            set
            {
                y = value.x;
                w = value.y;
            }
        }
        [XmlIgnore]
        public float2 ga
        {
            get
            {
                float2 vec;
                vec.x = y;
                vec.y = w;
                return vec;
            }
            set
            {
                y = value.x;
                w = value.y;
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
        public float2 zw
        {
            get
            {
                float2 vec;
                vec.x = z;
                vec.y = w;
                return vec;
            }
            set
            {
                z = value.x;
                w = value.y;
            }
        }
        [XmlIgnore]
        public float2 ba
        {
            get
            {
                float2 vec;
                vec.x = z;
                vec.y = w;
                return vec;
            }
            set
            {
                z = value.x;
                w = value.y;
            }
        }
        [XmlIgnore]
        public float2 wx
        {
            get
            {
                float2 vec;
                vec.x = w;
                vec.y = x;
                return vec;
            }
            set
            {
                w = value.x;
                x = value.y;
            }
        }
        [XmlIgnore]
        public float2 ar
        {
            get
            {
                float2 vec;
                vec.x = w;
                vec.y = x;
                return vec;
            }
            set
            {
                w = value.x;
                x = value.y;
            }
        }
        [XmlIgnore]
        public float2 wy
        {
            get
            {
                float2 vec;
                vec.x = w;
                vec.y = y;
                return vec;
            }
            set
            {
                w = value.x;
                y = value.y;
            }
        }
        [XmlIgnore]
        public float2 ag
        {
            get
            {
                float2 vec;
                vec.x = w;
                vec.y = y;
                return vec;
            }
            set
            {
                w = value.x;
                y = value.y;
            }
        }
        [XmlIgnore]
        public float2 wz
        {
            get
            {
                float2 vec;
                vec.x = w;
                vec.y = z;
                return vec;
            }
            set
            {
                w = value.x;
                z = value.y;
            }
        }
        [XmlIgnore]
        public float2 ab
        {
            get
            {
                float2 vec;
                vec.x = w;
                vec.y = z;
                return vec;
            }
            set
            {
                w = value.x;
                z = value.y;
            }
        }
        [XmlIgnore]
        public float2 ww
        {
            get
            {
                float2 vec;
                vec.x = w;
                vec.y = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float2 aa
        {
            get
            {
                float2 vec;
                vec.x = w;
                vec.y = w;
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
        public float3 xxw
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 rra
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
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
        public float3 xyw
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                return vec;
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
            }
        }
        [XmlIgnore]
        public float3 rga
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                return vec;
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
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
        public float3 xzw
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                return vec;
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }
        [XmlIgnore]
        public float3 rba
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                return vec;
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }
        [XmlIgnore]
        public float3 xwx
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 rar
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 xwy
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                return vec;
            }
            set
            {
                x = value.x;
                w = value.y;
                y = value.z;
            }
        }
        [XmlIgnore]
        public float3 rag
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                return vec;
            }
            set
            {
                x = value.x;
                w = value.y;
                y = value.z;
            }
        }
        [XmlIgnore]
        public float3 xwz
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                return vec;
            }
            set
            {
                x = value.x;
                w = value.y;
                z = value.z;
            }
        }
        [XmlIgnore]
        public float3 rab
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                return vec;
            }
            set
            {
                x = value.x;
                w = value.y;
                z = value.z;
            }
        }
        [XmlIgnore]
        public float3 xww
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 raa
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
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
        public float3 yxw
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                return vec;
            }
            set
            {
                y = value.x;
                x = value.y;
                w = value.z;
            }
        }
        [XmlIgnore]
        public float3 gra
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                return vec;
            }
            set
            {
                y = value.x;
                x = value.y;
                w = value.z;
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
        public float3 yyw
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 gga
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
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
        public float3 yzw
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                return vec;
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }
        [XmlIgnore]
        public float3 gba
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                return vec;
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }
        [XmlIgnore]
        public float3 ywx
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                return vec;
            }
            set
            {
                y = value.x;
                w = value.y;
                x = value.z;
            }
        }
        [XmlIgnore]
        public float3 gar
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                return vec;
            }
            set
            {
                y = value.x;
                w = value.y;
                x = value.z;
            }
        }
        [XmlIgnore]
        public float3 ywy
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 gag
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 ywz
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                return vec;
            }
            set
            {
                y = value.x;
                w = value.y;
                z = value.z;
            }
        }
        [XmlIgnore]
        public float3 gab
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                return vec;
            }
            set
            {
                y = value.x;
                w = value.y;
                z = value.z;
            }
        }
        [XmlIgnore]
        public float3 yww
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 gaa
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
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
        public float3 zxw
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                return vec;
            }
            set
            {
                z = value.x;
                x = value.y;
                w = value.z;
            }
        }
        [XmlIgnore]
        public float3 bra
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                return vec;
            }
            set
            {
                z = value.x;
                x = value.y;
                w = value.z;
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
        public float3 zyw
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                return vec;
            }
            set
            {
                z = value.x;
                y = value.y;
                w = value.z;
            }
        }
        [XmlIgnore]
        public float3 bga
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                return vec;
            }
            set
            {
                z = value.x;
                y = value.y;
                w = value.z;
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
        public float3 zzw
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 bba
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 zwx
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                return vec;
            }
            set
            {
                z = value.x;
                w = value.y;
                x = value.z;
            }
        }
        [XmlIgnore]
        public float3 bar
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                return vec;
            }
            set
            {
                z = value.x;
                w = value.y;
                x = value.z;
            }
        }
        [XmlIgnore]
        public float3 zwy
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                return vec;
            }
            set
            {
                z = value.x;
                w = value.y;
                y = value.z;
            }
        }
        [XmlIgnore]
        public float3 bag
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                return vec;
            }
            set
            {
                z = value.x;
                w = value.y;
                y = value.z;
            }
        }
        [XmlIgnore]
        public float3 zwz
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 bab
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 zww
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 baa
        {
            get
            {
                float3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 wxx
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 arr
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 wxy
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                return vec;
            }
            set
            {
                w = value.x;
                x = value.y;
                y = value.z;
            }
        }
        [XmlIgnore]
        public float3 arg
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                return vec;
            }
            set
            {
                w = value.x;
                x = value.y;
                y = value.z;
            }
        }
        [XmlIgnore]
        public float3 wxz
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                return vec;
            }
            set
            {
                w = value.x;
                x = value.y;
                z = value.z;
            }
        }
        [XmlIgnore]
        public float3 arb
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                return vec;
            }
            set
            {
                w = value.x;
                x = value.y;
                z = value.z;
            }
        }
        [XmlIgnore]
        public float3 wxw
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 ara
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 wyx
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                return vec;
            }
            set
            {
                w = value.x;
                y = value.y;
                x = value.z;
            }
        }
        [XmlIgnore]
        public float3 agr
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                return vec;
            }
            set
            {
                w = value.x;
                y = value.y;
                x = value.z;
            }
        }
        [XmlIgnore]
        public float3 wyy
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 agg
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 wyz
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                return vec;
            }
            set
            {
                w = value.x;
                y = value.y;
                z = value.z;
            }
        }
        [XmlIgnore]
        public float3 agb
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                return vec;
            }
            set
            {
                w = value.x;
                y = value.y;
                z = value.z;
            }
        }
        [XmlIgnore]
        public float3 wyw
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 aga
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 wzx
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                return vec;
            }
            set
            {
                w = value.x;
                z = value.y;
                x = value.z;
            }
        }
        [XmlIgnore]
        public float3 abr
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                return vec;
            }
            set
            {
                w = value.x;
                z = value.y;
                x = value.z;
            }
        }
        [XmlIgnore]
        public float3 wzy
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                return vec;
            }
            set
            {
                w = value.x;
                z = value.y;
                y = value.z;
            }
        }
        [XmlIgnore]
        public float3 abg
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                return vec;
            }
            set
            {
                w = value.x;
                z = value.y;
                y = value.z;
            }
        }
        [XmlIgnore]
        public float3 wzz
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 abb
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 wzw
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 aba
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 wwx
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 aar
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 wwy
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 aag
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 wwz
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 aab
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 www
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 aaa
        {
            get
            {
                float3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
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
        public float4 xxxw
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rrra
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = w;
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
        public float4 xxyw
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rrga
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = w;
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
        public float4 xxzw
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rrba
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xxwx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rrar
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xxwy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rrag
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xxwz
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rrab
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xxww
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rraa
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = w;
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
        public float4 xyxw
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rgra
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = w;
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
        public float4 xyyw
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rgga
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = w;
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
        public float4 xyzw
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        [XmlIgnore]
        public float4 rgba
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        [XmlIgnore]
        public float4 xywx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rgar
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xywy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rgag
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xywz
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
                z = value.w;
            }
        }
        [XmlIgnore]
        public float4 rgab
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
                z = value.w;
            }
        }
        [XmlIgnore]
        public float4 xyww
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rgaa
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = w;
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
        public float4 xzxw
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rbra
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = w;
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
        public float4 xzyw
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
                w = value.w;
            }
        }
        [XmlIgnore]
        public float4 rbga
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
                w = value.w;
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
        public float4 xzzw
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rbba
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xzwx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rbar
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xzwy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
                y = value.w;
            }
        }
        [XmlIgnore]
        public float4 rbag
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
                y = value.w;
            }
        }
        [XmlIgnore]
        public float4 xzwz
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rbab
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xzww
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rbaa
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xwxx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rarr
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xwxy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rarg
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xwxz
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rarb
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xwxw
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rara
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xwyx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ragr
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xwyy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ragg
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xwyz
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
            set
            {
                x = value.x;
                w = value.y;
                y = value.z;
                z = value.w;
            }
        }
        [XmlIgnore]
        public float4 ragb
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
            set
            {
                x = value.x;
                w = value.y;
                y = value.z;
                z = value.w;
            }
        }
        [XmlIgnore]
        public float4 xwyw
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 raga
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xwzx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rabr
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xwzy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
            set
            {
                x = value.x;
                w = value.y;
                z = value.z;
                y = value.w;
            }
        }
        [XmlIgnore]
        public float4 rabg
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
            set
            {
                x = value.x;
                w = value.y;
                z = value.z;
                y = value.w;
            }
        }
        [XmlIgnore]
        public float4 xwzz
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 rabb
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xwzw
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 raba
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xwwx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 raar
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xwwy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 raag
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xwwz
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 raab
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xwww
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 raaa
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = w;
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
        public float4 yxxw
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 grra
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = w;
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
        public float4 yxyw
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 grga
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = w;
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
        public float4 yxzw
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
                w = value.w;
            }
        }
        [XmlIgnore]
        public float4 grba
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
                w = value.w;
            }
        }
        [XmlIgnore]
        public float4 yxwx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 grar
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yxwy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 grag
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yxwz
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
            set
            {
                y = value.x;
                x = value.y;
                w = value.z;
                z = value.w;
            }
        }
        [XmlIgnore]
        public float4 grab
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
            set
            {
                y = value.x;
                x = value.y;
                w = value.z;
                z = value.w;
            }
        }
        [XmlIgnore]
        public float4 yxww
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 graa
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = w;
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
        public float4 yyxw
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ggra
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = w;
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
        public float4 yyyw
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ggga
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = w;
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
        public float4 yyzw
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ggba
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yywx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ggar
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yywy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ggag
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yywz
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ggab
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yyww
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ggaa
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = w;
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
        public float4 yzxw
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
                w = value.w;
            }
        }
        [XmlIgnore]
        public float4 gbra
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
                w = value.w;
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
        public float4 yzyw
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gbga
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = w;
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
        public float4 yzzw
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gbba
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yzwx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
                x = value.w;
            }
        }
        [XmlIgnore]
        public float4 gbar
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
                x = value.w;
            }
        }
        [XmlIgnore]
        public float4 yzwy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gbag
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yzwz
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gbab
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yzww
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gbaa
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ywxx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 garr
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ywxy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 garg
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ywxz
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
            set
            {
                y = value.x;
                w = value.y;
                x = value.z;
                z = value.w;
            }
        }
        [XmlIgnore]
        public float4 garb
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
            set
            {
                y = value.x;
                w = value.y;
                x = value.z;
                z = value.w;
            }
        }
        [XmlIgnore]
        public float4 ywxw
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gara
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ywyx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gagr
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ywyy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gagg
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ywyz
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gagb
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ywyw
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gaga
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ywzx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
            set
            {
                y = value.x;
                w = value.y;
                z = value.z;
                x = value.w;
            }
        }
        [XmlIgnore]
        public float4 gabr
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
            set
            {
                y = value.x;
                w = value.y;
                z = value.z;
                x = value.w;
            }
        }
        [XmlIgnore]
        public float4 ywzy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gabg
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ywzz
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gabb
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ywzw
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gaba
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ywwx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gaar
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ywwy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gaag
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ywwz
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gaab
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 ywww
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 gaaa
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = w;
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
        public float4 zxxw
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 brra
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = w;
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
        public float4 zxyw
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
                w = value.w;
            }
        }
        [XmlIgnore]
        public float4 brga
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
                w = value.w;
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
        public float4 zxzw
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 brba
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zxwx
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 brar
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zxwy
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
            set
            {
                z = value.x;
                x = value.y;
                w = value.z;
                y = value.w;
            }
        }
        [XmlIgnore]
        public float4 brag
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
            set
            {
                z = value.x;
                x = value.y;
                w = value.z;
                y = value.w;
            }
        }
        [XmlIgnore]
        public float4 zxwz
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 brab
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zxww
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 braa
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = w;
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
        public float4 zyxw
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
                w = value.w;
            }
        }
        [XmlIgnore]
        public float4 bgra
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
                w = value.w;
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
        public float4 zyyw
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bgga
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = w;
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
        public float4 zyzw
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bgba
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zywx
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
            set
            {
                z = value.x;
                y = value.y;
                w = value.z;
                x = value.w;
            }
        }
        [XmlIgnore]
        public float4 bgar
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
            set
            {
                z = value.x;
                y = value.y;
                w = value.z;
                x = value.w;
            }
        }
        [XmlIgnore]
        public float4 zywy
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bgag
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zywz
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bgab
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zyww
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bgaa
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = w;
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
        public float4 zzxw
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bbra
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = w;
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
        public float4 zzyw
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bbga
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = w;
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
        [XmlIgnore]
        public float4 zzzw
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bbba
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zzwx
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bbar
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zzwy
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bbag
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zzwz
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bbab
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zzww
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bbaa
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zwxx
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 barr
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zwxy
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
            set
            {
                z = value.x;
                w = value.y;
                x = value.z;
                y = value.w;
            }
        }
        [XmlIgnore]
        public float4 barg
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
            set
            {
                z = value.x;
                w = value.y;
                x = value.z;
                y = value.w;
            }
        }
        [XmlIgnore]
        public float4 zwxz
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 barb
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zwxw
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bara
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zwyx
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
            set
            {
                z = value.x;
                w = value.y;
                y = value.z;
                x = value.w;
            }
        }
        [XmlIgnore]
        public float4 bagr
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
            set
            {
                z = value.x;
                w = value.y;
                y = value.z;
                x = value.w;
            }
        }
        [XmlIgnore]
        public float4 zwyy
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bagg
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zwyz
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 bagb
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zwyw
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 baga
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zwzx
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 babr
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zwzy
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 babg
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zwzz
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 babb
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zwzw
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 baba
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zwwx
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 baar
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zwwy
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 baag
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zwwz
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 baab
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 zwww
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 baaa
        {
            get
            {
                float4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wxxx
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 arrr
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wxxy
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 arrg
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wxxz
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 arrb
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wxxw
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 arra
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wxyx
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 argr
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wxyy
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 argg
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wxyz
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
            set
            {
                w = value.x;
                x = value.y;
                y = value.z;
                z = value.w;
            }
        }
        [XmlIgnore]
        public float4 argb
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
            set
            {
                w = value.x;
                x = value.y;
                y = value.z;
                z = value.w;
            }
        }
        [XmlIgnore]
        public float4 wxyw
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 arga
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wxzx
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 arbr
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wxzy
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
            set
            {
                w = value.x;
                x = value.y;
                z = value.z;
                y = value.w;
            }
        }
        [XmlIgnore]
        public float4 arbg
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
            set
            {
                w = value.x;
                x = value.y;
                z = value.z;
                y = value.w;
            }
        }
        [XmlIgnore]
        public float4 wxzz
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 arbb
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wxzw
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 arba
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wxwx
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 arar
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wxwy
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 arag
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wxwz
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 arab
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wxww
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 araa
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wyxx
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 agrr
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wyxy
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 agrg
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wyxz
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
            set
            {
                w = value.x;
                y = value.y;
                x = value.z;
                z = value.w;
            }
        }
        [XmlIgnore]
        public float4 agrb
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
            set
            {
                w = value.x;
                y = value.y;
                x = value.z;
                z = value.w;
            }
        }
        [XmlIgnore]
        public float4 wyxw
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 agra
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wyyx
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aggr
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wyyy
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aggg
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wyyz
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aggb
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wyyw
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 agga
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wyzx
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
            set
            {
                w = value.x;
                y = value.y;
                z = value.z;
                x = value.w;
            }
        }
        [XmlIgnore]
        public float4 agbr
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
            set
            {
                w = value.x;
                y = value.y;
                z = value.z;
                x = value.w;
            }
        }
        [XmlIgnore]
        public float4 wyzy
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 agbg
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wyzz
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 agbb
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wyzw
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 agba
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wywx
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 agar
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wywy
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 agag
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wywz
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 agab
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wyww
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 agaa
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wzxx
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 abrr
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wzxy
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
            set
            {
                w = value.x;
                z = value.y;
                x = value.z;
                y = value.w;
            }
        }
        [XmlIgnore]
        public float4 abrg
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
            set
            {
                w = value.x;
                z = value.y;
                x = value.z;
                y = value.w;
            }
        }
        [XmlIgnore]
        public float4 wzxz
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 abrb
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wzxw
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 abra
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wzyx
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
            set
            {
                w = value.x;
                z = value.y;
                y = value.z;
                x = value.w;
            }
        }
        [XmlIgnore]
        public float4 abgr
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
            set
            {
                w = value.x;
                z = value.y;
                y = value.z;
                x = value.w;
            }
        }
        [XmlIgnore]
        public float4 wzyy
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 abgg
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wzyz
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 abgb
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wzyw
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 abga
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wzzx
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 abbr
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wzzy
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 abbg
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wzzz
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 abbb
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wzzw
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 abba
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wzwx
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 abar
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wzwy
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 abag
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wzwz
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 abab
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wzww
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 abaa
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wwxx
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aarr
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wwxy
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aarg
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wwxz
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aarb
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wwxw
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aara
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wwyx
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aagr
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wwyy
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aagg
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wwyz
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aagb
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wwyw
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aaga
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wwzx
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aabr
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wwzy
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aabg
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wwzz
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aabb
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wwzw
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aaba
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wwwx
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aaar
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wwwy
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aaag
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wwwz
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aaab
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 wwww
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 aaaa
        {
            get
            {
                float4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        /// <summary>
        /// Access the x, y, z, w components using [0], [1], [2], [3] respectively.
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
                    case 3: return w;
                    default:
                        throw new IndexOutOfRangeException("Invalid float4 index!");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    case 2: z = value; break;
                    case 3: w = value; break;
                    default:
                        throw new IndexOutOfRangeException("Invalid float4 index!");
                }
            }
        }
        /// <summary>
        /// Creates a new vector with given x, y, z, w components.
        /// </summary>
        /// <param name="xyzw"></param>
        public float4(float xyzw)
        {
            x = xyzw;
            y = xyzw;
            z = xyzw;
            w = xyzw;
        }
        /// <summary>
        /// Creates a new vector with given x, y, z, w components.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public float4(float x, float y, float z = 0f, float w = 0f)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        /// <summary>
        /// Creates a new vector with given xyz float3 and w float components.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="w"></param>
        public float4(float3 a, float w = 0f)
        {
            x = a.x;
            y = a.y;
            z = a.z;
            this.w = w;
        }
        /// <summary>
        /// Creates a new vector with given x float, float2 yz and w float components.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="a"></param>
        /// <param name="w"></param>
        public float4(float x, float2 a, float w = 0f)
        {
            this.x = x;
            y = a.x;
            z = a.y;
            this.w = w;
        }
        /// <summary>
        /// Creates a new vector with given xy float2, z and w float components.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public float4(float2 a, float z = 0f, float w = 0f)
        {
            x = a.x;
            y = a.y;
            this.z = z;
            this.w = w;
        }
        /// <summary>
        /// Creates a new vector with given x float and yzw float3 components.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="b"></param>
        public float4(float x, float3 b)
        {
            this.x = x;
            y = b.x;
            z = b.y;
            w = b.z;
        }
        /// <summary>
        /// Creates a new vector with given xy and zw float2 components.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public float4(float2 a, float2 b)
        {
            x = a.x;
            y = a.y;
            z = b.x;
            w = b.y;
        }
        /// <summary>
        /// Set x, y, z and w components of an existing Vector4.
        /// </summary>
        /// <param name="newX"></param>
        /// <param name="newY"></param>
        /// <param name="newZ"></param>
        /// <param name="newW"></param>
        public void Set(float newX, float newY, float newZ, float newW)
        {
            x = newX;
            y = newY;
            z = newZ;
            w = newW;
        }
        /// <summary>
        /// Linearly interpolates between two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float4 Lerp(float4 a, float4 b, float t)
        {
            t = t < 0f ? 0f : t > 1f ? 1f : t;
            a.x = a.x + (b.x - a.x) * t;
            a.y = a.y + (b.y - a.y) * t;
            a.z = a.z + (b.z - a.z) * t;
            a.w = a.w + (b.w - a.w) * t;
            return a;
        }
        /// <summary>
        /// Lineary interpolates between two vectors and normalize the result.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float4 Nlerp(float4 a, float4 b, float t)
        {
            t = t < 0f ? 0f : t > 1f ? 1f : t;
            a.x = a.x + (b.x - a.x) * t;
            a.y = a.y + (b.y - a.y) * t;
            a.z = a.z + (b.z - a.z) * t;
            a.w = a.w + (b.w - a.w) * t;
            float mag = (float)Mathematics.Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z + a.w * a.w);
            if (mag > 0.00001f)
            {
                a.x = a.x / mag;
                a.y = a.y / mag;
                a.z = a.z / mag;
                a.w = a.w / mag;
            }
            else
            {
                a.x = 0f;
                a.y = 0f;
                a.z = 0f;
                a.w = 0f;
            }
            return a;
        }
        /// <summary>
        /// Lineary interpolates between two vectors and normalize the result.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float4 Nlerp(float4 b, float t)
        {
            t = t < 0f ? 0f : t > 1f ? 1f : t;
            b.x = x + (b.x - x) * t;
            b.y = y + (b.y - y) * t;
            b.z = z + (b.z - z) * t;
            b.w = w + (b.w - w) * t;
            float mag = (float)Mathematics.Math.Sqrt(b.x * b.x + b.y * b.y + b.z * b.z + b.w * b.w);
            if (mag > 0.00001f)
            {
                b.x = b.x / mag;
                b.y = b.y / mag;
                b.z = b.z / mag;
                b.w = b.w / mag;
            }
            else
            {
                b.x = 0f;
                b.y = 0f;
                b.z = 0f;
                b.w = 0f;
            }
            return b;
        }
        /// <summary>
        /// Return the float raised to the power.
        /// </summary>
        /// <param name="power"></param>
        /// <returns></returns>
        public float4 Pow(float power)
        {
            float4 vec;
            vec.x = (float)Mathematics.Math.Pow(x, power);
            vec.y = (float)Mathematics.Math.Pow(y, power);
            vec.z = (float)Mathematics.Math.Pow(z, power);
            vec.w = (float)Mathematics.Math.Pow(w, power);
            return vec;
        }
        /// <summary>
        /// Return the float raised to the power.
        /// </summary>
        /// <param name="power"></param>
        /// <returns></returns>
        public float4 Pow(float4 power)
        {
            float4 vec;
            vec.x = (float)Mathematics.Math.Pow(x, power.x);
            vec.y = (float)Mathematics.Math.Pow(y, power.y);
            vec.z = (float)Mathematics.Math.Pow(z, power.z);
            vec.w = (float)Mathematics.Math.Pow(w, power.w);
            return vec;
        }
        /// <summary>
        /// Reflects a vector off the plane defined by a normal.
        /// </summary>
        /// <param name="inNormal"></param>
        /// <returns></returns>
        public float4 Reflect(float4 inNormal)
        {
            float dotNorm = inNormal.x * x + inNormal.y * y + inNormal.z * z + inNormal.w * w;
            inNormal.x = -2f * dotNorm * inNormal.x + x;
            inNormal.y = -2f * dotNorm * inNormal.y + y;
            inNormal.z = -2f * dotNorm * inNormal.z + z;
            inNormal.w = -2f * dotNorm * inNormal.w + w;
            return inNormal;
        }
        /// <summary>
        /// Check if a target vector is in the range of this position.
        /// </summary>
        /// <param name="targetPosition">Position of the target</param>
        /// <param name="rangeDistance">Detecting range</param>
        /// <returns></returns>
        public bool IsInRange(float4 targetPosition, float rangeDistance)
        {
            targetPosition.x = targetPosition.x - x;
            targetPosition.y = targetPosition.y - y;
            targetPosition.z = targetPosition.z - z;
            targetPosition.w = targetPosition.w - w;
            return targetPosition.x * targetPosition.x + targetPosition.y * targetPosition.y + targetPosition.z * targetPosition.z + targetPosition.w * targetPosition.w < rangeDistance * rangeDistance;
        }
        /// <summary>
        /// Returns the direction of b from a.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float4 Direction(float4 a, float4 b)
        {
            float4 dir;
            dir.x = b.x - a.x;
            dir.y = b.y - a.y;
            dir.z = b.z - a.z;
            dir.w = b.w - a.w;
            float mag = (float)Mathematics.Math.Sqrt(dir.x * dir.x + dir.y * dir.y + dir.z * dir.z + dir.w * dir.w);
            if (mag > 0.00001f)
            {
                dir.x = dir.x / mag;
                dir.y = dir.y / mag;
                dir.z = dir.z / mag;
                dir.w = dir.w / mag;
                return dir;
            }
            dir.x = 0f;
            dir.y = 0f;
            dir.z = 0f;
            dir.w = 0f;
            return dir;
        }
        /// <summary>
        /// Return if both vectors are opposed to each other.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsOppositeDirection(float4 b)
        {
            return x * b.x + y * b.y + z * b.z + w * b.w < 0f;
        }
        /// <summary>
        /// Return if both vectors are perpendicular to each other.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsPerpendicular(float4 b)
        {
            return x * b.x + y * b.y + z * b.z + w * b.w == 0f;
        }
        /// <summary>
        /// Return if botch vectors are in the same direction.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsSimilarDirection(float4 b)
        {
            return x * b.x + y * b.y + z * b.z + w * b.w > 0f;
        }
        /// <summary>
        /// Returns a int4 that contains the largest integer smaller to or equal to f.
        /// </summary>
        [XmlIgnore]
        public int4 FloorToInt
        {
            get
            {
                int4 vec;
                vec.x = (int)x;
                vec.y = (int)y;
                vec.z = (int)z;
                vec.w = (int)w;
                return vec;
            }
        }
        /// <summary>
        /// Returns a int4 that contains the smallest integer greater to or equal to f.
        /// </summary>
        [XmlIgnore]
        public int4 CeilToInt
        {
            get
            {
                int4 vec;
                vec.x = (int)Mathematics.Math.Ceil(x);
                vec.y = (int)Mathematics.Math.Ceil(y);
                vec.z = (int)Mathematics.Math.Ceil(z);
                vec.w = (int)Mathematics.Math.Ceil(w);
                return vec;
            }
        }
        /// <summary>
        /// Lineary interpolates between two vectors and normalize the result.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float4 NlerpUnclamped(float4 a, float4 b, float t)
        {
            a.x = a.x + (b.x - a.x) * t;
            a.y = a.y + (b.y - a.y) * t;
            a.z = a.z + (b.z - a.z) * t;
            a.w = a.w + (b.w - a.w) * t;
            float mag = Mathematics.Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z + a.w * a.w);
            if (mag > 0.00001f)
            {
                a.x = a.x / mag;
                a.y = a.y / mag;
                a.z = a.z / mag;
                a.w = a.w / mag;
            }
            else
            {
                a.x = 0f;
                a.y = 0f;
                a.z = 0f;
                a.w = 0f;
            }
            return a;
        }
        /// <summary>
        /// Lineary interpolates between two vectors and normalize the result.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float4 NlerpUnclamped(float4 b, float t)
        {
            b.x = x + (b.x - x) * t;
            b.y = y + (b.y - y) * t;
            b.z = z + (b.z - z) * t;
            b.w = w + (b.w - w) * t;
            float mag = Mathematics.Math.Sqrt(b.x * b.x + b.y * b.y + b.z * b.z + b.w * b.w);
            if (mag > 0.00001f)
            {
                b.x = b.x / mag;
                b.y = b.y / mag;
                b.z = b.z / mag;
                b.w = b.w / mag;
            }
            else
            {
                b.x = 0f;
                b.y = 0f;
                b.z = 0f;
                b.w = 0f;
            }
            return b;
        }
        /// <summary>
        /// Normalize a value t to a range a - b. The opposite of lerp.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float4 Unlerp(float4 a, float4 b, float t)
        {
            t = t < 0f ? 0f : t > 1f ? 1f : t;
            a.x = (t - a.x) / (b.x - a.x);
            a.y = (t - a.y) / (b.y - a.y);
            a.z = (t - a.z) / (b.z - a.z);
            a.w = (t - a.w) / (b.w - a.w);
            return a;
        }
        /// <summary>
        /// Normalize a value t to a range a - b. The opposite of lerp.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float4 Unlerp(float4 b, float t)
        {
            t = t < 0f ? 0f : t > 1f ? 1f : t;
            b.x = (t - x) / (b.x - x);
            b.y = (t - y) / (b.y - y);
            b.z = (t - z) / (b.z - z);
            b.w = (t - w) / (b.w - w);
            return b;
        }
        /// <summary>
        /// Lerp a value between a and c, using b as the bezier between a and c.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static float4 QuadraticBezier(float4 a, float4 b, float4 c, float t)
        {
            t = t > 1f ? 1f : t < 0f ? 0f : t;
            float oneMinusT = 1f - t;
            a.x = oneMinusT * oneMinusT * a.x + 2f * oneMinusT * t * b.x + t * t * c.x;
            a.y = oneMinusT * oneMinusT * a.y + 2f * oneMinusT * t * b.y + t * t * c.y;
            a.z = oneMinusT * oneMinusT * a.z + 2f * oneMinusT * t * b.z + t * t * c.z;
            a.w = oneMinusT * oneMinusT * a.w + 2f * oneMinusT * t * b.w + t * t * c.w;
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
        public static float4 QuadraticBezierTangent(float4 a, float4 b, float4 c, float t)
        {
            t = t > 1f ? 1f : t < 0f ? 0f : t;
            a.x = 2f * (1f - t) * (b.x - a.x) + 2f * t * (c.x - b.x);
            a.y = 2f * (1f - t) * (b.y - a.y) + 2f * t * (c.y - b.y);
            a.z = 2f * (1f - t) * (b.z - a.z) + 2f * t * (c.z - b.z);
            a.w = 2f * (1f - t) * (b.w - a.w) + 2f * t * (c.w - b.w);
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
        public static float4 CubicBezier(float4 a, float4 b, float4 c, float4 d, float t)
        {
            t = t > 1f ? 1f : t < 0f ? 0f : t;
            float oneMinusT = 1f - t;
            float oneMinusTPow2 = oneMinusT * oneMinusT;
            float t2 = t * t;
            a.x = oneMinusTPow2 * oneMinusT * a.x + 3f * oneMinusTPow2 * t * b.x + 3f * oneMinusT * t2 * c.x + t2 * t * d.x;
            a.y = oneMinusTPow2 * oneMinusT * a.y + 3f * oneMinusTPow2 * t * b.y + 3f * oneMinusT * t2 * c.y + t2 * t * d.y;
            a.z = oneMinusTPow2 * oneMinusT * a.z + 3f * oneMinusTPow2 * t * b.z + 3f * oneMinusT * t2 * c.z + t2 * t * d.z;
            a.w = oneMinusTPow2 * oneMinusT * a.w + 3f * oneMinusTPow2 * t * b.w + 3f * oneMinusT * t2 * c.w + t2 * t * d.w;
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
        public static float4 CubicBezierTrangent(float4 a, float4 b, float4 c, float4 d, float t)
        {
            t = t > 1f ? 1f : t < 0f ? 0f : t;
            float oneMinusT = 1f - t;
            a.x = 3f * oneMinusT * oneMinusT * (b.x - a.x) + 6f * oneMinusT * t * (c.x - b.x) + 3f * t * t * (d.x - c.x);
            a.y = 3f * oneMinusT * oneMinusT * (b.y - a.y) + 6f * oneMinusT * t * (c.y - b.y) + 3f * t * t * (d.y - c.y);
            a.z = 3f * oneMinusT * oneMinusT * (b.z - a.z) + 6f * oneMinusT * t * (c.z - b.z) + 3f * t * t * (d.z - c.z);
            a.w = 3f * oneMinusT * oneMinusT * (b.w - a.w) + 6f * oneMinusT * t * (c.w - b.w) + 3f * t * t * (d.w - c.w);
            return a;
        }
        /// <summary>
        /// Linearly interpolates between two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float4 LerpUnclamped(float4 a, float4 b, float t)
        {
            a.x = a.x + (b.x - a.x) * t;
            a.y = a.y + (b.y - a.y) * t;
            a.z = a.z + (b.z - a.z) * t;
            a.w = a.w + (b.w - a.w) * t;
            return a;
        }
        /// <summary>
        /// Normalize a value t to a range a - b. The opposite of lerp.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float4 UnlerpUnclamped(float4 a, float4 b, float t)
        {
            a.x = (t - a.x) / (b.x - a.x);
            a.y = (t - a.y) / (b.y - a.y);
            a.z = (t - a.z) / (b.z - a.z);
            a.w = (t - a.w) / (b.w - a.w);
            return a;
        }
        /// <summary>
        /// Normalize a value t to a range a - b. The opposite of lerp.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float4 UnlerpUnclamped(float4 b, float t)
        {
            b.x = (t - x) / (b.x - x);
            b.y = (t - y) / (b.y - y);
            b.z = (t - z) / (b.z - z);
            b.w = (t - w) / (b.w - w);
            return b;
        }
        /// <summary>
        /// Lerp a value between a and c, using b as the bezier between a and c.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static float4 QuadraticBezierUnclamped(float4 a, float4 b, float4 c, float t)
        {
            float oneMinusT = 1f - t;
            a.x = oneMinusT * oneMinusT * a.x + 2f * oneMinusT * t * b.x + t * t * c.x;
            a.y = oneMinusT * oneMinusT * a.y + 2f * oneMinusT * t * b.y + t * t * c.y;
            a.z = oneMinusT * oneMinusT * a.z + 2f * oneMinusT * t * b.z + t * t * c.z;
            a.w = oneMinusT * oneMinusT * a.w + 2f * oneMinusT * t * b.w + t * t * c.w;
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
        public static float4 QuadraticBezierTangentUnclamped(float4 a, float4 b, float4 c, float t)
        {
            a.x = 2f * (1f - t) * (b.x - a.x) + 2f * t * (c.x - b.x);
            a.y = 2f * (1f - t) * (b.y - a.y) + 2f * t * (c.y - b.y);
            a.z = 2f * (1f - t) * (b.z - a.z) + 2f * t * (c.z - b.z);
            a.w = 2f * (1f - t) * (b.w - a.w) + 2f * t * (c.w - b.w);
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
        public static float4 CubicBezierUnclamped(float4 a, float4 b, float4 c, float4 d, float t)
        {
            float oneMinusT = 1f - t;
            float oneMinusTPow2 = oneMinusT * oneMinusT;
            float t2 = t * t;
            a.x = oneMinusTPow2 * oneMinusT * a.x + 3f * oneMinusTPow2 * t * b.x + 3f * oneMinusT * t2 * c.x + t2 * t * d.x;
            a.y = oneMinusTPow2 * oneMinusT * a.y + 3f * oneMinusTPow2 * t * b.y + 3f * oneMinusT * t2 * c.y + t2 * t * d.y;
            a.z = oneMinusTPow2 * oneMinusT * a.z + 3f * oneMinusTPow2 * t * b.z + 3f * oneMinusT * t2 * c.z + t2 * t * d.z;
            a.w = oneMinusTPow2 * oneMinusT * a.w + 3f * oneMinusTPow2 * t * b.w + 3f * oneMinusT * t2 * c.w + t2 * t * d.w;
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
        public static float4 CubicBezierTrangentUnclamped(float4 a, float4 b, float4 c, float4 d, float t)
        {
            float oneMinusT = 1f - t;
            a.x = 3f * oneMinusT * oneMinusT * (b.x - a.x) + 6f * oneMinusT * t * (c.x - b.x) + 3f * t * t * (d.x - c.x);
            a.y = 3f * oneMinusT * oneMinusT * (b.y - a.y) + 6f * oneMinusT * t * (c.y - b.y) + 3f * t * t * (d.y - c.y);
            a.z = 3f * oneMinusT * oneMinusT * (b.z - a.z) + 6f * oneMinusT * t * (c.z - b.z) + 3f * t * t * (d.z - c.z);
            a.w = 3f * oneMinusT * oneMinusT * (b.w - a.w) + 6f * oneMinusT * t * (c.w - b.w) + 3f * t * t * (d.w - c.w);
            return a;
        }
        /// <summary>
        /// Moves a point current towards target.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="target"></param>
        /// <param name="maxDistanceDelta"></param>
        /// <returns></returns>
        public static float4 MoveTowards(float4 current, float4 target, float maxDistanceDelta)
        {
            float toVectorx = target.x - current.x;
            float toVectory = target.y - current.y;
            float toVectorz = target.z - current.z;
            float toVectorw = target.w - current.w;
            float dist = Mathematics.Math.Sqrt(toVectorx * toVectorx + toVectory * toVectory + toVectorz * toVectorz + toVectorw * toVectorw);
            if (dist <= maxDistanceDelta || dist == 0)
            {
                return target;
            }
            current.x = current.x + toVectorx / dist * maxDistanceDelta;
            current.y = current.y + toVectory / dist * maxDistanceDelta;
            current.z = current.z + toVectorz / dist * maxDistanceDelta;
            current.w = current.w + toVectorw / dist * maxDistanceDelta;
            return current;
        }
        /// <summary>
        /// Moves a point current towards target.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="maxDistanceDelta"></param>
        /// <returns></returns>
        public float4 MoveTowards(float4 target, float maxDistanceDelta)
        {
            float toVectorx = target.x - x;
            float toVectory = target.y - y;
            float toVectorz = target.z - z;
            float toVectorw = target.w - w;
            float dist = Mathematics.Math.Sqrt(toVectorx * toVectorx + toVectory * toVectory + toVectorz * toVectorz + toVectorw * toVectorw);
            if (dist <= maxDistanceDelta || dist == 0)
            {
                return target;
            }
            target.x = x + toVectorx / dist * maxDistanceDelta;
            target.y = y + toVectory / dist * maxDistanceDelta;
            target.z = z + toVectorz / dist * maxDistanceDelta;
            target.w = w + toVectorw / dist * maxDistanceDelta;
            return target;
        }
        public override int GetHashCode()
        {
            return x.GetHashCode() ^ (y.GetHashCode() << 2) ^ (z.GetHashCode() >> 2) ^ (w.GetHashCode() >> 1);
        }
        /// <summary>
        /// Returns true if the given vector is exactly equal to this vector.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            if (!(other is float4))
            {
                return false;
            }
            return Equals((float4)other);
        }
        /// <summary>
        /// Returns true if the given vector is exactly equal to this vector.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(float4 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z) && w.Equals(other.w);
        }
        /// <summary>
        /// Makes this vector have a magnitude of 1.
        /// </summary>
        public void Normalize()
        {
            float mag = Mathematics.Math.Sqrt(x * x + y * y + z * z + w * w);
            if (mag > 0.00001f)
            {
                x = x / mag;
                y = y / mag;
                z = z / mag;
                w = w / mag;
            }
            else
            {
                x = 0f;
                y = 0f;
                z = 0f;
                w = 0f;
            }
        }
        /// <summary>
        /// Returns this vector with a magnitude of 1 (Read Only).
        /// </summary>
        [XmlIgnore]
        public float4 Normalized
        {
            get
            {
                float4 a;
                float mag = Mathematics.Math.Sqrt(x * x + y * y + z * z + w * w);
                if (mag > 0.00001f)
                {
                    a.x = x / mag;
                    a.y = y / mag;
                    a.z = z / mag;
                    a.w = w / mag;
                    return a;
                }
                a.x = 0f;
                a.y = 0f;
                a.z = 0f;
                a.w = 0f;
                return a;
            }
        }
        /// <summary>
        /// Dot Product of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float Dot(float4 a, float4 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
        }
        /// <summary>
        /// Dot product clamped in the range [-1;1] corresponding to the cosine of the angle of directions.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float DotClamped(float4 a, float4 b)
        {
            float dot_ab = a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
            if (dot_ab < 1e-15f && dot_ab > -1e-15f)
            {
                return dot_ab;
            }
            return dot_ab / Mathematics.Math.Sqrt((a.x * a.x + a.y * a.y + a.z * a.z + a.w * a.w) * (b.x * b.x + b.y * b.y + b.z * b.z + b.w * b.w));
        }
        /// <summary>
        /// Dot product clamped in the range [-1;1] corresponding to the cosine of the angle of directions.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public float DotClamped(float4 b)
        {
            float dot_ab = x * b.x + y * b.y + z * b.z + w * b.w;
            if (dot_ab < 1e-15f && dot_ab > -1e-15f)
            {
                return dot_ab;
            }
            return dot_ab / Mathematics.Math.Sqrt((x * x + y * y + z * z + w * w) * (b.x * b.x + b.y * b.y + b.z * b.z + b.w * b.w));
        }
        /// <summary>
        /// Projects a vector onto another vector.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float4 Project(float4 a, float4 b)
        {
            float dotDot = (a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w) / (b.x * b.x + b.y * b.y + b.z * b.z + b.w * b.w);
            b.x = b.x * dotDot;
            b.y = b.y * dotDot;
            b.z = b.z * dotDot;
            b.w = b.w * dotDot;
            return b;
        }
        /// <summary>
        /// Returns the distance between a and b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float Distance(float4 a, float4 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            a.w = a.w - b.w;
            return Mathematics.Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z + a.w * a.w);
        }
        /// <summary>
        /// Returns the length of this vector (Read Only).
        /// </summary>
        [XmlIgnore]
        public float Magnitude
        {
            get
            {
                return Mathematics.Math.Sqrt(x * x + y * y + z * z + w * w);
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
                return x * x + y * y + z * z + w * w;
            }
        }
        /// <summary>
        /// Returns a vector that is made from the smallest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float4 Min(float4 a, float4 b)
        {
            a.x = a.x > b.x ? b.x : a.x;
            a.y = a.y > b.y ? b.y : a.y;
            a.z = a.z > b.z ? b.z : a.z;
            a.w = a.w > b.w ? b.w : a.w;
            return a;
        }
        /// <summary>
        /// Returns a vector that is made from the largest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float4 Max(float4 a, float4 b)
        {
            a.x = a.x > b.x ? a.x : b.x;
            a.y = a.y > b.y ? a.y : b.y;
            a.z = a.z > b.z ? a.z : b.z;
            a.w = a.w > b.w ? a.w : b.w;
            return a;
        }
        /// <summary>
        /// Returns the signed angle in degrees between from and to.
        /// </summary>
        /// <param name="to"></param>
        /// <param name="axis"></param>
        /// <returns></returns>
        public float SignedAngle(float4 to, float4 axis)
        {
            float unsignedAngle;
            float denominator = Mathematics.Math.Sqrt((x * x + y * y + z * z + w * w) * (to.x * to.x + to.y * to.y + to.z * to.z + to.w * to.w));
            if (denominator < 1e-15f)
            {
                unsignedAngle = 0f;
            }
            else
            {
                float val = (x * to.x + y * to.y + z * to.z + w * to.w) / denominator;
                unsignedAngle = (float)System.Math.Acos(val < -1f ? -1f : val > 1f ? 1f : val) * 57.2957795131f;
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
        public float DotProductAngle(float4 target)
        {
            float4 normThis = Normalized;
            target.Normalize();
            normThis.x = normThis.x * target.x + normThis.y * target.y + normThis.z * target.z + normThis.w * target.w;
            normThis.x = normThis.x > 1f ? 1f : normThis.x < -1f ? -1f : normThis.x;
            return (float)System.Math.Acos(normThis.x);
        }
        /// <summary>
        /// Returns the angle in degrees between from and to.
        /// </summary>
        /// <param name="to"></param>
        /// <returns></returns>
        public float AngleBetweenDirections(float4 to)
        {
            float denominator = Mathematics.Math.Sqrt((x * x + y * y + z * z + w * w) * (to.x * to.x + to.y * to.y + to.z * to.z + to.w * to.w));
            if (denominator < 1e-15f)
            {
                return 0f;
            }
            to.x = (x * to.x + y * to.y + z * to.z + w * to.w) / denominator;
            return (float)System.Math.Acos(to.x < -1f ? -1f : to.x > 1f ? 1f : to.x) * 57.2957795131f;
        }
        /// <summary>
        /// Return true if the distance between 2 points in less than the desired distance
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public static bool CompareDistance(float4 a, float4 b, float distance)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w < distance * distance;
        }
        /// <summary>
        /// Return true if the distance between 2 points in less than the desired distance
        /// </summary>
        /// <param name="b"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public bool CompareDistance(float4 b, float distance)
        {
            return x * b.x + y * b.y + z * b.z + w * b.w < distance * distance;
        }
        /// <summary>
        /// Return the sign of each component.
        /// </summary>
        [XmlIgnore]
        public float4 Sign
        {
            get
            {
                float4 vec;
                vec.x = x < 0f ? -x : x;
                vec.y = y < 0f ? -y : y;
                vec.z = z < 0f ? -z : z;
                vec.w = w < 0f ? -w : w;
                return vec;
            }
        }
        /// <summary>
        /// Return the sinus of each component.
        /// </summary>
        [XmlIgnore]
        public float4 Sin
        {
            get
            {
                float4 vec;
                vec.x = (float)System.Math.Sin(x);
                vec.y = (float)System.Math.Sin(y);
                vec.z = (float)System.Math.Sin(z);
                vec.w = (float)System.Math.Sin(w);
                return vec;
            }
        }
        /// <summary>
        /// Return the cosine of each component.
        /// </summary>
        [XmlIgnore]
        public float4 Cos
        {
            get
            {
                float4 vec;
                vec.x = (float)System.Math.Cos(x);
                vec.y = (float)System.Math.Cos(y);
                vec.z = (float)System.Math.Cos(z);
                vec.w = (float)System.Math.Cos(w);
                return vec;
            }
        }
        /// <summary>
        /// Return the tangent of each component.
        /// </summary>
        [XmlIgnore]
        public float4 Tan
        {
            get
            {
                float4 vec;
                vec.x = (float)System.Math.Tan(x);
                vec.y = (float)System.Math.Tan(y);
                vec.z = (float)System.Math.Tan(z);
                vec.w = (float)System.Math.Tan(w);
                return vec;
            }
        }
        /// <summary>
        /// Return the hyperbolic sinus of each component.
        /// </summary>
        [XmlIgnore]
        public float4 Sinh
        {
            get
            {
                float4 vec;
                vec.x = (float)System.Math.Sinh(x);
                vec.y = (float)System.Math.Sinh(y);
                vec.z = (float)System.Math.Sinh(z);
                vec.w = (float)System.Math.Sinh(w);
                return vec;
            }
        }
        /// <summary>
        /// Return the hyperbolic cosine of each component.
        /// </summary>
        [XmlIgnore]
        public float4 Cosh
        {
            get
            {
                float4 vec;
                vec.x = (float)System.Math.Cosh(x);
                vec.y = (float)System.Math.Cosh(y);
                vec.z = (float)System.Math.Cosh(z);
                vec.w = (float)System.Math.Cosh(w);
                return vec;
            }
        }
        /// <summary>
        /// Return the hyperbolic tangent of each component.
        /// </summary>
        [XmlIgnore]
        public float4 Tanh
        {
            get
            {
                float4 vec;
                vec.x = (float)System.Math.Tanh(x);
                vec.y = (float)System.Math.Tanh(y);
                vec.z = (float)System.Math.Tanh(z);
                vec.w = (float)System.Math.Tanh(w);
                return vec;
            }
        }
        /// <summary>
        /// Return the arc sinus of each component.
        /// </summary>
        [XmlIgnore]
        public float4 Asin
        {
            get
            {
                float4 vec;
                vec.x = (float)System.Math.Asin(x);
                vec.y = (float)System.Math.Asin(y);
                vec.z = (float)System.Math.Asin(z);
                vec.w = (float)System.Math.Asin(w);
                return vec;
            }
        }
        /// <summary>
        /// Return the arc cosine of each component.
        /// </summary>
        [XmlIgnore]
        public float4 Acos
        {
            get
            {
                float4 vec;
                vec.x = (float)System.Math.Acos(x);
                vec.y = (float)System.Math.Acos(y);
                vec.z = (float)System.Math.Acos(z);
                vec.w = (float)System.Math.Acos(w);
                return vec;
            }
        }
        /// <summary>
        /// Return the arc tangent of each component.
        /// </summary>
        [XmlIgnore]
        public float4 Atan
        {
            get
            {
                float4 vec;
                vec.x = (float)System.Math.Atan(x);
                vec.y = (float)System.Math.Atan(y);
                vec.z = (float)System.Math.Atan(z);
                vec.w = (float)System.Math.Atan(w);
                return vec;
            }
        }
        /// <summary>
        /// Clamp the vector between 0 and 1.
        /// </summary>
        [XmlIgnore]
        public float4 Saturate
        {
            get
            {
                float4 vec;
                vec.x = x < 0f ? 0f : x > 1f ? 1f : x;
                vec.y = y < 0f ? 0f : y > 1f ? 1f : y;
                vec.z = z < 0f ? 0f : z > 1f ? 1f : z;
                vec.w = w < 0f ? 0f : w > 1f ? 1f : w;
                return vec;
            }
        }
        /// <summary>
        /// Return the square root of each component.
        /// </summary>
        [XmlIgnore]
        public float4 Sqrt
        {
            get
            {
                float4 vec;
                vec.x = Mathematics.Math.Sqrt(x);
                vec.y = Mathematics.Math.Sqrt(y);
                vec.z = Mathematics.Math.Sqrt(z);
                vec.w = Mathematics.Math.Sqrt(w);
                return vec;
            }
        }
        /// <summary>
        /// Return f rounded to the nearest integer
        /// </summary>
        [XmlIgnore]
        public float4 Round
        {
            get
            {
                float4 vec;
                vec.x = Mathematics.Math.Round(x);
                vec.y = Mathematics.Math.Round(y);
                vec.z = Mathematics.Math.Round(z);
                vec.w = Mathematics.Math.Round(w);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-e exponential of each component.
        /// </summary>
        [XmlIgnore]
        public float4 Exp
        {
            get
            {
                float4 vec;
                vec.x = Mathematics.Math.Exp(x);
                vec.y = Mathematics.Math.Exp(y);
                vec.z = Mathematics.Math.Exp(z);
                vec.w = Mathematics.Math.Exp(w);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-2 exponential of each component.
        /// </summary>
        [XmlIgnore]
        public float4 Exp2
        {
            get
            {
                float4 vec;
                vec.x = Mathematics.Math.Exp(x * 0.69314718f);
                vec.y = Mathematics.Math.Exp(y * 0.69314718f);
                vec.z = Mathematics.Math.Exp(z * 0.69314718f);
                vec.w = Mathematics.Math.Exp(w * 0.69314718f);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-10 exponential of each component.
        /// </summary>
        [XmlIgnore]
        public float4 Exp10
        {
            get
            {
                float4 vec;
                vec.x = Mathematics.Math.Exp(x * 2.30258509f);
                vec.y = Mathematics.Math.Exp(y * 2.30258509f);
                vec.z = Mathematics.Math.Exp(z * 2.30258509f);
                vec.w = Mathematics.Math.Exp(w * 2.30258509f);
                return vec;
            }
        }
        /// <summary>
        /// Returns the natural logarithm of each component.
        /// </summary>
        [XmlIgnore]
        public float4 Ln
        {
            get
            {
                float4 vec;
                vec.x = Mathematics.Math.Ln(x);
                vec.y = Mathematics.Math.Ln(y);
                vec.z = Mathematics.Math.Ln(z);
                vec.w = Mathematics.Math.Ln(w);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-2 logarithm of each component.
        /// </summary>
        [XmlIgnore]
        public float4 Log2
        {
            get
            {
                float4 vec;
                vec.x = Mathematics.Math.Log(x, 2f);
                vec.y = Mathematics.Math.Log(y, 2f);
                vec.z = Mathematics.Math.Log(z, 2f);
                vec.w = Mathematics.Math.Log(w, 2f);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-10 logarithm of each component.
        /// </summary>
        [XmlIgnore]
        public float4 Log10
        {
            get
            {
                float4 vec;
                vec.x = Mathematics.Math.Log(x);
                vec.y = Mathematics.Math.Log(y);
                vec.z = Mathematics.Math.Log(z);
                vec.w = Mathematics.Math.Log(w);
                return vec;
            }
        }
        /// <summary>
        /// A step function returning 1 if a component is greater or equal to x, otherwise 0 is returned.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public float4 Step(float4 x)
        {
            float4 vec;
            vec.x = this.x >= x.x ? 1f : 0f;
            vec.y = y >= x.y ? 1f : 0f;
            vec.z = z >= x.z ? 1f : 0f;
            vec.w = w >= x.w ? 1f : 0f;
            return vec;
        }
        /// <summary>
        /// Return the smallest integer greater to or equal to f
        /// </summary>
        [XmlIgnore]
        public float4 Ceil
        {
            get
            {
                float4 vec;
                vec.x = Mathematics.Math.Ceil(x);
                vec.y = Mathematics.Math.Ceil(y);
                vec.z = Mathematics.Math.Ceil(z);
                vec.w = Mathematics.Math.Ceil(w);
                return vec;
            }
        }
        /// <summary>
        /// Returns a int4 that contains f rounded to the nearest integer.
        /// </summary>
        [XmlIgnore]
        public int4 RoundToInt
        {
            get
            {
                int4 vec;
                vec.x = (int)Mathematics.Math.Round(x);
                vec.y = (int)Mathematics.Math.Round(y);
                vec.z = (int)Mathematics.Math.Round(z);
                vec.w = (int)Mathematics.Math.Round(w);
                return vec;
            }
        }
        /// <summary>
        /// Return the largest integer smaller than or equal to this number.
        /// </summary>
        [XmlIgnore]
        public float4 Floor
        {
            get
            {
                float4 vec;
                vec.x = Mathematics.Math.Floor(x);
                vec.y = Mathematics.Math.Floor(y);
                vec.z = Mathematics.Math.Floor(z);
                vec.w = Mathematics.Math.Floor(w);
                return vec;
            }
        }
        /// <summary>
        /// Returns the fractional portion of each vector component.
        /// </summary>
        [XmlIgnore]
        public float4 Fract
        {
            get
            {
                float4 vec;
                vec.x = x - Mathematics.Math.Floor(x);
                vec.y = y - Mathematics.Math.Floor(y);
                vec.z = z - Mathematics.Math.Floor(z);
                vec.w = w - Mathematics.Math.Floor(w);
                return vec;
            }
        }
        /// <summary>
        /// Do a smoothstep from vectors value.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public float4 SmoothStep(float4 b, float4 x)
        {
            float4 vec;
            vec.x = (x.x - this.x) / (b.x - this.x);
            vec.x = vec.x > 1f ? 1f : (vec.x < 0f ? 0f : vec.x);
            vec.x = vec.x * vec.x * (3f - 2f * vec.x);
            vec.y = (x.y - y) / (b.y - y);
            vec.y = vec.y > 1f ? 1f : (vec.y < 0f ? 0f : vec.y);
            vec.y = vec.y * vec.y * (3f - 2f * vec.y);
            vec.z = (x.z - z) / (b.z - z);
            vec.z = vec.z > 1f ? 1f : (vec.z < 0f ? 0f : vec.z);
            vec.z = vec.z * vec.z * (3f - 2f * vec.z);
            vec.w = (x.w - w) / (b.w - w);
            vec.w = vec.w > 1f ? 1f : (vec.w < 0f ? 0f : vec.w);
            vec.w = vec.w * vec.w * (3f - 2f * vec.w);
            return vec;
        }
        /// <summary>
        /// Do a smoothstep from vectors value.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public float4 SmoothStep(float4 b, float x)
        {
            float4 vec;
            vec.x = (x - this.x) / (b.x - this.x);
            vec.x = vec.x > 1f ? 1f : (vec.x < 0f ? 0f : vec.x);
            vec.x = vec.x * vec.x * (3f - 2f * vec.x);
            vec.y = (x - y) / (b.y - y);
            vec.y = vec.y > 1f ? 1f : (vec.y < 0f ? 0f : vec.y);
            vec.y = vec.y * vec.y * (3f - 2f * vec.y);
            vec.z = (x - z) / (b.z - z);
            vec.z = vec.z > 1f ? 1f : (vec.z < 0f ? 0f : vec.z);
            vec.z = vec.z * vec.z * (3f - 2f * vec.z);
            vec.w = (x - w) / (b.w - w);
            vec.w = vec.w > 1f ? 1f : (vec.w < 0f ? 0f : vec.w);
            vec.w = vec.w * vec.w * (3f - 2f * vec.w);
            return vec;
        }
        /// <summary>
        /// Return the refraction vector from the incident vector, the normal vector n and the refraction index.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="indexRegraction"></param>
        /// <returns></returns>
        public float4 Refract(float4 n, float refractionIndex)
        {
            float dt = n.x * x + n.y * y + n.z * z + n.w * w;
            float k = 1f - refractionIndex * refractionIndex * (1f - dt * dt);
            if (k >= 0f)
            {
                k = Mathematics.Math.Sqrt(k);
                n.x = refractionIndex * x - (refractionIndex * dt + k) * n.x;
                n.y = refractionIndex * y - (refractionIndex * dt + k) * n.y;
                n.z = refractionIndex * z - (refractionIndex * dt + k) * n.z;
                n.w = refractionIndex * w - (refractionIndex * dt + k) * n.w;
                return n;
            }
            n.x = 0f;
            n.y = 0f;
            n.z = 0f;
            n.w = 0f;
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
        public float4 Remap(float minOldValue, float maxOldValue, float minNewValue, float maxNewValue)
        {
            maxOldValue = maxOldValue - minOldValue;
            maxNewValue = maxNewValue - minNewValue;
            float4 vec;
            vec.x = minNewValue + (x - minOldValue) * maxNewValue / maxOldValue;
            vec.y = minNewValue + (y - minOldValue) * maxNewValue / maxOldValue;
            vec.z = minNewValue + (z - minOldValue) * maxNewValue / maxOldValue;
            vec.w = minNewValue + (w - minOldValue) * maxNewValue / maxOldValue;
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
        public float4 Remap(float4 minOldValue, float4 maxOldValue, float4 minNewValue, float4 maxNewValue)
        {
            float4 vec;
            vec.x = minNewValue.x + (x - minOldValue.x) * (maxNewValue.x - minNewValue.x) / (maxOldValue.x - minOldValue.x);
            vec.y = minNewValue.y + (y - minOldValue.y) * (maxNewValue.y - minNewValue.y) / (maxOldValue.y - minOldValue.y);
            vec.z = minNewValue.z + (z - minOldValue.z) * (maxNewValue.z - minNewValue.z) / (maxOldValue.z - minOldValue.z);
            vec.w = minNewValue.w + (w - minOldValue.w) * (maxNewValue.w - minNewValue.w) / (maxOldValue.w - minOldValue.w);
            return vec;
        }
        /// <summary>
        /// Returns a vector that is made from the smallest components of two vectors.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public float4 Min(float4 b)
        {
            float4 vec;
            vec.x = x > b.x ? b.x : x;
            vec.y = y > b.y ? b.y : y;
            vec.z = z > b.z ? b.z : z;
            vec.w = w > b.z ? b.w : w;
            return vec;
        }
        /// <summary>
        /// Returns a vector that is made from the largest components of two vectors.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public float4 Max(float4 b)
        {
            float4 vec;
            vec.x = x > b.x ? x : b.x;
            vec.y = y > b.y ? y : b.y;
            vec.z = z > b.z ? z : b.z;
            vec.w = w > b.z ? w : b.w;
            return vec;
        }
        /// <summary>
        /// Returns this vector with absolute value of each component.
        /// </summary>
        [XmlIgnore]
        public float4 Abs
        {
            get
            {
                float4 vec;
                vec.x = x > 0f ? x : -x;
                vec.y = y > 0f ? y : -y;
                vec.z = z > 0f ? z : -z;
                vec.w = w > 0f ? w : -w;
                return vec;
            }
        }
        /// <summary>
        /// Lerp clamped between two vectors.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float4 Lerp(float4 b, float t)
        {
            t = t > 1f ? 1f : t < 0f ? 0f : t;
            b.x = x + (b.x - x) * t;
            b.y = y + (b.y - y) * t;
            b.z = z + (b.z - z) * t;
            b.w = w + (b.w - w) * t;
            return b;
        }
        /// <summary>
        /// Lerp unclamped between two vectors.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float4 LerpUnclamped(float4 b, float t)
        {
            b.x = x + (b.x - x) * t;
            b.y = y + (b.y - y) * t;
            b.z = z + (b.z - z) * t;
            b.w = w + (b.w - w) * t;
            return b;
        }
        /// <summary>
        /// Dot product of two vectors.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public float Dot(float4 b)
        {
            return x * b.x + y * b.y + z * b.z + w * b.w;
        }
        /// <summary>
        /// Clamp the vector between a min and a max value, then, return it.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public float4 Clamp(float min, float max)
        {
            float4 vec;
            vec.x = x > max ? max : x < min ? min : x;
            vec.y = y > max ? max : y < min ? min : y;
            vec.z = z > max ? max : z < min ? min : z;
            vec.w = w > max ? max : w < min ? min : w;
            return vec;
        }
        /// <summary>
        /// Clamp the vector between a min and a max vector value, then, return it.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public float4 Clamp(float4 min, float4 max)
        {
            float4 vec;
            vec.x = x > max.x ? max.x : x < min.x ? min.x : x;
            vec.y = y > max.y ? max.y : y < min.y ? min.y : y;
            vec.z = z > max.z ? max.z : z < min.z ? min.z : z;
            vec.w = w > max.w ? max.w : w < min.w ? min.w : w;
            return vec;
        }
        /// <summary>
        /// Return the direction of the targetted vector.
        /// </summary>
        /// <param name="targetPosition"></param>
        /// <returns></returns>
        public float4 Direction(float4 targetPosition)
        {
            targetPosition.x = targetPosition.x - x;
            targetPosition.y = targetPosition.y - y;
            targetPosition.z = targetPosition.z - z;
            targetPosition.w = targetPosition.w - w;
            float mag = Mathematics.Math.Sqrt(targetPosition.x * targetPosition.x + targetPosition.y * targetPosition.y + targetPosition.z * targetPosition.z + targetPosition.w * targetPosition.w);
            if(mag > 0.00001f)
            {
                targetPosition.x = targetPosition.x / mag;
                targetPosition.y = targetPosition.y / mag;
                targetPosition.z = targetPosition.z / mag;
                targetPosition.w = targetPosition.w / mag;
                return targetPosition;
            }
            targetPosition.x = 0f;
            targetPosition.y = 0f;
            targetPosition.z = 0f;
            targetPosition.w = 0f;
            return targetPosition;
        }
        /// <summary>
        /// Return the distance between two vectors.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public float Distance(float4 target)
        {
            target.x = x - target.x;
            target.y = y - target.y;
            target.z = z - target.z;
            target.w = w - target.w;
            return Mathematics.Math.Sqrt(target.x * target.x + target.y * target.y + target.z * target.z + target.w * target.w);
        }
        /// <summary>
        /// Projects a vector onto another vector.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public float4 Project(float4 b)
        {
            return b * (x * b.x + y * b.y + z * b.z + w * b.w) / (b.x * b.x + b.y * b.y + b.z * b.z + b.w * b.w);
        }
        /// <summary>
        /// Shortcut to write a vector full of 0.
        /// </summary>
        [XmlIgnore]
        public static float4 Zero
        {
            get
            {
                float4 vec;
                vec.x = 0f;
                vec.y = 0f;
                vec.z = 0f;
                vec.w = 0f;
                return vec;
            }
        }
        /// <summary>
        /// Shortcut to write a vector full of 1.
        /// </summary>
        [XmlIgnore]
        public static float4 One
        {
            get
            {
                float4 vec;
                vec.x = 1f;
                vec.y = 1f;
                vec.z = 1f;
                vec.w = 1f;
                return vec;
            }
        }
        /// <summary>
        /// Shortcut to write a vector full of positive infinity.
        /// </summary>
        [XmlIgnore]
        public static float4 PositiveInfinity
        {
            get
            {
                float4 vec;
                vec.x = float.PositiveInfinity;
                vec.y = float.PositiveInfinity;
                vec.z = float.PositiveInfinity;
                vec.w = float.PositiveInfinity;
                return vec;
            }
        }
        /// <summary>
        /// Shortcut to write a vector full of negative infinity.
        /// </summary>
        [XmlIgnore]
        public static float4 NegativeInfinity
        {
            get
            {
                float4 vec;
                vec.x = float.NegativeInfinity;
                vec.y = float.NegativeInfinity;
                vec.z = float.NegativeInfinity;
                vec.w = float.NegativeInfinity;
                return vec;
            }
        }
        public static float4 operator +(float4 a, float4 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            a.w = a.w + b.w;
            return a;
        }
        public static float4 operator +(float a, float4 b)
        {
            b.x = a + b.x;
            b.y = a + b.y;
            b.z = a + b.z;
            b.w = a + b.w;
            return b;
        }
        public static float4 operator +(float4 a, float b)
        {
            a.x = a.x + b;
            a.y = a.y + b;
            a.z = a.z + b;
            a.w = a.w + b;
            return a;
        }
        public static float4 operator +(float4 a, float3 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            return a;
        }
        public static float4 operator +(float3 a, float4 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            b.z = a.z + b.z;
            return b;
        }
        public static float4 operator +(float4 a, float2 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            return a;
        }
        public static float4 operator +(float2 a, float4 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            return b;
        }
        public static float4 operator -(float4 a, float4 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            a.w = a.w - b.w;
            return a;
        }
        public static float4 operator -(float a, float4 b)
        {
            b.x = a - b.x;
            b.y = a - b.y;
            b.z = a - b.z;
            b.w = a - b.w;
            return b;
        }
        public static float4 operator -(float4 a, float b)
        {
            a.x = a.x - b;
            a.y = a.y - b;
            a.z = a.z - b;
            a.w = a.w - b;
            return a;
        }
        public static float4 operator -(float4 a, float3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return a;
        }
        public static float4 operator -(float3 a, float4 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            b.z = a.z - b.z;
            return b;
        }
        public static float4 operator -(float4 a, float2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a;
        }
        public static float4 operator -(float2 a, float4 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            return b;
        }
        public static float4 operator *(float4 a, float4 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            a.w = a.w * b.w;
            return a;
        }
        public static float4 operator *(float a, float4 b)
        {
            b.x = a * b.x;
            b.y = a * b.y;
            b.z = a * b.z;
            b.w = a * b.w;
            return b;
        }
        public static float4 operator *(float4 a, float b)
        {
            a.x = a.x * b;
            a.y = a.y * b;
            a.z = a.z * b;
            a.w = a.w * b;
            return a;
        }
        public static float4 operator *(float4 a, float3 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            return a;
        }
        public static float4 operator *(float3 a, float4 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            b.z = a.z * b.z;
            return b;
        }
        public static float4 operator *(float4 a, float2 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            return a;
        }
        public static float4 operator *(float2 a, float4 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            return b;
        }
        public static float4 operator /(float4 a, float4 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            a.w = a.w / b.w;
            return a;
        }
        public static float4 operator /(float a, float4 b)
        {
            b.x = a / b.x;
            b.y = a / b.y;
            b.z = a / b.z;
            b.w = a / b.w;
            return b;
        }
        public static float4 operator /(float4 a, float b)
        {
            a.x = a.x / b;
            a.y = a.y / b;
            a.z = a.z / b;
            a.w = a.w / b;
            return a;
        }
        public static float4 operator /(float4 a, float3 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            return a;
        }
        public static float4 operator /(float3 a, float4 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            b.z = a.z / b.z;
            return b;
        }
        public static float4 operator /(float4 a, float2 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            return a;
        }
        public static float4 operator /(float2 a, float4 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            return b;
        }
        public static float4 operator %(float4 a, float4 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            a.w = a.w % b.w;
            return a;
        }
        public static float4 operator %(float a, float4 b)
        {
            b.x = a % b.x;
            b.y = a % b.y;
            b.z = a % b.z;
            b.w = a % b.w;
            return b;
        }
        public static float4 operator %(float4 a, float b)
        {
            a.x = a.x % b;
            a.y = a.y % b;
            a.z = a.z % b;
            a.w = a.w % b;
            return a;
        }
        public static float4 operator %(float4 a, float3 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            return a;
        }
        public static float4 operator %(float3 a, float4 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            b.z = a.z % b.z;
            return b;
        }
        public static float4 operator %(float4 a, float2 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            return a;
        }
        public static float4 operator %(float2 a, float4 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            return b;
        }
        public static float4 operator -(float4 a)
        {
            a.x = -a.x;
            a.y = -a.y;
            a.z = -a.z;
            a.w = -a.w;
            return a;
        }
        public static bool operator ==(float4 a, float4 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            a.w = a.w - b.w;
            return a.x * a.x + a.y * a.y + a.z * a.z + a.w * a.w < 0.0000000001f;
        }
        public static bool operator !=(float4 a, float4 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            a.w = a.w - b.w;
            return a.x * a.x + a.y * a.y + a.z * a.z + a.w * a.w >= 0.0000000001f;
        }
        public static explicit operator bool2(float4 v)
        {
            bool2 vec;
            vec.x = v.x > 0f;
            vec.y = v.y > 0f;
            return vec;
        }
        public static implicit operator double4(float4 v)
        {
            double4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            vec.w = v.w;
            return vec;
        }
        public static implicit operator double2(float4 v)
        {
            double2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static explicit operator double3(float4 v)
        {
            double3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            return vec;
        }
        public static explicit operator bool3(float4 v)
        {
            bool3 vec;
            vec.x = v.x > 0f;
            vec.y = v.y > 0f;
            vec.z = v.z > 0f;
            return vec;
        }
        public static explicit operator bool4(float4 v)
        {
            bool4 vec;
            vec.x = v.x > 0f;
            vec.y = v.y > 0f;
            vec.z = v.z > 0f;
            vec.w = v.w > 0f;
            return vec;
        }
        public static explicit operator float2(float4 v)
        {
            float2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static explicit operator float3(float4 v)
        {
            float3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            return vec;
        }
        public static explicit operator int2(float4 v)
        {
            int2 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            return vec;
        }
        public static explicit operator int3(float4 v)
        {
            int3 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            vec.z = (int)v.z;
            return vec;
        }
        public static explicit operator int4(float4 v)
        {
            int4 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            vec.z = (int)v.z;
            vec.w = (int)v.w;
            return vec;
        }
        /// <summary>
        /// Return the Vector4 formatted as a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("({0:F1}, {1:F1}, {2:F1}, {3:F1})", x, y, z, w);
        }
    }
}
