using IkiCore.Core;
using IkiCore.Mathematics;
namespace IkiCore.Graphics
{
    public static class ColorConversion
    {
        public static float3 CMYKToRGB(float4 cmyk)
        {
            float3 color;
            color.x = (1f - cmyk.x) * (1f - cmyk.w);
            color.y = (1f - cmyk.y) * (1f - cmyk.w);
            color.z = (1f - cmyk.z) * (1f - cmyk.w);
            return color;
        }
        public static float4 RGBToCMYK(float3 rgb)
        {
            float4 cmyk;
            cmyk.w = 1f - Mathematics.Math.Max(Mathematics.Math.Max(rgb.x, rgb.y), rgb.z);
            cmyk.w = cmyk.w <= 0 || float.IsNaN(cmyk.w) ? 0f : cmyk.w;
            cmyk.x = (1f - rgb.x - cmyk.w) / (1f - cmyk.w);
            cmyk.x = cmyk.x <= 0 || float.IsNaN(cmyk.x) ? 0f : cmyk.x;
            cmyk.y = (1f - rgb.y - cmyk.w) / (1f - cmyk.w);
            cmyk.y = cmyk.y <= 0 || float.IsNaN(cmyk.y) ? 0f : cmyk.y;
            cmyk.z = (1f - rgb.z - cmyk.w) / (1f - cmyk.w);
            cmyk.z = cmyk.z <= 0 || float.IsNaN(cmyk.z) ? 0f : cmyk.z;
            return cmyk;
        }
        public static float3 RGBToHLS(float3 rgb)
        {
            float3 hls;
            float max = rgb.x;
            max = max < rgb.y ? rgb.y : max;
            max = max < rgb.z ? rgb.z : max;
            float min = rgb.x;
            min = min > rgb.y ? rgb.y : min;
            min = min > rgb.z ? rgb.z : min;
            float diff = max - min;
            hls.y = (max + min) / 2f;
            if (Mathematics.Math.Abs(diff) < 0.00001f)
            {
                hls.z = 0f;
                hls.x = 0f;
            }
            else
            {
                hls.z = hls.y <= 0.5f ? diff / (max + min) : diff / (2f - max - min);
                float r_dist = (max - rgb.x) / diff;
                float g_dist = (max - rgb.y) / diff;
                float b_dist = (max - rgb.z) / diff;
                hls.x = (rgb.x == max) ? (b_dist - g_dist) * 60f : (rgb.y == max) ? (2 + r_dist - b_dist) * 60f : (4 + g_dist - r_dist) * 60f;
                hls.x = hls.x < 0f ? hls.x + 360f : hls.x;
            }
            return hls;
        }
        public static float3 HLSToRGB(float3 hls)
        {
            float p2 = (hls.y <= 0.5f) ? hls.y * (1f + hls.z) : hls.y + hls.z - hls.y * hls.z;
            float p1 = 2f * hls.y - p2;
            float3 rgb;
            if (hls.z == 0f)
            {
                rgb.x = hls.y;
                rgb.y = hls.y;
                rgb.z = hls.y;
            }
            else
            {
                float hue = hls.x + 120f;
                hue = hue > 360 ? hue - 360f : hue < 0 ? hue + 360f : hue;
                rgb.x = (hue < 60f) ? p1 + (p2 - p1) * hue / 60f : (hue < 180f) ? p2 : (hue < 240f) ? p1 + (p2 - p1) * (240f - hue) / 60f : p1;
                hue = hls.x;
                hue = hue > 360 ? hue - 360f : hue < 0 ? hue + 360f : hue;
                rgb.y = (hue < 60f) ? p1 + (p2 - p1) * hue / 60f : (hue < 180f) ? p2 : (hue < 240f) ? p1 + (p2 - p1) * (240f - hue) / 60f : p1;
                hue = hls.x - 120f;
                hue = hue > 360 ? hue - 360f : hue < 0 ? hue + 360f : hue;
                rgb.z = (hue < 60f) ? p1 + (p2 - p1) * hue / 60f : (hue < 180f) ? p2 : (hue < 240f) ? p1 + (p2 - p1) * (240f - hue) / 60f : p1;
            }
            return rgb;
        }
    }
}
