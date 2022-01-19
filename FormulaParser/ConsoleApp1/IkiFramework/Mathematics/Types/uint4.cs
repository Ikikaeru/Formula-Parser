using System;
using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    [Serializable]
    public partial struct uint4 : IEquatable<uint4>
    {
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
        /// W component of the vector.
        /// </summary>
        public uint w;
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
        /// <summary>
        /// W component of the vector.
        /// </summary>
        [XmlIgnore]
        public uint a
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
        public uint2 xw
        {
            get
            {
                uint2 vec;
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
        public uint2 ra
        {
            get
            {
                uint2 vec;
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
        public uint2 yw
        {
            get
            {
                uint2 vec;
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
        public uint2 ga
        {
            get
            {
                uint2 vec;
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
        public uint2 zw
        {
            get
            {
                uint2 vec;
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
        public uint2 ba
        {
            get
            {
                uint2 vec;
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
        public uint2 wx
        {
            get
            {
                uint2 vec;
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
        public uint2 ar
        {
            get
            {
                uint2 vec;
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
        public uint2 wy
        {
            get
            {
                uint2 vec;
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
        public uint2 ag
        {
            get
            {
                uint2 vec;
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
        public uint2 wz
        {
            get
            {
                uint2 vec;
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
        public uint2 ab
        {
            get
            {
                uint2 vec;
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
        public uint2 ww
        {
            get
            {
                uint2 vec;
                vec.x = w;
                vec.y = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint2 aa
        {
            get
            {
                uint2 vec;
                vec.x = w;
                vec.y = w;
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
        public uint3 xxw
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 rra
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
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
        public uint3 xyw
        {
            get
            {
                uint3 vec;
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
        public uint3 rga
        {
            get
            {
                uint3 vec;
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
        public uint3 xzw
        {
            get
            {
                uint3 vec;
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
        public uint3 rba
        {
            get
            {
                uint3 vec;
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
        public uint3 xwx
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 rar
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 xwy
        {
            get
            {
                uint3 vec;
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
        public uint3 rag
        {
            get
            {
                uint3 vec;
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
        public uint3 xwz
        {
            get
            {
                uint3 vec;
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
        public uint3 rab
        {
            get
            {
                uint3 vec;
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
        public uint3 xww
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 raa
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
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
        public uint3 yxw
        {
            get
            {
                uint3 vec;
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
        public uint3 gra
        {
            get
            {
                uint3 vec;
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
        public uint3 yyw
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 gga
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
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
        public uint3 yzw
        {
            get
            {
                uint3 vec;
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
        public uint3 gba
        {
            get
            {
                uint3 vec;
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
        public uint3 ywx
        {
            get
            {
                uint3 vec;
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
        public uint3 gar
        {
            get
            {
                uint3 vec;
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
        public uint3 ywy
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 gag
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 ywz
        {
            get
            {
                uint3 vec;
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
        public uint3 gab
        {
            get
            {
                uint3 vec;
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
        public uint3 yww
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 gaa
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
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
        public uint3 zxw
        {
            get
            {
                uint3 vec;
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
        public uint3 bra
        {
            get
            {
                uint3 vec;
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
        public uint3 zyw
        {
            get
            {
                uint3 vec;
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
        public uint3 bga
        {
            get
            {
                uint3 vec;
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
        public uint3 zzw
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 bba
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 zwx
        {
            get
            {
                uint3 vec;
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
        public uint3 bar
        {
            get
            {
                uint3 vec;
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
        public uint3 zwy
        {
            get
            {
                uint3 vec;
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
        public uint3 bag
        {
            get
            {
                uint3 vec;
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
        public uint3 zwz
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 bab
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 zww
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 baa
        {
            get
            {
                uint3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 wxx
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 arr
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 wxy
        {
            get
            {
                uint3 vec;
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
        public uint3 arg
        {
            get
            {
                uint3 vec;
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
        public uint3 wxz
        {
            get
            {
                uint3 vec;
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
        public uint3 arb
        {
            get
            {
                uint3 vec;
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
        public uint3 wxw
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 ara
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 wyx
        {
            get
            {
                uint3 vec;
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
        public uint3 agr
        {
            get
            {
                uint3 vec;
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
        public uint3 wyy
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 agg
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 wyz
        {
            get
            {
                uint3 vec;
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
        public uint3 agb
        {
            get
            {
                uint3 vec;
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
        public uint3 wyw
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 aga
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 wzx
        {
            get
            {
                uint3 vec;
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
        public uint3 abr
        {
            get
            {
                uint3 vec;
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
        public uint3 wzy
        {
            get
            {
                uint3 vec;
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
        public uint3 abg
        {
            get
            {
                uint3 vec;
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
        public uint3 wzz
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 abb
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 wzw
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 aba
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 wwx
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 aar
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 wwy
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 aag
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 wwz
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 aab
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 www
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 aaa
        {
            get
            {
                uint3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
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
        public uint4 xxxw
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rrra
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = w;
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
        public uint4 xxyw
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rrga
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = w;
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
        public uint4 xxzw
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rrba
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xxwx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rrar
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xxwy
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rrag
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xxwz
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rrab
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xxww
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rraa
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = w;
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
        public uint4 xyxw
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rgra
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = w;
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
        public uint4 xyyw
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rgga
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = w;
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
        public uint4 xyzw
        {
            get
            {
                uint4 vec;
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
        public uint4 rgba
        {
            get
            {
                uint4 vec;
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
        public uint4 xywx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rgar
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xywy
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rgag
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xywz
        {
            get
            {
                uint4 vec;
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
        public uint4 rgab
        {
            get
            {
                uint4 vec;
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
        public uint4 xyww
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rgaa
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = w;
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
        public uint4 xzxw
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rbra
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = w;
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
        public uint4 xzyw
        {
            get
            {
                uint4 vec;
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
        public uint4 rbga
        {
            get
            {
                uint4 vec;
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
        public uint4 xzzw
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rbba
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xzwx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rbar
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xzwy
        {
            get
            {
                uint4 vec;
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
        public uint4 rbag
        {
            get
            {
                uint4 vec;
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
        public uint4 xzwz
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rbab
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xzww
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rbaa
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xwxx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rarr
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xwxy
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rarg
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xwxz
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rarb
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xwxw
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rara
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xwyx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ragr
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xwyy
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ragg
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xwyz
        {
            get
            {
                uint4 vec;
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
        public uint4 ragb
        {
            get
            {
                uint4 vec;
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
        public uint4 xwyw
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 raga
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xwzx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rabr
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xwzy
        {
            get
            {
                uint4 vec;
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
        public uint4 rabg
        {
            get
            {
                uint4 vec;
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
        public uint4 xwzz
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 rabb
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xwzw
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 raba
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xwwx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 raar
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xwwy
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 raag
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xwwz
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 raab
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xwww
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 raaa
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = w;
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
        public uint4 yxxw
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 grra
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = w;
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
        public uint4 yxyw
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 grga
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = w;
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
        public uint4 yxzw
        {
            get
            {
                uint4 vec;
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
        public uint4 grba
        {
            get
            {
                uint4 vec;
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
        public uint4 yxwx
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 grar
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yxwy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 grag
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yxwz
        {
            get
            {
                uint4 vec;
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
        public uint4 grab
        {
            get
            {
                uint4 vec;
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
        public uint4 yxww
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 graa
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = w;
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
        public uint4 yyxw
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ggra
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = w;
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
        public uint4 yyyw
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ggga
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = w;
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
        public uint4 yyzw
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ggba
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yywx
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ggar
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yywy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ggag
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yywz
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ggab
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yyww
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ggaa
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = w;
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
        public uint4 yzxw
        {
            get
            {
                uint4 vec;
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
        public uint4 gbra
        {
            get
            {
                uint4 vec;
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
        public uint4 yzyw
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gbga
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = w;
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
        public uint4 yzzw
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gbba
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yzwx
        {
            get
            {
                uint4 vec;
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
        public uint4 gbar
        {
            get
            {
                uint4 vec;
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
        public uint4 yzwy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gbag
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yzwz
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gbab
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yzww
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gbaa
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ywxx
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 garr
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ywxy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 garg
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ywxz
        {
            get
            {
                uint4 vec;
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
        public uint4 garb
        {
            get
            {
                uint4 vec;
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
        public uint4 ywxw
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gara
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ywyx
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gagr
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ywyy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gagg
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ywyz
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gagb
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ywyw
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gaga
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ywzx
        {
            get
            {
                uint4 vec;
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
        public uint4 gabr
        {
            get
            {
                uint4 vec;
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
        public uint4 ywzy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gabg
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ywzz
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gabb
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ywzw
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gaba
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ywwx
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gaar
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ywwy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gaag
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ywwz
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gaab
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 ywww
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 gaaa
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = w;
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
        public uint4 zxxw
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 brra
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = w;
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
        public uint4 zxyw
        {
            get
            {
                uint4 vec;
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
        public uint4 brga
        {
            get
            {
                uint4 vec;
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
        public uint4 zxzw
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 brba
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zxwx
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 brar
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zxwy
        {
            get
            {
                uint4 vec;
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
        public uint4 brag
        {
            get
            {
                uint4 vec;
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
        public uint4 zxwz
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 brab
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zxww
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 braa
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = w;
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
        public uint4 zyxw
        {
            get
            {
                uint4 vec;
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
        public uint4 bgra
        {
            get
            {
                uint4 vec;
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
        public uint4 zyyw
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bgga
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = w;
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
        public uint4 zyzw
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bgba
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zywx
        {
            get
            {
                uint4 vec;
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
        public uint4 bgar
        {
            get
            {
                uint4 vec;
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
        public uint4 zywy
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bgag
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zywz
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bgab
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zyww
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bgaa
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = w;
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
        public uint4 zzxw
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bbra
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = w;
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
        public uint4 zzyw
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bbga
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = w;
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
        [XmlIgnore]
        public uint4 zzzw
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bbba
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zzwx
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bbar
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zzwy
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bbag
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zzwz
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bbab
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zzww
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bbaa
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zwxx
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 barr
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zwxy
        {
            get
            {
                uint4 vec;
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
        public uint4 barg
        {
            get
            {
                uint4 vec;
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
        public uint4 zwxz
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 barb
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zwxw
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bara
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zwyx
        {
            get
            {
                uint4 vec;
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
        public uint4 bagr
        {
            get
            {
                uint4 vec;
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
        public uint4 zwyy
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bagg
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zwyz
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 bagb
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zwyw
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 baga
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zwzx
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 babr
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zwzy
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 babg
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zwzz
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 babb
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zwzw
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 baba
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zwwx
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 baar
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zwwy
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 baag
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zwwz
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 baab
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 zwww
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 baaa
        {
            get
            {
                uint4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wxxx
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 arrr
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wxxy
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 arrg
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wxxz
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 arrb
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wxxw
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 arra
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wxyx
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 argr
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wxyy
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 argg
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wxyz
        {
            get
            {
                uint4 vec;
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
        public uint4 argb
        {
            get
            {
                uint4 vec;
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
        public uint4 wxyw
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 arga
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wxzx
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 arbr
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wxzy
        {
            get
            {
                uint4 vec;
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
        public uint4 arbg
        {
            get
            {
                uint4 vec;
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
        public uint4 wxzz
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 arbb
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wxzw
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 arba
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wxwx
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 arar
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wxwy
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 arag
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wxwz
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 arab
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wxww
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 araa
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wyxx
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 agrr
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wyxy
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 agrg
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wyxz
        {
            get
            {
                uint4 vec;
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
        public uint4 agrb
        {
            get
            {
                uint4 vec;
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
        public uint4 wyxw
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 agra
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wyyx
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aggr
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wyyy
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aggg
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wyyz
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aggb
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wyyw
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 agga
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wyzx
        {
            get
            {
                uint4 vec;
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
        public uint4 agbr
        {
            get
            {
                uint4 vec;
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
        public uint4 wyzy
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 agbg
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wyzz
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 agbb
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wyzw
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 agba
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wywx
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 agar
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wywy
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 agag
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wywz
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 agab
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wyww
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 agaa
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wzxx
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 abrr
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wzxy
        {
            get
            {
                uint4 vec;
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
        public uint4 abrg
        {
            get
            {
                uint4 vec;
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
        public uint4 wzxz
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 abrb
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wzxw
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 abra
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wzyx
        {
            get
            {
                uint4 vec;
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
        public uint4 abgr
        {
            get
            {
                uint4 vec;
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
        public uint4 wzyy
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 abgg
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wzyz
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 abgb
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wzyw
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 abga
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wzzx
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 abbr
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wzzy
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 abbg
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wzzz
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 abbb
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wzzw
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 abba
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wzwx
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 abar
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wzwy
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 abag
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wzwz
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 abab
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wzww
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 abaa
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wwxx
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aarr
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wwxy
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aarg
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wwxz
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aarb
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wwxw
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aara
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wwyx
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aagr
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wwyy
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aagg
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wwyz
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aagb
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wwyw
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aaga
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wwzx
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aabr
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wwzy
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aabg
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wwzz
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aabb
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wwzw
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aaba
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wwwx
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aaar
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wwwy
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aaag
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wwwz
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aaab
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 wwww
        {
            get
            {
                uint4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 aaaa
        {
            get
            {
                uint4 vec;
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
        public uint this[uint index]
        {
            get
            {
                switch (index)
                {
                    case 0u: return x;
                    case 1u: return y;
                    case 2u: return z;
                    case 3u: return w;
                    default:
                        throw new IndexOutOfRangeException("Invalid uint4 index!");
                }
            }
            set
            {
                switch (index)
                {
                    case 0u: x = value; break;
                    case 1u: y = value; break;
                    case 2u: z = value; break;
                    case 3u: w = value; break;
                    default:
                        throw new IndexOutOfRangeException("Invalid uint4 index!");
                }
            }
        }
        /// <summary>
        /// Creates a new vector with given x, y, z, w components.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public uint4(uint x = 0u, uint y = 0u, uint z = 0u, uint w = 0u)
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
        public uint4(uint3 a, uint w = 0u)
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
        public uint4(uint x, uint2 a, uint w = 0u)
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
        public uint4(uint2 a, uint z = 0u, uint w = 0u)
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
        public uint4(uint x, uint3 b)
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
        public uint4(uint2 a, uint2 b)
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
        public void Set(uint newX, uint newY, uint newZ, uint newW)
        {
            x = newX;
            y = newY;
            z = newZ;
            w = newW;
        }
        /// <summary>
        /// Multiplies two vectors component-wise.
        /// </summary>
        /// <param name="scale"></param>
        public void Scale(uint4 scale)
        {
            x *= scale.x;
            y *= scale.y;
            z *= scale.z;
            w *= scale.w;
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
            if (!(other is uint4))
            {
                return false;
            }
            return Equals((uint4)other);
        }
        /// <summary>
        /// Returns true if the given vector is exactly equal to this vector.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(uint4 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z) && w.Equals(other.w);
        }
        /// <summary>
        /// Returns the distance between a and b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float Distance(uint4 a, uint4 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            a.w = a.w - b.w;
            return (float)System.Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z + a.w * a.w);
        }
        /// <summary>
        /// Dot Product of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static uint Dot(uint4 a, uint4 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
        }
        /// <summary>
        /// Returns the length of this vector (Read Only).
        /// </summary>
        [XmlIgnore]
        public float Magnitude
        {
            get { return (float)System.Math.Sqrt(x * x + y * y + z * z + w * w); }
        }
        /// <summary>
        /// Returns the squared length of this vector (Read Only).
        /// </summary>
        [XmlIgnore]
        public float SqrMagnitude
        {
            get { return x * x + y * y + z * z + w * w; }
        }
        /// <summary>
        /// Returns a vector that is made from the smallest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static uint4 Min(uint4 a, uint4 b)
        {
            b.x = a.x > b.x ? b.x : a.x;
            b.y = a.y > b.y ? b.y : a.y;
            b.z = a.z > b.z ? b.z : a.z;
            b.w = a.w > b.w ? b.w : a.w;
            return b;
        }
        /// <summary>
        /// Returns a vector that is made from the largest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static uint4 Max(uint4 a, uint4 b)
        {
            b.x = a.x > b.x ? a.x : b.x;
            b.y = a.y > b.y ? a.y : b.y;
            b.z = a.z > b.z ? a.z : b.z;
            b.w = a.w > b.w ? a.w : b.w;
            return b;
        }
        /// <summary>
        /// Returns the distance between a and b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public float Distance(uint4 b)
        {
            b.x = x - b.x;
            b.y = y - b.y;
            b.z = z - b.z;
            b.w = w - b.w;
            return (float)System.Math.Sqrt(b.x * b.x + b.y * b.y + b.z * b.z + b.w * b.w);
        }
        /// <summary>
        /// Returns a vector that is made from the smallest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public uint4 Min(uint4 b)
        {
            b.x = x > b.x ? b.x : x;
            b.y = y > b.y ? b.y : y;
            b.z = z > b.z ? b.z : z;
            b.w = w > b.w ? b.w : w;
            return b;
        }
        /// <summary>
        /// Returns a vector that is made from the largest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public uint4 Max(uint4 b)
        {
            b.x = x > b.x ? x : b.x;
            b.y = y > b.y ? y : b.y;
            b.z = z > b.z ? z : b.z;
            b.w = w > b.w ? w : b.w;
            return b;
        }
        /// <summary>
        /// Clamps the Vector3uint to the bounds given by min and max.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public uint4 Clamp(uint min, uint max)
        {
            uint4 vec;
            vec.x = x > max ? max : x < min ? min : x;
            vec.y = y > max ? max : y < min ? min : y;
            vec.z = z > max ? max : z < min ? min : z;
            vec.w = w > max ? max : w < min ? min : w;
            return vec;
        }
        /// <summary>
        /// Clamps the Vector3uint to the bounds given by min and max.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public uint4 Clamp(uint4 min, uint4 max)
        {
            min.x = x > max.x ? max.x : x < min.x ? min.x : x;
            min.y = y > max.y ? max.y : y < min.y ? min.y : y;
            min.z = z > max.z ? max.z : z < min.z ? min.z : z;
            min.w = w > max.w ? max.w : w < min.w ? min.w : w;
            return min;
        }
        /// <summary>
        /// Sortcut to write a vector (0, 0, 0, 0)
        /// </summary>
        [XmlIgnore]
        public static uint4 Zero
        {
            get
            {
                uint4 vec;
                vec.x = 0u;
                vec.y = 0u;
                vec.z = 0u;
                vec.w = 0u;
                return vec;
            }
        }
        /// <summary>
        /// Sortcut to write a vector (1, 1, 1, 1)
        /// </summary>
        [XmlIgnore]
        public static uint4 One
        {
            get
            {
                uint4 vec;
                vec.x = 1u;
                vec.y = 1u;
                vec.z = 1u;
                vec.w = 1u;
                return vec;
            }
        }
        public static uint4 operator +(uint4 a, uint4 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            a.w = a.w + b.w;
            return a;
        }
        public static float4 operator +(float4 a, uint4 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            a.w = a.w + b.w;
            return a;
        }
        public static float4 operator +(uint4 a, float4 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            b.z = a.z + b.z;
            b.w = a.w + b.w;
            return b;
        }
        public static uint4 operator +(uint a, uint4 b)
        {
            b.x = a + b.x;
            b.y = a + b.y;
            b.z = a + b.z;
            b.w = a + b.w;
            return b;
        }
        public static uint4 operator +(uint4 a, uint b)
        {
            a.x = a.x + b;
            a.y = a.y + b;
            a.z = a.z + b;
            a.w = a.w + b;
            return a;
        }
        public static float4 operator +(float a, uint4 b)
        {
            float4 vec;
            vec.x = a + b.x;
            vec.y = a + b.y;
            vec.z = a + b.z;
            vec.w = a + b.w;
            return vec;
        }
        public static float4 operator +(uint4 a, float b)
        {
            float4 vec;
            vec.x = a.x + b;
            vec.y = a.y + b;
            vec.z = a.z + b;
            vec.w = a.w + b;
            return vec;
        }
        public static uint4 operator +(uint4 a, uint3 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            return a;
        }
        public static uint4 operator +(uint3 a, uint4 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            b.z = a.z + b.z;
            return b;
        }
        public static float4 operator +(uint4 a, float3 b)
        {
            float4 vec;
            vec.x = a.x + b.x;
            vec.y = a.y + b.y;
            vec.z = a.z + b.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator +(float3 a, uint4 b)
        {
            float4 vec;
            vec.x = a.x + b.x;
            vec.y = a.y + b.y;
            vec.z = a.z + b.z;
            vec.w = b.w;
            return vec;
        }
        public static uint4 operator +(uint4 a, uint2 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            return a;
        }
        public static uint4 operator +(uint2 a, uint4 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            return b;
        }
        public static float4 operator +(uint4 a, float2 b)
        {
            float4 vec;
            vec.x = a.x + b.x;
            vec.y = a.y + b.y;
            vec.z = a.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator +(float2 a, uint4 b)
        {
            float4 vec;
            vec.x = a.x + b.x;
            vec.y = a.y + b.y;
            vec.z = b.z;
            vec.w = b.w;
            return vec;
        }
        public static uint4 operator -(uint4 a, uint4 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            a.w = a.w - b.w;
            return a;
        }
        public static float4 operator -(float4 a, uint4 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            a.w = a.w - b.w;
            return a;
        }
        public static float4 operator -(uint4 a, float4 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            b.z = a.z - b.z;
            b.w = a.w - b.w;
            return b;
        }
        public static uint4 operator -(uint a, uint4 b)
        {
            b.x = a - b.x;
            b.y = a - b.y;
            b.z = a - b.z;
            b.w = a - b.w;
            return b;
        }
        public static uint4 operator -(uint4 a, uint b)
        {
            a.x = a.x - b;
            a.y = a.y - b;
            a.z = a.z - b;
            a.w = a.w - b;
            return a;
        }
        public static float4 operator -(float a, uint4 b)
        {
            float4 vec;
            vec.x = a - b.x;
            vec.y = a - b.y;
            vec.z = a - b.z;
            vec.w = a - b.w;
            return vec;
        }
        public static float4 operator -(uint4 a, float b)
        {
            float4 vec;
            vec.x = a.x - b;
            vec.y = a.y - b;
            vec.z = a.z - b;
            vec.w = a.w - b;
            return vec;
        }
        public static uint4 operator -(uint4 a, uint3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return a;
        }
        public static uint4 operator -(uint3 a, uint4 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            b.z = a.z - b.z;
            return b;
        }
        public static float4 operator -(uint4 a, float3 b)
        {
            float4 vec;
            vec.x = a.x - b.x;
            vec.y = a.y - b.y;
            vec.z = a.z - b.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator -(float3 a, uint4 b)
        {
            float4 vec;
            vec.x = a.x - b.x;
            vec.y = a.y - b.y;
            vec.z = a.z - b.z;
            vec.w = b.w;
            return vec;
        }
        public static uint4 operator -(uint4 a, uint2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a;
        }
        public static uint4 operator -(uint2 a, uint4 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            return b;
        }
        public static float4 operator -(uint4 a, float2 b)
        {
            float4 vec;
            vec.x = a.x - b.x;
            vec.y = a.y - b.y;
            vec.z = a.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator -(float2 a, uint4 b)
        {
            float4 vec;
            vec.x = a.x - b.x;
            vec.y = a.y - b.y;
            vec.z = b.z;
            vec.w = b.w;
            return vec;
        }
        public static uint4 operator *(uint4 a, uint4 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            a.w = a.w * b.w;
            return a;
        }
        public static float4 operator *(float4 a, uint4 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            a.w = a.w * b.w;
            return a;
        }
        public static float4 operator *(uint4 a, float4 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            b.z = a.z * b.z;
            b.w = a.w * b.w;
            return b;
        }
        public static uint4 operator *(uint a, uint4 b)
        {
            b.x = a * b.x;
            b.y = a * b.y;
            b.z = a * b.z;
            b.w = a * b.w;
            return b;
        }
        public static uint4 operator *(uint4 a, uint b)
        {
            a.x = a.x * b;
            a.y = a.y * b;
            a.z = a.z * b;
            a.w = a.w * b;
            return a;
        }
        public static float4 operator *(float a, uint4 b)
        {
            float4 vec;
            vec.x = a * b.x;
            vec.y = a * b.y;
            vec.z = a * b.z;
            vec.w = a * b.w;
            return vec;
        }
        public static float4 operator *(uint4 a, float b)
        {
            float4 vec;
            vec.x = a.x * b;
            vec.y = a.y * b;
            vec.z = a.z * b;
            vec.w = a.w * b;
            return vec;
        }
        public static uint4 operator *(uint4 a, uint3 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            return a;
        }
        public static uint4 operator *(uint3 a, uint4 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            b.z = a.z * b.z;
            return b;
        }
        public static float4 operator *(uint4 a, float3 b)
        {
            float4 vec;
            vec.x = a.x * b.x;
            vec.y = a.y * b.y;
            vec.z = a.z * b.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator *(float3 a, uint4 b)
        {
            float4 vec;
            vec.x = a.x * b.x;
            vec.y = a.y * b.y;
            vec.z = a.z * b.z;
            vec.w = b.w;
            return vec;
        }
        public static uint4 operator *(uint4 a, uint2 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            return a;
        }
        public static uint4 operator *(uint2 a, uint4 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            return b;
        }
        public static float4 operator *(uint4 a, float2 b)
        {
            float4 vec;
            vec.x = a.x * b.x;
            vec.y = a.y * b.y;
            vec.z = a.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator *(float2 a, uint4 b)
        {
            float4 vec;
            vec.x = a.x * b.x;
            vec.y = a.y * b.y;
            vec.z = b.z;
            vec.w = b.w;
            return vec;
        }
        public static uint4 operator /(uint4 a, uint4 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            a.w = a.w / b.w;
            return a;
        }
        public static float4 operator /(float4 a, uint4 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            a.w = a.w / b.w;
            return a;
        }
        public static float4 operator /(uint4 a, float4 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            b.z = a.z / b.z;
            b.w = a.w / b.w;
            return b;
        }
        public static uint4 operator /(uint a, uint4 b)
        {
            b.x = a / b.x;
            b.y = a / b.y;
            b.z = a / b.z;
            b.w = a / b.w;
            return b;
        }
        public static uint4 operator /(uint4 a, uint b)
        {
            a.x = a.x / b;
            a.y = a.y / b;
            a.z = a.z / b;
            a.w = a.w / b;
            return a;
        }
        public static float4 operator /(float a, uint4 b)
        {
            float4 vec;
            vec.x = a / b.x;
            vec.y = a / b.y;
            vec.z = a / b.z;
            vec.w = a / b.w;
            return vec;
        }
        public static float4 operator /(uint4 a, float b)
        {
            float4 vec;
            vec.x = a.x / b;
            vec.y = a.y / b;
            vec.z = a.z / b;
            vec.w = a.w / b;
            return vec;
        }
        public static uint4 operator /(uint4 a, uint3 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            return a;
        }
        public static uint4 operator /(uint3 a, uint4 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            b.z = a.z / b.z;
            return b;
        }
        public static float4 operator /(uint4 a, float3 b)
        {
            float4 vec;
            vec.x = a.x / b.x;
            vec.y = a.y / b.y;
            vec.z = a.z / b.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator /(float3 a, uint4 b)
        {
            float4 vec;
            vec.x = a.x / b.x;
            vec.y = a.y / b.y;
            vec.z = a.z / b.z;
            vec.w = b.w;
            return vec;
        }
        public static uint4 operator /(uint4 a, uint2 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            return a;
        }
        public static uint4 operator /(uint2 a, uint4 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            return b;
        }
        public static float4 operator /(uint4 a, float2 b)
        {
            float4 vec;
            vec.x = a.x / b.x;
            vec.y = a.y / b.y;
            vec.z = a.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator /(float2 a, uint4 b)
        {
            float4 vec;
            vec.x = a.x / b.x;
            vec.y = a.y / b.y;
            vec.z = b.z;
            vec.w = b.w;
            return vec;
        }
        public static uint4 operator %(uint4 a, uint4 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            a.w = a.w % b.w;
            return a;
        }
        public static float4 operator %(float4 a, uint4 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            a.w = a.w % b.w;
            return a;
        }
        public static float4 operator %(uint4 a, float4 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            b.z = a.z % b.z;
            b.w = a.w % b.w;
            return b;
        }
        public static uint4 operator %(uint a, uint4 b)
        {
            b.x = a % b.x;
            b.y = a % b.y;
            b.z = a % b.z;
            b.w = a % b.w;
            return b;
        }
        public static uint4 operator %(uint4 a, uint b)
        {
            a.x = a.x % b;
            a.y = a.y % b;
            a.z = a.z % b;
            a.w = a.w % b;
            return a;
        }
        public static float4 operator %(float a, uint4 b)
        {
            float4 vec;
            vec.x = a % b.x;
            vec.y = a % b.y;
            vec.z = a % b.z;
            vec.w = a % b.w;
            return vec;
        }
        public static float4 operator %(uint4 a, float b)
        {
            float4 vec;
            vec.x = a.x % b;
            vec.y = a.y % b;
            vec.z = a.z % b;
            vec.w = a.w % b;
            return vec;
        }
        public static uint4 operator %(uint4 a, uint3 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            return a;
        }
        public static uint4 operator %(uint3 a, uint4 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            b.z = a.z % b.z;
            return b;
        }
        public static float4 operator %(uint4 a, float3 b)
        {
            float4 vec;
            vec.x = a.x % b.x;
            vec.y = a.y % b.y;
            vec.z = a.z % b.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator %(float3 a, uint4 b)
        {
            float4 vec;
            vec.x = a.x % b.x;
            vec.y = a.y % b.y;
            vec.z = a.z % b.z;
            vec.w = b.w;
            return vec;
        }
        public static uint4 operator %(uint4 a, uint2 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            return a;
        }
        public static uint4 operator %(uint2 a, uint4 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            return b;
        }
        public static float4 operator %(uint4 a, float2 b)
        {
            float4 vec;
            vec.x = a.x % b.x;
            vec.y = a.y % b.y;
            vec.z = a.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator %(float2 a, uint4 b)
        {
            float4 vec;
            vec.x = a.x % b.x;
            vec.y = a.y % b.y;
            vec.z = b.z;
            vec.w = b.w;
            return vec;
        }
        public static uint4 operator &(uint4 a, uint4 b)
        {
            a.x = a.x & b.x;
            a.y = a.y & b.y;
            a.z = a.z & b.z;
            a.w = a.w & b.w;
            return a;
        }
        public static uint4 operator &(uint a, uint4 b)
        {
            b.x = a & b.x;
            b.y = a & b.y;
            b.z = a & b.z;
            b.w = a & b.w;
            return b;
        }
        public static uint4 operator &(uint4 a, uint b)
        {
            a.x = a.x & b;
            a.y = a.y & b;
            a.z = a.z & b;
            a.w = a.w & b;
            return a;
        }
        public static uint4 operator &(uint4 a, uint3 b)
        {
            a.x = a.x & b.x;
            a.y = a.y & b.y;
            a.z = a.z & b.z;
            return a;
        }
        public static uint4 operator &(uint3 a, uint4 b)
        {
            b.x = a.x & b.x;
            b.y = a.y & b.y;
            b.z = a.z & b.z;
            return b;
        }
        public static uint4 operator &(uint4 a, uint2 b)
        {
            a.x = a.x & b.x;
            a.y = a.y & b.y;
            return a;
        }
        public static uint4 operator &(uint2 a, uint4 b)
        {
            b.x = a.x & b.x;
            b.y = a.y & b.y;
            return b;
        }
        public static uint4 operator |(uint4 a, uint4 b)
        {
            a.x = a.x | b.x;
            a.y = a.y | b.y;
            a.z = a.z | b.z;
            a.w = a.w | b.w;
            return a;
        }
        public static uint4 operator |(uint a, uint4 b)
        {
            b.x = a | b.x;
            b.y = a | b.y;
            b.z = a | b.z;
            b.w = a | b.w;
            return b;
        }
        public static uint4 operator |(uint4 a, uint b)
        {
            a.x = a.x | b;
            a.y = a.y | b;
            a.z = a.z | b;
            a.w = a.w | b;
            return a;
        }
        public static uint4 operator |(uint4 a, uint3 b)
        {
            a.x = a.x | b.x;
            a.y = a.y | b.y;
            a.z = a.z | b.z;
            return a;
        }
        public static uint4 operator |(uint3 a, uint4 b)
        {
            b.x = a.x | b.x;
            b.y = a.y | b.y;
            b.z = a.z | b.z;
            return b;
        }
        public static uint4 operator |(uint4 a, uint2 b)
        {
            a.x = a.x | b.x;
            a.y = a.y | b.y;
            return a;
        }
        public static uint4 operator |(uint2 a, uint4 b)
        {
            b.x = a.x | b.x;
            b.y = a.y | b.y;
            return b;
        }
        public static uint4 operator ^(uint4 a, uint4 b)
        {
            a.x = a.x ^ b.x;
            a.y = a.y ^ b.y;
            a.z = a.z ^ b.z;
            a.w = a.w ^ b.w;
            return a;
        }
        public static uint4 operator ^(uint a, uint4 b)
        {
            b.x = a ^ b.x;
            b.y = a ^ b.y;
            b.z = a ^ b.z;
            b.w = a ^ b.w;
            return b;
        }
        public static uint4 operator ^(uint4 a, uint b)
        {
            a.x = a.x ^ b;
            a.y = a.y ^ b;
            a.z = a.z ^ b;
            a.w = a.w ^ b;
            return a;
        }
        public static uint4 operator ^(uint4 a, uint3 b)
        {
            a.x = a.x ^ b.x;
            a.y = a.y ^ b.y;
            a.z = a.z ^ b.z;
            return a;
        }
        public static uint4 operator ^(uint3 a, uint4 b)
        {
            b.x = a.x ^ b.x;
            b.y = a.y ^ b.y;
            b.z = a.z ^ b.z;
            return b;
        }
        public static uint4 operator ^(uint4 a, uint2 b)
        {
            a.x = a.x ^ b.x;
            a.y = a.y ^ b.y;
            return a;
        }
        public static uint4 operator ^(uint2 a, uint4 b)
        {
            b.x = a.x ^ b.x;
            b.y = a.y ^ b.y;
            return b;
        }
        public static uint4 operator <<(uint4 a, int b)
        {
            a.x = a.x << b;
            a.y = a.y << b;
            a.z = a.z << b;
            a.w = a.w << b;
            return a;
        }
        public static uint4 operator >>(uint4 a, int b)
        {
            a.x = a.x >> b;
            a.y = a.y >> b;
            a.z = a.z >> b;
            a.w = a.w >> b;
            return a;
        }
        public static uint4 operator ~(uint4 a)
        {
            a.x = ~a.x;
            a.y = ~a.y;
            a.z = ~a.z;
            a.w = ~a.w;
            return a;
        }
        public static bool operator ==(uint4 a, uint4 b)
        {
            return a.x == b.x && a.y == b.y && a.z == b.z && a.w == b.w;
        }
        public static bool operator !=(uint4 a, uint4 b)
        {
            return a.x != b.x || a.y != b.y || a.z != b.z || a.w != b.w;
        }
        public static explicit operator int2(uint4 v)
        {
            int2 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            return vec;
        }
        public static explicit operator int3(uint4 v)
        {
            int3 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            vec.z = (int)v.z;
            return vec;
        }
        public static implicit operator int4(uint4 v)
        {
            int4 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            vec.z = (int)v.z;
            vec.w = (int)v.w;
            return vec;
        }
        public static explicit operator uint2(uint4 v)
        {
            uint2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static explicit operator uint3(uint4 v)
        {
            uint3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            return vec;
        }
        public static explicit operator float2(uint4 v)
        {
            float2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static explicit operator float3(uint4 v)
        {
            float3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            return vec;
        }
        public static implicit operator float4(uint4 v)
        {
            float4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            vec.w = v.w;
            return vec;
        }
        public static explicit operator double2(uint4 v)
        {
            float2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static explicit operator double3(uint4 v)
        {
            float3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            return vec;
        }
        public static implicit operator double4(uint4 v)
        {
            float4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            vec.w = v.w;
            return vec;
        }
        public static explicit operator bool2(uint4 v)
        {
            bool2 vec;
            vec.x = v.x != 0u;
            vec.y = v.y != 0u;
            return vec;
        }
        public static explicit operator bool3(uint4 v)
        {
            bool3 vec;
            vec.x = v.x != 0u;
            vec.y = v.y != 0u;
            vec.z = v.z != 0u;
            return vec;
        }
        public static explicit operator bool4(uint4 v)
        {
            bool4 vec;
            vec.x = v.x != 0u;
            vec.y = v.y != 0u;
            vec.z = v.z != 0u;
            vec.w = v.w != 0u;
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
