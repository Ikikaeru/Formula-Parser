using IkiCore.Core;
using IkiCore.Mathematics;
namespace IkiCore.Procedural
{
    /// <summary>
    /// Use to calculate some step pattern.
    /// </summary>
    public struct GridPattern
    {
        int2 position;
        byte switchPattern;
        int step;
        /// <summary>
        /// Create a pattern maker.
        /// </summary>
        /// <param name="x">X position of the starting point.</param>
        /// <param name="y">Y position of the starting point.</param>
        public GridPattern(int pattern = 0)
        {
            position = int2.Zero;
            step = 1;
            switchPattern = (byte)pattern;
        }
        /// <summary>
        /// Calculate the next step in a spiral shape clockwise starting at the top, then return it in grid coordinate.
        /// Values can be positive or negative.
        /// </summary>
        /// <returns></returns>
        public void SpiralGridStep()
        {
            switch(switchPattern)
            {
                case 0:
                case 2:
                    position.y = switchPattern == 0 ? position.y + 1 : position.y - 1;
                    if (position.y.Abs() == step)
                    {
                        switchPattern = (byte)((switchPattern + 1) % 4);
                    }
                    break;
                case 1:
                case 3:
                    position.x = switchPattern == 1 ? position.x + 1 : position.x - 1;
                    if (position.x.Abs() == step)
                    {
                        if (switchPattern == 3)
                        {
                            step++;
                        }
                        switchPattern = (byte)((switchPattern + 1) % 4);
                    }
                    break;
            }
        }
        /// <summary>
        /// Make a step in y. If it's at the end of the grid, it will goes to the up and make a right turn.
        /// Value are always positive.
        /// </summary>
        /// <returns></returns>
        public void DownStep(int maxHeight)
        {
            position.y = (position.y + step) % maxHeight;
            position.x = position.y == 0 ? position.x + step : position.x;
        }
        /// <summary>
        /// Return the actual position of the pattern maker.
        /// </summary>
        public float2 GetNewPosition { get { return position; } }
    }
}
