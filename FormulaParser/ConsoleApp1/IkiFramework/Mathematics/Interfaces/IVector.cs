namespace IkiCore.Mathematics
{
    public interface IVector
    {
        float this[int index] { get; set; }
        int Dimension { get; }
        float Magnitude { get; }
        IVector Transpose { get; }
    }
}
