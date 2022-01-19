using IkiCore.Core;
using IkiCore.Mathematics;
namespace IkiCore.Physics
{
	public static class CircularMotion
	{
        public static float Force_MVR(float mass, float velocity, float radius)
        {
            return (mass * velocity * velocity) / radius;
        }
        public static float Acceleration_VR(float velocity, float radius)
        {
            return velocity * velocity / radius;
        }
        public static float Acceleration_VR(float radius, float theta, float time)
        {
            return (theta / time) * (theta / time) * radius;
        }
        public static float Velocity_RA(float radius, float acceleration)
        {
            return (acceleration * radius).Sqrt();
        }
        public static float Velocity_RRp(float radius, float rotationPeriod)
        {
            return 6.28318530718f * radius / rotationPeriod;
        }
        public static float AngularRate_ThT(float theta, float time)
        {
            return theta / time;
        }
        public static float AngularRate_V0VT(float3 initialVelocity, float3 velocity, float time)
        {
            float d = (velocity - initialVelocity).Magnitude;
            return d * (float)System.Math.Acos(initialVelocity.Normalized.Dot(velocity.Normalized)) / (d * time);
        }
        public static float AngularRate_V0VThT(float initialVelocity, float velocity, float theta, float time)
        {
            return (velocity - initialVelocity) * (float)System.Math.Acos(theta) / ((velocity - initialVelocity) * time);
        }
        public static float AngularRate(float velocity, float theta, float radius)
        {
            return velocity * (float)System.Math.Sin(theta) / radius;
        }
        public static float AngularAcceleration_RpT(float rotationPeriod, float time)
        {
            return (6.28318530718f / rotationPeriod) / time;
        }
        public static float Angle_RpT(float rotationPeriod, float time)
        {
            return time / rotationPeriod * 6.28318530718f;
        }
        public static float Radius_VA(float velocity, float acceleration)
        {
            return velocity * velocity / acceleration;
        }
    }
}
