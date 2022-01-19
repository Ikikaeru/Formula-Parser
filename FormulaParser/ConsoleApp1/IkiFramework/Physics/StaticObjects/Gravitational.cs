using IkiCore.Mathematics;
namespace IkiCore.Physics
{
	public static class Gravitational
	{
        public static float GravityForce_MaMbD(float massA, float massB, float distanceBetweenCenters)
        {
            return -(0.000000000066740831f * massA * massB / (distanceBetweenCenters * distanceBetweenCenters * distanceBetweenCenters)) * distanceBetweenCenters;
        }
        public static float GravitationalForce_MaMbD(float massA, float massB, float distanceBetweenCenters)
        {
            return 0.000000000066740831f * (massA * massB / (distanceBetweenCenters * distanceBetweenCenters));
        }
        public static float3 Field_MDDm(float mass, float distanceBetweenCenters, float3 largeToSmallMassDir)
        {
            return -(0.000000000066740831f * mass / (distanceBetweenCenters * distanceBetweenCenters)) * largeToSmallMassDir;
        }
        public static float PotentialEnergy_MaMbD(float massA, float massB, float distanceBetweenCenters)
        {
            return -(0.000000000066740831f * massA * massB / distanceBetweenCenters);
        }
    }
}
