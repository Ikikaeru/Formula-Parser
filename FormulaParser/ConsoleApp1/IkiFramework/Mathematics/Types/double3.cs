using System;
using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    [Serializable]
    public partial struct double3 : IEquatable<double3>
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
        /// <summary>
        /// Creates a new vector with given x, y, z components.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public double3(double xyz)
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
        public double3(double x, double y, double z = 0d)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        /// <summary>
        /// Creates a new vector with given x double and yz double2 components.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="a"></param>
        public double3(double x, double2 a)
        {
            this.x = x;
            y = a.x;
            z = a.y;
        }
        /// <summary>
        /// Creates a new vector with given xy double2 and z double components.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="z"></param>
        public double3(double2 a, double z = 0d)
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
        public void Set(double newX, double newY, double newZ)
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
        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    default:
                        throw new IndexOutOfRangeException("Invalid double3 index!");
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
                        throw new IndexOutOfRangeException("Invalid double3 index!");
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
        public static double3 Lerp(double3 a, double3 b, double t)
        {
            t = t < 0d ? 0d : t > 1d ? 1d : t;
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
        public double3 Unlerp(double3 a, double3 b, double t)
        {
            t = t < 0d ? 0d : t > 1d ? 1d : t;
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
        public double3 Unlerp(double3 b, double t)
        {
            t = t < 0d ? 0d : t > 1d ? 1d : t;
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
        public static double3 Nlerp(double3 a, double3 b, double t)
        {
            t = t < 0d ? 0d : t > 1d ? 1d : t;
            a.x = a.x + (b.x - a.x) * t;
            a.y = a.y + (b.y - a.y) * t;
            a.z = a.z + (b.z - a.z) * t;
            double mag = (double)Mathematics.Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z);
            if (mag > 0.000000000001d)
            {
                a.x = a.x / mag;
                a.y = a.y / mag;
                a.z = a.z / mag;
            }
            else
            {
                a.x = 0d;
                a.y = 0d;
                a.z = 0d;
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
        public static double3 QuadraticBezier(double3 a, double3 b, double3 c, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            double oneMinusT = 1f - t;
            a.x = oneMinusT * oneMinusT * a.x + 2d * oneMinusT * t * b.x + t * t * c.x;
            a.y = oneMinusT * oneMinusT * a.y + 2d * oneMinusT * t * b.y + t * t * c.y;
            a.z = oneMinusT * oneMinusT * a.z + 2d * oneMinusT * t * b.z + t * t * c.z;
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
        public static double3 QuadraticBezierTangent(double3 a, double3 b, double3 c, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            a.x = 2d * (1d - t) * (b.x - a.x) + 2d * t * (c.x - b.x);
            a.y = 2d * (1d - t) * (b.y - a.y) + 2d * t * (c.y - b.y);
            a.z = 2d * (1d - t) * (b.z - a.z) + 2d * t * (c.z - b.z);
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
        public static double3 CubicBezier(double3 a, double3 b, double3 c, double3 d, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            double oneMinusT = 1d - t;
            double oneMinusTPow2 = oneMinusT * oneMinusT;
            double t2 = t * t;
            a.x = oneMinusTPow2 * oneMinusT * a.x + 3d * oneMinusTPow2 * t * b.x + 3d * oneMinusT * t2 * c.x + t2 * t * d.x;
            a.y = oneMinusTPow2 * oneMinusT * a.y + 3d * oneMinusTPow2 * t * b.y + 3d * oneMinusT * t2 * c.y + t2 * t * d.y;
            a.z = oneMinusTPow2 * oneMinusT * a.z + 3d * oneMinusTPow2 * t * b.z + 3d * oneMinusT * t2 * c.z + t2 * t * d.z;
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
        public static double3 CubicBezierTangent(double3 a, double3 b, double3 c, double3 d, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            double oneMinusT = 1d - t;
            a.x = 3d * oneMinusT * oneMinusT * (b.x - a.x) + 6d * oneMinusT * t * (c.x - b.x) + 3d * t * t * (d.x - c.x);
            a.y = 3d * oneMinusT * oneMinusT * (b.y - a.y) + 6d * oneMinusT * t * (c.y - b.y) + 3d * t * t * (d.y - c.y);
            a.z = 3d * oneMinusT * oneMinusT * (b.z - a.z) + 6d * oneMinusT * t * (c.z - b.z) + 3d * t * t * (d.z - c.z);
            return a;
        }
        /// <summary>
        /// Linearly interpolates between two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static double3 LerpUnclamped(double3 a, double3 b, double t)
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
        public double3 UnlerpUnclamped(double3 a, double3 b, double t)
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
        public double3 UnlerpUnclamped(double3 b, double t)
        {
            b.x = (t - x) / (b.x - x);
            b.y = (t - y) / (b.y - y);
            b.z = (t - z) / (b.z - z);
            return b;
        }
        /// <summary>
        /// Returns the direction of b from a.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double3 Direction(double3 a, double3 b)
        {
            double3 dir;
            dir.x = b.x - a.x;
            dir.y = b.y - a.y;
            dir.z = b.z - a.z;
            double mag = Mathematics.Math.Sqrt(dir.x * dir.x + dir.y * dir.y + dir.z * dir.z);
            if (mag > 0.000000000001d)
            {
                dir.x = dir.x / mag;
                dir.y = dir.y / mag;
                dir.z = dir.z / mag;
                return dir;
            }
            dir.x = 0d;
            dir.y = 0d;
            dir.z = 0d;
            return dir;
        }
        /// <summary>
        /// Lineary interpolates between two vectors and normalize the result.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static double3 NlerpUnclamped(double3 a, double3 b, double t)
        {
            a.x = a.x + (b.x - a.x) * t;
            a.y = a.y + (b.y - a.y) * t;
            a.z = a.z + (b.z - a.z) * t;
            double mag = (double)Mathematics.Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z);
            if (mag > 0.000000000001d)
            {
                a.x = a.x / mag;
                a.y = a.y / mag;
                a.z = a.z / mag;
            }
            else
            {
                a.x = 0d;
                a.y = 0d;
                a.z = 0d;
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
        public static double3 QuadraticBezierUnclamped(double3 a, double3 b, double3 c, double t)
        {
            double oneMinusT = 1d - t;
            a.x = oneMinusT * oneMinusT * a.x + 2d * oneMinusT * t * b.x + t * t * c.x;
            a.y = oneMinusT * oneMinusT * a.y + 2d * oneMinusT * t * b.y + t * t * c.y;
            a.z = oneMinusT * oneMinusT * a.z + 2d * oneMinusT * t * b.z + t * t * c.z;
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
        public static double3 QuadraticBezierTangentUnclamped(double3 a, double3 b, double3 c, double t)
        {
            a.x = 2d * (1d - t) * (b.x - a.x) + 2d * t * (c.x - b.x);
            a.y = 2d * (1d - t) * (b.y - a.y) + 2d * t * (c.y - b.y);
            a.z = 2d * (1d - t) * (b.z - a.z) + 2d * t * (c.z - b.z);
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
        public static double3 CubicBezierUnclamped(double3 a, double3 b, double3 c, double3 d, double t)
        {
            double oneMinusT = 1d - t;
            double oneMinusTPow2 = oneMinusT * oneMinusT;
            double t2 = t * t;
            a.x = oneMinusTPow2 * oneMinusT * a.x + 3d * oneMinusTPow2 * t * b.x + 3d * oneMinusT * t2 * c.x + t2 * t * d.x;
            a.y = oneMinusTPow2 * oneMinusT * a.y + 3d * oneMinusTPow2 * t * b.y + 3d * oneMinusT * t2 * c.y + t2 * t * d.y;
            a.z = oneMinusTPow2 * oneMinusT * a.z + 3d * oneMinusTPow2 * t * b.z + 3d * oneMinusT * t2 * c.z + t2 * t * d.z;
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
        public static double3 CubicBezierTangentUnclamped(double3 a, double3 b, double3 c, double3 d, double t)
        {
            double oneMinusT = 1d - t;
            a.x = 3d * oneMinusT * oneMinusT * (b.x - a.x) + 6d * oneMinusT * t * (c.x - b.x) + 3d * t * t * (d.x - c.x);
            a.y = 3d * oneMinusT * oneMinusT * (b.y - a.y) + 6d * oneMinusT * t * (c.y - b.y) + 3d * t * t * (d.y - c.y);
            a.z = 3d * oneMinusT * oneMinusT * (b.z - a.z) + 6d * oneMinusT * t * (c.z - b.z) + 3d * t * t * (d.z - c.z);
            return a;
        }
        /// <summary>
        /// Moves a point current in a straight line towards a target point.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="target"></param>
        /// <param name="maxDistanceDelta"></param>
        /// <returns></returns>
        public static double3 MoveTowards(double3 current, double3 target, double maxDistanceDelta)
        {
            double toVectorx = target.x - current.x;
            double toVectory = target.y - current.y;
            double toVectorz = target.z - current.z;
            double dist = Mathematics.Math.Sqrt(toVectorx * toVectorx + toVectory * toVectory + toVectorz * toVectorz);
            if (dist <= maxDistanceDelta || dist < double.Epsilon)
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
        public double3 MoveTowards(double3 target, double maxDistanceDelta)
        {
            double toVectorx = target.x - x;
            double toVectory = target.y - y;
            double toVectorz = target.z - z;
            double dist = Mathematics.Math.Sqrt(toVectorx * toVectorx + toVectory * toVectory + toVectorz * toVectorz);
            if (dist <= maxDistanceDelta || dist < double.Epsilon)
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
        public double3 CastCenterOnCollision(double3 direction, double hitInfoDistance)
        {
            double mag = Mathematics.Math.Sqrt(direction.x * direction.x + direction.y * direction.y + direction.z * direction.z);
            if (mag > 0.000000000001d)
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
        public bool IsInRange(double3 targetPosition, double rangeDistance)
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
        public double Distance(double3 target)
        {
            target.x = x - target.x;
            target.y = y - target.y;
            target.z = z - target.z;
            return Mathematics.Math.Sqrt(target.x * target.x + target.y * target.y + target.z * target.z);
        }
        /// <summary>
        /// Cross Product of two vectors.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public double3 Cross(double3 b)
        {
            double3 vec;
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
        public double3 Direction(double3 targetPosition)
        {
            targetPosition.x = targetPosition.x - x;
            targetPosition.y = targetPosition.y - y;
            targetPosition.z = targetPosition.z - z;
            double mag = Mathematics.Math.Sqrt(targetPosition.x * targetPosition.x + targetPosition.y * targetPosition.y + targetPosition.z * targetPosition.z);
            if (mag > 0.000000000001d)
            {
                targetPosition.x = targetPosition.x / mag;
                targetPosition.y = targetPosition.y / mag;
                targetPosition.z = targetPosition.z / mag;
                return targetPosition;
            }
            targetPosition.x = 0d;
            targetPosition.y = 0d;
            targetPosition.z = 0d;
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
        public static double3 SmoothDamp(double3 current, double3 target, ref double3 currentVelocity, double smoothTime, double maxSpeed, double deltaTime)
        {
            smoothTime = 0.0001d > smoothTime ? 0.0001d : smoothTime;
            double omega = 2d / smoothTime;
            double x = omega * deltaTime;
            double exp = 1d / (1d + x + 0.48d * x * x + 0.235d * x * x * x);
            double3 change;
            change.x = current.x - target.x;
            change.y = current.y - target.y;
            change.z = current.z - target.z;
            double3 originalTo = target;
            double maxChange = maxSpeed * smoothTime;
            double sqrMag = change.x * change.x + change.y * change.y + change.z * change.z;
            if (sqrMag > maxChange * maxChange)
            {
                sqrMag = Mathematics.Math.Sqrt(sqrMag);
                if (sqrMag > 0.000000000001d)
                {
                    change.x = change.x / sqrMag;
                    change.y = change.y / sqrMag;
                    change.z = change.z / sqrMag;
                }
                else
                {
                    change.x = 0d;
                    change.y = 0d;
                    change.z = 0d;
                }
            }
            target.x = current.x - change.x;
            target.y = current.y - change.y;
            target.z = current.z - change.z;
            double tempX, tempY, tempZ;
            tempX = (currentVelocity.x + omega * change.x) * deltaTime;
            tempY = (currentVelocity.y + omega * change.y) * deltaTime;
            tempZ = (currentVelocity.z + omega * change.z) * deltaTime;
            currentVelocity.x = (currentVelocity.x - omega * tempX) * exp;
            currentVelocity.y = (currentVelocity.y - omega * tempY) * exp;
            currentVelocity.z = (currentVelocity.z - omega * tempZ) * exp;
            double3 output;
            output.x = target.x + (change.x + tempX) * exp;
            output.y = target.y + (change.y + tempY) * exp;
            output.z = target.z + (change.z + tempZ) * exp;
            double oriCurrX = originalTo.x - current.x;
            double oriCurrY = originalTo.y - current.y;
            double oriCurrZ = originalTo.z - current.z;
            double outOriX = output.x - originalTo.x;
            double outOriY = output.y - originalTo.y;
            double outOriZ = output.z - originalTo.z;
            if ((oriCurrX * outOriX + oriCurrY * outOriY + oriCurrZ * outOriZ) > 0d)
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
        public static double3 Cross(double3 a, double3 b)
        {
            double3 vec;
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
            if (!(other is double3))
            {
                return false;
            }
            return Equals((double3)other);
        }
        /// <summary>
        /// Returns true if the given vector is exactly equal to this vector.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(double3 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z);
        }
        /// <summary>
        /// Reflects a vector off the plane defined by a normal.
        /// </summary>
        /// <param name="inDirection"></param>
        /// <param name="inNormal"></param>
        /// <returns></returns>
        public static double3 Reflect(double3 inDirection, double3 inNormal)
        {
            double dotNorm = inNormal.x * inDirection.x + inNormal.y * inDirection.y + inNormal.z * inDirection.z;
            inDirection.x = -2d * dotNorm * inNormal.x + inDirection.x;
            inDirection.y = -2d * dotNorm * inNormal.y + inDirection.y;
            inDirection.z = -2d * dotNorm * inNormal.z + inDirection.z;
            return inDirection;
        }
        /// <summary>
        /// Reflects a vector off the plane defined by a normal.
        /// </summary>
        /// <param name="inNormal"></param>
        /// <returns></returns>
        public double3 Reflect(double3 inNormal)
        {
            double dotNorm = inNormal.x * x + inNormal.y * y + inNormal.z * z;
            inNormal.x = -2d * dotNorm * inNormal.x + x;
            inNormal.y = -2d * dotNorm * inNormal.y + y;
            inNormal.z = -2d * dotNorm * inNormal.z + z;
            return inNormal;
        }
        /// <summary>
        /// Makes this vector have a magnitude of 1.
        /// </summary>
        public void Normalize()
        {
            double mag = Mathematics.Math.Sqrt(x * x + y * y + z * z);
            if (mag > 0.000000000001d)
            {
                x = x / mag;
                y = y / mag;
                z = z / mag;
            }
            else
            {
                x = 0d;
                y = 0d;
                z = 0d;
            }
        }
        /// <summary>
        /// Returns this vector with a magnitude of 1 (Read Only).
        /// </summary>
        [XmlIgnore]
        public double3 Normalized
        {
            get
            {
                double mag = Mathematics.Math.Sqrt(x * x + y * y + z * z);
                double3 value;
                if (mag > 0.000000000001d)
                {
                    value.x = x / mag;
                    value.y = y / mag;
                    value.z = z / mag;
                    return value;
                }
                value.x = 0d;
                value.y = 0d;
                value.z = 0d;
                return value;
            }
        }
        /// <summary>
        /// Dot Product of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Dot(double3 a, double3 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }
        /// <summary>
        /// Dot Product of two vectors.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Dot(double3 b)
        {
            return x * b.x + y * b.y + z * b.z;
        }
        /// <summary>
        /// Projects a vector onto another vector.
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="onNormal"></param>
        /// <returns></returns>
        public static double3 Project(double3 vector, double3 onNormal)
        {
            double sqrMag = onNormal.x * onNormal.x + onNormal.y * onNormal.y + onNormal.z * onNormal.z;
            if (sqrMag < double.Epsilon)
            {
                return Zero;
            }
            double d = vector.x * onNormal.x + vector.y * onNormal.y + vector.z * onNormal.z;
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
        public static double3 ProjectOnPlane(double3 vector, double3 planeNormal)
        {
            double sqrMag = planeNormal.x * planeNormal.x + planeNormal.y * planeNormal.y + planeNormal.z * planeNormal.z;
            if (sqrMag < double.Epsilon)
            {
                return Zero;
            }
            double d = vector.x * planeNormal.x + vector.y * planeNormal.y + vector.z * planeNormal.z;
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
        public static double Angle(double3 from, double3 to)
        {
            double denominator = Mathematics.Math.Sqrt((from.x * from.x + from.y * from.y + from.z * from.z) * (to.x * to.x + to.y * to.y + to.z * to.z));
            if (denominator < 1e-15d)
            {
                return 0d;
            }
            from.x = (from.x * to.x + from.y * to.y + from.z * to.z) / denominator;
            return System.Math.Acos(from.x < -1d ? -1d : from.x > 1d ? 1d : from.x) * 57.2957795131d;
        }
        /// <summary>
        /// Returns the angle in degrees between from and to.
        /// </summary>
        /// <param name="to"></param>
        /// <returns></returns>
        public double AngleBetweenDirections(double3 to)
        {
            double denominator = Mathematics.Math.Sqrt((x * x + y * y + z * z) * (to.x * to.x + to.y * to.y + to.z * to.z));
            if (denominator < 1e-15d)
            {
                return 0d;
            }
            to.x = (x * to.x + y * to.y + z * to.z) / denominator;
            return System.Math.Acos(to.x < -1d ? -1d : to.x > 1d ? 1d : to.x) * 57.2957795131d;
        }
        /// <summary>
        /// Returns the signed angle in degrees between from and to.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="axis"></param>
        /// <returns></returns>
        public static double SignedAngle(double3 from, double3 to, double3 axis)
        {
            double unsignedAngle;
            double denominator = Mathematics.Math.Sqrt((from.x * from.x + from.y * from.y + from.z * from.z) * (to.x * to.x + to.y * to.y + to.z * to.z));
            if (denominator < 1e-15d)
            {
                unsignedAngle = 0d;
            }
            else
            {
                double val = (from.x * to.x + from.y * to.y + from.z * to.z) / denominator;
                double dot = val < -1d ? -1d : val > 1d ? 1d : val;
                unsignedAngle = System.Math.Acos(dot) * 57.2957795131d;
            }
            double3 vec;
            vec.x = from.y * to.z - from.z * to.y;
            vec.y = from.z * to.x - from.x * to.z;
            vec.z = from.x * to.y - from.y * to.x;
            return unsignedAngle * ((axis.x * vec.x + axis.y * vec.y + axis.z * vec.z) < 0d ? -1d : 1d);
        }
        /// <summary>
        /// Returns the signed angle in degrees between from and to.
        /// </summary>
        /// <param name="to"></param>
        /// <param name="axis"></param>
        /// <returns></returns>
        public double SignedAngle(double3 to, double3 axis)
        {
            double unsignedAngle;
            double denominator = Mathematics.Math.Sqrt((x * x + y * y + z * z) * (to.x * to.x + to.y * to.y + to.z * to.z));
            if (denominator < 1e-15d)
            {
                unsignedAngle = 0d;
            }
            else
            {
                double val = (x * to.x + y * to.y + z * to.z) / denominator;
                double dot = val < -1d ? -1d : val > 1d ? 1d : val;
                unsignedAngle = System.Math.Acos(dot) * 57.2957795131d;
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
        public double DotProductAngle(double3 target)
        {
            double3 normThis = Normalized;
            target.Normalize();
            normThis.x = normThis.x * target.x + normThis.y * target.y + normThis.z * target.z;
            normThis.x = normThis.x > 1d ? 1d : normThis.x < -1d ? -1d : normThis.x;
            return System.Math.Acos(normThis.x);
        }
        /// <summary>
        /// Returns the distance between a and b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Distance(double3 a, double3 b)
        {
            double vecx = a.x - b.x;
            double vecy = a.y - b.y;
            double vecz = a.z - b.z;
            return Mathematics.Math.Sqrt(vecx * vecx + vecy * vecy + vecz * vecz);
        }
        /// <summary>
        /// Return the double raised to the power.
        /// </summary>
        /// <param name="power"></param>
        /// <returns></returns>
        public double3 Pow(double3 power)
        {
            double3 vec;
            vec.x = Mathematics.Math.Pow(x, power.x);
            vec.y = Mathematics.Math.Pow(y, power.y);
            vec.z = Mathematics.Math.Pow(z, power.z);
            return vec;
        }
        /// <summary>
        /// Return the sinus of each vector's components.
        /// </summary>
        [XmlIgnore]
        public double3 Sin
        {
            get
            {
                double3 vec;
                vec.x = System.Math.Sin(x);
                vec.y = System.Math.Sin(y);
                vec.z = System.Math.Sin(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the cosine of each vector's components.
        /// </summary>
        [XmlIgnore]
        public double3 Cos
        {
            get
            {
                double3 vec;
                vec.x = System.Math.Cos(x);
                vec.y = System.Math.Cos(y);
                vec.z = System.Math.Cos(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the tangent of each vector's components.
        /// </summary>
        [XmlIgnore]
        public double3 Tan
        {
            get
            {
                double3 vec;
                vec.x = System.Math.Tan(x);
                vec.y = System.Math.Tan(y);
                vec.z = System.Math.Tan(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the arc sinus of each vector's components.
        /// </summary>
        [XmlIgnore]
        public double3 Asin
        {
            get
            {
                double3 vec;
                vec.x = System.Math.Asin(x);
                vec.y = System.Math.Asin(y);
                vec.z = System.Math.Asin(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the arc cosine of each vector's components.
        /// </summary>
        [XmlIgnore]
        public double3 Acos
        {
            get
            {
                double3 vec;
                vec.x = System.Math.Acos(x);
                vec.y = System.Math.Acos(y);
                vec.z = System.Math.Acos(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the arc tangent of each vector's components.
        /// </summary>
        [XmlIgnore]
        public double3 Atan
        {
            get
            {
                double3 vec;
                vec.x = System.Math.Atan(x);
                vec.y = System.Math.Atan(y);
                vec.z = System.Math.Atan(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the hyperbolic sinus of each vector's components.
        /// </summary>
        [XmlIgnore]
        public double3 Sinh
        {
            get
            {
                double3 vec;
                vec.x = System.Math.Sinh(x);
                vec.y = System.Math.Sinh(y);
                vec.z = System.Math.Sinh(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the hyperbolic cosine of each vector's components.
        /// </summary>
        [XmlIgnore]
        public double3 Cosh
        {
            get
            {
                double3 vec;
                vec.x = System.Math.Cosh(x);
                vec.y = System.Math.Cosh(y);
                vec.z = System.Math.Cosh(z);
                return vec;
            }
        }
        /// <summary>
        /// Return the hyperbolic tangent of each vector's components.
        /// </summary>
        [XmlIgnore]
        public double3 Tanh
        {
            get
            {
                double3 vec;
                vec.x = System.Math.Tanh(x);
                vec.y = System.Math.Tanh(y);
                vec.z = System.Math.Tanh(z);
                return vec;
            }
        }
        /// <summary>
        /// Returns a copy of vector with its magnitude clamped to maxLength.
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        public static double3 ClampMagnitude(double3 vector, double maxLength)
        {
            double sqrMag = vector.x * vector.x + vector.y * vector.y + vector.z * vector.z;
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
        public double Magnitude
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
        public double SqrMagnitude
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
        public static double3 Min(double3 a, double3 b)
        {
            double3 vec;
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
        public static double3 Max(double3 a, double3 b)
        {
            double3 vec;
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
        public double3 Min(double3 b)
        {
            double3 vec;
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
        public double3 Max(double3 b)
        {
            double3 vec;
            vec.x = x > b.x ? x : b.x;
            vec.y = y > b.y ? y : b.y;
            vec.z = z > b.z ? z : b.z;
            return vec;
        }
        /// <summary>
        /// Return the minimum value of this vector's component and the double.
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public double3 Min(double w)
        {
            double3 vec;
            vec.x = x > w ? w : x;
            vec.y = y > w ? w : y;
            vec.z = z > w ? w : z;
            return vec;
        }
        /// <summary>
        /// Return the maximum value of this vector's component and the double.
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public double3 Max(double w)
        {
            double3 vec;
            vec.x = x > w ? x : w;
            vec.y = y > w ? y : w;
            vec.z = z > w ? z : w;
            return vec;
        }
        /// <summary>
        /// Rounds down each component of the vector.
        /// </summary>
        [XmlIgnore]
        public double3 Floor
        {
            get
            {
                double3 vec;
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
        public bool IsOppositeDirection(double3 b)
        {
            return x * b.x + y * b.y + z * b.z < 0d;
        }
        /// <summary>
        /// Return if both vectors are perpendicular to each other.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsPerpendicular(double3 b)
        {
            return x * b.x + y * b.y + z * b.z == 0d;
        }
        /// <summary>
        /// Return if botch vectors are in the same direction.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsSimilarDirection(double3 b)
        {
            return x * b.x + y * b.y + z * b.z > 0d;
        }
        /// <summary>
        /// Spherically interpolate direction vector. It doesn't work with point in space like slerp.
        /// </summary>
        /// <param name="actualVector"></param>
        /// <param name="targetVector"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public double3 Nslerp(double3 actualVector, double3 targetVector, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            double startMag = Mathematics.Math.Sqrt(actualVector.x * actualVector.x + actualVector.y * actualVector.y + actualVector.z * actualVector.z);
            startMag = startMag + (Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z) - startMag) * t;
            double dot = actualVector.x * targetVector.x + actualVector.y * targetVector.y + actualVector.z * targetVector.z;
            double theta = System.Math.Acos(dot) * t;
            double c = System.Math.Cos(theta);
            double s = System.Math.Sin(theta);
            targetVector.x = targetVector.x - actualVector.x * dot;
            targetVector.y = targetVector.y - actualVector.y * dot;
            targetVector.z = targetVector.z - actualVector.z * dot;
            double normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.000000000001d)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0d;
                targetVector.y = 0d;
                targetVector.z = 0d;
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
        public double3 Nslerp(double3 targetVector, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            double3 actualVector;
            actualVector.x = x;
            actualVector.y = y;
            actualVector.z = z;
            double startMag = Mathematics.Math.Sqrt(actualVector.x * actualVector.x + actualVector.y * actualVector.y + actualVector.z * actualVector.z);
            startMag = startMag + (Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z) - startMag) * t;
            double dot = actualVector.x * targetVector.x + actualVector.y * targetVector.y + actualVector.z * targetVector.z;
            double theta = System.Math.Acos(dot) * t;
            double c = System.Math.Cos(theta);
            double s = System.Math.Sin(theta);
            targetVector.x = targetVector.x - actualVector.x * dot;
            targetVector.y = targetVector.y - actualVector.y * dot;
            targetVector.z = targetVector.z - actualVector.z * dot;
            double normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.000000000001d)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0d;
                targetVector.y = 0d;
                targetVector.z = 0d;
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
        public double3 NslerpUnclamped(double3 targetVector, double t)
        {
            double3 actualVector;
            actualVector.x = x;
            actualVector.y = y;
            actualVector.z = z;
            double startMag = Mathematics.Math.Sqrt(actualVector.x * actualVector.x + actualVector.y * actualVector.y + actualVector.z * actualVector.z);
            startMag = startMag + (Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z) - startMag) * t;
            double dot = actualVector.x * targetVector.x + actualVector.y * targetVector.y + actualVector.z * targetVector.z;
            double theta = System.Math.Acos(dot) * t;
            double c = System.Math.Cos(theta);
            double s = System.Math.Sin(theta);
            targetVector.x = targetVector.x - actualVector.x * dot;
            targetVector.y = targetVector.y - actualVector.y * dot;
            targetVector.z = targetVector.z - actualVector.z * dot;
            double normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.000000000001d)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0d;
                targetVector.y = 0d;
                targetVector.z = 0d;
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
        public double3 NslerpUnclamped(double3 actualVector, double3 targetVector, double t)
        {
            double startMag = Mathematics.Math.Sqrt(actualVector.x * actualVector.x + actualVector.y * actualVector.y + actualVector.z * actualVector.z);
            startMag = startMag + (Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z) - startMag) * t;
            double dot = actualVector.x * targetVector.x + actualVector.y * targetVector.y + actualVector.z * targetVector.z;
            double theta = System.Math.Acos(dot) * t;
            double c = System.Math.Cos(theta);
            double s = System.Math.Sin(theta);
            targetVector.x = targetVector.x - actualVector.x * dot;
            targetVector.y = targetVector.y - actualVector.y * dot;
            targetVector.z = targetVector.z - actualVector.z * dot;
            double normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.000000000001d)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0d;
                targetVector.y = 0d;
                targetVector.z = 0d;
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
        public double3 Slerp(double3 targetVector, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            double3 vec;
            double startMag = Mathematics.Math.Sqrt(x * x + y * y + z * z);
            if (startMag > 0.000000000001d)
            {
                vec.x = x / startMag;
                vec.y = y / startMag;
                vec.z = z / startMag;
            }
            else
            {
                vec.x = 0d;
                vec.y = 0d;
                vec.z = 0d;
            }
            double normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.000000000001d)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0d;
                targetVector.y = 0d;
                targetVector.z = 0d;
            }
            startMag = startMag + (normalizedMag - startMag) * t;
            double dot = vec.x * targetVector.x + vec.y * targetVector.y + vec.z * targetVector.z;
            double theta = System.Math.Acos(dot) * t;
            double c = System.Math.Cos(theta);
            double s = System.Math.Sin(theta);
            targetVector.x = targetVector.x - vec.x * dot;
            targetVector.y = targetVector.y - vec.y * dot;
            targetVector.z = targetVector.z - vec.z * dot;
            normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.000000000001d)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0d;
                targetVector.y = 0d;
                targetVector.z = 0d;
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
        public static double3 Slerp(double3 actualVector, double3 targetVector, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            double startMag = Mathematics.Math.Sqrt(actualVector.x * actualVector.x + actualVector.y * actualVector.y + actualVector.z * actualVector.z);
            if (startMag > 0.000000000001d)
            {
                actualVector.x = actualVector.x / startMag;
                actualVector.y = actualVector.y / startMag;
                actualVector.z = actualVector.z / startMag;
            }
            else
            {
                actualVector.x = 0d;
                actualVector.y = 0d;
                actualVector.z = 0d;
            }
            double normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.000000000001d)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0d;
                targetVector.y = 0d;
                targetVector.z = 0d;
            }
            startMag = startMag + (normalizedMag - startMag) * t;
            double dot = actualVector.x * targetVector.x + actualVector.y * targetVector.y + actualVector.z * targetVector.z;
            double theta = System.Math.Acos(dot) * t;
            double c = System.Math.Cos(theta);
            double s = System.Math.Sin(theta);
            targetVector.x = targetVector.x - actualVector.x * dot;
            targetVector.y = targetVector.y - actualVector.y * dot;
            targetVector.z = targetVector.z - actualVector.z * dot;
            normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.000000000001d)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0d;
                targetVector.y = 0d;
                targetVector.z = 0d;
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
        public double3 SlerpUnclamped(double3 targetVector, double t)
        {
            double3 vec;
            double startMag = Mathematics.Math.Sqrt(x * x + y * y + z * z);
            if (startMag > 0.000000000001d)
            {
                vec.x = x / startMag;
                vec.y = y / startMag;
                vec.z = z / startMag;
            }
            else
            {
                vec.x = 0d;
                vec.y = 0d;
                vec.z = 0d;
            }
            double normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.000000000001d)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0d;
                targetVector.y = 0d;
                targetVector.z = 0d;
            }
            startMag = startMag + (normalizedMag - startMag) * t;
            double dot = vec.x * targetVector.x + vec.y * targetVector.y + vec.z * targetVector.z;
            double theta = System.Math.Acos(dot) * t;
            double c = System.Math.Cos(theta);
            double s = System.Math.Sin(theta);
            targetVector.x = targetVector.x - vec.x * dot;
            targetVector.y = targetVector.y - vec.y * dot;
            targetVector.z = targetVector.z - vec.z * dot;
            normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.000000000001d)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0d;
                targetVector.y = 0d;
                targetVector.z = 0d;
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
        public static double3 SlerpUnclamped(double3 actualVector, double3 targetVector, double t)
        {
            double startMag = Mathematics.Math.Sqrt(actualVector.x * actualVector.x + actualVector.y * actualVector.y + actualVector.z * actualVector.z);
            if (startMag > 0.000000000001d)
            {
                actualVector.x = actualVector.x / startMag;
                actualVector.y = actualVector.y / startMag;
                actualVector.z = actualVector.z / startMag;
            }
            else
            {
                actualVector.x = 0d;
                actualVector.y = 0d;
                actualVector.z = 0d;
            }
            double normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.000000000001d)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0d;
                targetVector.y = 0d;
                targetVector.z = 0d;
            }
            startMag = startMag + (normalizedMag - startMag) * t;
            double dot = actualVector.x * targetVector.x + actualVector.y * targetVector.y + actualVector.z * targetVector.z;
            double theta = System.Math.Acos(dot) * t;
            double c = System.Math.Cos(theta);
            double s = System.Math.Sin(theta);
            targetVector.x = targetVector.x - actualVector.x * dot;
            targetVector.y = targetVector.y - actualVector.y * dot;
            targetVector.z = targetVector.z - actualVector.z * dot;
            normalizedMag = Mathematics.Math.Sqrt(targetVector.x * targetVector.x + targetVector.y * targetVector.y + targetVector.z * targetVector.z);
            if (normalizedMag > 0.000000000001d)
            {
                targetVector.x = targetVector.x / normalizedMag;
                targetVector.y = targetVector.y / normalizedMag;
                targetVector.z = targetVector.z / normalizedMag;
            }
            else
            {
                targetVector.x = 0d;
                targetVector.y = 0d;
                targetVector.z = 0d;
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
        public double3 Clamp(double min, double max)
        {
            double3 vec;
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
        public double3 Clamp(double3 min, double3 max)
        {
            double3 vec;
            vec.x = x < min.x ? min.x : x > max.x ? max.x : x;
            vec.y = y < min.y ? min.y : y > max.y ? max.y : y;
            vec.z = z < min.z ? min.z : z > max.z ? max.z : z;
            return vec;
        }
        /// <summary>
        /// Clamp the vector between 0 and 1.
        /// </summary>
        [XmlIgnore]
        public double3 Saturate
        {
            get
            {
                double3 vec;
                vec.x = x < 0d ? 0d : x > 1d ? 1d : x;
                vec.y = y < 0d ? 0d : y > 1d ? 1d : y;
                vec.z = z < 0d ? 0d : z > 1d ? 1d : z;
                return vec;
            }
        }
        /// <summary>
        /// Return the absolute value of the vector.
        /// </summary>
        [XmlIgnore]
        public double3 Abs
        {
            get
            {
                double3 vec;
                vec.x = x < 0d ? -x : x;
                vec.y = y < 0d ? -y : y;
                vec.z = z < 0d ? -z : z;
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
        /// Return the double raised to the power.
        /// </summary>
        /// <param name="power"></param>
        /// <returns></returns>
        public double3 Pow(double power)
        {
            double3 vec;
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
        public double3 SmoothStep(double3 b, double x)
        {
            double3 vec;
            vec.x = (x - this.x) / (b.x - this.x);
            vec.x = vec.x > 1d ? 1d : (vec.x < 0d ? 0d : vec.x);
            vec.x = vec.x * vec.x * (3d - 2d * vec.x);
            vec.y = (x - y) / (b.y - y);
            vec.y = vec.y > 1d ? 1d : (vec.y < 0d ? 0d : vec.y);
            vec.y = vec.y * vec.y * (3d - 2d * vec.y);
            vec.z = (x - z) / (b.z - z);
            vec.z = vec.z > 1d ? 1d : (vec.z < 0d ? 0d : vec.z);
            vec.z = vec.z * vec.z * (3d - 2d * vec.z);
            return vec;
        }
        /// <summary>
        /// Do a smoothstep from vectors value.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public double3 SmoothStep(double3 b, double3 x)
        {
            double3 vec;
            vec.x = (x.x - this.x) / (b.x - this.x);
            vec.x = vec.x > 1d ? 1d : (vec.x < 0d ? 0d : vec.x);
            vec.x = vec.x * vec.x * (3d - 2d * vec.x);
            vec.y = (x.y - y) / (b.y - y);
            vec.y = vec.y > 1d ? 1d : (vec.y < 0d ? 0d : vec.y);
            vec.y = vec.y * vec.y * (3d - 2d * vec.y);
            vec.z = (x.z - z) / (b.z - z);
            vec.z = vec.z > 1d ? 1d : (vec.z < 0d ? 0d : vec.z);
            vec.z = vec.z * vec.z * (3d - 2d * vec.z);
            return vec;
        }
        /// <summary>
        /// Return the square root of each component.
        /// </summary>
        [XmlIgnore]
        public double3 Sqrt
        {
            get
            {
                double3 vec;
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
        public double3 Ceil
        {
            get
            {
                double3 vec;
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
        public double3 Round
        {
            get
            {
                double3 vec;
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
        public double3 Step(double3 x)
        {
            double3 vec;
            vec.x = this.x >= x.x ? 1d : 0d;
            vec.y = y >= x.y ? 1d : 0d;
            vec.z = z >= x.z ? 1d : 0d;
            return vec;
        }
        /// <summary>
        /// Returns the fractional portion of each vector component.
        /// </summary>
        [XmlIgnore]
        public double3 Fract
        {
            get
            {
                double3 vec;
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
        public double3 Exp
        {
            get
            {
                double3 vec;
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
        public double3 Exp2
        {
            get
            {
                double3 vec;
                vec.x = Mathematics.Math.Exp(x * 0.69314718d);
                vec.y = Mathematics.Math.Exp(y * 0.69314718d);
                vec.z = Mathematics.Math.Exp(z * 0.69314718d);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-10 exponential of each component.
        /// </summary>
        [XmlIgnore]
        public double3 Exp10
        {
            get
            {
                double3 vec;
                vec.x = Mathematics.Math.Exp(x * 2.30258509d);
                vec.y = Mathematics.Math.Exp(y * 2.30258509d);
                vec.z = Mathematics.Math.Exp(z * 2.30258509d);
                return vec;
            }
        }
        /// <summary>
        /// Returns the natural logarithm of each component.
        /// </summary>
        [XmlIgnore]
        public double3 Ln
        {
            get
            {
                double3 vec;
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
        public double3 Log2
        {
            get
            {
                double3 vec;
                vec.x = Mathematics.Math.Log(x, 2d);
                vec.y = Mathematics.Math.Log(y, 2d);
                vec.z = Mathematics.Math.Log(z, 2d);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-10 logarithm of each component.
        /// </summary>
        [XmlIgnore]
        public double3 Log10
        {
            get
            {
                double3 vec;
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
        public double3 Sign
        {
            get
            {
                double3 vec;
                vec.x = x < 0d ? -1d : 1d;
                vec.y = y < 0d ? -1d : 1d;
                vec.z = z < 0d ? -1d : 1d;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(0, 0, 0).
        /// </summary>
        [XmlIgnore]
        public static double3 Zero
        {
            get
            {
                double3 vec;
                vec.x = 0d;
                vec.y = 0d;
                vec.z = 0d;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(0.5, 0.5, 0.5).
        /// </summary>
        [XmlIgnore]
        public static double3 Half
        {
            get
            {
                double3 vec;
                vec.x = 0.5d;
                vec.y = 0.5d;
                vec.z = 0.5d;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(1, 1, 1).
        /// </summary>
        [XmlIgnore]
        public static double3 One
        {
            get
            {
                double3 vec;
                vec.x = 1d;
                vec.y = 1d;
                vec.z = 1d;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(0, 0, 1).
        /// </summary>
        [XmlIgnore]
        public static double3 Forward
        {
            get
            {
                double3 vec;
                vec.x = 0d;
                vec.y = 0d;
                vec.z = 1d;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(0, 0, -1).
        /// </summary>
        [XmlIgnore]
        public static double3 Back
        {
            get
            {
                double3 vec;
                vec.x = 0d;
                vec.y = 0d;
                vec.z = -1d;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(0, 1, 0).
        /// </summary>
        [XmlIgnore]
        public static double3 Up
        {
            get
            {
                double3 vec;
                vec.x = 0d;
                vec.y = 1d;
                vec.z = 0d;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(0, -1, 0).
        /// </summary>
        [XmlIgnore]
        public static double3 Down
        {
            get
            {
                double3 vec;
                vec.x = 0d;
                vec.y = -1d;
                vec.z = 0d;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(-1, 0, 0).
        /// </summary>
        [XmlIgnore]
        public static double3 Left
        {
            get
            {
                double3 vec;
                vec.x = -1d;
                vec.y = 0d;
                vec.z = 0d;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(1, 0, 0).
        /// </summary>
        [XmlIgnore]
        public static double3 Right
        {
            get
            {
                double3 vec;
                vec.x = 1d;
                vec.y = 0d;
                vec.z = 0d;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity).
        /// </summary>
        [XmlIgnore]
        public static double3 PositiveInfinity
        {
            get
            {
                double3 vec;
                vec.x = double.PositiveInfinity;
                vec.y = double.PositiveInfinity;
                vec.z = double.PositiveInfinity;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector3(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity).
        /// </summary>
        [XmlIgnore]
        public static double3 NegativeInfinity
        {
            get
            {
                double3 vec;
                vec.x = double.NegativeInfinity;
                vec.y = double.NegativeInfinity;
                vec.z = double.NegativeInfinity;
                return vec;
            }
        }
        /// <summary>
        /// Freeze the position of desired component of the vector to 0.
        /// </summary>
        /// <param name="freezeAxis"></param>
        /// <returns></returns>
        public double3 FreezeVector(bool3 freezeAxis)
        {
            double3 vec;
            vec.x = freezeAxis.x ? 0d : x;
            vec.y = freezeAxis.y ? 0d : y;
            vec.z = freezeAxis.z ? 0d : z;
            return vec;
        }
        /// <summary>
        /// Return the refraction vector from the incident vector i, the normal vector n and the refraction index.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="n"></param>
        /// <param name="refractionIndex"></param>
        /// <returns></returns>
        public static double3 Refract(double3 i, double3 n, double refractionIndex)
        {
            double dt = n.x * i.x + n.y * i.y + n.z * i.z;
            double k = 1d - refractionIndex * refractionIndex * (1d - dt * dt);
            if (k >= 0d)
            {
                k = Mathematics.Math.Sqrt(k);
                n.x = refractionIndex * i.x - (refractionIndex * dt + k) * n.x;
                n.y = refractionIndex * i.y - (refractionIndex * dt + k) * n.y;
                n.z = refractionIndex * i.z - (refractionIndex * dt + k) * n.z;
                return n;
            }
            n.x = 0d;
            n.y = 0d;
            n.z = 0d;
            return n;
        }
        /// <summary>
        /// Return the refraction vector from the incident vector, the normal vector n and the refraction index.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="indexRegraction"></param>
        /// <returns></returns>
        public double3 Refract(double3 n, double refractionIndex)
        {
            double dt = n.x * x + n.y * y + n.z * z;
            double k = 1d - refractionIndex * refractionIndex * (1d - dt * dt);
            if (k >= 0d)
            {
                k = Mathematics.Math.Sqrt(k);
                n.x = refractionIndex * x - (refractionIndex * dt + k) * n.x;
                n.y = refractionIndex * y - (refractionIndex * dt + k) * n.y;
                n.z = refractionIndex * z - (refractionIndex * dt + k) * n.z;
                return n;
            }
            n.x = 0d;
            n.y = 0d;
            n.z = 0d;
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
        public double3 Remap(double minOldValue, double maxOldValue, double minNewValue, double maxNewValue)
        {
            maxOldValue = maxOldValue - minOldValue;
            maxNewValue = maxNewValue - minNewValue;
            double3 vec;
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
        public double3 Remap(double3 minOldValue, double3 maxOldValue, double3 minNewValue, double3 maxNewValue)
        {
            double3 vec;
            vec.x = minNewValue.x + (x - minOldValue.x) * (maxNewValue.x - minNewValue.x) / (maxOldValue.x - minOldValue.x);
            vec.y = minNewValue.y + (y - minOldValue.y) * (maxNewValue.y - minNewValue.y) / (maxOldValue.y - minOldValue.y);
            vec.z = minNewValue.z + (z - minOldValue.z) * (maxNewValue.z - minNewValue.z) / (maxOldValue.z - minOldValue.z);
            return vec;
        }
        /// <summary>
        /// Returns a nicely formatted string for this vector.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("({0:F1}, {1:F1}, {2:F1})", x, y, z);
        }
        public static double3 operator +(double3 a, float3 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            return a;
        }
        public static double3 operator +(float3 a, double3 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            b.z = a.z + b.z;
            return a;
        }
        public static double3 operator +(double3 a, float2 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            return a;
        }
        public static double3 operator +(float2 a, double3 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            return b;
        }
        public static double3 operator +(double3 a, float b)
        {
            a.x = a.x + b;
            a.y = a.y + b;
            a.z = a.z + b;
            return a;
        }
        public static double3 operator +(float a, double3 b)
        {
            b.x = a + b.x;
            b.y = a + b.y;
            b.z = a + b.z;
            return b;
        }
        public static double3 operator -(double3 a, float3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return a;
        }
        public static double3 operator -(float3 a, double3 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            b.z = a.z - b.z;
            return a;
        }
        public static double3 operator -(double3 a, float2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a;
        }
        public static double3 operator -(float2 a, double3 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            return b;
        }
        public static double3 operator -(double3 a, float b)
        {
            a.x = a.x - b;
            a.y = a.y - b;
            a.z = a.z - b;
            return a;
        }
        public static double3 operator -(float a, double3 b)
        {
            b.x = a - b.x;
            b.y = a - b.y;
            b.z = a - b.z;
            return b;
        }
        public static double3 operator *(double3 a, float3 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            return a;
        }
        public static double3 operator *(float3 a, double3 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            b.z = a.z * b.z;
            return a;
        }
        public static double3 operator *(double3 a, float2 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            return a;
        }
        public static double3 operator *(float2 a, double3 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            return b;
        }
        public static double3 operator *(double3 a, float b)
        {
            a.x = a.x * b;
            a.y = a.y * b;
            a.z = a.z * b;
            return a;
        }
        public static double3 operator *(float a, double3 b)
        {
            b.x = a * b.x;
            b.y = a * b.y;
            b.z = a * b.z;
            return b;
        }
        public static double3 operator /(double3 a, float3 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            return a;
        }
        public static double3 operator /(float3 a, double3 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            b.z = a.z / b.z;
            return a;
        }
        public static double3 operator /(double3 a, float2 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            return a;
        }
        public static double3 operator /(float2 a, double3 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            return b;
        }
        public static double3 operator /(double3 a, float b)
        {
            a.x = a.x / b;
            a.y = a.y / b;
            a.z = a.z / b;
            return a;
        }
        public static double3 operator /(float a, double3 b)
        {
            b.x = a / b.x;
            b.y = a / b.y;
            b.z = a / b.z;
            return b;
        }
        public static double3 operator %(double3 a, float3 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            return a;
        }
        public static double3 operator %(float3 a, double3 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            b.z = a.z % b.z;
            return a;
        }
        public static double3 operator %(double3 a, float2 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            return a;
        }
        public static double3 operator %(float2 a, double3 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            return b;
        }
        public static double3 operator %(double3 a, float b)
        {
            a.x = a.x % b;
            a.y = a.y % b;
            a.z = a.z % b;
            return a;
        }
        public static double3 operator %(float a, double3 b)
        {
            b.x = a % b.x;
            b.y = a % b.y;
            b.z = a % b.z;
            return b;
        }
        public static double3 operator +(double3 a, double3 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            a.z = a.z + b.z;
            return a;
        }
        public static double3 operator +(double3 a, double2 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            return a;
        }
        public static double3 operator +(double2 a, double3 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            return b;
        }
        public static double3 operator +(double3 a, double b)
        {
            a.x = a.x + b;
            a.y = a.y + b;
            a.z = a.z + b;
            return a;
        }
        public static double3 operator +(double a, double3 b)
        {
            b.x = a + b.x;
            b.y = a + b.y;
            b.z = a + b.z;
            return b;
        }
        public static double3 operator -(double3 a, double3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return a;
        }
        public static double3 operator -(double3 a, double2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a;
        }
        public static double3 operator -(double2 a, double3 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            return b;
        }
        public static double3 operator -(double3 a, double b)
        {
            a.x = a.x - b;
            a.y = a.y - b;
            a.z = a.z - b;
            return a;
        }
        public static double3 operator -(double a, double3 b)
        {
            b.x = a - b.x;
            b.y = a - b.y;
            b.z = a - b.z;
            return b;
        }
        public static double3 operator *(double3 a, double3 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            a.z = a.z * b.z;
            return a;
        }
        public static double3 operator *(double3 a, double2 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            return a;
        }
        public static double3 operator *(double2 a, double3 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            return b;
        }
        public static double3 operator *(double3 a, double b)
        {
            a.x = a.x * b;
            a.y = a.y * b;
            a.z = a.z * b;
            return a;
        }
        public static double3 operator *(double a, double3 b)
        {
            b.x = a * b.x;
            b.y = a * b.y;
            b.z = a * b.z;
            return b;
        }
        public static double3 operator %(double3 a, double3 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            a.z = a.z % b.z;
            return a;
        }
        public static double3 operator %(double3 a, double2 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            return a;
        }
        public static double3 operator %(double2 a, double3 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            return b;
        }
        public static double3 operator %(double3 a, double b)
        {
            a.x = a.x % b;
            a.y = a.y % b;
            a.z = a.z % b;
            return a;
        }
        public static double3 operator %(double a, double3 b)
        {
            b.x = a % b.x;
            b.y = a % b.y;
            b.z = a % b.z;
            return b;
        }
        public static double3 operator /(double3 a, double3 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            a.z = a.z / b.z;
            return a;
        }
        public static double3 operator /(double3 a, double2 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            return a;
        }
        public static double3 operator /(double2 a, double3 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            return b;
        }
        public static double3 operator /(double3 a, double b)
        {
            a.x = a.x / b;
            a.y = a.y / b;
            a.z = a.z / b;
            return a;
        }
        public static double3 operator /(double a, double3 b)
        {
            b.x = a / b.x;
            b.y = a / b.y;
            b.z = a / b.z;
            return b;
        }
        public static double3 operator -(double3 a)
        {
            a.x = -a.x;
            a.y = -a.y;
            a.z = -a.z;
            return a;
        }
        public static explicit operator double2(double3 v)
        {
            double2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static explicit operator int2(double3 v)
        {
            int2 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            return vec;
        }
        public static explicit operator int3(double3 v)
        {
            int3 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            vec.z = (int)v.z;
            return vec;
        }
        public static explicit operator bool2(double3 v)
        {
            bool2 vec;
            vec.x = v.x > 0d;
            vec.y = v.y > 0d;
            return vec;
        }
        public static explicit operator bool3(double3 v)
        {
            bool3 vec;
            vec.x = v.x > 0d;
            vec.y = v.y > 0d;
            vec.z = v.z > 0d;
            return vec;
        }
        public static explicit operator bool4(double3 v)
        {
            bool4 vec;
            vec.x = v.x > 0d;
            vec.y = v.y > 0d;
            vec.z = v.z > 0d;
            vec.w = false;
            return vec;
        }
        public static explicit operator int4(double3 v)
        {
            int4 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            vec.z = (int)v.z;
            vec.w = 0;
            return vec;
        }
        public static explicit operator float2(double3 v)
        {
            float2 vec;
            vec.x = (float)v.x;
            vec.y = (float)v.y;
            return vec;
        }
        public static explicit operator float3(double3 v)
        {
            float3 vec;
            vec.x = (float)v.x;
            vec.y = (float)v.y;
            vec.z = (float)v.z;
            return vec;
        }
        public static implicit operator double4(double3 v)
        {
            double4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            vec.w = 0d;
            return vec;
        }
        public static explicit operator float4(double3 v)
        {
            float4 vec;
            vec.x = (float)v.x;
            vec.y = (float)v.y;
            vec.z = (float)v.z;
            vec.w = 0f;
            return vec;
        }
        public static bool operator ==(double3 a, double3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return a.x * a.x + a.y * a.y + a.z * a.z < 0.000000000001d;
        }
        public static bool operator !=(double3 a, double3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return a.x * a.x + a.y * a.y + a.z * a.z >= 0.000000000001d;
        }
        public static bool operator ==(double3 a, float3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return a.x * a.x + a.y * a.y + a.z * a.z < 0.000000000001d;
        }
        public static bool operator !=(double3 a, float3 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.z = a.z - b.z;
            return a.x * a.x + a.y * a.y + a.z * a.z >= 0.000000000001d;
        }
        public static bool operator ==(float3 a, double3 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            b.z = a.z - b.z;
            return a.x * a.x + a.y * a.y + a.z * a.z < 0.000000000001d;
        }
        public static bool operator !=(float3 a, double3 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            b.z = a.z - b.z;
            return a.x * a.x + a.y * a.y + a.z * a.z >= 0.000000000001d;
        }
    }
}
