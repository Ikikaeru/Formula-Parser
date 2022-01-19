using System;
using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    [Serializable]
    public partial struct double4 : IEquatable<double4>
    {
        /// <summary>
        /// X component of the vector.
        /// </summary>
        public double x;
        /// <summary>
        /// Y component of the vector.
        /// </summary>
        public double y;
        /// <summary>
        /// Z component of the vector.
        /// </summary>
        public double z;
        /// <summary>
        /// W component of the vector.
        /// </summary>
        public double w;
        /// <summary>
        /// X component of the vector.
        /// </summary>
        [XmlIgnore]
        public double r
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
        public double g
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
        public double b
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
        public double a
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
        public double2 xx
        {
            get
            {
                double2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double2 rr
        {
            get
            {
                double2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double2 xy
        {
            get
            {
                double2 vec;
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
        public double2 rg
        {
            get
            {
                double2 vec;
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
        public double2 xz
        {
            get
            {
                double2 vec;
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
        public double2 rb
        {
            get
            {
                double2 vec;
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
        public double2 xw
        {
            get
            {
                double2 vec;
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
        public double2 ra
        {
            get
            {
                double2 vec;
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
        public double2 yx
        {
            get
            {
                double2 vec;
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
        public double2 gr
        {
            get
            {
                double2 vec;
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
        public double2 yy
        {
            get
            {
                double2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double2 gg
        {
            get
            {
                double2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double2 yz
        {
            get
            {
                double2 vec;
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
        public double2 gb
        {
            get
            {
                double2 vec;
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
        public double2 yw
        {
            get
            {
                double2 vec;
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
        public double2 ga
        {
            get
            {
                double2 vec;
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
        public double2 zx
        {
            get
            {
                double2 vec;
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
        public double2 br
        {
            get
            {
                double2 vec;
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
        public double2 zy
        {
            get
            {
                double2 vec;
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
        public double2 bg
        {
            get
            {
                double2 vec;
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
        public double2 zz
        {
            get
            {
                double2 vec;
                vec.x = z;
                vec.y = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double2 bb
        {
            get
            {
                double2 vec;
                vec.x = z;
                vec.y = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double2 zw
        {
            get
            {
                double2 vec;
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
        public double2 ba
        {
            get
            {
                double2 vec;
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
        public double2 wx
        {
            get
            {
                double2 vec;
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
        public double2 ar
        {
            get
            {
                double2 vec;
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
        public double2 wy
        {
            get
            {
                double2 vec;
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
        public double2 ag
        {
            get
            {
                double2 vec;
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
        public double2 wz
        {
            get
            {
                double2 vec;
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
        public double2 ab
        {
            get
            {
                double2 vec;
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
        public double2 ww
        {
            get
            {
                double2 vec;
                vec.x = w;
                vec.y = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double2 aa
        {
            get
            {
                double2 vec;
                vec.x = w;
                vec.y = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 xxx
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 rrr
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 xxy
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 rrg
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 xxz
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 rrb
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 xxw
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 rra
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 xyx
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 rgr
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 xyy
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 rgg
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 xyz
        {
            get
            {
                double3 vec;
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
        public double3 rgb
        {
            get
            {
                double3 vec;
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
        public double3 xyw
        {
            get
            {
                double3 vec;
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
        public double3 rga
        {
            get
            {
                double3 vec;
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
        public double3 xzx
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 rbr
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 xzy
        {
            get
            {
                double3 vec;
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
        public double3 rbg
        {
            get
            {
                double3 vec;
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
        public double3 xzz
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 rbb
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 xzw
        {
            get
            {
                double3 vec;
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
        public double3 rba
        {
            get
            {
                double3 vec;
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
        public double3 xwx
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 rar
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 xwy
        {
            get
            {
                double3 vec;
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
        public double3 rag
        {
            get
            {
                double3 vec;
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
        public double3 xwz
        {
            get
            {
                double3 vec;
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
        public double3 rab
        {
            get
            {
                double3 vec;
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
        public double3 xww
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 raa
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 yxx
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 grr
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 yxy
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 grg
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 yxz
        {
            get
            {
                double3 vec;
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
        public double3 grb
        {
            get
            {
                double3 vec;
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
        public double3 yxw
        {
            get
            {
                double3 vec;
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
        public double3 gra
        {
            get
            {
                double3 vec;
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
        public double3 yyx
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 ggr
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 yyy
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 ggg
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 yyz
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 ggb
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 yyw
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 gga
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 yzx
        {
            get
            {
                double3 vec;
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
        public double3 gbr
        {
            get
            {
                double3 vec;
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
        public double3 yzy
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 gbg
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 yzz
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 gbb
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 yzw
        {
            get
            {
                double3 vec;
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
        public double3 gba
        {
            get
            {
                double3 vec;
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
        public double3 ywx
        {
            get
            {
                double3 vec;
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
        public double3 gar
        {
            get
            {
                double3 vec;
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
        public double3 ywy
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 gag
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 ywz
        {
            get
            {
                double3 vec;
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
        public double3 gab
        {
            get
            {
                double3 vec;
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
        public double3 yww
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 gaa
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 zxx
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 brr
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 zxy
        {
            get
            {
                double3 vec;
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
        public double3 brg
        {
            get
            {
                double3 vec;
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
        public double3 zxz
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 brb
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 zxw
        {
            get
            {
                double3 vec;
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
        public double3 bra
        {
            get
            {
                double3 vec;
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
        public double3 zyx
        {
            get
            {
                double3 vec;
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
        public double3 bgr
        {
            get
            {
                double3 vec;
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
        public double3 zyy
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 bgg
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 zyz
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 bgb
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 zyw
        {
            get
            {
                double3 vec;
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
        public double3 bga
        {
            get
            {
                double3 vec;
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
        public double3 zzx
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 bbr
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 zzy
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 bbg
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 zzz
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 bbb
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 zzw
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 bba
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 zwx
        {
            get
            {
                double3 vec;
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
        public double3 bar
        {
            get
            {
                double3 vec;
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
        public double3 zwy
        {
            get
            {
                double3 vec;
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
        public double3 bag
        {
            get
            {
                double3 vec;
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
        public double3 zwz
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 bab
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 zww
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 baa
        {
            get
            {
                double3 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 wxx
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 arr
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 wxy
        {
            get
            {
                double3 vec;
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
        public double3 arg
        {
            get
            {
                double3 vec;
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
        public double3 wxz
        {
            get
            {
                double3 vec;
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
        public double3 arb
        {
            get
            {
                double3 vec;
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
        public double3 wxw
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 ara
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 wyx
        {
            get
            {
                double3 vec;
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
        public double3 agr
        {
            get
            {
                double3 vec;
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
        public double3 wyy
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 agg
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 wyz
        {
            get
            {
                double3 vec;
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
        public double3 agb
        {
            get
            {
                double3 vec;
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
        public double3 wyw
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 aga
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 wzx
        {
            get
            {
                double3 vec;
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
        public double3 abr
        {
            get
            {
                double3 vec;
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
        public double3 wzy
        {
            get
            {
                double3 vec;
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
        public double3 abg
        {
            get
            {
                double3 vec;
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
        public double3 wzz
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 abb
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 wzw
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 aba
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 wwx
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 aar
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 wwy
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 aag
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 wwz
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 aab
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 www
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 aaa
        {
            get
            {
                double3 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxxx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rrrr
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxxy
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rrrg
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxxz
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rrrb
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxxw
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rrra
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxyx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rrgr
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxyy
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rrgg
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxyz
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rrgb
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxyw
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rrga
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxzx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rrbr
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxzy
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rrbg
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxzz
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rrbb
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxzw
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rrba
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxwx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rrar
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxwy
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rrag
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxwz
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rrab
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxww
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rraa
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xyxx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rgrr
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xyxy
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rgrg
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xyxz
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rgrb
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xyxw
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rgra
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xyyx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rggr
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xyyy
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rggg
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xyyz
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rggb
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xyyw
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rgga
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xyzx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rgbr
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xyzy
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rgbg
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xyzz
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rgbb
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xyzw
        {
            get
            {
                double4 vec;
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
        public double4 rgba
        {
            get
            {
                double4 vec;
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
        public double4 xywx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rgar
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xywy
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rgag
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xywz
        {
            get
            {
                double4 vec;
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
        public double4 rgab
        {
            get
            {
                double4 vec;
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
        public double4 xyww
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rgaa
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xzxx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rbrr
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xzxy
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rbrg
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xzxz
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rbrb
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xzxw
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rbra
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xzyx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rbgr
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xzyy
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rbgg
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xzyz
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rbgb
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xzyw
        {
            get
            {
                double4 vec;
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
        public double4 rbga
        {
            get
            {
                double4 vec;
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
        public double4 xzzx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rbbr
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xzzy
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rbbg
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xzzz
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rbbb
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xzzw
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rbba
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xzwx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rbar
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xzwy
        {
            get
            {
                double4 vec;
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
        public double4 rbag
        {
            get
            {
                double4 vec;
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
        public double4 xzwz
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rbab
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xzww
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rbaa
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xwxx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rarr
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xwxy
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rarg
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xwxz
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rarb
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xwxw
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rara
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xwyx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ragr
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xwyy
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ragg
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xwyz
        {
            get
            {
                double4 vec;
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
        public double4 ragb
        {
            get
            {
                double4 vec;
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
        public double4 xwyw
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 raga
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xwzx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rabr
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xwzy
        {
            get
            {
                double4 vec;
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
        public double4 rabg
        {
            get
            {
                double4 vec;
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
        public double4 xwzz
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 rabb
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xwzw
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 raba
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xwwx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 raar
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xwwy
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 raag
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xwwz
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 raab
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xwww
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 raaa
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yxxx
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 grrr
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yxxy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 grrg
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yxxz
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 grrb
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yxxw
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 grra
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yxyx
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 grgr
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yxyy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 grgg
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yxyz
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 grgb
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yxyw
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 grga
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yxzx
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 grbr
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yxzy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 grbg
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yxzz
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 grbb
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yxzw
        {
            get
            {
                double4 vec;
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
        public double4 grba
        {
            get
            {
                double4 vec;
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
        public double4 yxwx
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 grar
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yxwy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 grag
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yxwz
        {
            get
            {
                double4 vec;
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
        public double4 grab
        {
            get
            {
                double4 vec;
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
        public double4 yxww
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 graa
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yyxx
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ggrr
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yyxy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ggrg
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yyxz
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ggrb
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yyxw
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ggra
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yyyx
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gggr
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yyyy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gggg
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yyyz
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gggb
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yyyw
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ggga
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yyzx
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ggbr
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yyzy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ggbg
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yyzz
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ggbb
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yyzw
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ggba
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yywx
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ggar
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yywy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ggag
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yywz
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ggab
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yyww
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ggaa
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yzxx
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gbrr
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yzxy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gbrg
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yzxz
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gbrb
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yzxw
        {
            get
            {
                double4 vec;
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
        public double4 gbra
        {
            get
            {
                double4 vec;
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
        public double4 yzyx
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gbgr
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yzyy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gbgg
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yzyz
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gbgb
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yzyw
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gbga
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yzzx
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gbbr
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yzzy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gbbg
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yzzz
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gbbb
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yzzw
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gbba
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yzwx
        {
            get
            {
                double4 vec;
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
        public double4 gbar
        {
            get
            {
                double4 vec;
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
        public double4 yzwy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gbag
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yzwz
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gbab
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yzww
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gbaa
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ywxx
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 garr
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ywxy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 garg
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ywxz
        {
            get
            {
                double4 vec;
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
        public double4 garb
        {
            get
            {
                double4 vec;
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
        public double4 ywxw
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gara
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ywyx
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gagr
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ywyy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gagg
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ywyz
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gagb
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ywyw
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gaga
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ywzx
        {
            get
            {
                double4 vec;
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
        public double4 gabr
        {
            get
            {
                double4 vec;
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
        public double4 ywzy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gabg
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ywzz
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gabb
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ywzw
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gaba
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ywwx
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gaar
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ywwy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gaag
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ywwz
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gaab
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 ywww
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 gaaa
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zxxx
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 brrr
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zxxy
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 brrg
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zxxz
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 brrb
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zxxw
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 brra
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zxyx
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 brgr
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zxyy
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 brgg
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zxyz
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 brgb
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zxyw
        {
            get
            {
                double4 vec;
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
        public double4 brga
        {
            get
            {
                double4 vec;
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
        public double4 zxzx
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 brbr
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zxzy
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 brbg
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zxzz
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 brbb
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zxzw
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 brba
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zxwx
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 brar
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zxwy
        {
            get
            {
                double4 vec;
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
        public double4 brag
        {
            get
            {
                double4 vec;
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
        public double4 zxwz
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 brab
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zxww
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 braa
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zyxx
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bgrr
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zyxy
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bgrg
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zyxz
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bgrb
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zyxw
        {
            get
            {
                double4 vec;
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
        public double4 bgra
        {
            get
            {
                double4 vec;
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
        public double4 zyyx
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bggr
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zyyy
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bggg
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zyyz
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bggb
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zyyw
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bgga
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zyzx
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bgbr
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zyzy
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bgbg
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zyzz
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bgbb
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zyzw
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bgba
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zywx
        {
            get
            {
                double4 vec;
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
        public double4 bgar
        {
            get
            {
                double4 vec;
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
        public double4 zywy
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bgag
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zywz
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bgab
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zyww
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bgaa
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zzxx
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bbrr
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zzxy
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bbrg
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zzxz
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bbrb
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zzxw
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bbra
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zzyx
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bbgr
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zzyy
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bbgg
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zzyz
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bbgb
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zzyw
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bbga
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zzzx
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bbbr
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zzzy
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bbbg
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zzzz
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bbbb
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zzzw
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bbba
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zzwx
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bbar
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zzwy
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bbag
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zzwz
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bbab
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zzww
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bbaa
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zwxx
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 barr
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zwxy
        {
            get
            {
                double4 vec;
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
        public double4 barg
        {
            get
            {
                double4 vec;
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
        public double4 zwxz
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 barb
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zwxw
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bara
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zwyx
        {
            get
            {
                double4 vec;
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
        public double4 bagr
        {
            get
            {
                double4 vec;
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
        public double4 zwyy
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bagg
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zwyz
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 bagb
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zwyw
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 baga
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zwzx
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 babr
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zwzy
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 babg
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zwzz
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 babb
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zwzw
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 baba
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zwwx
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 baar
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zwwy
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 baag
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zwwz
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 baab
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 zwww
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 baaa
        {
            get
            {
                double4 vec;
                vec.x = z;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wxxx
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 arrr
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wxxy
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 arrg
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wxxz
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 arrb
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wxxw
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 arra
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wxyx
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 argr
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wxyy
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 argg
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wxyz
        {
            get
            {
                double4 vec;
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
        public double4 argb
        {
            get
            {
                double4 vec;
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
        public double4 wxyw
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 arga
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wxzx
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 arbr
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wxzy
        {
            get
            {
                double4 vec;
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
        public double4 arbg
        {
            get
            {
                double4 vec;
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
        public double4 wxzz
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 arbb
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wxzw
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 arba
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wxwx
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 arar
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wxwy
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 arag
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wxwz
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 arab
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wxww
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 araa
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = x;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wyxx
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 agrr
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wyxy
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 agrg
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wyxz
        {
            get
            {
                double4 vec;
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
        public double4 agrb
        {
            get
            {
                double4 vec;
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
        public double4 wyxw
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 agra
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wyyx
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aggr
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wyyy
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aggg
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wyyz
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aggb
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wyyw
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 agga
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wyzx
        {
            get
            {
                double4 vec;
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
        public double4 agbr
        {
            get
            {
                double4 vec;
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
        public double4 wyzy
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 agbg
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wyzz
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 agbb
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wyzw
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 agba
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wywx
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 agar
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wywy
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 agag
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wywz
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 agab
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wyww
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 agaa
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = y;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wzxx
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 abrr
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wzxy
        {
            get
            {
                double4 vec;
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
        public double4 abrg
        {
            get
            {
                double4 vec;
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
        public double4 wzxz
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 abrb
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wzxw
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 abra
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wzyx
        {
            get
            {
                double4 vec;
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
        public double4 abgr
        {
            get
            {
                double4 vec;
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
        public double4 wzyy
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 abgg
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wzyz
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 abgb
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wzyw
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 abga
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wzzx
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 abbr
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wzzy
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 abbg
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wzzz
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 abbb
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wzzw
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 abba
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wzwx
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 abar
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wzwy
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 abag
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wzwz
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 abab
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wzww
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 abaa
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = z;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wwxx
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aarr
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wwxy
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aarg
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wwxz
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aarb
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wwxw
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aara
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = x;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wwyx
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aagr
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wwyy
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aagg
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wwyz
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aagb
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wwyw
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aaga
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = y;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wwzx
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aabr
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wwzy
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aabg
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wwzz
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aabb
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wwzw
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aaba
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = z;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wwwx
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aaar
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wwwy
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aaag
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wwwz
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aaab
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = z;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 wwww
        {
            get
            {
                double4 vec;
                vec.x = w;
                vec.y = w;
                vec.z = w;
                vec.w = w;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 aaaa
        {
            get
            {
                double4 vec;
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
        public double this[int index]
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
                        throw new IndexOutOfRangeException("Invalid double4 index!");
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
                        throw new IndexOutOfRangeException("Invalid double4 index!");
                }
            }
        }
        /// <summary>
        /// Creates a new vector with given x, y, z, w components.
        /// </summary>
        /// <param name="xyzw"></param>
        public double4(double xyzw)
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
        public double4(double x, double y, double z = 0d, double w = 0d)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        /// <summary>
        /// Creates a new vector with given xyz double3 and w double components.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="w"></param>
        public double4(double3 a, double w = 0d)
        {
            x = a.x;
            y = a.y;
            z = a.z;
            this.w = w;
        }
        /// <summary>
        /// Creates a new vector with given x double, double2 yz and w double components.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="a"></param>
        /// <param name="w"></param>
        public double4(double x, double2 a, double w = 0d)
        {
            this.x = x;
            y = a.x;
            z = a.y;
            this.w = w;
        }
        /// <summary>
        /// Creates a new vector with given xy double2, z and w double components.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public double4(double2 a, double z = 0f, double w = 0d)
        {
            x = a.x;
            y = a.y;
            this.z = z;
            this.w = w;
        }
        /// <summary>
        /// Creates a new vector with given x double and yzw double3 components.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="b"></param>
        public double4(double x, double3 b)
        {
            this.x = x;
            y = b.x;
            z = b.y;
            w = b.z;
        }
        /// <summary>
        /// Creates a new vector with given xy and zw double2 components.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public double4(double2 a, double2 b)
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
        public void Set(double newX, double newY, double newZ, double newW)
        {
            x = newX;
            y = newY;
            z = newZ;
            w = newW;
        }
        /// <summary>
        /// Returns the direction of b from a.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double4 Direction(double4 a, double4 b)
        {
            double4 dir;
            dir.x = b.x - a.x;
            dir.y = b.y - a.y;
            dir.z = b.z - a.z;
            dir.w = b.w - a.w;
            double mag = Mathematics.Math.Sqrt(dir.x * dir.x + dir.y * dir.y + dir.z * dir.z + dir.w * dir.w);
            if (mag > 0.000000000001d)
            {
                dir.x = dir.x / mag;
                dir.y = dir.y / mag;
                dir.z = dir.z / mag;
                dir.w = dir.w / mag;
                return dir;
            }
            dir.x = 0d;
            dir.y = 0d;
            dir.z = 0d;
            dir.w = 0d;
            return dir;
        }
        /// <summary>
        /// Linearly interpolates between two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static double4 Lerp(double4 a, double4 b, double t)
        {
            t = t < 0d ? 0d : t > 1d ? 1d : t;
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
        public static double4 Nlerp(double4 a, double4 b, double t)
        {
            t = t < 0d ? 0d : t > 1d ? 1d : t;
            a.x = a.x + (b.x - a.x) * t;
            a.y = a.y + (b.y - a.y) * t;
            a.z = a.z + (b.z - a.z) * t;
            a.w = a.w + (b.w - a.w) * t;
            double mag = Mathematics.Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z + a.w * a.w);
            if (mag > 0.000000000001d)
            {
                a.x = a.x / mag;
                a.y = a.y / mag;
                a.z = a.z / mag;
                a.w = a.w / mag;
            }
            else
            {
                a.x = 0d;
                a.y = 0d;
                a.z = 0d;
                a.w = 0d;
            }
            return a;
        }
        /// <summary>
        /// Lineary interpolates between two vectors and normalize the result.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public double4 Nlerp(double4 b, double t)
        {
            t = t < 0d ? 0d : t > 1d ? 1d : t;
            b.x = x + (b.x - x) * t;
            b.y = y + (b.y - y) * t;
            b.z = z + (b.z - z) * t;
            b.w = w + (b.w - w) * t;
            double mag = Mathematics.Math.Sqrt(b.x * b.x + b.y * b.y + b.z * b.z + b.w * b.w);
            if (mag > 0.000000000001d)
            {
                b.x = b.x / mag;
                b.y = b.y / mag;
                b.z = b.z / mag;
                b.w = b.w / mag;
            }
            else
            {
                b.x = 0d;
                b.y = 0d;
                b.z = 0d;
                b.w = 0d;
            }
            return b;
        }
        /// <summary>
        /// Return the double raised to the power.
        /// </summary>
        /// <param name="power"></param>
        /// <returns></returns>
        public double4 Pow(double power)
        {
            double4 vec;
            vec.x = Mathematics.Math.Pow(x, power);
            vec.y = Mathematics.Math.Pow(y, power);
            vec.z = Mathematics.Math.Pow(z, power);
            vec.w = Mathematics.Math.Pow(w, power);
            return vec;
        }
        /// <summary>
        /// Return the double raised to the power.
        /// </summary>
        /// <param name="power"></param>
        /// <returns></returns>
        public double4 Pow(double4 power)
        {
            double4 vec;
            vec.x = Mathematics.Math.Pow(x, power.x);
            vec.y = Mathematics.Math.Pow(y, power.y);
            vec.z = Mathematics.Math.Pow(z, power.z);
            vec.w = Mathematics.Math.Pow(w, power.w);
            return vec;
        }
        /// <summary>
        /// Reflects a vector off the plane defined by a normal.
        /// </summary>
        /// <param name="inNormal"></param>
        /// <returns></returns>
        public double4 Reflect(double4 inNormal)
        {
            double dotNorm = inNormal.x * x + inNormal.y * y + inNormal.z * z + inNormal.w * w;
            inNormal.x = -2d * dotNorm * inNormal.x + x;
            inNormal.y = -2d * dotNorm * inNormal.y + y;
            inNormal.z = -2d * dotNorm * inNormal.z + z;
            inNormal.w = -2d * dotNorm * inNormal.w + w;
            return inNormal;
        }
        /// <summary>
        /// Check if a target vector is in the range of this position.
        /// </summary>
        /// <param name="targetPosition">Position of the target</param>
        /// <param name="rangeDistance">Detecting range</param>
        /// <returns></returns>
        public bool IsInRange(double4 targetPosition, double rangeDistance)
        {
            targetPosition.x = targetPosition.x - x;
            targetPosition.y = targetPosition.y - y;
            targetPosition.z = targetPosition.z - z;
            targetPosition.w = targetPosition.w - w;
            return targetPosition.x * targetPosition.x + targetPosition.y * targetPosition.y + targetPosition.z * targetPosition.z + targetPosition.w * targetPosition.w < rangeDistance * rangeDistance;
        }
        /// <summary>
        /// Return if both vectors are opposed to each other.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsOppositeDirection(double4 b)
        {
            return x * b.x + y * b.y + z * b.z + w * b.w < 0d;
        }
        /// <summary>
        /// Return if both vectors are perpendicular to each other.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsPerpendicular(double4 b)
        {
            return x * b.x + y * b.y + z * b.z + w * b.w == 0d;
        }
        /// <summary>
        /// Return if botch vectors are in the same direction.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsSimilarDirection(double4 b)
        {
            return x * b.x + y * b.y + z * b.z + w * b.w > 0d;
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
        public static double4 NlerpUnclamped(double4 a, double4 b, double t)
        {
            a.x = a.x + (b.x - a.x) * t;
            a.y = a.y + (b.y - a.y) * t;
            a.z = a.z + (b.z - a.z) * t;
            a.w = a.w + (b.w - a.w) * t;
            double mag = Mathematics.Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z + a.w * a.w);
            if (mag > 0.000000000001d)
            {
                a.x = a.x / mag;
                a.y = a.y / mag;
                a.z = a.z / mag;
                a.w = a.w / mag;
            }
            else
            {
                a.x = 0d;
                a.y = 0d;
                a.z = 0d;
                a.w = 0d;
            }
            return a;
        }
        /// <summary>
        /// Lineary interpolates between two vectors and normalize the result.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public double4 NlerpUnclamped(double4 b, double t)
        {
            b.x = x + (b.x - x) * t;
            b.y = y + (b.y - y) * t;
            b.z = z + (b.z - z) * t;
            b.w = w + (b.w - w) * t;
            double mag = Mathematics.Math.Sqrt(b.x * b.x + b.y * b.y + b.z * b.z + b.w * b.w);
            if (mag > 0.000000000001d)
            {
                b.x = b.x / mag;
                b.y = b.y / mag;
                b.z = b.z / mag;
                b.w = b.w / mag;
            }
            else
            {
                b.x = 0d;
                b.y = 0d;
                b.z = 0d;
                b.w = 0d;
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
        public double4 Unlerp(double4 a, double4 b, double t)
        {
            t = t < 0d ? 0d : t > 1d ? 1d : t;
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
        public double4 Unlerp(double4 b, double t)
        {
            t = t < 0d ? 0d : t > 1d ? 1d : t;
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
        public static double4 QuadraticBezier(double4 a, double4 b, double4 c, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            double oneMinusT = 1d - t;
            a.x = oneMinusT * oneMinusT * a.x + 2d * oneMinusT * t * b.x + t * t * c.x;
            a.y = oneMinusT * oneMinusT * a.y + 2d * oneMinusT * t * b.y + t * t * c.y;
            a.z = oneMinusT * oneMinusT * a.z + 2d * oneMinusT * t * b.z + t * t * c.z;
            a.w = oneMinusT * oneMinusT * a.w + 2d * oneMinusT * t * b.w + t * t * c.w;
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
        public static double4 QuadraticBezierTangent(double4 a, double4 b, double4 c, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            a.x = 2d * (1d - t) * (b.x - a.x) + 2d * t * (c.x - b.x);
            a.y = 2d * (1d - t) * (b.y - a.y) + 2d * t * (c.y - b.y);
            a.z = 2d * (1d - t) * (b.z - a.z) + 2d * t * (c.z - b.z);
            a.w = 2d * (1d - t) * (b.w - a.w) + 2d * t * (c.w - b.w);
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
        public static double4 CubicBezier(double4 a, double4 b, double4 c, double4 d, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            double oneMinusT = 1d - t;
            double oneMinusTPow2 = oneMinusT * oneMinusT;
            double t2 = t * t;
            a.x = oneMinusTPow2 * oneMinusT * a.x + 3d * oneMinusTPow2 * t * b.x + 3d * oneMinusT * t2 * c.x + t2 * t * d.x;
            a.y = oneMinusTPow2 * oneMinusT * a.y + 3d * oneMinusTPow2 * t * b.y + 3d * oneMinusT * t2 * c.y + t2 * t * d.y;
            a.z = oneMinusTPow2 * oneMinusT * a.z + 3d * oneMinusTPow2 * t * b.z + 3d * oneMinusT * t2 * c.z + t2 * t * d.z;
            a.w = oneMinusTPow2 * oneMinusT * a.w + 3d * oneMinusTPow2 * t * b.w + 3d * oneMinusT * t2 * c.w + t2 * t * d.w;
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
        public static double4 CubicBezierTrangent(double4 a, double4 b, double4 c, double4 d, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            double oneMinusT = 1d - t;
            a.x = 3d * oneMinusT * oneMinusT * (b.x - a.x) + 6d * oneMinusT * t * (c.x - b.x) + 3d * t * t * (d.x - c.x);
            a.y = 3d * oneMinusT * oneMinusT * (b.y - a.y) + 6d * oneMinusT * t * (c.y - b.y) + 3d * t * t * (d.y - c.y);
            a.z = 3d * oneMinusT * oneMinusT * (b.z - a.z) + 6d * oneMinusT * t * (c.z - b.z) + 3d * t * t * (d.z - c.z);
            a.w = 3d * oneMinusT * oneMinusT * (b.w - a.w) + 6d * oneMinusT * t * (c.w - b.w) + 3d * t * t * (d.w - c.w);
            return a;
        }
        /// <summary>
        /// Linearly interpolates between two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static double4 LerpUnclamped(double4 a, double4 b, double t)
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
        public double4 UnlerpUnclamped(double4 a, double4 b, double t)
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
        public double4 UnlerpUnclamped(double4 b, double t)
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
        public static double4 QuadraticBezierUnclamped(double4 a, double4 b, double4 c, double t)
        {
            double oneMinusT = 1d - t;
            a.x = oneMinusT * oneMinusT * a.x + 2d * oneMinusT * t * b.x + t * t * c.x;
            a.y = oneMinusT * oneMinusT * a.y + 2d * oneMinusT * t * b.y + t * t * c.y;
            a.z = oneMinusT * oneMinusT * a.z + 2d * oneMinusT * t * b.z + t * t * c.z;
            a.w = oneMinusT * oneMinusT * a.w + 2d * oneMinusT * t * b.w + t * t * c.w;
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
        public static double4 QuadraticBezierTangentUnclamped(double4 a, double4 b, double4 c, double t)
        {
            a.x = 2d * (1d - t) * (b.x - a.x) + 2d * t * (c.x - b.x);
            a.y = 2d * (1d - t) * (b.y - a.y) + 2d * t * (c.y - b.y);
            a.z = 2d * (1d - t) * (b.z - a.z) + 2d * t * (c.z - b.z);
            a.w = 2d * (1d - t) * (b.w - a.w) + 2d * t * (c.w - b.w);
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
        public static double4 CubicBezierUnclamped(double4 a, double4 b, double4 c, double4 d, double t)
        {
            double oneMinusT = 1d - t;
            double oneMinusTPow2 = oneMinusT * oneMinusT;
            double t2 = t * t;
            a.x = oneMinusTPow2 * oneMinusT * a.x + 3d * oneMinusTPow2 * t * b.x + 3d * oneMinusT * t2 * c.x + t2 * t * d.x;
            a.y = oneMinusTPow2 * oneMinusT * a.y + 3d * oneMinusTPow2 * t * b.y + 3d * oneMinusT * t2 * c.y + t2 * t * d.y;
            a.z = oneMinusTPow2 * oneMinusT * a.z + 3d * oneMinusTPow2 * t * b.z + 3d * oneMinusT * t2 * c.z + t2 * t * d.z;
            a.w = oneMinusTPow2 * oneMinusT * a.w + 3d * oneMinusTPow2 * t * b.w + 3d * oneMinusT * t2 * c.w + t2 * t * d.w;
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
        public static double4 CubicBezierTrangentUnclamped(double4 a, double4 b, double4 c, double4 d, double t)
        {
            double oneMinusT = 1d - t;
            a.x = 3d * oneMinusT * oneMinusT * (b.x - a.x) + 6d * oneMinusT * t * (c.x - b.x) + 3d * t * t * (d.x - c.x);
            a.y = 3d * oneMinusT * oneMinusT * (b.y - a.y) + 6d * oneMinusT * t * (c.y - b.y) + 3d * t * t * (d.y - c.y);
            a.z = 3d * oneMinusT * oneMinusT * (b.z - a.z) + 6d * oneMinusT * t * (c.z - b.z) + 3d * t * t * (d.z - c.z);
            a.w = 3d * oneMinusT * oneMinusT * (b.w - a.w) + 6d * oneMinusT * t * (c.w - b.w) + 3d * t * t * (d.w - c.w);
            return a;
        }
        /// <summary>
        /// Moves a point current towards target.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="target"></param>
        /// <param name="maxDistanceDelta"></param>
        /// <returns></returns>
        public static double4 MoveTowards(double4 current, double4 target, double maxDistanceDelta)
        {
            double toVectorx = target.x - current.x;
            double toVectory = target.y - current.y;
            double toVectorz = target.z - current.z;
            double toVectorw = target.w - current.w;
            double dist = Mathematics.Math.Sqrt(toVectorx * toVectorx + toVectory * toVectory + toVectorz * toVectorz + toVectorw * toVectorw);
            if (dist <= maxDistanceDelta || dist == 0d)
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
        public double4 MoveTowards(double4 target, double maxDistanceDelta)
        {
            double toVectorx = target.x - x;
            double toVectory = target.y - y;
            double toVectorz = target.z - z;
            double toVectorw = target.w - w;
            double dist = Mathematics.Math.Sqrt(toVectorx * toVectorx + toVectory * toVectory + toVectorz * toVectorz + toVectorw * toVectorw);
            if (dist <= maxDistanceDelta || dist == 0d)
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
            if (!(other is double4))
            {
                return false;
            }
            return Equals((double4)other);
        }
        /// <summary>
        /// Returns true if the given vector is exactly equal to this vector.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(double4 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z) && w.Equals(other.w);
        }
        /// <summary>
        /// Makes this vector have a magnitude of 1.
        /// </summary>
        public void Normalize()
        {
            double mag = Mathematics.Math.Sqrt(x * x + y * y + z * z + w * w);
            if (mag > 0.000000000001d)
            {
                x = x / mag;
                y = y / mag;
                z = z / mag;
                w = w / mag;
            }
            else
            {
                x = 0d;
                y = 0d;
                z = 0d;
                w = 0d;
            }
        }
        /// <summary>
        /// Returns this vector with a magnitude of 1 (Read Only).
        /// </summary>
        [XmlIgnore]
        public double4 Normalized
        {
            get
            {
                double4 a;
                double mag = Mathematics.Math.Sqrt(x * x + y * y + z * z + w * w);
                if (mag > 0.000000000001d)
                {
                    a.x = x / mag;
                    a.y = y / mag;
                    a.z = z / mag;
                    a.w = w / mag;
                    return a;
                }
                a.x = 0d;
                a.y = 0d;
                a.z = 0d;
                a.w = 0d;
                return a;
            }
        }
        /// <summary>
        /// Dot Product of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Dot(double4 a, double4 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
        }
        /// <summary>
        /// Projects a vector onto another vector.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double4 Project(double4 a, double4 b)
        {
            double dotDot = (a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w) / (b.x * b.x + b.y * b.y + b.z * b.z + b.w * b.w);
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
        public static double Distance(double4 a, double4 b)
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
        public double Magnitude
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
        public double SqrMagnitude
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
        public static double4 Min(double4 a, double4 b)
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
        public static double4 Max(double4 a, double4 b)
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
        public double SignedAngle(double4 to, double4 axis)
        {
            double unsignedAngle;
            double denominator = Mathematics.Math.Sqrt((x * x + y * y + z * z + w * w) * (to.x * to.x + to.y * to.y + to.z * to.z + to.w * to.w));
            if (denominator < 1e-15d)
            {
                unsignedAngle = 0d;
            }
            else
            {
                double val = (x * to.x + y * to.y + z * to.z + w * to.w) / denominator;
                unsignedAngle = (float)System.Math.Acos(val < -1d ? -1d : val > 1d ? 1d : val) * 57.2957795131d;
            }
            double3 vec;
            vec.x = y * to.z - z * to.y;
            vec.y = z * to.x - x * to.z;
            vec.z = x * to.y - y * to.x;
            return unsignedAngle * ((axis.x * vec.x + axis.y * vec.y + axis.z * vec.z) < 0d ? -1d : 1d);
        }
        /// <summary>
        /// Return the dot product angle of both vectors.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public double DotProductAngle(double4 target)
        {
            double4 normThis = Normalized;
            target.Normalize();
            normThis.x = normThis.x * target.x + normThis.y * target.y + normThis.z * target.z + normThis.w * target.w;
            normThis.x = normThis.x > 1d ? 1d : normThis.x < -1d ? -1d : normThis.x;
            return (float)System.Math.Acos(normThis.x);
        }
        /// <summary>
        /// Returns the angle in degrees between from and to.
        /// </summary>
        /// <param name="to"></param>
        /// <returns></returns>
        public double AngleBetweenDirections(double4 to)
        {
            double denominator = Mathematics.Math.Sqrt((x * x + y * y + z * z + w * w) * (to.x * to.x + to.y * to.y + to.z * to.z + to.w * to.w));
            if (denominator < 1e-15d)
            {
                return 0f;
            }
            to.x = (x * to.x + y * to.y + z * to.z + w * to.w) / denominator;
            return (float)System.Math.Acos(to.x < -1d ? -1d : to.x > 1d ? 1d : to.x) * 57.2957795131d;
        }
        /// <summary>
        /// Return the sign of each component.
        /// </summary>
        [XmlIgnore]
        public double4 Sign
        {
            get
            {
                double4 vec;
                vec.x = x < 0d ? -x : x;
                vec.y = y < 0d ? -y : y;
                vec.z = z < 0d ? -z : z;
                vec.w = w < 0d ? -w : w;
                return vec;
            }
        }
        /// <summary>
        /// Return the sinus of each component.
        /// </summary>
        [XmlIgnore]
        public double4 Sin
        {
            get
            {
                double4 vec;
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
        public double4 Cos
        {
            get
            {
                double4 vec;
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
        public double4 Tan
        {
            get
            {
                double4 vec;
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
        public double4 Sinh
        {
            get
            {
                double4 vec;
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
        public double4 Cosh
        {
            get
            {
                double4 vec;
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
        public double4 Tanh
        {
            get
            {
                double4 vec;
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
        public double4 Asin
        {
            get
            {
                double4 vec;
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
        public double4 Acos
        {
            get
            {
                double4 vec;
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
        public double4 Atan
        {
            get
            {
                double4 vec;
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
        public double4 Saturate
        {
            get
            {
                double4 vec;
                vec.x = x < 0d ? 0d : x > 1d ? 1d : x;
                vec.y = y < 0d ? 0d : y > 1d ? 1d : y;
                vec.z = z < 0d ? 0d : z > 1d ? 1d : z;
                vec.w = w < 0d ? 0d : w > 1d ? 1d : w;
                return vec;
            }
        }
        /// <summary>
        /// Return the square root of each component.
        /// </summary>
        [XmlIgnore]
        public double4 Sqrt
        {
            get
            {
                double4 vec;
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
        public double4 Round
        {
            get
            {
                double4 vec;
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
        public double4 Exp
        {
            get
            {
                double4 vec;
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
        public double4 Exp2
        {
            get
            {
                double4 vec;
                vec.x = Mathematics.Math.Exp(x * 0.69314718d);
                vec.y = Mathematics.Math.Exp(y * 0.69314718d);
                vec.z = Mathematics.Math.Exp(z * 0.69314718d);
                vec.w = Mathematics.Math.Exp(w * 0.69314718d);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-10 exponential of each component.
        /// </summary>
        [XmlIgnore]
        public double4 Exp10
        {
            get
            {
                double4 vec;
                vec.x = Mathematics.Math.Exp(x * 2.30258509d);
                vec.y = Mathematics.Math.Exp(y * 2.30258509d);
                vec.z = Mathematics.Math.Exp(z * 2.30258509d);
                vec.w = Mathematics.Math.Exp(w * 2.30258509d);
                return vec;
            }
        }
        /// <summary>
        /// Returns the natural logarithm of each component.
        /// </summary>
        [XmlIgnore]
        public double4 Ln
        {
            get
            {
                double4 vec;
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
        public double4 Log2
        {
            get
            {
                double4 vec;
                vec.x = Mathematics.Math.Log(x, 2d);
                vec.y = Mathematics.Math.Log(y, 2d);
                vec.z = Mathematics.Math.Log(z, 2d);
                vec.w = Mathematics.Math.Log(w, 2d);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-10 logarithm of each component.
        /// </summary>
        [XmlIgnore]
        public double4 Log10
        {
            get
            {
                double4 vec;
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
        public double4 Step(double4 x)
        {
            double4 vec;
            vec.x = this.x >= x.x ? 1d : 0d;
            vec.y = y >= x.y ? 1d : 0d;
            vec.z = z >= x.z ? 1d : 0d;
            vec.w = w >= x.w ? 1d : 0d;
            return vec;
        }
        /// <summary>
        /// Return the smallest integer greater to or equal to f
        /// </summary>
        [XmlIgnore]
        public double4 Ceil
        {
            get
            {
                double4 vec;
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
        public double4 Floor
        {
            get
            {
                double4 vec;
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
        public double4 Fract
        {
            get
            {
                double4 vec;
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
        public double4 SmoothStep(double4 b, double4 x)
        {
            double4 vec;
            vec.x = (x.x - this.x) / (b.x - this.x);
            vec.x = vec.x > 1d ? 1d : (vec.x < 0d ? 0d : vec.x);
            vec.x = vec.x * vec.x * (3d - 2d * vec.x);
            vec.y = (x.y - y) / (b.y - y);
            vec.y = vec.y > 1d ? 1d : (vec.y < 0d ? 0d : vec.y);
            vec.y = vec.y * vec.y * (3d - 2d * vec.y);
            vec.z = (x.z - z) / (b.z - z);
            vec.z = vec.z > 1d ? 1d : (vec.z < 0d ? 0d : vec.z);
            vec.z = vec.z * vec.z * (3f - 2f * vec.z);
            vec.w = (x.w - w) / (b.w - w);
            vec.w = vec.w > 1d ? 1d : (vec.w < 0d ? 0d : vec.w);
            vec.w = vec.w * vec.w * (3d - 2d * vec.w);
            return vec;
        }
        /// <summary>
        /// Do a smoothstep from vectors value.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public double4 SmoothStep(double4 b, double x)
        {
            double4 vec;
            vec.x = (x - this.x) / (b.x - this.x);
            vec.x = vec.x > 1d ? 1d : (vec.x < 0d ? 0d : vec.x);
            vec.x = vec.x * vec.x * (3f - 2f * vec.x);
            vec.y = (x - y) / (b.y - y);
            vec.y = vec.y > 1d ? 1d : (vec.y < 0d ? 0d : vec.y);
            vec.y = vec.y * vec.y * (3d - 2d * vec.y);
            vec.z = (x - z) / (b.z - z);
            vec.z = vec.z > 1d ? 1d : (vec.z < 0d ? 0d : vec.z);
            vec.z = vec.z * vec.z * (3d - 2d * vec.z);
            vec.w = (x - w) / (b.w - w);
            vec.w = vec.w > 1d ? 1d : (vec.w < 0d ? 0d : vec.w);
            vec.w = vec.w * vec.w * (3d - 2d * vec.w);
            return vec;
        }
        /// <summary>
        /// Return the refraction vector from the incident vector, the normal vector n and the refraction index.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="indexRegraction"></param>
        /// <returns></returns>
        public double4 Refract(double4 n, double refractionIndex)
        {
            double dt = n.x * x + n.y * y + n.z * z + n.w * w;
            double k = 1d - refractionIndex * refractionIndex * (1d - dt * dt);
            if (k >= 0d)
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
        public double4 Remap(double minOldValue, double maxOldValue, double minNewValue, double maxNewValue)
        {
            maxOldValue = maxOldValue - minOldValue;
            maxNewValue = maxNewValue - minNewValue;
            double4 vec;
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
        public double4 Remap(double4 minOldValue, double4 maxOldValue, double4 minNewValue, double4 maxNewValue)
        {
            double4 vec;
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
        public double4 Min(double4 b)
        {
            double4 vec;
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
        public double4 Max(double4 b)
        {
            double4 vec;
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
        public double4 Abs
        {
            get
            {
                double4 vec;
                vec.x = x > 0d ? x : -x;
                vec.y = y > 0d ? y : -y;
                vec.z = z > 0d ? z : -z;
                vec.w = w > 0d ? w : -w;
                return vec;
            }
        }
        /// <summary>
        /// Lerp clamped between two vectors.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public double4 Lerp(double4 b, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
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
        public double4 LerpUnclamped(double4 b, double t)
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
        public double Dot(double4 b)
        {
            return x * b.x + y * b.y + z * b.z + w * b.w;
        }
        /// <summary>
        /// Clamp the vector between a min and a max value, then, return it.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public double4 Clamp(double min, double max)
        {
            double4 vec;
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
        public double4 Clamp(double4 min, double4 max)
        {
            double4 vec;
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
        public double4 Direction(double4 targetPosition)
        {
            targetPosition.x = targetPosition.x - x;
            targetPosition.y = targetPosition.y - y;
            targetPosition.z = targetPosition.z - z;
            targetPosition.w = targetPosition.w - w;
            double mag = Mathematics.Math.Sqrt(targetPosition.x * targetPosition.x + targetPosition.y * targetPosition.y + targetPosition.z * targetPosition.z + targetPosition.w * targetPosition.w);
            if (mag > 0.000000000001d)
            {
                targetPosition.x = targetPosition.x / mag;
                targetPosition.y = targetPosition.y / mag;
                targetPosition.z = targetPosition.z / mag;
                targetPosition.w = targetPosition.w / mag;
                return targetPosition;
            }
            targetPosition.x = 0d;
            targetPosition.y = 0d;
            targetPosition.z = 0d;
            targetPosition.w = 0d;
            return targetPosition;
        }
        /// <summary>
        /// Return the distance between two vectors.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public double Distance(double4 target)
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
        public double4 Project(double4 b)
        {
            return b * (x * b.x + y * b.y + z * b.z + w * b.w) / (b.x * b.x + b.y * b.y + b.z * b.z + b.w * b.w);
        }
        /// <summary>
        /// Shortcut to write a vector full of 0.
        /// </summary>
        [XmlIgnore]
        public static double4 Zero
        {
            get
            {
                double4 vec;
                vec.x = 0d;
                vec.y = 0d;
                vec.z = 0d;
                vec.w = 0d;
                return vec;
            }
        }
        /// <summary>
        /// Shortcut to write a vector full of 1.
        /// </summary>
        [XmlIgnore]
        public static double4 One
        {
            get
            {
                double4 vec;
                vec.x = 1d;
                vec.y = 1d;
                vec.z = 1d;
                vec.w = 1d;
                return vec;
            }
        }
        /// <summary>
        /// Shortcut to write a vector full of positive infinity.
        /// </summary>
        [XmlIgnore]
        public static double4 PositiveInfinity
        {
            get
            {
                double4 vec;
                vec.x = double.PositiveInfinity;
                vec.y = double.PositiveInfinity;
                vec.z = double.PositiveInfinity;
                vec.w = double.PositiveInfinity;
                return vec;
            }
        }
        /// <summary>
        /// Shortcut to write a vector full of negative infinity.
        /// </summary>
        [XmlIgnore]
        public static double4 NegativeInfinity
        {
            get
            {
                double4 vec;
                vec.x = double.NegativeInfinity;
                vec.y = double.NegativeInfinity;
                vec.z = double.NegativeInfinity;
                vec.w = double.NegativeInfinity;
                return vec;
            }
        }
        public static double4 operator +(double4 a, double4 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            a.w = a.w + b.w;
            return a;
        }
        public static double4 operator +(double a, double4 b)
        {
            b.x = a + b.x;
            b.y = a + b.y;
            b.z = a + b.z;
            b.w = a + b.w;
            return b;
        }
        public static double4 operator +(double4 a, double b)
        {
            a.x = a.x + b;
            a.y = a.y + b;
            a.z = a.z + b;
            a.w = a.w + b;
            return a;
        }
        public static double4 operator +(double4 a, double3 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            return a;
        }
        public static double4 operator +(double3 a, double4 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            b.z = a.z + b.z;
            return b;
        }
        public static double4 operator +(double4 a, double2 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            return a;
        }
        public static double4 operator +(double2 a, double4 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            return b;
        }
        public static double4 operator +(double4 a, float4 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            a.w = a.w + b.w;
            return a;
        }
        public static double4 operator +(float4 a, double4 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            b.z = a.z + b.z;
            b.w = a.w + b.w;
            return a;
        }
        public static double4 operator +(float a, double4 b)
        {
            b.x = a + b.x;
            b.y = a + b.y;
            b.z = a + b.z;
            b.w = a + b.w;
            return b;
        }
        public static double4 operator +(double4 a, float b)
        {
            a.x = a.x + b;
            a.y = a.y + b;
            a.z = a.z + b;
            a.w = a.w + b;
            return a;
        }
        public static double4 operator +(double4 a, float3 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            return a;
        }
        public static double4 operator +(float3 a, double4 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            b.z = a.z + b.z;
            return b;
        }
        public static double4 operator +(double4 a, float2 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            return a;
        }
        public static double4 operator +(float2 a, double4 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            return b;
        }
        public static double4 operator -(double4 a, float4 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            a.w = a.w - b.w;
            return a;
        }
        public static double4 operator -(float4 a, double4 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            b.z = a.z - b.z;
            b.w = a.w - b.w;
            return a;
        }
        public static double4 operator -(float a, double4 b)
        {
            b.x = a - b.x;
            b.y = a - b.y;
            b.z = a - b.z;
            b.w = a - b.w;
            return b;
        }
        public static double4 operator -(double4 a, float b)
        {
            a.x = a.x - b;
            a.y = a.y - b;
            a.z = a.z - b;
            a.w = a.w - b;
            return a;
        }
        public static double4 operator -(double4 a, float3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return a;
        }
        public static double4 operator -(float3 a, double4 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            b.z = a.z - b.z;
            return b;
        }
        public static double4 operator -(double4 a, float2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a;
        }
        public static double4 operator -(float2 a, double4 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            return b;
        }
        public static double4 operator *(double4 a, float4 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            a.w = a.w * b.w;
            return a;
        }
        public static double4 operator *(float4 a, double4 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            b.z = a.z * b.z;
            b.w = a.w * b.w;
            return a;
        }
        public static double4 operator *(float a, double4 b)
        {
            b.x = a * b.x;
            b.y = a * b.y;
            b.z = a * b.z;
            b.w = a * b.w;
            return b;
        }
        public static double4 operator *(double4 a, float b)
        {
            a.x = a.x * b;
            a.y = a.y * b;
            a.z = a.z * b;
            a.w = a.w * b;
            return a;
        }
        public static double4 operator *(double4 a, float3 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            return a;
        }
        public static double4 operator *(float3 a, double4 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            b.z = a.z * b.z;
            return b;
        }
        public static double4 operator *(double4 a, float2 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            return a;
        }
        public static double4 operator *(float2 a, double4 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            return b;
        }
        public static double4 operator /(double4 a, float4 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            a.w = a.w / b.w;
            return a;
        }
        public static double4 operator /(float4 a, double4 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            b.z = a.z / b.z;
            b.w = a.w / b.w;
            return a;
        }
        public static double4 operator /(float a, double4 b)
        {
            b.x = a / b.x;
            b.y = a / b.y;
            b.z = a / b.z;
            b.w = a / b.w;
            return b;
        }
        public static double4 operator /(double4 a, float b)
        {
            a.x = a.x / b;
            a.y = a.y / b;
            a.z = a.z / b;
            a.w = a.w / b;
            return a;
        }
        public static double4 operator /(double4 a, float3 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            return a;
        }
        public static double4 operator /(float3 a, double4 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            b.z = a.z / b.z;
            return b;
        }
        public static double4 operator /(double4 a, float2 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            return a;
        }
        public static double4 operator /(float2 a, double4 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            return b;
        }
        public static double4 operator %(double4 a, float4 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            a.w = a.w % b.w;
            return a;
        }
        public static double4 operator %(float4 a, double4 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            b.z = a.z % b.z;
            b.w = a.w % b.w;
            return a;
        }
        public static double4 operator %(float a, double4 b)
        {
            b.x = a % b.x;
            b.y = a % b.y;
            b.z = a % b.z;
            b.w = a % b.w;
            return b;
        }
        public static double4 operator %(double4 a, float b)
        {
            a.x = a.x % b;
            a.y = a.y % b;
            a.z = a.z % b;
            a.w = a.w % b;
            return a;
        }
        public static double4 operator %(double4 a, float3 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            return a;
        }
        public static double4 operator %(float3 a, double4 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            b.z = a.z % b.z;
            return b;
        }
        public static double4 operator %(double4 a, float2 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            return a;
        }
        public static double4 operator %(float2 a, double4 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            return b;
        }
        public static double4 operator -(double4 a, double4 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            a.w = a.w - b.w;
            return a;
        }
        public static double4 operator -(double a, double4 b)
        {
            b.x = a - b.x;
            b.y = a - b.y;
            b.z = a - b.z;
            b.w = a - b.w;
            return b;
        }
        public static double4 operator -(double4 a, double b)
        {
            a.x = a.x - b;
            a.y = a.y - b;
            a.z = a.z - b;
            a.w = a.w - b;
            return a;
        }
        public static double4 operator -(double4 a, double3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return a;
        }
        public static double4 operator -(double3 a, double4 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            b.z = a.z - b.z;
            return b;
        }
        public static double4 operator -(double4 a, double2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a;
        }
        public static double4 operator -(double2 a, double4 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            return b;
        }
        public static double4 operator *(double4 a, double4 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            a.w = a.w * b.w;
            return a;
        }
        public static double4 operator *(double a, double4 b)
        {
            b.x = a * b.x;
            b.y = a * b.y;
            b.z = a * b.z;
            b.w = a * b.w;
            return b;
        }
        public static double4 operator *(double4 a, double b)
        {
            a.x = a.x * b;
            a.y = a.y * b;
            a.z = a.z * b;
            a.w = a.w * b;
            return a;
        }
        public static double4 operator *(double4 a, double3 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            return a;
        }
        public static double4 operator *(double3 a, double4 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            b.z = a.z * b.z;
            return b;
        }
        public static double4 operator *(double4 a, double2 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            return a;
        }
        public static double4 operator *(double2 a, double4 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            return b;
        }
        public static double4 operator /(double4 a, double4 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            a.w = a.w / b.w;
            return a;
        }
        public static double4 operator /(double a, double4 b)
        {
            b.x = a / b.x;
            b.y = a / b.y;
            b.z = a / b.z;
            b.w = a / b.w;
            return b;
        }
        public static double4 operator /(double4 a, double b)
        {
            a.x = a.x / b;
            a.y = a.y / b;
            a.z = a.z / b;
            a.w = a.w / b;
            return a;
        }
        public static double4 operator /(double4 a, double3 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            return a;
        }
        public static double4 operator /(double3 a, double4 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            b.z = a.z / b.z;
            return b;
        }
        public static double4 operator /(double4 a, double2 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            return a;
        }
        public static double4 operator /(double2 a, double4 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            return b;
        }
        public static double4 operator %(double4 a, double4 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            a.w = a.w % b.w;
            return a;
        }
        public static double4 operator %(double a, double4 b)
        {
            b.x = a % b.x;
            b.y = a % b.y;
            b.z = a % b.z;
            b.w = a % b.w;
            return b;
        }
        public static double4 operator %(double4 a, double b)
        {
            a.x = a.x % b;
            a.y = a.y % b;
            a.z = a.z % b;
            a.w = a.w % b;
            return a;
        }
        public static double4 operator %(double4 a, double3 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            return a;
        }
        public static double4 operator %(double3 a, double4 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            b.z = a.z % b.z;
            return b;
        }
        public static double4 operator %(double4 a, double2 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            return a;
        }
        public static double4 operator %(double2 a, double4 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            return b;
        }
        public static double4 operator -(double4 a)
        {
            a.x = -a.x;
            a.y = -a.y;
            a.z = -a.z;
            a.w = -a.w;
            return a;
        }
        public static bool operator ==(double4 a, double4 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            a.w = a.w - b.w;
            return a.x * a.x + a.y * a.y + a.z * a.z + a.w * a.w < 0.0000000001d;
        }
        public static bool operator !=(double4 a, double4 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            a.w = a.w - b.w;
            return a.x * a.x + a.y * a.y + a.z * a.z + a.w * a.w >= 0.0000000001d;
        }
        public static bool operator ==(double4 a, float4 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            a.w = a.w - b.w;
            return a.x * a.x + a.y * a.y + a.z * a.z + a.w * a.w < 0.0000000001d;
        }
        public static bool operator !=(double4 a, float4 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            a.w = a.w - b.w;
            return a.x * a.x + a.y * a.y + a.z * a.z + a.w * a.w >= 0.0000000001d;
        }
        public static bool operator ==(float4 a, double4 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            b.z = a.z - b.z;
            b.w = a.w - b.w;
            return a.x * a.x + a.y * a.y + a.z * a.z + a.w * a.w < 0.0000000001d;
        }
        public static bool operator !=(float4 a, double4 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            b.z = a.z - b.z;
            b.w = a.w - b.w;
            return a.x * a.x + a.y * a.y + a.z * a.z + a.w * a.w >= 0.0000000001d;
        }
        public static explicit operator bool2(double4 v)
        {
            bool2 vec;
            vec.x = v.x > 0d;
            vec.y = v.y > 0d;
            return vec;
        }
        public static explicit operator bool3(double4 v)
        {
            bool3 vec;
            vec.x = v.x > 0d;
            vec.y = v.y > 0d;
            vec.z = v.z > 0d;
            return vec;
        }
        public static explicit operator bool4(double4 v)
        {
            bool4 vec;
            vec.x = v.x > 0d;
            vec.y = v.y > 0d;
            vec.z = v.z > 0d;
            vec.w = v.w > 0d;
            return vec;
        }
        public static explicit operator float2(double4 v)
        {
            float2 vec;
            vec.x = (float)v.x;
            vec.y = (float)v.y;
            return vec;
        }
        public static explicit operator float3(double4 v)
        {
            float3 vec;
            vec.x = (float)v.x;
            vec.y = (float)v.y;
            vec.z = (float)v.z;
            return vec;
        }
        public static implicit operator float4(double4 v)
        {
            float4 vec;
            vec.x = (float)v.x;
            vec.y = (float)v.y;
            vec.z = (float)v.z;
            vec.w = (float)v.w;
            return vec;
        }
        public static explicit operator double3(double4 v)
        {
            double3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            return vec;
        }
        public static explicit operator double2(double4 v)
        {
            double2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static explicit operator int2(double4 v)
        {
            int2 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            return vec;
        }
        public static explicit operator int3(double4 v)
        {
            int3 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            vec.z = (int)v.z;
            return vec;
        }
        public static explicit operator int4(double4 v)
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
