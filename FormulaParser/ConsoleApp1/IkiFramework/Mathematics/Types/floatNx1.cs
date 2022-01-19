using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    public partial struct floatNx1 : IVector
    {
        internal float[] Matrix { get; set; }
        public floatNx1(int dimension)
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
        [XmlIgnore] public IVector Transpose
        {
            get
            {
                float1xN tr = new float1xN();
                tr.Matrix = Matrix;
                return tr;
            }
        }
        [XmlIgnore] public float Magnitude { get => Math.Sqrt(Vector.DotProduct(this, this)); }
    }
}
