using IkiCore.Core;
using IkiCore.Mathematics;
namespace IkiCore.Graphics
{
	public static class LayerFilter
	{
        /// <summary>
        /// Get the specified filter for the actual pixel.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="baseLayer"></param>
        /// <param name="blendLayer"></param>
        /// <returns></returns>
        public static float PixelFilter(float baseLayer, float blendLayer, Filter filter, bool clamp01 = true, float alpha = 1f)
        {
            float tmpLayer = 0f;
            switch (filter)
            {
                case Filter.Add:
                    tmpLayer = (baseLayer + blendLayer) * 0.5f;
                    break;
                case Filter.CompleteAdd:
                    tmpLayer = baseLayer + blendLayer;
                    break;
                case Filter.Substract:
                    tmpLayer = baseLayer - blendLayer;
                    break;
                case Filter.InvertSubstract:
                    tmpLayer = blendLayer - baseLayer;
                    break;
                case Filter.Multiply:
                    tmpLayer = baseLayer * blendLayer;
                    break;
                case Filter.Screen:
                    tmpLayer = 1f - ((1f - blendLayer) * (1f - baseLayer));
                    break;
                case Filter.Darken:
                    tmpLayer = baseLayer < blendLayer ? baseLayer : blendLayer;
                    break;
                case Filter.Lighten:
                    tmpLayer = baseLayer > blendLayer ? baseLayer : blendLayer;
                    break;
                case Filter.AdditifBlend:
                    tmpLayer = 1f.Min(baseLayer + blendLayer);
                    break;
                case Filter.SubstractifBlend:
                    tmpLayer = 0f.Max(baseLayer + blendLayer - 1f);
                    break;
                case Filter.Difference:
                    tmpLayer = (baseLayer - blendLayer).Abs();
                    break;
                case Filter.Negation:
                    tmpLayer = 1f - (1f - baseLayer - blendLayer).Abs();
                    break;
                case Filter.Exclusion:
                    tmpLayer = baseLayer + blendLayer - (2f * baseLayer * blendLayer);
                    break;
                case Filter.Overlay:
                    tmpLayer = baseLayer < 0.5f ? 2f * baseLayer * blendLayer : 1f - 2f * (1f - blendLayer) * (1f - baseLayer);
                    break;
                case Filter.SoftLight:
                    float baseSqrt = baseLayer < 0.5f ? 0f : (float)Mathematics.Math.Sqrt(baseLayer);
                    tmpLayer = baseLayer < 0.5f ? 2f * (baseLayer * blendLayer) + (baseLayer * baseLayer) - 2f * (baseLayer * baseLayer) * blendLayer : 2f * baseSqrt * blendLayer - baseSqrt + 2f * baseLayer - 2f * (baseLayer * blendLayer);
                    break;
                case Filter.Dodge:
                    tmpLayer = baseLayer / (1f - (blendLayer == 1f ? 0.99999999999999f : blendLayer));
                    break;
                case Filter.Burn:
                    tmpLayer = 1f - (1f - baseLayer) / (blendLayer == 1f ? 0.99999999999999f : blendLayer);
                    break;
                case Filter.Reflectif:
                    tmpLayer = (blendLayer == 1.0f) ? blendLayer : 1f.Min(baseLayer * baseLayer / (1f - blendLayer));
                    break;
                case Filter.Phoenix:
                    tmpLayer = (baseLayer < blendLayer ? baseLayer : blendLayer) - (baseLayer > blendLayer ? baseLayer : blendLayer) + 1f;
                    break;
                case Filter.Normal:
                    tmpLayer = blendLayer;
                    break;
                case Filter.Step:
                    tmpLayer = baseLayer >= blendLayer ? 1f : 0f;
                    break;
                case Filter.Average:
                    tmpLayer = baseLayer + (blendLayer - baseLayer) * 0.5f;
                    break;
                default:
                    return baseLayer;
            }
            baseLayer = baseLayer + (tmpLayer - baseLayer) * alpha;
            return clamp01 ? Mathematics.Math.Clamp(baseLayer, 0f, 1f) : baseLayer;
        }
        /// <summary>
        /// Get the specified filter for the actual pixel color.
        /// </summary>
        /// <param name="baseLayer"></param>
        /// <param name="blendLayer"></param>
        /// <param name="filter"></param>
        /// <param name="clamp01"></param>
        /// <returns></returns>
        public static float3 ColorFilter(float3 baseLayer, float3 blendLayer, Filter filter, bool clamp01 = true, float alpha = 1f)
        {
            float3 layer;
            layer.x = 0f;
            layer.y = 0f;
            layer.z = 0f;
            switch (filter)
            {
                case Filter.Add:
                    layer = baseLayer + blendLayer;
                    break;
                case Filter.CompleteAdd:
                    baseLayer = baseLayer + blendLayer;
                    break;
                case Filter.Substract:
                    layer = baseLayer - blendLayer;
                    break;
                case Filter.InvertSubstract:
                    layer = blendLayer - baseLayer;
                    break;
                case Filter.Multiply:
                    layer = baseLayer * blendLayer;
                    break;
                case Filter.Screen:
                    layer = 1f - ((1f - blendLayer) * (1f - baseLayer));
                    break;
                case Filter.Darken:
                    layer.x = baseLayer.x < blendLayer.x ? baseLayer.x : blendLayer.x;
                    layer.y = baseLayer.y < blendLayer.y ? baseLayer.y : blendLayer.y;
                    layer.z = baseLayer.z < blendLayer.z ? baseLayer.z : blendLayer.z;
                    break;
                case Filter.Lighten:
                    layer.x = baseLayer.x > blendLayer.x ? baseLayer.x : blendLayer.x;
                    layer.y = baseLayer.y > blendLayer.y ? baseLayer.y : blendLayer.y;
                    layer.z = baseLayer.z > blendLayer.z ? baseLayer.z : blendLayer.z;
                    break;
                case Filter.AdditifBlend:
                    layer = float3.One.Min(baseLayer + blendLayer);
                    break;
                case Filter.SubstractifBlend:
                    layer = float3.Zero.Max(baseLayer + blendLayer - 1f);
                    break;
                case Filter.Difference:
                    layer = (baseLayer - blendLayer).Abs;
                    break;
                case Filter.Negation:
                    layer = 1f - (1f - baseLayer - blendLayer).Abs;
                    break;
                case Filter.Exclusion:
                    layer = baseLayer + blendLayer - (2f * baseLayer * blendLayer);
                    break;
                case Filter.Overlay:
                    layer.x = baseLayer.x < 0.5f ? 2f * baseLayer.x * blendLayer.x : 1f - 2f * (1f - blendLayer.x) * (1f - baseLayer.x);
                    layer.y = baseLayer.y < 0.5f ? 2f * baseLayer.y * blendLayer.y : 1f - 2f * (1f - blendLayer.y) * (1f - baseLayer.y);
                    layer.z = baseLayer.z < 0.5f ? 2f * baseLayer.z * blendLayer.z : 1f - 2f * (1f - blendLayer.z) * (1f - baseLayer.z);
                    break;
                case Filter.SoftLight:
                    float baseSqrt = baseLayer.x < 0.5f ? 0f : (float)Mathematics.Math.Sqrt(baseLayer.x);
                    layer.x = baseLayer.x < 0.5f ? 2f * (baseLayer.x * blendLayer.x) + (baseLayer.x * baseLayer.x) - 2f * (baseLayer.x * baseLayer.x) * blendLayer.x : 2f * baseSqrt * blendLayer.x - baseSqrt + 2f * baseLayer.x - 2f * (baseLayer.x * blendLayer.x);
                    baseSqrt = baseLayer.y < 0.5f ? 0f : (float)Mathematics.Math.Sqrt(baseLayer.y);
                    layer.y = baseLayer.y < 0.5f ? 2f * (baseLayer.y * blendLayer.y) + (baseLayer.y * baseLayer.y) - 2f * (baseLayer.y * baseLayer.y) * blendLayer.y : 2f * baseSqrt * blendLayer.y - baseSqrt + 2f * baseLayer.y - 2f * (baseLayer.y * blendLayer.y);
                    baseSqrt = baseLayer.z < 0.5f ? 0f : (float)Mathematics.Math.Sqrt(baseLayer.z);
                    layer.z = baseLayer.z < 0.5f ? 2f * (baseLayer.z * blendLayer.z) + (baseLayer.z * baseLayer.z) - 2f * (baseLayer.z * baseLayer.z) * blendLayer.z : 2f * baseSqrt * blendLayer.z - baseSqrt + 2f * baseLayer.z - 2f * (baseLayer.z * blendLayer.z);
                    break;
                case Filter.Dodge:
                    layer.x = baseLayer.x / (1f - (blendLayer.x == 1f ? 0.99999999999999f : blendLayer.x));
                    layer.y = baseLayer.y / (1f - (blendLayer.y == 1f ? 0.99999999999999f : blendLayer.y));
                    layer.z = baseLayer.z / (1f - (blendLayer.z == 1f ? 0.99999999999999f : blendLayer.z));
                    break;
                case Filter.Burn:
                    layer.x = 1f - (1f - baseLayer.x) / (blendLayer.x == 1f ? 0.99999999999999f : blendLayer.x);
                    layer.y = 1f - (1f - baseLayer.y) / (blendLayer.y == 1f ? 0.99999999999999f : blendLayer.y);
                    layer.z = 1f - (1f - baseLayer.z) / (blendLayer.z == 1f ? 0.99999999999999f : blendLayer.z);
                    break;
                case Filter.Reflectif:
                    layer.x = (blendLayer.x == 1.0f) ? blendLayer.x : 1f.Min(baseLayer.x * baseLayer.x / (1f - blendLayer.x));
                    layer.y = (blendLayer.y == 1.0f) ? blendLayer.y : 1f.Min(baseLayer.y * baseLayer.y / (1f - blendLayer.y));
                    layer.z = (blendLayer.z == 1.0f) ? blendLayer.z : 1f.Min(baseLayer.z * baseLayer.z / (1f - blendLayer.z));
                    break;
                case Filter.Phoenix:
                    layer.x = (baseLayer.x < blendLayer.x ? baseLayer.x : blendLayer.x) - (baseLayer.x > blendLayer.x ? baseLayer.x : blendLayer.x) + 1f;
                    layer.y = (baseLayer.y < blendLayer.y ? baseLayer.y : blendLayer.y) - (baseLayer.y > blendLayer.y ? baseLayer.y : blendLayer.y) + 1f;
                    layer.z = (baseLayer.z < blendLayer.z ? baseLayer.z : blendLayer.z) - (baseLayer.z > blendLayer.z ? baseLayer.z : blendLayer.z) + 1f;
                    break;
                case Filter.Normal:
                    layer = blendLayer;
                    break;
                case Filter.Step:
                    layer = baseLayer.Step(blendLayer);
                    break;
                case Filter.Average:
                    layer = baseLayer + (blendLayer - baseLayer) * 0.5f;
                    break;
                default:
                    return baseLayer;
            }
            layer = float3.Lerp(baseLayer, layer, alpha);
            return clamp01 ? layer.Clamp(0f, 1f) : layer;
        }
        /// <summary>
        /// Get the specified folter for the actual pixel color, handle the alpha layer.
        /// </summary>
        /// <param name="baseLayer"></param>
        /// <param name="blendLayer"></param>
        /// <param name="filter"></param>
        /// <param name="clamp01"></param>
        /// <returns></returns>
        public static float4 ColorFilter(float4 baseLayer, float4 blendLayer, Filter filter, bool clamp01 = true)
        {
            float4 layer;
            layer.x = 0f;
            layer.y = 0f;
            layer.z = 0f;
            layer.w = 0f;
            switch (filter)
            {
                case Filter.Add:
                    layer = baseLayer + blendLayer;
                    break;
                case Filter.CompleteAdd:
                    baseLayer = baseLayer + blendLayer;
                    break;
                case Filter.Substract:
                    layer = baseLayer - blendLayer;
                    break;
                case Filter.InvertSubstract:
                    layer = blendLayer - baseLayer;
                    break;
                case Filter.Multiply:
                    layer = baseLayer * blendLayer;
                    break;
                case Filter.Screen:
                    layer = 1f - ((1f - blendLayer) * (1f - baseLayer));
                    break;
                case Filter.Darken:
                    layer.x = baseLayer.x < blendLayer.x ? baseLayer.x : blendLayer.x;
                    layer.y = baseLayer.y < blendLayer.y ? baseLayer.y : blendLayer.y;
                    layer.z = baseLayer.z < blendLayer.z ? baseLayer.z : blendLayer.z;
                    break;
                case Filter.Lighten:
                    layer.x = baseLayer.x > blendLayer.x ? baseLayer.x : blendLayer.x;
                    layer.y = baseLayer.y > blendLayer.y ? baseLayer.y : blendLayer.y;
                    layer.z = baseLayer.z > blendLayer.z ? baseLayer.z : blendLayer.z;
                    break;
                case Filter.AdditifBlend:
                    layer = float3.One.Min(baseLayer.xyz + blendLayer.xyz);
                    break;
                case Filter.SubstractifBlend:
                    layer = float3.Zero.Max(baseLayer.xyz + blendLayer.xyz - 1f);
                    break;
                case Filter.Difference:
                    layer = (baseLayer - blendLayer).Abs;
                    break;
                case Filter.Negation:
                    layer = 1f - (1f - baseLayer - blendLayer).Abs;
                    break;
                case Filter.Exclusion:
                    layer = baseLayer + blendLayer - (2f * baseLayer * blendLayer);
                    break;
                case Filter.Overlay:
                    layer.x = baseLayer.x < 0.5f ? 2f * baseLayer.x * blendLayer.x : 1f - 2f * (1f - blendLayer.x) * (1f - baseLayer.x);
                    layer.y = baseLayer.y < 0.5f ? 2f * baseLayer.y * blendLayer.y : 1f - 2f * (1f - blendLayer.y) * (1f - baseLayer.y);
                    layer.z = baseLayer.z < 0.5f ? 2f * baseLayer.z * blendLayer.z : 1f - 2f * (1f - blendLayer.z) * (1f - baseLayer.z);
                    break;
                case Filter.SoftLight:
                    float baseSqrt = baseLayer.x < 0.5f ? 0f : (float)Mathematics.Math.Sqrt(baseLayer.x);
                    layer.x = baseLayer.x < 0.5f ? 2f * (baseLayer.x * blendLayer.x) + (baseLayer.x * baseLayer.x) - 2f * (baseLayer.x * baseLayer.x) * blendLayer.x : 2f * baseSqrt * blendLayer.x - baseSqrt + 2f * baseLayer.x - 2f * (baseLayer.x * blendLayer.x);
                    baseSqrt = baseLayer.y < 0.5f ? 0f : (float)Mathematics.Math.Sqrt(baseLayer.y);
                    layer.y = baseLayer.y < 0.5f ? 2f * (baseLayer.y * blendLayer.y) + (baseLayer.y * baseLayer.y) - 2f * (baseLayer.y * baseLayer.y) * blendLayer.y : 2f * baseSqrt * blendLayer.y - baseSqrt + 2f * baseLayer.y - 2f * (baseLayer.y * blendLayer.y);
                    baseSqrt = baseLayer.z < 0.5f ? 0f : (float)Mathematics.Math.Sqrt(baseLayer.z);
                    layer.z = baseLayer.z < 0.5f ? 2f * (baseLayer.z * blendLayer.z) + (baseLayer.z * baseLayer.z) - 2f * (baseLayer.z * baseLayer.z) * blendLayer.z : 2f * baseSqrt * blendLayer.z - baseSqrt + 2f * baseLayer.z - 2f * (baseLayer.z * blendLayer.z);
                    break;
                case Filter.Dodge:
                    layer.x = baseLayer.x / (1f - (blendLayer.x == 1f ? 0.99999999999999f : blendLayer.x));
                    layer.y = baseLayer.y / (1f - (blendLayer.y == 1f ? 0.99999999999999f : blendLayer.y));
                    layer.z = baseLayer.z / (1f - (blendLayer.z == 1f ? 0.99999999999999f : blendLayer.z));
                    break;
                case Filter.Burn:
                    layer.x = 1f - (1f - baseLayer.x) / (blendLayer.x == 1f ? 0.99999999999999f : blendLayer.x);
                    layer.y = 1f - (1f - baseLayer.y) / (blendLayer.y == 1f ? 0.99999999999999f : blendLayer.y);
                    layer.z = 1f - (1f - baseLayer.z) / (blendLayer.z == 1f ? 0.99999999999999f : blendLayer.z);
                    break;
                case Filter.Reflectif:
                    layer.x = (blendLayer.x == 1.0f) ? blendLayer.x : 1f.Min(baseLayer.x * baseLayer.x / (1f - blendLayer.x));
                    layer.y = (blendLayer.y == 1.0f) ? blendLayer.y : 1f.Min(baseLayer.y * baseLayer.y / (1f - blendLayer.y));
                    layer.z = (blendLayer.z == 1.0f) ? blendLayer.z : 1f.Min(baseLayer.z * baseLayer.z / (1f - blendLayer.z));
                    break;
                case Filter.Phoenix:
                    layer.x = (baseLayer.x < blendLayer.x ? baseLayer.x : blendLayer.x) - (baseLayer.x > blendLayer.x ? baseLayer.x : blendLayer.x) + 1f;
                    layer.y = (baseLayer.y < blendLayer.y ? baseLayer.y : blendLayer.y) - (baseLayer.y > blendLayer.y ? baseLayer.y : blendLayer.y) + 1f;
                    layer.z = (baseLayer.z < blendLayer.z ? baseLayer.z : blendLayer.z) - (baseLayer.z > blendLayer.z ? baseLayer.z : blendLayer.z) + 1f;
                    break;
                case Filter.Normal:
                    layer = blendLayer;
                    break;
                case Filter.Step:
                    layer = baseLayer.Step(blendLayer);
                    break;
                case Filter.Average:
                    layer = baseLayer + (blendLayer - baseLayer) * 0.5f;
                    break;
                default:
                    return baseLayer;
            }
            layer.xyz = float3.Lerp(baseLayer.xyz, layer.xyz, blendLayer.w);
            layer.w = baseLayer.w + blendLayer.w;
            return clamp01 ? layer.Clamp(0f, 1f) : layer;
        }
    }
}
