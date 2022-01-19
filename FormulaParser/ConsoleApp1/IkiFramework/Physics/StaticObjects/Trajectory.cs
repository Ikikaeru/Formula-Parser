using IkiCore.Core;
using IkiCore.Mathematics;
namespace IkiCore.Physics
{
    public static class Trajectory
    {
        public static float Distance_Y0V0GTh(float initialHeight, float initialVelocity, float gravity, float theta)
        {
            float sinTh = (float)System.Math.Sin(2f * theta);
            float v0Cos = initialVelocity * (float)System.Math.Cos(theta);
            return (initialVelocity * initialVelocity) * sinTh / (2f * gravity) + Math.Sqrt((initialVelocity * initialVelocity * sinTh) * (initialVelocity * initialVelocity * sinTh) / (4f * gravity * gravity) + (2f * initialHeight * v0Cos * v0Cos) / gravity);
        }
        public static float Distance_Y0VGTh(float initialHeight, float velocity, float gravity, float theta)
        {
            float sinTh = (float)System.Math.Sin(theta);
            return (velocity * velocity / (2f * gravity)) + (1f + 2f * gravity * initialHeight / (velocity * velocity * sinTh * sinTh)) * (float)System.Math.Sin(2f * theta);
        }
        public static float Distance_VGTh(float velocity, float gravity, float theta)
        {
            return velocity * velocity * (float)System.Math.Sin(2f * theta) / gravity;
        }
        public static float Distance_VG(float velocity, float gravity)
        {
            return velocity * velocity / gravity;
        }
        public static float FlightTime_VGTh(float velocity, float gravity, float theta)
        {
            return 2f * velocity * (float)System.Math.Sin(theta) / gravity;
        }
        public static float FlightTime_Y0VGTh(float initialHeight, float velocity, float gravity, float theta)
        {
            float sinTh = (float)System.Math.Sin(theta);
            return velocity * sinTh / gravity + ((float)Math.Sqrt(velocity * velocity * sinTh * sinTh + 2f * gravity * initialHeight) / gravity);
        }
        public static float2 Angle_DV0(float distance, float initialVelocity, float gravity)
        {
            float2 v;
            v.x = 0.5f * (float)System.Math.Asin(gravity * distance / (initialVelocity * initialVelocity));
            v.y = 1.57079632679f - v.x;
            return v;
        }
        public static float Angle_Y0VG(float initialHeight, float velocity, float gravity)
        {
            return (float)System.Math.Acos(Math.Sqrt((2f * gravity * initialHeight + velocity * velocity) / (2f * gravity * initialHeight + 2f * velocity * velocity)));
        }
        public static float Angle_VTh(float velocity, float theta)
        {
            return velocity * (float)System.Math.Cos(theta);
        }
        public static float Angle_VDG(float velocity, float distance, float gravity)
        {
            return 0.5f * (1f / (float)System.Math.Sin(gravity * distance / (velocity * velocity)));
        }
        public static float Angle_Y0D(float initialHeight, float distance)
        {
            return 1.57079632679f - 0.5f * (1.57079632679f - distance / initialHeight);
        }
        public static float2 Angle_YDVG(float height, float distance, float velocity, float gravity)
        {
            float vSqr = velocity * velocity;
            float quadratic = (vSqr * vSqr - gravity * (gravity * distance * distance + 2f * height * vSqr)).Sqrt();
            float2 v;
            v.x = (float)System.Math.Atan((vSqr + quadratic) / gravity * distance);
            v.y = (float)System.Math.Atan((vSqr - quadratic) / gravity * distance);
            return v;
        }
        public static float InitialVelocity_VTh(float velocity, float theta)
        {
            return velocity * (float)System.Math.Sin(theta);
        }
        public static float ImpactAngle_Y0VGTh(float initialHeight, float velocity, float gravity, float theta)
        {
            float sinTh = (float)System.Math.Sin(theta);
            return (float)System.Math.Atan(Math.Sqrt(velocity * velocity * sinTh * sinTh + 2f * gravity * initialHeight) / (velocity * (float)System.Math.Cos(theta)));
        }
        public static float Position_VThT(float velocity, float theta, float time)
        {
            return velocity * time * (float)System.Math.Cos(theta);
        }
        public static float Position_X0VThT(float initialPosition, float velocity, float theta, float time)
        {
            return velocity * time * (float)System.Math.Cos(theta) + initialPosition;
        }
        public static float Velocity_V0GThT(float initialVelocity, float gravity, float theta, float time)
        {
            return initialVelocity * (float)System.Math.Sin(theta) - gravity * time;
        }
        public static float Height_VG(float velocity, float gravity)
        {
            return (velocity * velocity) / (4f * gravity);
        }
        public static float Height_VGThT(float velocity, float gravity, float theta, float time)
        {
            return velocity * time * (float)System.Math.Sin(theta) - 0.5f * gravity * time * time;
        }
        public static float Height_YVGThT(float initialHeight, float velocity, float gravity, float theta, float time)
        {
            return initialHeight + velocity * time * (float)System.Math.Sin(theta) - 0.5f * gravity * time * time;
        }
        public static float Height_VGTh(float velocity, float gravity, float theta)
        {
            float sinTh = (float)System.Math.Sin(theta);
            return (velocity * velocity * sinTh * sinTh) / (2f * gravity);
        }
        public static float Height_XV0GTh(float position, float initialVelocity, float gravity, float theta)
        {
            float sec = 1f / (float)System.Math.Cos(theta);
            return -(gravity * sec * sec / (2f * initialVelocity * initialVelocity)) * position * position + position * (float)System.Math.Tan(theta);
        }
        public static float Height_V0G(float initialVelocity, float gravity)
        {
            return (initialVelocity * initialVelocity) / (2f * gravity);
        }
        public static float Height_V0VG(float initialVelocity, float velocity, float gravity)
        {
            return (velocity * velocity - initialVelocity * initialVelocity) / -(2f * gravity);
        }
        public static float Velocity_Y0G(float height, float gravity)
        {
            return Mathematics.Math.Sqrt(-2f * gravity * height);
        }
        public static float Height_Y0V0GTh(float initialHeight, float initialVelocity, float gravity, float theta)
        {
            float sinTh = initialVelocity * initialVelocity * (float)System.Math.Sin(theta);
            return sinTh * sinTh / (2f * gravity) + initialHeight;
        }
        public static float Height_AHt(float acceleration, float hangTime)
        {
            return hangTime * hangTime *acceleration * 0.125f;
        }
    }
}
