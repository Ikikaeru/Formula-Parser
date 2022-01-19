using IkiCore.Core;
using IkiCore.Mathematics;
namespace IkiCore.Physics
{
	public static class UniformAcceleration
    {
        public static float Acceleration_VT(float velocity, float time)
        {
            return velocity / time;
        }
        public static float Velocity_AT(float acceleration, float time)
        {
            return acceleration * time;
        }
        public static float Time_VA(float velocity, float acceleration)
        {
            return velocity / acceleration;
        }
        public static float Velocity_V0AT(float initialVelocity, float acceleration, float time)
        {
            return initialVelocity + acceleration * time;
        }
        public static float InitialVelocity_VAT(float velocity, float acceleration, float time)
        {
            return velocity - acceleration * time;
        }
        public static float Time_V0VA(float initialVelocity, float velocity, float acceleration)
        {
            return (velocity - initialVelocity) / acceleration;
        }
        public static float Acceleration_V0VT(float initialVelocity, float velocity, float time)
        {
            return (velocity - initialVelocity) / time;
        }
        public static float Position_X0V0AT(float initialPosition, float initialVelocity, float acceleration, float time)
        {
            return initialPosition + initialVelocity * time + 0.5f * acceleration * time * time;
        }
        public static float InitialPosition_XV0AT(float position, float initialVelocity, float acceleration, float time)
        {
            return -(initialVelocity * time + 0.5f * acceleration * time * time - position);
        }
        public static float InitialVelocity_X0XAT(float initialPosition, float position, float acceleration, float time)
        {
            return -(initialPosition + 0.5f * acceleration * time * time - position) / time;
        }
        public static float Acceleration_X0XV0T(float initialPosition, float position, float initialVelocity, float time)
        {
            return -(initialPosition + initialVelocity * time - position) / (0.5f * time * time);
        }
        public static float Time_X0XV0A(float initialPosition, float position, float initialVelocity, float acceleration)
        {
            return (-initialVelocity + (initialVelocity + 2f * acceleration * (position - initialPosition)).Sqrt()) / acceleration;
        }
        public static float2 FullTime_X0XV0A(float initialPosition, float position, float initialVelocity, float acceleration)
        {
            initialPosition = (initialVelocity + 2f * acceleration * (position - initialPosition)).Sqrt();
            float2 t;
            t.x = (-initialVelocity + initialPosition) / acceleration;
            t.y = (-initialVelocity - initialPosition) / acceleration;
            return t;
        }
        public static float ClosestTime_X0XV0A(float initialPosition, float position, float initialVelocity, float acceleration)
        {
            initialPosition = (initialVelocity + 2f * acceleration * (position - initialPosition)).Sqrt();
            position = (-initialVelocity + initialPosition) / acceleration;
            initialPosition = (-initialVelocity - initialPosition) / acceleration;
            return initialPosition.Abs().Min(position.Abs());
        }
        public static float LongestTime_X0XV0A(float initialPosition, float position, float initialVelocity, float acceleration)
        {
            initialPosition = (initialVelocity + 2f * acceleration * (position - initialPosition)).Sqrt();
            position = (-initialVelocity + initialPosition) / acceleration;
            initialPosition = (-initialVelocity - initialPosition) / acceleration;
            return initialPosition.Abs().Max(position.Abs());
        }
        public static float Velocity_X0XV0A(float initialPosition, float position, float initialVelocity, float acceleration)
        {
            return Mathematics.Math.Sqrt(initialVelocity * initialVelocity + 2f * acceleration * (position - initialPosition));
        }
        public static float InitialVelocity_X0XVA(float initialPosition, float position, float velocity, float acceleration)
        {
            return Mathematics.Math.Sqrt(2f * acceleration * (position - initialPosition) / (velocity * velocity));
        }
        public static float Acceleration_X0XV0V(float initialPosition, float position, float initialVelocity, float velocity)
        {
            return initialVelocity * initialVelocity + 2f * (position - initialPosition) / (velocity * velocity);
        }
        public static float InitialPosition_XV0VA(float position, float initialVelocity, float velocity, float acceleration)
        {
            return -(velocity * velocity / ((initialVelocity * initialVelocity) + 2f * acceleration) - position);
        }
        public static float Position_X0V0VA(float initialPosition, float initialVelocity, float velocity, float acceleration)
        {
            return velocity * velocity / ((initialVelocity * initialVelocity) + 2f * acceleration) + initialPosition;
        }
    }
}
