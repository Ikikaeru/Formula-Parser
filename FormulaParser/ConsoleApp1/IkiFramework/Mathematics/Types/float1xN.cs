using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    public partial struct float1xN : IVector
    {
        internal float[] Matrix { get; set; }
        public float1xN(int dimension)
        {
            Matrix = new float[dimension];
        }
        [XmlIgnore] public float this[int index]
        {
            get
            {
                return Matrix[index];
            }
            set
            {
                Matrix[index] = value;
            }
        }
        [XmlIgnore] public int Dimension { get => Matrix.Length; }
        [XmlIgnore]
        public IVector Transpose
        {
            get
            {
                floatNx1 tr = new floatNx1();
                tr.Matrix = Matrix;
                return tr;
            }
        }
        [XmlIgnore] public float Magnitude { get => Math.Sqrt(Vector.DotProduct(this, this)); }
    }
}
