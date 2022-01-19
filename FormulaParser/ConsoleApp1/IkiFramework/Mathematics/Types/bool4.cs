using System;
using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    [Serializable]
    public partial struct bool4 : IEquatable<bool4>
    {
        /// <summary>
        /// X value of the vector.
        /// </summary>
        public bool x;
        /// <summary>
        /// Y value of the vector.
        /// </summary>
        public bool y;
        /// <summary>
        /// Z value of the vector.
        /// </summary>
        public bool z;
        /// <summary>
        /// W value of the vector.
        /// </summary>
        public bool w;
        /// <summary>
        /// X component of the vector.
        /// </summary>
        [XmlIgnore]
        public bool r
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
        public bool g
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
        public bool b
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
        public bool a
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
        public bool2 xx
        {
            get
            {
                bool2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool2 rr
        {
            get
            {
                bool2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool2 xy
        {
            get
            {
                bool2 vec;
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
        public bool2 rg
        {
            get
            {
                bool2 vec;
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
        public bool2 xz
        {
            get
            {
                bool2 vec;
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
        public bool2 rb
        {
            get
            {
                bool2 vec;
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
        public bool2 xw
        {
            get
            {
                bool2 vec;
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
        public bool2 ra
        {
            get
            {
                bool2 vec;
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
        public bool2 yx
        {
            get
            {
                bool2 vec;
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
        public bool2 gr
        {
            get
            {
                bool2 vec;
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
        public bool2 yy
        {
            get
            {
                bool2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool2 gg
        {
            get
            {
                bool2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool2 yz
        {
            get
            {
                bool2 vec;
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
        public bool2 gb
        {
            get
            {
                bool2 vec;
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
        public bool2 yw
        {
            get
            {
                bool2 vec;
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
        public bool2 ga
        {
            get
            {
                bool2 vec;
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
        public bool2 zx
        {
            get
            {
                bool2 vec;
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
        public bool2 br
        {
            get
            {
                bool2 vec;
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
        public bool2 zy
        {
            get
            {
                bool2 vec;
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
        public bool2 bg
        {
            get
            {
                bool2 vec;
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
        public bool2 zz
        {
            get
            {
                bool2 vec;
                vec.x = z;
                vec.y = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool2 bb
        {
            get
            {
                bool2 vec;
                vec.x = z;
                vec.y = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool2 zw
        {
            get
            {
                bool2 vec;
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
        public bool2 ba
        {
            get
            {
                bool2 vec;
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
        public bool2 wx
        {
            get
            {
                bool2 vec;
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
        public bool2 ar
        {
            get
            {
                bool2 vec;
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
        public bool2 wy
        {
            get
            {
                bool2 vec;
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
        public bool2 ag
        {
            get
            {
                bool2 vec;
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
        public bool2 wz
        {
            get
            {
                bool2 vec;
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
        public bool2 ab
        {
            get
            {
                bool2 vec;
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
        public bool2 ww
        {
            get
            {
                bool2 vec;
                vec.x = w;
                vec.y = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool2 aa
        {
            get
            {
                bool2 vec;
                vec.x = w;
                vec.y = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 xxx
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 rrr
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 xxy
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 rrg
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 xxz
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 rrb
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 xxw
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 rra
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 xyx
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 rgr
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 xyy
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 rgg
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 xyz
        {
            get
            {
                bool3 vec;
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
        public bool3 rgb
        {
            get
            {
                bool3 vec;
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
        public bool3 xyw
        {
            get
            {
                bool3 vec;
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
        public bool3 rga
        {
            get
            {
                bool3 vec;
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
        public bool3 xzx
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 rbr
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 xzy
        {
            get
            {
                bool3 vec;
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
        public bool3 rbg
        {
            get
            {
                bool3 vec;
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
        public bool3 xzz
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 rbb
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 xzw
        {
            get
            {
                bool3 vec;
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
        public bool3 rba
        {
            get
            {
                bool3 vec;
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
        public bool3 xwx
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 rar
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 xwy
        {
            get
            {
                bool3 vec;
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
        public bool3 rag
        {
            get
            {
                bool3 vec;
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
        public bool3 xwz
        {
            get
            {
                bool3 vec;
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
        public bool3 rab
        {
            get
            {
                bool3 vec;
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
        public bool3 xww
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 raa
        {
            get
            {
                bool3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 yxx
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 grr
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 yxy
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 grg
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 yxz
        {
            get
            {
                bool3 vec;
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
        public bool3 grb
        {
            get
            {
                bool3 vec;
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
        public bool3 yxw
        {
            get
            {
                bool3 vec;
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
        public bool3 gra
        {
            get
            {
                bool3 vec;
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
        public bool3 yyx
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 ggr
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 yyy
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 ggg
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 yyz
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 ggb
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 yyw
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 gga
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 yzx
        {
            get
            {
                bool3 vec;
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
        public bool3 gbr
        {
            get
            {
                bool3 vec;
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
        public bool3 yzy
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 gbg
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 yzz
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 gbb
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 yzw
        {
            get
            {
                bool3 vec;
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
        public bool3 gba
        {
            get
            {
                bool3 vec;
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
        public bool3 ywx
        {
            get
            {
                bool3 vec;
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
        public bool3 gar
        {
            get
            {
                bool3 vec;
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
        public bool3 ywy
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 gag
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 ywz
        {
            get
            {
                bool3 vec;
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
        public bool3 gab
        {
            get
            {
                bool3 vec;
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
        public bool3 yww
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 gaa
        {
            get
            {
                bool3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 zxx
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 brr
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 zxy
        {
            get
            {
                bool3 vec;
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
        public bool3 brg
        {
            get
            {
                bool3 vec;
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
        public bool3 zxz
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 brb
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 zxw
        {
            get
            {
                bool3 vec;
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
        public bool3 bra
        {
            get
            {
                bool3 vec;
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
        public bool3 zyx
        {
            get
            {
                bool3 vec;
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
        public bool3 bgr
        {
            get
            {
                bool3 vec;
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
        public bool3 zyy
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 bgg
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 zyz
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 bgb
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 zyw
        {
            get
            {
                bool3 vec;
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
        public bool3 bga
        {
            get
            {
                bool3 vec;
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
        public bool3 zzx
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 bbr
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 zzy
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 bbg
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 zzz
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 bbb
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 zzw
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 bba
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 zwx
        {
            get
            {
                bool3 vec;
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
        public bool3 bar
        {
            get
            {
                bool3 vec;
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
        public bool3 zwy
        {
            get
            {
                bool3 vec;
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
        public bool3 bag
        {
            get
            {
                bool3 vec;
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
        public bool3 zwz
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 bab
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 zww
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 baa
        {
            get
            {
                bool3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 wxx
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 arr
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 wxy
        {
            get
            {
                bool3 vec;
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
        public bool3 arg
        {
            get
            {
                bool3 vec;
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
        public bool3 wxz
        {
            get
            {
                bool3 vec;
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
        public bool3 arb
        {
            get
            {
                bool3 vec;
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
        public bool3 wxw
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 ara
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 wyx
        {
            get
            {
                bool3 vec;
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
        public bool3 agr
        {
            get
            {
                bool3 vec;
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
        public bool3 wyy
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 agg
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 wyz
        {
            get
            {
                bool3 vec;
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
        public bool3 agb
        {
            get
            {
                bool3 vec;
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
        public bool3 wyw
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 aga
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 wzx
        {
            get
            {
                bool3 vec;
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
        public bool3 abr
        {
            get
            {
                bool3 vec;
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
        public bool3 wzy
        {
            get
            {
                bool3 vec;
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
        public bool3 abg
        {
            get
            {
                bool3 vec;
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
        public bool3 wzz
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 abb
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 wzw
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 aba
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 wwx
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 aar
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 wwy
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 aag
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 wwz
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 aab
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 www
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool3 aaa
        {
            get
            {
                bool3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxxx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rrrr
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxxy
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rrrg
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxxz
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rrrb
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxxw
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rrra
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxyx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rrgr
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxyy
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rrgg
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxyz
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rrgb
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxyw
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rrga
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxzx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rrbr
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxzy
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rrbg
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxzz
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rrbb
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxzw
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rrba
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxwx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rrar
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxwy
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rrag
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxwz
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rrab
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xxww
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rraa
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xyxx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rgrr
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xyxy
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rgrg
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xyxz
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rgrb
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xyxw
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rgra
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xyyx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rggr
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xyyy
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rggg
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xyyz
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rggb
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xyyw
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rgga
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xyzx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rgbr
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xyzy
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rgbg
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xyzz
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rgbb
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xyzw
        {
            get
            {
                bool4 vec;
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
        public bool4 rgba
        {
            get
            {
                bool4 vec;
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
        public bool4 xywx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rgar
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xywy
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rgag
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xywz
        {
            get
            {
                bool4 vec;
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
        public bool4 rgab
        {
            get
            {
                bool4 vec;
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
        public bool4 xyww
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rgaa
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xzxx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rbrr
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xzxy
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rbrg
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xzxz
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rbrb
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xzxw
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rbra
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xzyx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rbgr
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xzyy
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rbgg
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xzyz
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rbgb
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xzyw
        {
            get
            {
                bool4 vec;
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
        public bool4 rbga
        {
            get
            {
                bool4 vec;
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
        public bool4 xzzx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rbbr
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xzzy
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rbbg
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xzzz
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rbbb
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xzzw
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rbba
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xzwx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rbar
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xzwy
        {
            get
            {
                bool4 vec;
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
        public bool4 rbag
        {
            get
            {
                bool4 vec;
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
        public bool4 xzwz
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rbab
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xzww
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rbaa
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xwxx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rarr
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xwxy
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rarg
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xwxz
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rarb
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xwxw
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rara
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xwyx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ragr
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xwyy
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ragg
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xwyz
        {
            get
            {
                bool4 vec;
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
        public bool4 ragb
        {
            get
            {
                bool4 vec;
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
        public bool4 xwyw
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 raga
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xwzx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rabr
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xwzy
        {
            get
            {
                bool4 vec;
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
        public bool4 rabg
        {
            get
            {
                bool4 vec;
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
        public bool4 xwzz
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 rabb
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xwzw
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 raba
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xwwx
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 raar
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xwwy
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 raag
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xwwz
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 raab
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 xwww
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 raaa
        {
            get
            {
                bool4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yxxx
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 grrr
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yxxy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 grrg
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yxxz
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 grrb
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yxxw
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 grra
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yxyx
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 grgr
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yxyy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 grgg
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yxyz
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 grgb
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yxyw
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 grga
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yxzx
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 grbr
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yxzy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 grbg
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yxzz
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 grbb
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yxzw
        {
            get
            {
                bool4 vec;
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
        public bool4 grba
        {
            get
            {
                bool4 vec;
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
        public bool4 yxwx
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 grar
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yxwy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 grag
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yxwz
        {
            get
            {
                bool4 vec;
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
        public bool4 grab
        {
            get
            {
                bool4 vec;
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
        public bool4 yxww
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 graa
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yyxx
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ggrr
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yyxy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ggrg
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yyxz
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ggrb
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yyxw
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ggra
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yyyx
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gggr
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yyyy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gggg
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yyyz
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gggb
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yyyw
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ggga
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yyzx
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ggbr
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yyzy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ggbg
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yyzz
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ggbb
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yyzw
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ggba
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yywx
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ggar
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yywy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ggag
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yywz
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ggab
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yyww
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ggaa
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yzxx
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gbrr
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yzxy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gbrg
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yzxz
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gbrb
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yzxw
        {
            get
            {
                bool4 vec;
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
        public bool4 gbra
        {
            get
            {
                bool4 vec;
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
        public bool4 yzyx
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gbgr
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yzyy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gbgg
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yzyz
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gbgb
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yzyw
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gbga
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yzzx
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gbbr
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yzzy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gbbg
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yzzz
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gbbb
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yzzw
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gbba
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yzwx
        {
            get
            {
                bool4 vec;
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
        public bool4 gbar
        {
            get
            {
                bool4 vec;
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
        public bool4 yzwy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gbag
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yzwz
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gbab
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 yzww
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gbaa
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ywxx
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 garr
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ywxy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 garg
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ywxz
        {
            get
            {
                bool4 vec;
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
        public bool4 garb
        {
            get
            {
                bool4 vec;
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
        public bool4 ywxw
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gara
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ywyx
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gagr
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ywyy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gagg
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ywyz
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gagb
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ywyw
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gaga
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ywzx
        {
            get
            {
                bool4 vec;
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
        public bool4 gabr
        {
            get
            {
                bool4 vec;
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
        public bool4 ywzy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gabg
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ywzz
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gabb
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ywzw
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gaba
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ywwx
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gaar
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ywwy
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gaag
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ywwz
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gaab
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 ywww
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 gaaa
        {
            get
            {
                bool4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zxxx
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 brrr
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zxxy
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 brrg
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zxxz
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 brrb
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zxxw
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 brra
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zxyx
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 brgr
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zxyy
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 brgg
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zxyz
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 brgb
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zxyw
        {
            get
            {
                bool4 vec;
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
        public bool4 brga
        {
            get
            {
                bool4 vec;
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
        public bool4 zxzx
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 brbr
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zxzy
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 brbg
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zxzz
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 brbb
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zxzw
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 brba
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zxwx
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 brar
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zxwy
        {
            get
            {
                bool4 vec;
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
        public bool4 brag
        {
            get
            {
                bool4 vec;
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
        public bool4 zxwz
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 brab
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zxww
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 braa
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zyxx
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bgrr
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zyxy
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bgrg
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zyxz
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bgrb
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zyxw
        {
            get
            {
                bool4 vec;
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
        public bool4 bgra
        {
            get
            {
                bool4 vec;
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
        public bool4 zyyx
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bggr
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zyyy
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bggg
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zyyz
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bggb
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zyyw
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bgga
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zyzx
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bgbr
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zyzy
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bgbg
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zyzz
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bgbb
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zyzw
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bgba
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zywx
        {
            get
            {
                bool4 vec;
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
        public bool4 bgar
        {
            get
            {
                bool4 vec;
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
        public bool4 zywy
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bgag
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zywz
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bgab
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zyww
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bgaa
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zzxx
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bbrr
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zzxy
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bbrg
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zzxz
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bbrb
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zzxw
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bbra
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zzyx
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bbgr
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zzyy
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bbgg
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zzyz
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bbgb
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zzyw
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bbga
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zzzx
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bbbr
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zzzy
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bbbg
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zzzz
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bbbb
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zzzw
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bbba
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zzwx
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bbar
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zzwy
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bbag
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zzwz
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bbab
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zzww
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bbaa
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zwxx
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 barr
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zwxy
        {
            get
            {
                bool4 vec;
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
        public bool4 barg
        {
            get
            {
                bool4 vec;
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
        public bool4 zwxz
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 barb
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zwxw
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bara
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zwyx
        {
            get
            {
                bool4 vec;
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
        public bool4 bagr
        {
            get
            {
                bool4 vec;
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
        public bool4 zwyy
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bagg
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zwyz
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 bagb
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zwyw
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 baga
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zwzx
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 babr
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zwzy
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 babg
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zwzz
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 babb
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zwzw
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 baba
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zwwx
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 baar
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zwwy
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 baag
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zwwz
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 baab
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 zwww
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 baaa
        {
            get
            {
                bool4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wxxx
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 arrr
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wxxy
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 arrg
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wxxz
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 arrb
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wxxw
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 arra
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wxyx
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 argr
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wxyy
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 argg
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wxyz
        {
            get
            {
                bool4 vec;
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
        public bool4 argb
        {
            get
            {
                bool4 vec;
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
        public bool4 wxyw
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 arga
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wxzx
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 arbr
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wxzy
        {
            get
            {
                bool4 vec;
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
        public bool4 arbg
        {
            get
            {
                bool4 vec;
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
        public bool4 wxzz
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 arbb
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wxzw
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 arba
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wxwx
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 arar
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wxwy
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 arag
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wxwz
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 arab
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wxww
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 araa
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wyxx
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 agrr
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wyxy
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 agrg
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wyxz
        {
            get
            {
                bool4 vec;
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
        public bool4 agrb
        {
            get
            {
                bool4 vec;
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
        public bool4 wyxw
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 agra
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wyyx
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aggr
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wyyy
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aggg
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wyyz
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aggb
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wyyw
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 agga
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wyzx
        {
            get
            {
                bool4 vec;
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
        public bool4 agbr
        {
            get
            {
                bool4 vec;
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
        public bool4 wyzy
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 agbg
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wyzz
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 agbb
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wyzw
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 agba
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wywx
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 agar
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wywy
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 agag
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wywz
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 agab
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wyww
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 agaa
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wzxx
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 abrr
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wzxy
        {
            get
            {
                bool4 vec;
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
        public bool4 abrg
        {
            get
            {
                bool4 vec;
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
        public bool4 wzxz
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 abrb
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wzxw
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 abra
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wzyx
        {
            get
            {
                bool4 vec;
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
        public bool4 abgr
        {
            get
            {
                bool4 vec;
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
        public bool4 wzyy
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 abgg
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wzyz
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 abgb
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wzyw
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 abga
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wzzx
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 abbr
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wzzy
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 abbg
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wzzz
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 abbb
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wzzw
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 abba
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wzwx
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 abar
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wzwy
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 abag
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wzwz
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 abab
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wzww
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 abaa
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wwxx
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aarr
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wwxy
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aarg
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wwxz
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aarb
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wwxw
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aara
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wwyx
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aagr
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wwyy
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aagg
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wwyz
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aagb
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wwyw
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aaga
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wwzx
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aabr
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wwzy
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aabg
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wwzz
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aabb
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wwzw
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aaba
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wwwx
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aaar
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wwwy
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aaag
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wwwz
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aaab
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 wwww
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public bool4 aaaa
        {
            get
            {
                bool4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        public bool this[int index]
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
                        throw new IndexOutOfRangeException("Invalid bool4 index!");
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
                        throw new IndexOutOfRangeException("Invalid bool4 index!");
                }
            }
        }
        /// <summary>
        /// Construct a vector4bool, all value are false by default.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public bool4(bool x = false, bool y = false, bool z = false, bool w = false)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        /// <summary>
        /// Swap value to the left.
        /// </summary>
        public void ShiftLeft()
        {
            bool a = x;
            x = y;
            y = z;
            z = w;
            w = a;
        }
        /// <summary>
        /// Swap value to the right.
        /// </summary>
        public void ShiftRight()
        {
            bool a = x;
            x = w;
            z = y;
            w = z;
            y = a;
        }
        /// <summary>
        /// Return true if any vector is true.
        /// </summary>
        /// <returns></returns>
        public bool IsAnyTrue()
        {
            return x || y || z || w;
        }
        /// <summary>
        /// Return true if all the vectors are true.
        /// </summary>
        /// <returns></returns>
        public bool IsTrue()
        {
            return x && y && z && w;
        }
        /// <summary>
        /// Set all points to false.
        /// </summary>
        public void SetFalse()
        {
            x = y = z = w = false;
        }
        /// <summary>
        /// Set all points to true.
        /// </summary>
        public void SetTrue()
        {
            x = y = z = w = true;
        }
        /// <summary>
        /// Negation operator for vector.
        /// </summary>
        public static bool4 operator !(bool4 a)
        {
            a.x = !a.x;
            a.y = !a.y;
            a.z = !a.z;
            a.w = !a.w;
            return a;
        }
        /// <summary>
        /// AND operator for vector.
        /// </summary>
        public static bool4 operator &(bool4 a, bool4 b)
        {
            a.x = a.x && b.x;
            a.y = a.y && b.y;
            a.z = a.z && b.z;
            a.w = a.w && b.w;
            return a;
        }
        /// <summary>
        /// OR operator for vector.
        /// </summary>
        public static bool4 operator |(bool4 a, bool4 b)
        {
            a.x = a.x || b.x;
            a.y = a.y || b.y;
            a.z = a.z || b.z;
            a.w = a.w || b.w;
            return a;
        }
        /// <summary>
        /// XOR operator for vector.
        /// </summary>
        public static bool4 operator ^(bool4 a, bool4 b)
        {
            a.x = a.x ^ b.x;
            a.y = a.y ^ b.y;
            a.z = a.z ^ b.z;
            a.w = a.w ^ b.w;
            return a;
        }
        /// <summary>
        /// Equal operator for vector.
        /// </summary>
        public static bool4 operator ==(bool4 a, bool4 b)
        {
            a.x = a.x == b.x;
            a.y = a.y == b.y;
            a.z = a.z == b.z;
            a.w = a.w == b.w;
            return a;
        }
        /// <summary>
        /// Not equal operator for vector.
        /// </summary>
        public static bool4 operator !=(bool4 a, bool4 b)
        {
            a.x = a.x != b.x;
            a.y = a.y != b.y;
            a.z = a.z != b.z;
            a.w = a.w != b.w;
            return a;
        }
        public static explicit operator bool3(bool4 v)
        {
            bool3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            return vec;
        }
        public static explicit operator bool2(bool4 v)
        {
            bool2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static implicit operator double2(bool4 v)
        {
            double2 vec;
            vec.x = v.x ? 1d : 0d;
            vec.y = v.y ? 1d : 0d;
            return vec;
        }
        public static implicit operator double3(bool4 v)
        {
            double3 vec;
            vec.x = v.x ? 1d : 0d;
            vec.y = v.y ? 1d : 0d;
            vec.z = v.z ? 1d : 0d;
            return vec;
        }
        public static implicit operator double4(bool4 v)
        {
            double4 vec;
            vec.x = v.x ? 1d : 0d;
            vec.y = v.y ? 1d : 0d;
            vec.z = v.z ? 1d : 0d;
            vec.w = v.w ? 1d : 0d;
            return vec;
        }
        public static implicit operator int4(bool4 v)
        {
            int4 vec;
            vec.x = v.x ? 1 : 0;
            vec.y = v.y ? 1 : 0;
            vec.z = v.z ? 1 : 0;
            vec.w = v.w ? 1 : 0;
            return vec;
        }
        public static implicit operator float2(bool4 v)
        {
            float2 vec;
            vec.x = v.x ? 1f : 0f;
            vec.y = v.y ? 1f : 0f;
            return vec;
        }
        public static implicit operator uint3(bool4 v)
        {
            uint3 vec;
            vec.x = v.x ? 1u : 0u;
            vec.y = v.y ? 1u : 0u;
            vec.z = v.z ? 1u : 0u;
            return vec;
        }
        public static implicit operator float3(bool4 v)
        {
            float3 vec;
            vec.x = v.x ? 1f : 0f;
            vec.y = v.y ? 1f : 0f;
            vec.z = v.z ? 1f : 0f;
            return vec;
        }
        public static implicit operator uint4(bool4 v)
        {
            uint4 vec;
            vec.x = v.x ? 1u : 0u;
            vec.y = v.y ? 1u : 0u;
            vec.z = v.z ? 1u : 0u;
            vec.w = v.w ? 1u : 0u;
            return vec;
        }
        public static implicit operator float4(bool4 v)
        {
            float4 vec;
            vec.x = v.x ? 1f : 0f;
            vec.y = v.y ? 1f : 0f;
            vec.z = v.z ? 1f : 0f;
            vec.w = v.w ? 1f : 0f;
            return vec;
        }
        public static implicit operator int3(bool4 v)
        {
            int3 vec;
            vec.x = v.x ? 1 : 0;
            vec.y = v.y ? 1 : 0;
            vec.z = v.z ? 1 : 0;
            return vec;
        }
        public override string ToString()
        {
            return x.ToString() + "," + y.ToString() + "," + z.ToString() + "," + w.ToString();
        }
        public override int GetHashCode()
        {
            return x.GetHashCode() ^ (y.GetHashCode() << 2) ^ (z.GetHashCode() >> 2) ^ (w.GetHashCode() >> 1);
        }
        public override bool Equals(object other)
        {
            if (!(other is bool4))
            {
                return false;
            }
            return Equals((bool4)other);
        }
        public bool Equals(bool4 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z) && w.Equals(other.w);
        }
    }
}
