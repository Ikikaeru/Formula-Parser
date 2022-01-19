using IkiCore.Core;
namespace IkiCore.Mathematics
{
	public static class SpaceTransform
	{
        public static int2 Convert1DTo2DPosition(this int index, int width)
        {
            int2 vec;
            vec.x = index % width;
            vec.y = index / width;
            return vec;
        }
        public static float2 fConvert1DTo2DPosition(this int index, int width)
        {
            float2 vec;
            vec.x = index % width;
            vec.y = index / width;
            return vec;
        }
        public static int3 Convert1DTo3DPosition(this int i, int width, int height)
        {
            int3 v;
            v.x = i % width;
            v.y = (i / width) % height;
            v.z = i / (width * height);
            return v;
        }
        public static float3 fConvert1DTo3DPosition(this int i, int width, int height)
        {
            float3 v;
            v.x = i % width;
            v.y = (i / width) % height;
            v.z = i / (width * height);
            return v;
        }
        public static int Convert2DTo1DPosition(this int x, int y, int width) => x + y * width;
        public static int Convert2DTo1DPosition(this int2 x, int width) => x.x + x.y * width;
        public static int Convert3DTo1DPosition(this int x, int y, int z, int width, int height) => x + y * width + z * height * width;
        public static uint Convert3DTo1DPosition(this uint x, uint y, uint z, uint width, uint height) => x + y * width + z * height * width;
    }
}
