using System;
using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    [Serializable]
    public struct bool3 : IEquatable<bool3>
    {
        /// <summary>
        /// X of the bool vector.
        /// </summary>
        public bool x;
        /// <summary>
        /// Y of the bool vector.
        /// </summary>
        public bool y;
        /// <summary>
        /// Z of the bool vector.
        /// </summary>
        public bool z;
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
        public bool this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    default:
                        throw new IndexOutOfRangeException("Invalid bool3 index!");
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
                        throw new IndexOutOfRangeException("Invalid bool3 index!");
                }
            }
        }
        /// <summary>
        /// Construct a vector3bool, all value are false by default.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public bool3(bool x = false, bool y = false, bool z = false)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        /// <summary>
        /// Swap value to left.
        /// </summary>
        public void ShiftLeft()
        {
            bool a = x;
            x = y;
            y = z;
            z = a;
        }
        /// <summary>
        /// Swap value to right.
        /// </summary>
        public void ShiftRight()
        {
            bool a = x;
            x = z;            
            z = y;
            y = a;
        }
        /// <summary>
        /// Return true if any bool is true.
        /// </summary>
        /// <returns></returns>
        public bool IsAnyTrue()
        {
            return x || y || z;
        }
        /// <summary>
        /// Return true if only X and Y are true.
        /// </summary>
        /// <returns></returns>
        public bool XY()
        {
            return x && y && !z;
        }
        /// <summary>
        /// Return true if only Y and Z are true.
        /// </summary>
        /// <returns></returns>
        public bool YZ()
        {
            return z && y && !x;
        }
        /// <summary>
        /// Return true if only X and Z are true.
        /// </summary>
        /// <returns></returns>
        public bool XZ()
        {
            return x && z && !y;
        }
        /// <summary>
        /// Return true if every bool is true.
        /// </summary>
        /// <returns></returns>
        public bool IsTrue()
        {
            return x && y && z;
        }
        /// <summary>
        /// Set every bool to false.
        /// </summary>
        public void SetFalse()
        {
            x = y = z = false;
        }
        /// <summary>
        /// Set every bool to true.
        /// </summary>
        public void SetTrue()
        {
            x = y = z = true;
        }
        /// <summary>
        /// Negation operator for vector.
        /// </summary>
        public static bool3 operator !(bool3 a)
        {
            a.x = !a.x;
            a.y = !a.y;
            a.z = !a.z;
            return a;
        }
        /// <summary>
        /// AND operator for vector.
        /// </summary>
        public static bool3 operator &(bool3 a, bool3 b)
        {
            a.x = a.x && b.x;
            a.y = a.y && b.y;
            a.z = a.z && b.z;
            return a;
        }
        /// <summary>
        /// OR operator for vector.
        /// </summary>
        public static bool3 operator |(bool3 a, bool3 b)
        {
            a.x = a.x || b.x;
            a.y = a.y || b.y;
            a.z = a.z || b.z;
            return a;
        }
        /// <summary>
        /// XOR operator for vector.
        /// </summary>
        public static bool3 operator ^(bool3 a, bool3 b)
        {
            a.x = a.x ^ b.x;
            a.y = a.y ^ b.y;
            a.z = a.z ^ b.z;
            return a;
        }
        /// <summary>
        /// Equal operator for vector.
        /// </summary>
        public static bool3 operator ==(bool3 a, bool3 b)
        {
            a.x = a.x == b.x;
            a.y = a.y == b.y;
            a.z = a.z == b.z;
            return a;
        }
        /// <summary>
        /// Not equal operator for vector.
        /// </summary>
        public static bool3 operator !=(bool3 a, bool3 b)
        {
            a.x = a.x != b.x;
            a.y = a.y != b.y;
            a.z = a.z != b.z;
            return a;
        }
        public static implicit operator float3(bool3 v)
        {
            float3 vec;
            vec.x = v.x ? 1f : 0f;
            vec.y = v.y ? 1f : 0f;
            vec.z = v.z ? 1f : 0f;
            return vec;
        }
        public static implicit operator float4(bool3 v)
        {
            float4 vec;
            vec.x = v.x ? 1f : 0f;
            vec.y = v.y ? 1f : 0f;
            vec.z = v.z ? 1f : 0f;
            vec.w = 0f;
            return vec;
        }
        public static implicit operator uint3(bool3 v)
        {
            uint3 vec;
            vec.x = v.x ? 1u : 0u;
            vec.y = v.y ? 1u : 0u;
            vec.z = v.z ? 1u : 0u;
            return vec;
        }
        public static implicit operator float2(bool3 v)
        {
            float2 vec;
            vec.x = v.x ? 1f : 0f;
            vec.y = v.y ? 1f : 0f;
            return vec;
        }
        public static implicit operator int3(bool3 v)
        {
            int3 vec;
            vec.x = v.x ? 1 : 0;
            vec.y = v.y ? 1 : 0;
            vec.z = v.z ? 1 : 0;
            return vec;
        }
        public static explicit operator bool2(bool3 v)
        {
            bool2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static implicit operator double4(bool3 v)
        {
            double4 vec;
            vec.x = v.x ? 1d : 0d;
            vec.y = v.y ? 1d : 0d;
            vec.z = v.z ? 1d : 0d;
            vec.w = 0d;
            return vec;
        }
        public static implicit operator bool4(bool3 v)
        {
            bool4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = v.z;
            vec.w = false;
            return vec;
        }
        public static implicit operator double2(bool3 v)
        {
            double2 vec;
            vec.x = v.x ? 1d : 0d;
            vec.y = v.y ? 1d : 0d;
            return vec;
        }
        public static implicit operator double3(bool3 v)
        {
            double3 vec;
            vec.x = v.x ? 1d : 0d;
            vec.y = v.y ? 1d : 0d;
            vec.z = v.z ? 1d : 0d;
            return vec;
        }
        public static implicit operator int4(bool3 v)
        {
            int4 vec;
            vec.x = v.x ? 1 : 0;
            vec.y = v.y ? 1 : 0;
            vec.z = v.z ? 1 : 0;
            vec.w = 0;
            return vec;
        }
        public static implicit operator uint4(bool3 v)
        {
            uint4 vec;
            vec.x = v.x ? 1u : 0u;
            vec.y = v.y ? 1u : 0u;
            vec.z = v.z ? 1u : 0u;
            vec.w = 0u;
            return vec;
        }
        public override string ToString()
        {
            return x.ToString() + "," + y.ToString() + "," + z.ToString();
        }
        public override int GetHashCode()
        {
            return x.GetHashCode() ^ (y.GetHashCode() << 2) ^ (z.GetHashCode() >> 2);
        }
        public override bool Equals(object other)
        {
            if (!(other is bool3))
            {
                return false;
            }
            return Equals((bool3)other);
        }
        public bool Equals(bool3 other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z);
        }
    }
}
