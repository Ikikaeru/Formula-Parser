using IkiCore.Core;
using IkiCore.Mathematics;
namespace IkiCore.Physics
{
	public static class PhysicsFormula
    {
        public static float3 KelvinToRGB(this float k)
        {
            double kelvin = k < 1000f ? 10d : k > 40000f ? 400d : k * 0.01d;
            double tmpCalc;
            double r;
            if (kelvin <= 66d)
            {
                r = 255d;
            }
            else
            {
                tmpCalc = 329.698727446d * System.Math.Pow(kelvin - 60d, -0.1332047592d);
                r = tmpCalc < 0d ? 0d : tmpCalc > 255d ? 255d : tmpCalc;
            }
            double g;
            if (kelvin <= 66d)
            {
                tmpCalc = 99.4708025861d * System.Math.Log(kelvin) - 161.1195681661d;
                g = tmpCalc < 0d ? 0d : tmpCalc > 255d ? 255d : tmpCalc;
            }
            else
            {
                tmpCalc = 288.1221695283d * System.Math.Pow(kelvin - 60d, -0.0755148492d);
                g = tmpCalc < 0d ? 0d : tmpCalc > 255d ? 255d : tmpCalc;
            }
            double b;
            if (kelvin >= 66d)
            {
                b = 255d;
            }
            else if (kelvin <= 19d)
            {
                b = 0d;
            }
            else
            {
                tmpCalc = 138.5177312231d * System.Math.Log(kelvin - 10d) - 305.0447927307d;
                b = tmpCalc < 0d ? 0d : tmpCalc > 255d ? 255d : tmpCalc;
            }
            float3 col;
            col.x = (float)(r / 255d);
            col.y = (float)(g / 255d);
            col.z = (float)(b / 255d);
            return col;
        }
        static bool IsApproximately(float valueA, float valueB)
        {
            return valueA <= valueB + float.Epsilon && valueA >= valueB - float.Epsilon;
        }
        public static void Velocity2D(float2 velocity, float2 gravityDirection, ref float horizontalVelocity, ref float verticalVelocity)
        {
            horizontalVelocity = (velocity * float3.Cross(-gravityDirection, float3.Forward).Normalized.xy).Magnitude;
            verticalVelocity = (velocity * -gravityDirection).Magnitude;
        }
        public static void Velocity2D_f2(float2 velocity, float2 gravityDirection, ref float2 horizontalVelocity, ref float2 verticalVelocity)
        {
            horizontalVelocity = velocity * float3.Cross(-gravityDirection, float3.Forward).Normalized.xy;
            verticalVelocity = velocity * -gravityDirection;
        }
        public static void Velocity3D(float3 velocity, float3 gravityDirection, ref float horizontalVelocity, ref float verticalVelocity, ref float forwardVelocity)
        {
            float3 fV = velocity * float3.Cross(velocity, -gravityDirection).Normalized;
            forwardVelocity = fV.Magnitude;
            float3 vV = velocity * -gravityDirection;
            verticalVelocity = vV.Magnitude;
            horizontalVelocity = (velocity * float3.Cross(vV, fV).Normalized).Magnitude;
        }
        public static void Velocity3D_f3(float3 velocity, float3 gravityDirection, ref float3 horizontalVelocity, ref float3 verticalVelocity, ref float3 forwardVelocity)
        {
            forwardVelocity = velocity * float3.Cross(velocity, -gravityDirection).Normalized;
            verticalVelocity = velocity * -gravityDirection;
            horizontalVelocity = float3.Cross(verticalVelocity, forwardVelocity).Normalized;
        }
        public static float2 JumpVelocityFromJumpHeight_f2(float height, float2 gravityDirection, float gravity)
        {
            return -gravityDirection * Mathematics.Math.Sqrt(-2f * gravity * height);
        }
        public static float3 JumpVelocityFromJumpHeight_f3(float height, float3 gravityDirection, float gravity)
        {
            return -gravityDirection * Mathematics.Math.Sqrt(-2f * gravity * height);
        }
        public static float JumpVelocityFromJumpHeightCustomGravity(float height, float gravity, float lowJumpMultiplier)
        {
            return Mathematics.Math.Sqrt(-2f * gravity * lowJumpMultiplier * height);
        }
        public static float VelocityFromCustomGravity(float velocity, float lowJumpMultiplier, float fallMultiplier, float gravity, bool isGrounded, float time)
        {
            if (isGrounded)
            {
                return 0f;
            }
            if (velocity <= 0f)
            {
                return gravity * fallMultiplier * time * time;
            }
            else if (velocity > 0f)
            {
                return gravity * lowJumpMultiplier * time * time;
            }
            return 0f;
        }
        public static float2 VelocityFromCustomGravity_f2(float2 velocity, float2 gravityDirection, float lowJumpMultiplier, float fallMultiplier, float gravity, bool isGrounded, float time)
        {
            if(isGrounded)
            {
                return float2.Zero;
            }
            velocity.y = velocity.Normalized.Dot(gravityDirection);
            if (velocity.y <= 0f)
            {
                return gravityDirection * gravity * fallMultiplier * time * time;
            }
            else if (velocity.y > 0f)
            {
                return gravityDirection * gravity * lowJumpMultiplier * time * time;
            }
            return float2.Zero;
        }
        public static float3 VelocityFromCustomGravity_f3(float3 velocity, float3 gravityDirection, float lowJumpMultiplier, float fallMultiplier, float gravity, bool isGrounded, float time)
        {
            if (isGrounded)
            {
                return float3.Zero;
            }
            velocity.y = velocity.Normalized.Dot(gravityDirection);
            if (velocity.y <= 0f)
            {
                return gravityDirection * gravity * fallMultiplier * time * time;
            }
            else if (velocity.y > 0f)
            {
                return gravityDirection * gravity * lowJumpMultiplier * time * time;
            }
            return float3.Zero;
        }
    }
}
