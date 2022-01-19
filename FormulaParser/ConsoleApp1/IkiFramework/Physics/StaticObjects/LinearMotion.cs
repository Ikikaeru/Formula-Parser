using IkiCore.Mathematics;
namespace IkiCore.Physics
{
	public static class LinearMotion
	{
        public static float Position(float initialPosition, float speed, float time)
        {
            return initialPosition + speed * time;
        }
        public static float InitialPosition(float targetPosition, float speed, float time)
        {
            return targetPosition - speed * time;
        }
        public static float Speed(float initialPosition, float targetPosition, float time)
        {
            return (targetPosition - initialPosition) / time;
        }
        public static float Time(float initialPosition, float targetPosition, float speed)
        {
            return (targetPosition - initialPosition) / speed;
        }
        public static float2 Position(float2 initialPosition, float speed, float time)
        {
            return initialPosition + speed * time;
        }
        public static float2 InitialPosition(float2 targetPosition, float speed, float time)
        {
            return targetPosition - speed * time;
        }
        public static float Speed(float2 initialPosition, float2 targetPosition, float time)
        {
            return (targetPosition - initialPosition).Magnitude / time;
        }
        public static float Time(float2 initialPosition, float2 targetPosition, float speed)
        {
            return (targetPosition - initialPosition).Magnitude / speed;
        }
        public static float3 Position(float3 initialPosition, float speed, float time)
        {
            return initialPosition + speed * time;
        }
        public static float3 InitialPosition(float3 targetPosition, float speed, float time)
        {
            return targetPosition - speed * time;
        }
        public static float Speed(float3 initialPosition, float3 targetPosition, float time)
        {
            return (targetPosition - initialPosition).Magnitude / time;
        }
        public static float Time(float3 initialPosition, float3 targetPosition, float speed)
        {
            return (targetPosition - initialPosition).Magnitude / speed;
        }
        public static float4 Position(float4 initialPosition, float speed, float time)
        {
            return initialPosition + speed * time;
        }
        public static float4 InitialPosition(float4 targetPosition, float speed, float time)
        {
            return targetPosition - speed * time;
        }
        public static float Speed(float4 initialPosition, float4 targetPosition, float time)
        {
            return (targetPosition - initialPosition).Magnitude / time;
        }
        public static float Time(float4 initialPosition, float4 targetPosition, float speed)
        {
            return (targetPosition - initialPosition).Magnitude / speed;
        }
    }
}
