using IkiCore.Mathematics;
namespace IkiCore.Procedural
{
	public struct RogueRoom
	{
        public bool IsConnected { get; private set; }
        public int Left { get { return position.x; } }
        public int Right { get { return position.x + size.x; } }
        public int Top { get { return position.y; } }
        public int Bottom { get { return position.y + size.y; } }
        public int2 Size { get { return size; } }
        public int2 Center { get { int2 c; c.x = position.x + size.x / 2; c.y = position.y + size.y / 2; return c; } }
        int2 position;
        int2 size;
        public RogueRoom(int x, int y, int width, int height)
        {
            IsConnected = false;
            position.x = x;
            position.y = y;
            size.x = width;
            size.y = height;
        }
        public void SetConnected()
        {
            IsConnected = true;
        }
        public bool IsOverlapping(RogueRoom other)
        {
            return !(position.x > other.Right || position.y > other.Bottom || Right < other.Left || Bottom < other.Top);
        }
    }
}
