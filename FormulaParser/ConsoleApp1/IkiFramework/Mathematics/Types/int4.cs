using System;
using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    [Serializable]
    public partial struct int4 : IEquatable<int4>
    {
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
        /// W component of the vector.
        /// </summary>
        public int w;
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
        /// <summary>
        /// W component of the vector.
        /// </summary>
        [XmlIgnore]
        public int a
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
        public int2 xw
        {
            get
            {
                int2 vec;
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
        public int2 ra
        {
            get
            {
                int2 vec;
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
        public int2 yw
        {
            get
            {
                int2 vec;
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
        public int2 ga
        {
            get
            {
                int2 vec;
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
        public int2 zw
        {
            get
            {
                int2 vec;
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
        public int2 ba
        {
            get
            {
                int2 vec;
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
        public int2 wx
        {
            get
            {
                int2 vec;
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
        public int2 ar
        {
            get
            {
                int2 vec;
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
        public int2 wy
        {
            get
            {
                int2 vec;
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
        public int2 ag
        {
            get
            {
                int2 vec;
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
        public int2 wz
        {
            get
            {
                int2 vec;
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
        public int2 ab
        {
            get
            {
                int2 vec;
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
        public int2 ww
        {
            get
            {
                int2 vec;
                vec.x = w;
                vec.y = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int2 aa
        {
            get
            {
                int2 vec;
                vec.x = w;
                vec.y = w;
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
        public int3 xxw
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 rra
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
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
        public int3 xyw
        {
            get
            {
                int3 vec;
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
        public int3 rga
        {
            get
            {
                int3 vec;
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
        public int3 xzw
        {
            get
            {
                int3 vec;
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
        public int3 rba
        {
            get
            {
                int3 vec;
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
        public int3 xwx
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 rar
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 xwy
        {
            get
            {
                int3 vec;
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
        public int3 rag
        {
            get
            {
                int3 vec;
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
        public int3 xwz
        {
            get
            {
                int3 vec;
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
        public int3 rab
        {
            get
            {
                int3 vec;
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
        public int3 xww
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 raa
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
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
        public int3 yxw
        {
            get
            {
                int3 vec;
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
        public int3 gra
        {
            get
            {
                int3 vec;
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
        public int3 yyw
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 gga
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
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
        public int3 yzw
        {
            get
            {
                int3 vec;
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
        public int3 gba
        {
            get
            {
                int3 vec;
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
        public int3 ywx
        {
            get
            {
                int3 vec;
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
        public int3 gar
        {
            get
            {
                int3 vec;
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
        public int3 ywy
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 gag
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 ywz
        {
            get
            {
                int3 vec;
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
        public int3 gab
        {
            get
            {
                int3 vec;
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
        public int3 yww
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 gaa
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
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
        public int3 zxw
        {
            get
            {
                int3 vec;
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
        public int3 bra
        {
            get
            {
                int3 vec;
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
        public int3 zyw
        {
            get
            {
                int3 vec;
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
        public int3 bga
        {
            get
            {
                int3 vec;
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
        public int3 zzw
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 bba
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 zwx
        {
            get
            {
                int3 vec;
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
        public int3 bar
        {
            get
            {
                int3 vec;
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
        public int3 zwy
        {
            get
            {
                int3 vec;
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
        public int3 bag
        {
            get
            {
                int3 vec;
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
        public int3 zwz
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 bab
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 zww
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 baa
        {
            get
            {
                int3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 wxx
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 arr
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 wxy
        {
            get
            {
                int3 vec;
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
        public int3 arg
        {
            get
            {
                int3 vec;
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
        public int3 wxz
        {
            get
            {
                int3 vec;
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
        public int3 arb
        {
            get
            {
                int3 vec;
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
        public int3 wxw
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 ara
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 wyx
        {
            get
            {
                int3 vec;
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
        public int3 agr
        {
            get
            {
                int3 vec;
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
        public int3 wyy
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 agg
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 wyz
        {
            get
            {
                int3 vec;
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
        public int3 agb
        {
            get
            {
                int3 vec;
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
        public int3 wyw
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 aga
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 wzx
        {
            get
            {
                int3 vec;
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
        public int3 abr
        {
            get
            {
                int3 vec;
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
        public int3 wzy
        {
            get
            {
                int3 vec;
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
        public int3 abg
        {
            get
            {
                int3 vec;
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
        public int3 wzz
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 abb
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 wzw
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 aba
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 wwx
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 aar
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 wwy
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 aag
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 wwz
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 aab
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 www
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 aaa
        {
            get
            {
                int3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
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
        public int4 xxxw
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rrra
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = w;
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
        public int4 xxyw
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rrga
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = w;
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
        public int4 xxzw
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rrba
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xxwx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rrar
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xxwy
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rrag
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xxwz
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rrab
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xxww
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rraa
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = w;
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
        public int4 xyxw
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rgra
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = w;
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
        public int4 xyyw
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rgga
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = w;
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
        public int4 xyzw
        {
            get
            {
                int4 vec;
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
        public int4 rgba
        {
            get
            {
                int4 vec;
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
        public int4 xywx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rgar
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xywy
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rgag
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xywz
        {
            get
            {
                int4 vec;
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
        public int4 rgab
        {
            get
            {
                int4 vec;
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
        public int4 xyww
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rgaa
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = w;
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
        public int4 xzxw
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rbra
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = w;
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
        public int4 xzyw
        {
            get
            {
                int4 vec;
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
        public int4 rbga
        {
            get
            {
                int4 vec;
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
        public int4 xzzw
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rbba
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xzwx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rbar
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xzwy
        {
            get
            {
                int4 vec;
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
        public int4 rbag
        {
            get
            {
                int4 vec;
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
        public int4 xzwz
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rbab
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xzww
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rbaa
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xwxx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rarr
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xwxy
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rarg
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xwxz
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rarb
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xwxw
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rara
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xwyx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ragr
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xwyy
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ragg
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xwyz
        {
            get
            {
                int4 vec;
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
        public int4 ragb
        {
            get
            {
                int4 vec;
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
        public int4 xwyw
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 raga
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xwzx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rabr
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xwzy
        {
            get
            {
                int4 vec;
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
        public int4 rabg
        {
            get
            {
                int4 vec;
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
        public int4 xwzz
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 rabb
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xwzw
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 raba
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xwwx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 raar
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xwwy
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 raag
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xwwz
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 raab
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xwww
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 raaa
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = w;
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
        public int4 yxxw
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 grra
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = w;
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
        public int4 yxyw
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 grga
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = w;
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
        public int4 yxzw
        {
            get
            {
                int4 vec;
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
        public int4 grba
        {
            get
            {
                int4 vec;
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
        public int4 yxwx
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 grar
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yxwy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 grag
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yxwz
        {
            get
            {
                int4 vec;
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
        public int4 grab
        {
            get
            {
                int4 vec;
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
        public int4 yxww
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 graa
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = w;
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
        public int4 yyxw
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ggra
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = w;
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
        public int4 yyyw
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ggga
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = w;
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
        public int4 yyzw
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ggba
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yywx
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ggar
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yywy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ggag
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yywz
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ggab
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yyww
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ggaa
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = w;
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
        public int4 yzxw
        {
            get
            {
                int4 vec;
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
        public int4 gbra
        {
            get
            {
                int4 vec;
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
        public int4 yzyw
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gbga
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = w;
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
        public int4 yzzw
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gbba
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yzwx
        {
            get
            {
                int4 vec;
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
        public int4 gbar
        {
            get
            {
                int4 vec;
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
        public int4 yzwy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gbag
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yzwz
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gbab
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yzww
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gbaa
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ywxx
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 garr
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ywxy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 garg
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ywxz
        {
            get
            {
                int4 vec;
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
        public int4 garb
        {
            get
            {
                int4 vec;
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
        public int4 ywxw
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gara
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ywyx
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gagr
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ywyy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gagg
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ywyz
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gagb
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ywyw
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gaga
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ywzx
        {
            get
            {
                int4 vec;
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
        public int4 gabr
        {
            get
            {
                int4 vec;
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
        public int4 ywzy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gabg
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ywzz
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gabb
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ywzw
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gaba
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ywwx
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gaar
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ywwy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gaag
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ywwz
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gaab
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 ywww
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 gaaa
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = w;
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
        public int4 zxxw
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 brra
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = w;
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
        public int4 zxyw
        {
            get
            {
                int4 vec;
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
        public int4 brga
        {
            get
            {
                int4 vec;
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
        public int4 zxzw
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 brba
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zxwx
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 brar
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zxwy
        {
            get
            {
                int4 vec;
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
        public int4 brag
        {
            get
            {
                int4 vec;
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
        public int4 zxwz
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 brab
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zxww
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 braa
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = w;
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
        public int4 zyxw
        {
            get
            {
                int4 vec;
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
        public int4 bgra
        {
            get
            {
                int4 vec;
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
        public int4 zyyw
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bgga
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = w;
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
        public int4 zyzw
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bgba
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zywx
        {
            get
            {
                int4 vec;
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
        public int4 bgar
        {
            get
            {
                int4 vec;
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
        public int4 zywy
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bgag
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zywz
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bgab
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zyww
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bgaa
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = w;
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
        public int4 zzxw
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bbra
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = w;
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
        public int4 zzyw
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bbga
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = w;
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
        [XmlIgnore]
        public int4 zzzw
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bbba
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zzwx
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bbar
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zzwy
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bbag
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zzwz
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bbab
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zzww
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bbaa
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zwxx
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 barr
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zwxy
        {
            get
            {
                int4 vec;
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
        public int4 barg
        {
            get
            {
                int4 vec;
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
        public int4 zwxz
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 barb
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zwxw
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bara
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zwyx
        {
            get
            {
                int4 vec;
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
        public int4 bagr
        {
            get
            {
                int4 vec;
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
        public int4 zwyy
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bagg
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zwyz
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 bagb
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zwyw
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 baga
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zwzx
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 babr
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zwzy
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 babg
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zwzz
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 babb
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zwzw
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 baba
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zwwx
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 baar
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zwwy
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 baag
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zwwz
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 baab
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 zwww
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 baaa
        {
            get
            {
                int4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wxxx
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 arrr
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wxxy
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 arrg
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wxxz
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 arrb
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wxxw
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 arra
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wxyx
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 argr
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wxyy
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 argg
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wxyz
        {
            get
            {
                int4 vec;
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
        public int4 argb
        {
            get
            {
                int4 vec;
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
        public int4 wxyw
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 arga
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wxzx
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 arbr
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wxzy
        {
            get
            {
                int4 vec;
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
        public int4 arbg
        {
            get
            {
                int4 vec;
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
        public int4 wxzz
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 arbb
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wxzw
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 arba
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wxwx
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 arar
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wxwy
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 arag
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wxwz
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 arab
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wxww
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 araa
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wyxx
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 agrr
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wyxy
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 agrg
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wyxz
        {
            get
            {
                int4 vec;
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
        public int4 agrb
        {
            get
            {
                int4 vec;
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
        public int4 wyxw
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 agra
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wyyx
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aggr
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wyyy
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aggg
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wyyz
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aggb
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wyyw
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 agga
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wyzx
        {
            get
            {
                int4 vec;
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
        public int4 agbr
        {
            get
            {
                int4 vec;
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
        public int4 wyzy
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 agbg
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wyzz
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 agbb
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wyzw
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 agba
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wywx
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 agar
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wywy
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 agag
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wywz
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 agab
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wyww
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 agaa
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wzxx
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 abrr
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wzxy
        {
            get
            {
                int4 vec;
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
        public int4 abrg
        {
            get
            {
                int4 vec;
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
        public int4 wzxz
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 abrb
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wzxw
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 abra
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wzyx
        {
            get
            {
                int4 vec;
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
        public int4 abgr
        {
            get
            {
                int4 vec;
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
        public int4 wzyy
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 abgg
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wzyz
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 abgb
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wzyw
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 abga
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wzzx
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 abbr
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wzzy
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 abbg
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wzzz
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 abbb
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wzzw
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 abba
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wzwx
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 abar
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wzwy
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 abag
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wzwz
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 abab
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wzww
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 abaa
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wwxx
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aarr
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wwxy
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aarg
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wwxz
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aarb
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wwxw
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aara
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wwyx
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aagr
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wwyy
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aagg
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wwyz
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aagb
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wwyw
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aaga
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wwzx
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aabr
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wwzy
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aabg
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wwzz
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aabb
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wwzw
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aaba
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wwwx
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aaar
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wwwy
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aaag
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wwwz
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aaab
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 wwww
        {
            get
            {
                int4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 aaaa
        {
            get
            {
                int4 vec;
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
        public int this[int index]
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
                        throw new IndexOutOfRangeException("Invalid int4 index!");
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
                        throw new IndexOutOfRangeException("Invalid int4 index!");
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
        public int4(int x = 0, int y = 0, int z = 0, int w = 0)
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
        public int4(int3 a, int w = 0)
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
        public int4(int x, int2 a, int w = 0)
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
        public int4(int2 a, int z = 0, int w = 0)
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
        public int4(int x, int3 b)
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
        public int4(int2 a, int2 b)
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
        public void Set(int newX, int newY, int newZ, int newW)
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
        public void Scale(int4 scale)
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
            if (!(other is int4))
            {
                return false;
            }
            return Equals((int4)other);
        }
        /// <summary>
        /// Returns true if the given vector is exactly equal to this vector.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(int4 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z) && w.Equals(other.w);
        }
        /// <summary>
        /// Returns the distance between a and b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float Distance(int4 a, int4 b)
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
        public static int Dot(int4 a, int4 b)
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
        public static int4 Min(int4 a, int4 b)
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
        public static int4 Max(int4 a, int4 b)
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
        public float Distance(int4 b)
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
        public int4 Min(int4 b)
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
        public int4 Max(int4 b)
        {
            b.x = x > b.x ? x : b.x;
            b.y = y > b.y ? y : b.y;
            b.z = z > b.z ? z : b.z;
            b.w = w > b.w ? w : b.w;
            return b;
        }
        /// <summary>
        /// Clamps the Vector3Int to the bounds given by min and max.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int4 Clamp(int min, int max)
        {
            int4 vec;
            vec.x = x > max ? max : x < min ? min : x;
            vec.y = y > max ? max : y < min ? min : y;
            vec.z = z > max ? max : z < min ? min : z;
            vec.w = w > max ? max : w < min ? min : w;
            return vec;
        }
        /// <summary>
        /// Clamps the Vector3Int to the bounds given by min and max.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int4 Clamp(int4 min, int4 max)
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
        public static int4 Zero
        {
            get
            {
                int4 vec;
                vec.x = 0;
                vec.y = 0;
                vec.z = 0;
                vec.w = 0;
                return vec;
            }
        }
        /// <summary>
        /// Sortcut to write a vector (1, 1, 1, 1)
        /// </summary>
        [XmlIgnore]
        public static int4 One
        {
            get
            {
                int4 vec;
                vec.x = 1;
                vec.y = 1;
                vec.z = 1;
                vec.w = 1;
                return vec;
            }
        }
        public static int4 operator +(int4 a, int4 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            a.w = a.w + b.w;
            return a;
        }
        public static float4 operator +(float4 a, int4 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            a.w = a.w + b.w;
            return a;
        }
        public static float4 operator +(int4 a, float4 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            b.z = a.z + b.z;
            b.w = a.w + b.w;
            return b;
        }
        public static int4 operator +(int a, int4 b)
        {
            b.x = a + b.x;
            b.y = a + b.y;
            b.z = a + b.z;
            b.w = a + b.w;
            return b;
        }
        public static int4 operator +(int4 a, int b)
        {
            a.x = a.x + b;
            a.y = a.y + b;
            a.z = a.z + b;
            a.w = a.w + b;
            return a;
        }
        public static float4 operator +(float a, int4 b)
        {
            float4 vec;
            vec.x = a + b.x;
            vec.y = a + b.y;
            vec.z = a + b.z;
            vec.w = a + b.w;
            return vec;
        }
        public static float4 operator +(int4 a, float b)
        {
            float4 vec;
            vec.x = a.x + b;
            vec.y = a.y + b;
            vec.z = a.z + b;
            vec.w = a.w + b;
            return vec;
        }
        public static int4 operator +(int4 a, int3 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            return a;
        }
        public static int4 operator +(int3 a, int4 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            b.z = a.z + b.z;
            return b;
        }
        public static float4 operator +(int4 a, float3 b)
        {
            float4 vec;
            vec.x = a.x + b.x;
            vec.y = a.y + b.y;
            vec.z = a.z + b.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator +(float3 a, int4 b)
        {
            float4 vec;
            vec.x = a.x + b.x;
            vec.y = a.y + b.y;
            vec.z = a.z + b.z;
            vec.w = b.w;
            return vec;
        }
        public static int4 operator +(int4 a, int2 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            return a;
        }
        public static int4 operator +(int2 a, int4 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            return b;
        }
        public static float4 operator +(int4 a, float2 b)
        {
            float4 vec;
            vec.x = a.x + b.x;
            vec.y = a.y + b.y;
            vec.z = a.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator +(float2 a, int4 b)
        {
            float4 vec;
            vec.x = a.x + b.x;
            vec.y = a.y + b.y;
            vec.z = b.z;
            vec.w = b.w;
            return vec;
        }
        public static int4 operator -(int4 a, int4 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            a.w = a.w - b.w;
            return a;
        }
        public static float4 operator -(float4 a, int4 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            a.w = a.w - b.w;
            return a;
        }
        public static float4 operator -(int4 a, float4 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            b.z = a.z - b.z;
            b.w = a.w - b.w;
            return b;
        }
        public static int4 operator -(int a, int4 b)
        {
            b.x = a - b.x;
            b.y = a - b.y;
            b.z = a - b.z;
            b.w = a - b.w;
            return b;
        }
        public static int4 operator -(int4 a, int b)
        {
            a.x = a.x - b;
            a.y = a.y - b;
            a.z = a.z - b;
            a.w = a.w - b;
            return a;
        }
        public static float4 operator -(float a, int4 b)
        {
            float4 vec;
            vec.x = a - b.x;
            vec.y = a - b.y;
            vec.z = a - b.z;
            vec.w = a - b.w;
            return vec;
        }
        public static float4 operator -(int4 a, float b)
        {
            float4 vec;
            vec.x = a.x - b;
            vec.y = a.y - b;
            vec.z = a.z - b;
            vec.w = a.w - b;
            return vec;
        }
        public static int4 operator -(int4 a, int3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return a;
        }
        public static int4 operator -(int3 a, int4 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            b.z = a.z - b.z;
            return b;
        }
        public static float4 operator -(int4 a, float3 b)
        {
            float4 vec;
            vec.x = a.x - b.x;
            vec.y = a.y - b.y;
            vec.z = a.z - b.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator -(float3 a, int4 b)
        {
            float4 vec;
            vec.x = a.x - b.x;
            vec.y = a.y - b.y;
            vec.z = a.z - b.z;
            vec.w = b.w;
            return vec;
        }
        public static int4 operator -(int4 a, int2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a;
        }
        public static int4 operator -(int2 a, int4 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            return b;
        }
        public static float4 operator -(int4 a, float2 b)
        {
            float4 vec;
            vec.x = a.x - b.x;
            vec.y = a.y - b.y;
            vec.z = a.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator -(float2 a, int4 b)
        {
            float4 vec;
            vec.x = a.x - b.x;
            vec.y = a.y - b.y;
            vec.z = b.z;
            vec.w = b.w;
            return vec;
        }
        public static int4 operator *(int4 a, int4 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            a.w = a.w * b.w;
            return a;
        }
        public static float4 operator *(float4 a, int4 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            a.w = a.w * b.w;
            return a;
        }
        public static float4 operator *(int4 a, float4 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            b.z = a.z * b.z;
            b.w = a.w * b.w;
            return b;
        }
        public static int4 operator *(int a, int4 b)
        {
            b.x = a * b.x;
            b.y = a * b.y;
            b.z = a * b.z;
            b.w = a * b.w;
            return b;
        }
        public static int4 operator *(int4 a, int b)
        {
            a.x = a.x * b;
            a.y = a.y * b;
            a.z = a.z * b;
            a.w = a.w * b;
            return a;
        }
        public static float4 operator *(float a, int4 b)
        {
            float4 vec;
            vec.x = a * b.x;
            vec.y = a * b.y;
            vec.z = a * b.z;
            vec.w = a * b.w;
            return vec;
        }
        public static float4 operator *(int4 a, float b)
        {
            float4 vec;
            vec.x = a.x * b;
            vec.y = a.y * b;
            vec.z = a.z * b;
            vec.w = a.w * b;
            return vec;
        }
        public static int4 operator *(int4 a, int3 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            return a;
        }
        public static int4 operator *(int3 a, int4 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            b.z = a.z * b.z;
            return b;
        }
        public static float4 operator *(int4 a, float3 b)
        {
            float4 vec;
            vec.x = a.x * b.x;
            vec.y = a.y * b.y;
            vec.z = a.z * b.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator *(float3 a, int4 b)
        {
            float4 vec;
            vec.x = a.x * b.x;
            vec.y = a.y * b.y;
            vec.z = a.z * b.z;
            vec.w = b.w;
            return vec;
        }
        public static int4 operator *(int4 a, int2 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            return a;
        }
        public static int4 operator *(int2 a, int4 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            return b;
        }
        public static float4 operator *(int4 a, float2 b)
        {
            float4 vec;
            vec.x = a.x * b.x;
            vec.y = a.y * b.y;
            vec.z = a.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator *(float2 a, int4 b)
        {
            float4 vec;
            vec.x = a.x * b.x;
            vec.y = a.y * b.y;
            vec.z = b.z;
            vec.w = b.w;
            return vec;
        }
        public static int4 operator /(int4 a, int4 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            a.w = a.w / b.w;
            return a;
        }
        public static float4 operator /(float4 a, int4 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            a.w = a.w / b.w;
            return a;
        }
        public static float4 operator /(int4 a, float4 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            b.z = a.z / b.z;
            b.w = a.w / b.w;
            return b;
        }
        public static int4 operator /(int a, int4 b)
        {
            b.x = a / b.x;
            b.y = a / b.y;
            b.z = a / b.z;
            b.w = a / b.w;
            return b;
        }
        public static int4 operator /(int4 a, int b)
        {
            a.x = a.x / b;
            a.y = a.y / b;
            a.z = a.z / b;
            a.w = a.w / b;
            return a;
        }
        public static float4 operator /(float a, int4 b)
        {
            float4 vec;
            vec.x = a / b.x;
            vec.y = a / b.y;
            vec.z = a / b.z;
            vec.w = a / b.w;
            return vec;
        }
        public static float4 operator /(int4 a, float b)
        {
            float4 vec;
            vec.x = a.x / b;
            vec.y = a.y / b;
            vec.z = a.z / b;
            vec.w = a.w / b;
            return vec;
        }
        public static int4 operator /(int4 a, int3 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            return a;
        }
        public static int4 operator /(int3 a, int4 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            b.z = a.z / b.z;
            return b;
        }
        public static float4 operator /(int4 a, float3 b)
        {
            float4 vec;
            vec.x = a.x / b.x;
            vec.y = a.y / b.y;
            vec.z = a.z / b.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator /(float3 a, int4 b)
        {
            float4 vec;
            vec.x = a.x / b.x;
            vec.y = a.y / b.y;
            vec.z = a.z / b.z;
            vec.w = b.w;
            return vec;
        }
        public static int4 operator /(int4 a, int2 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            return a;
        }
        public static int4 operator /(int2 a, int4 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            return b;
        }
        public static float4 operator /(int4 a, float2 b)
        {
            float4 vec;
            vec.x = a.x / b.x;
            vec.y = a.y / b.y;
            vec.z = a.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator /(float2 a, int4 b)
        {
            float4 vec;
            vec.x = a.x / b.x;
            vec.y = a.y / b.y;
            vec.z = b.z;
            vec.w = b.w;
            return vec;
        }
        public static int4 operator %(int4 a, int4 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            a.w = a.w % b.w;
            return a;
        }
        public static float4 operator %(float4 a, int4 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            a.w = a.w % b.w;
            return a;
        }
        public static float4 operator %(int4 a, float4 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            b.z = a.z % b.z;
            b.w = a.w % b.w;
            return b;
        }
        public static int4 operator %(int a, int4 b)
        {
            b.x = a % b.x;
            b.y = a % b.y;
            b.z = a % b.z;
            b.w = a % b.w;
            return b;
        }
        public static int4 operator %(int4 a, int b)
        {
            a.x = a.x % b;
            a.y = a.y % b;
            a.z = a.z % b;
            a.w = a.w % b;
            return a;
        }
        public static float4 operator %(float a, int4 b)
        {
            float4 vec;
            vec.x = a % b.x;
            vec.y = a % b.y;
            vec.z = a % b.z;
            vec.w = a % b.w;
            return vec;
        }
        public static float4 operator %(int4 a, float b)
        {
            float4 vec;
            vec.x = a.x % b;
            vec.y = a.y % b;
            vec.z = a.z % b;
            vec.w = a.w % b;
            return vec;
        }
        public static int4 operator %(int4 a, int3 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            return a;
        }
        public static int4 operator %(int3 a, int4 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            b.z = a.z % b.z;
            return b;
        }
        public static float4 operator %(int4 a, float3 b)
        {
            float4 vec;
            vec.x = a.x % b.x;
            vec.y = a.y % b.y;
            vec.z = a.z % b.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator %(float3 a, int4 b)
        {
            float4 vec;
            vec.x = a.x % b.x;
            vec.y = a.y % b.y;
            vec.z = a.z % b.z;
            vec.w = b.w;
            return vec;
        }
        public static int4 operator %(int4 a, int2 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            return a;
        }
        public static int4 operator %(int2 a, int4 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            return b;
        }
        public static float4 operator %(int4 a, float2 b)
        {
            float4 vec;
            vec.x = a.x % b.x;
            vec.y = a.y % b.y;
            vec.z = a.z;
            vec.w = a.w;
            return vec;
        }
        public static float4 operator %(float2 a, int4 b)
        {
            float4 vec;
            vec.x = a.x % b.x;
            vec.y = a.y % b.y;
            vec.z = b.z;
            vec.w = b.w;
            return vec;
        }
        public static int4 operator &(int4 a, int4 b)
        {
            a.x = a.x & b.x;
            a.y = a.y & b.y;
            a.z = a.z & b.z;
            a.w = a.w & b.w;
            return a;
        }
        public static int4 operator &(int a, int4 b)
        {
            b.x = a & b.x;
            b.y = a & b.y;
            b.z = a & b.z;
            b.w = a & b.w;
            return b;
        }
        public static int4 operator &(int4 a, int b)
        {
            a.x = a.x & b;
            a.y = a.y & b;
            a.z = a.z & b;
            a.w = a.w & b;
            return a;
        }
        public static int4 operator &(int4 a, int3 b)
        {
            a.x = a.x & b.x;
            a.y = a.y & b.y;
            a.z = a.z & b.z;
            return a;
        }
        public static int4 operator &(int3 a, int4 b)
        {
            b.x = a.x & b.x;
            b.y = a.y & b.y;
            b.z = a.z & b.z;
            return b;
        }
        public static int4 operator &(int4 a, int2 b)
        {
            a.x = a.x & b.x;
            a.y = a.y & b.y;
            return a;
        }
        public static int4 operator &(int2 a, int4 b)
        {
            b.x = a.x & b.x;
            b.y = a.y & b.y;
            return b;
        }
        public static int4 operator |(int4 a, int4 b)
        {
            a.x = a.x | b.x;
            a.y = a.y | b.y;
            a.z = a.z | b.z;
            a.w = a.w | b.w;
            return a;
        }
        public static int4 operator |(int a, int4 b)
        {
            b.x = a | b.x;
            b.y = a | b.y;
            b.z = a | b.z;
            b.w = a | b.w;
            return b;
        }
        public static int4 operator |(int4 a, int b)
        {
            a.x = a.x | b;
            a.y = a.y | b;
            a.z = a.z | b;
            a.w = a.w | b;
            return a;
        }
        public static int4 operator |(int4 a, int3 b)
        {
            a.x = a.x | b.x;
            a.y = a.y | b.y;
            a.z = a.z | b.z;
            return a;
        }
        public static int4 operator |(int3 a, int4 b)
        {
            b.x = a.x | b.x;
            b.y = a.y | b.y;
            b.z = a.z | b.z;
            return b;
        }
        public static int4 operator |(int4 a, int2 b)
        {
            a.x = a.x | b.x;
            a.y = a.y | b.y;
            return a;
        }
        public static int4 operator |(int2 a, int4 b)
        {
            b.x = a.x | b.x;
            b.y = a.y | b.y;
            return b;
        }
        public static int4 operator ^(int4 a, int4 b)
        {
            a.x = a.x ^ b.x;
            a.y = a.y ^ b.y;
            a.z = a.z ^ b.z;
            a.w = a.w ^ b.w;
            return a;
        }
        public static int4 operator ^(int a, int4 b)
        {
            b.x = a ^ b.x;
            b.y = a ^ b.y;
            b.z = a ^ b.z;
            b.w = a ^ b.w;
            return b;
        }
        public static int4 operator ^(int4 a, int b)
        {
            a.x = a.x ^ b;
            a.y = a.y ^ b;
            a.z = a.z ^ b;
            a.w = a.w ^ b;
            return a;
        }
        public static int4 operator ^(int4 a, int3 b)
        {
            a.x = a.x ^ b.x;
            a.y = a.y ^ b.y;
            a.z = a.z ^ b.z;
            return a;
        }
        public static int4 operator ^(int3 a, int4 b)
        {
            b.x = a.x ^ b.x;
            b.y = a.y ^ b.y;
            b.z = a.z ^ b.z;
            return b;
        }
        public static int4 operator ^(int4 a, int2 b)
        {
            a.x = a.x ^ b.x;
            a.y = a.y ^ b.y;
            return a;
        }
        public static int4 operator ^(int2 a, int4 b)
        {
            b.x = a.x ^ b.x;
            b.y = a.y ^ b.y;
            return b;
        }
        public static int4 operator <<(int4 a, int b)
        {
            a.x = a.x << b;
            a.y = a.y << b;
            a.z = a.z << b;
            a.w = a.w << b;
            return a;
        }
        public static int4 operator >>(int4 a, int b)
        {
            a.x = a.x >> b;
            a.y = a.y >> b;
            a.z = a.z >> b;
            a.w = a.w >> b;
            return a;
        }
        public static int4 operator -(int4 a)
        {
            a.x = -a.x;
            a.y = -a.y;
            a.z = -a.z;
            a.w = -a.w;
            return a;
        }
        public static int4 operator ~(int4 a)
        {
            a.x = ~a.x;
            a.y = ~a.y;
            a.z = ~a.z;
            a.w = ~a.w;
            return a;
        }
        public static bool operator ==(int4 a, int4 b)
        {
            return a.x == b.x && a.y == b.y && a.z == b.z && a.w == b.w;
        }
        public static bool operator !=(int4 a, int4 b)
        {
            return a.x != b.x || a.y != b.y || a.z != b.z || a.w != b.w;
        }
        
        public static explicit operator float3(int4 v)
        {
            float3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            return vec;
        }
        public static explicit operator int3(int4 v)
        {
            int3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            return vec;
        }
        public static explicit operator float2(int4 v)
        {
            float2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static explicit operator int2(int4 v)
        {
            int2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static explicit operator bool2(int4 v)
        {
            bool2 vec;
            vec.x = v.x != 0;
            vec.y = v.y != 0;
            return vec;
        }
        public static explicit operator bool3(int4 v)
        {
            bool3 vec;
            vec.x = v.x != 0;
            vec.y = v.y != 0;
            vec.z = v.z != 0;
            return vec;
        }
        public static explicit operator bool4(int4 v)
        {
            bool4 vec;
            vec.x = v.x != 0;
            vec.y = v.y != 0;
            vec.z = v.z != 0;
            vec.w = v.w != 0;
            return vec;
        }
        
        public static implicit operator float4(int4 v)
        {
            float4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            vec.w = v.w;
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
