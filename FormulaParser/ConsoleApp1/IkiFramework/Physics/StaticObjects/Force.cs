using IkiCore.Core;
using IkiCore.Mathematics;
namespace IkiCore.Physics
{
	public static class Force
    {
        public static float Inertia_MVRTh(float mass, float velocity, float radius, float theta)
        {
            return (mass * velocity * radius) / (velocity * (float)System.Math.Sin(theta) / radius);
        }
        public static float Inertia_MR(float mass, float radius)
        {
            return mass * radius * radius;
        }
        public static float InertialMass_MiV(float invariantMass, float velocity)
        {
            return (float)System.Math.Sqrt(1f - velocity * velocity / 89875517873681760f) * invariantMass;
        }
        public static float PotentialEnergy_MGY(float mass, float gravity, float height)
        {
            return mass * gravity * height;
        }
        public static float PotentialEnergy_MV(float mass, float velocity)
        {
            return mass * velocity * velocity * 0.5f;
        }
        public static float Acceleration_FM(float force, float mass)
        {
            return force / mass;
        }
        public static float Magnetic(float charge, float velocity)
        {
            return charge * velocity;
        }
        public static float Work_FVDT(float force, float velocity, float distance, float time)
        {
            return force * velocity * distance * time;
        }
        public static float Work_FD(float force, float distance)
        {
            return force * distance;
        }
        public static float Work_MV(float mass, float velocity)
        {
            return mass * velocity * velocity * -0.5f;
        }
        public static float Work_MV0V(float mass, float initialVelocity, float velocity)
        {
            return 0.5f * mass * velocity * velocity - 0.5f * mass * initialVelocity * initialVelocity;
        }
        public static float Work_V0VA(float initialVelocity, float velocity, float acceleration)
        {
            return (velocity - initialVelocity) / (2f * acceleration);
        }
        public static float Position_X0V0PcMT(float initialPosition, float initialVelocity, float proportionalityCoefficient, float mass, float time)
        {
            return initialPosition + (mass * initialVelocity / proportionalityCoefficient) * (1f - MathConstf.E.Pow(-(proportionalityCoefficient / mass) * time));
        }
        public static float ProportionalityCoefficient(float mass, float gravity, float velocity)
        {
            return mass * gravity / velocity;
        }
        public static float Mass_FV(float force, float velocity)
        {
            return force / velocity;
        }
        public static float AnalyticForce_PcV(float proportionalityCoefficient, float velocity)
        {
            return -proportionalityCoefficient * velocity;
        }
        public static float RealisticForce_PcV(float proportionalityCoefficient, float velocity)
        {
            return -proportionalityCoefficient * velocity * velocity;
        }
        public static float ForceGravity_MGX0X(float mass, float gravity, float initialPosition, float position)
        {
            return -mass * gravity * (position - initialPosition);
        }
        public static float Force_MVGPc(float mass, float velocity, float gravity, float proportionalityCoefficient)
        {
            return -proportionalityCoefficient * velocity - mass * gravity;
        }
        public static float Force_MV(float mass, float velocity)
        {
            return mass * velocity;
        }
        public static float Force_MVPc(float mass, float velocity, float proportionalityCoefficient)
        {
            return -proportionalityCoefficient * velocity / mass;
        }
        public static float Force_MVT(float mass, float2 velocity, float time)
        {
            return (mass * velocity.Magnitude) / time;
        }
        public static float Force_PcRV(float proportionalityCoefficient, float radius, float velocity)
        {
            return -18.8495559215f * proportionalityCoefficient * radius * velocity;
        }
        public static float Force_PcCsMdV(float proportionalityCoefficient, float crossSectionalArea, float mediumDensity, float velocity)
        {
            return -proportionalityCoefficient * mediumDensity * crossSectionalArea * velocity * velocity;
        }
        public static float Force_VT(float velocity, float time)
        {
            return velocity / time;
        }
    }
}
