using System;
using IkiCore.Mathematics;
namespace IkiCore.Modeling
{
    [Serializable]
    public struct Vertice
    {
        public float3 Position;
        public float3 Normal;
        public float2 Uv;
        public float4 Color;
        public float4 Tangent;
        public Vertice(float3 position, float3 normal, float2 uv, float4 color, float4 tangent)
        {
            Position = position;
            Normal = normal;
            Uv = uv;
            Color = color;
            Tangent = tangent;
        }
    }
}