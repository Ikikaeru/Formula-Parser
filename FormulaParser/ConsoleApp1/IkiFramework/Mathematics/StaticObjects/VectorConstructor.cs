using IkiCore.Core;
namespace IkiCore.Mathematics
{
	public static class VectorConstructor
	{
		public static float2 float2(float xy)
        {
            float2 a;
            a.x = xy;
            a.y = xy;
            return a;
        }
        public static float2 float2(float x, float y)
        {
            float2 a;
            a.x = x;
            a.y = y;
            return a;
        }
        public static float3 float3(float xyz)
        {
            float3 a;
            a.x = xyz;
            a.y = xyz;
            a.z = xyz;
            return a;
        }
        public static float3 float3(float x, float y)
        {
            float3 a;
            a.x = x;
            a.y = y;
            a.z = 0f;
            return a;
        }
        public static float3 float3(float2 xy)
        {
            float3 a;
            a.x = xy.x;
            a.y = xy.y;
            a.z = 0f;
            return a;
        }
        public static float3 float3(float2 xy, float z)
        {
            float3 a;
            a.x = xy.x;
            a.y = xy.y;
            a.z = z;
            return a;
        }
        public static float3 float3(float x, float y, float z)
        {
            float3 a;
            a.x = x;
            a.y = y;
            a.z = z;
            return a;
        }
        public static float3 float3(float x, float2 yz)
        {
            float3 a;
            a.x = x;
            a.y = yz.x;
            a.z = yz.y;
            return a;
        }
    }
}
