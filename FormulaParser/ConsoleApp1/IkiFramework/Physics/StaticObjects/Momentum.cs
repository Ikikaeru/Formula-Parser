using IkiCore.Core;
using IkiCore.Mathematics;
namespace IkiCore.Physics
{
	public static class Momentum
	{
        public static float LorentzFactor(float velocity)
        {
            return Mathematics.Math.Sqrt(1f - velocity * velocity / 89875517873681760f);
        }
        public static float Linear_MV(float mass, float velocity)
        {
            return mass * velocity;
        }
        public static float Angular_MV(float mass, float velocity, float radius)
        {
            return mass * velocity * radius;
        }
        public static float InitialPosition_XVT(float position, float velocity, float time)
        {
            return position - velocity * time;
        }
        public static float NormalImpulse_MaV0aMbV0bRc(float massA, float initialVelocityA, float massB, float initialVelocityB, float restitutionCoefficient)
        {
            return massA * massB / (massA + massB) * (1f + restitutionCoefficient) * (initialVelocityB - initialVelocityA);
        }
        public static float2 ElasticVelocity_MaV0aMbV0b(float massA, float initialVelocityA, float massB, float initialVelocityB)
        {
            float2 r;
            r.x = (massA - massB) / (massA + massB) * initialVelocityA + 2f * massB / (massA + massB) * initialVelocityB;
            r.y = (massB - massA) / (massA + massB) * initialVelocityB + 2f * massA / (massA + massB) * initialVelocityA;
            return r;
        }
        public static float PerfectInelasticVelocity_MaV0aMbV0b(float massA, float initialVelocityA, float massB, float initialVelocityB)
        {
            return (massA * initialVelocityA + massB * initialVelocityB) / (massA + massB);
        }
        public static float InelasticVelocity_JnM(float normalImpulse, float mass)
        {
            return normalImpulse / mass;
        }
        public static float2 InelasticVelocity_MaV0aMbV0bRc(float massA, float initialVelocityA, float massB, float initialVelocityB, float restitutionCoefficient)
        {
            float2 r;
            r.x = (restitutionCoefficient * massB * (initialVelocityB - initialVelocityA) + massA * initialVelocityA + massB * initialVelocityB) / (massA * massB);
            r.y = (restitutionCoefficient * massA * (initialVelocityA - initialVelocityB) + massA * initialVelocityA + massB * initialVelocityB) / (massA * massB);
            return r;
        }
        public static float InelasticVelocity_MaMbV0(float massA, float massB, float initialVelocity)
        {
            return massA / (massA + massB) * initialVelocity;
        }
        public static float RestitutionCoefficient_ByDy(float bounceHeight, float dropHeight)
        {
            return (bounceHeight / dropHeight).Sqrt();
        }
	}
}
