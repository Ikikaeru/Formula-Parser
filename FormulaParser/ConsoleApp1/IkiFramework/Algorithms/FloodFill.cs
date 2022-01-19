using System.Collections.Generic;
using IkiCore.Mathematics;
namespace IkiCore.Algorithms
{
    public static partial class FloodFill
    {
        /// <summary>
        /// Return all positions of the neighbour of the specific started cell that are exactly the same.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="startX"></param>
        /// <param name="startY"></param>
        /// <returns></returns>
        public static List<int2> GetRegion(bool[,] array, int startX, int startY)
        {
            List<int2> tiles;
            tiles = new List<int2>();
            bool[,] mapFlag;
            mapFlag = new bool[array.GetLength(0), array.GetLength(1)];
            bool tileType = array[startX, startY];
            Queue<int2> queue;
            queue = new Queue<int2>();
            int2 startVec;
            startVec.x = startX;
            startVec.y = startY;
            queue.Enqueue(startVec);
            mapFlag[startX, startY] = true;
            int2 tempWH, tile;
            int x, y;
            while (queue.Count > 0)
            {
                tile = queue.Dequeue();
                tiles.Add(tile);
                tempWH.x = tile.x + 2;
                tempWH.y = tile.y + 2;
                for (y = tile.y - 1; y < tempWH.y; y++)
                {
                    for (x = tile.x - 1; x < tempWH.x; x++)
                    {
                        if ((x > -1 && x < mapFlag.GetLength(0) && y > -1 && y < mapFlag.GetLength(1)) && (y == tile.y || x == tile.x) && mapFlag[x, y] == false && array[x, y] == tileType)
                        {
                            mapFlag[x, y] = true;
                            startVec.x = x;
                            startVec.y = y;
                            queue.Enqueue(startVec);
                        }
                    }
                }
            }
            return tiles;
        }
        /// <summary>
        /// Return all positions of the neighbour of the specific started cell that are exactly the same.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="startX"></param>
        /// <param name="startY"></param>
        /// <returns></returns>
        public static List<int2> GetRegion(int[,] array, int startX, int startY)
        {
            List<int2> tiles;
            tiles = new List<int2>();
            bool[,] mapFlag;
            mapFlag = new bool[array.GetLength(0), array.GetLength(1)];
            int tileType = array[startX, startY];
            Queue<int2> queue;
            queue = new Queue<int2>();
            int2 startVec;
            startVec.x = startX;
            startVec.y = startY;
            queue.Enqueue(startVec);
            mapFlag[startX, startY] = true;
            int2 tile, tempWH;
            int x, y;
            while(queue.Count > 0)
            {
                tile = queue.Dequeue();
                tiles.Add(tile);
                tempWH.x = tile.x + 2;
                tempWH.y = tile.y + 2;
                for(y = tile.y - 1; y < tempWH.y; y++)
                {
                    for (x = tile.x - 1; x < tempWH.x; x++)
                    {
                        if((x > -1 && x < mapFlag.GetLength(0) && y > -1 && y < mapFlag.GetLength(1)) && (y == tile.y || x == tile.x) && mapFlag[x, y] == false && array[x, y] == tileType)
                        {
                            mapFlag[x, y] = true;
                            startVec.x = x;
                            startVec.y = y;
                            queue.Enqueue(startVec);
                        }
                    }
                }
            }
            return tiles;
        }
        /*
        /// <summary>
        /// Return all positions of the neighbour of the specific started cell that are exactly the same.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="startX"></param>
        /// <param name="startY"></param>
        /// <returns></returns>
        public static List<int2> GetRegion(IntGrid2D array, int startX, int startY)
        {
            List<int2> tiles;
            tiles = new List<int2>();
            bool[,] mapFlag;
            mapFlag = new bool[array.Width, array.Height];
            int tileType = array[startX, startY];
            Queue<int2> queue;
            queue = new Queue<int2>();
            int2 startVec;
            startVec.x = startX;
            startVec.y = startY;
            queue.Enqueue(startVec);
            mapFlag[startX, startY] = true;
            while (queue.Count > 0)
            {
                int2 tile;
                tile = queue.Dequeue();
                tiles.Add(tile);
                int2 tempWH;
                tempWH.x = tile.x + 2;
                tempWH.y = tile.y + 2;
                for (int y = tile.y - 1; y < tempWH.y; y++)
                {
                    for (int x = tile.x - 1; x < tempWH.x; x++)
                    {
                        if ((x > -1 && x < mapFlag.GetLength(0) && y > -1 && y < mapFlag.GetLength(1)) && (y == tile.y || x == tile.x) && mapFlag[x, y] == false && array[x, y] == tileType)
                        {
                            mapFlag[x, y] = true;
                            startVec.x = x;
                            startVec.y = y;
                            queue.Enqueue(startVec);
                        }
                    }
                }
            }
            return tiles;
        }*/
        /// <summary>
        /// Return all the regions that contains a specific value.
        /// To use this kind of loop, it's pretty simple:
        /// The first iteration of this list is list.Count, the second is the looped list[i].Count. To get the value, it's: list[i][j]
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<List<int2>> GetRegions(int[,] array, int value)
        {
            List<List<int2>> regions;
            regions = new List<List<int2>>();
            bool[,] mapFlag;
            mapFlag = new bool[array.GetLength(0), array.GetLength(1)];
            List<int2> newRegion;
            int x, y, i;
            for (y = 0; y < array.GetLength(1); y++)
            {
                for (x = 0; x < array.GetLength(0); x++)
                {
                    if (mapFlag[x, y] == false && array[x, y] == value)
                    {
                        newRegion = GetRegion(array, x, y);
                        regions.Add(newRegion);
                        for(i = 0; i < newRegion.Count; i++)
                        {
                            mapFlag[newRegion[i].x, newRegion[i].x] = true;
                        }
                    }
                }
            }
            return regions;
        }
        /// <summary>
        /// Return all the regions that contains a specific value.
        /// To use this kind of loop, it's pretty simple:
        /// The first iteration of this list is list.Count, the second is the looped list[i].Count. To get the value, it's: list[i][j]
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<List<int2>> GetRegions(bool[,] array, bool value)
        {
            List<List<int2>> regions;
            regions = new List<List<int2>>();
            bool[,] mapFlag;
            mapFlag = new bool[array.GetLength(0), array.GetLength(1)];
            int x, y, i;
            List<int2> newRegion;
            for (y = 0; y < array.GetLength(1); y++)
            {
                for (x = 0; x < array.GetLength(0); x++)
                {
                    if (mapFlag[x, y] == false && array[x, y] == value)
                    {
                        newRegion = GetRegion(array, x, y);
                        regions.Add(newRegion);
                        for (i = 0; i < newRegion.Count; i++)
                        {
                            mapFlag[newRegion[i].x, newRegion[i].x] = true;
                        }
                    }
                }
            }
            return regions;
        }
        /*
        /// <summary>
        /// Return all the regions that contains a specific value.
        /// To use this kind of loop, it's pretty simple:
        /// The first iteration of this list is list.Count, the second is the looped list[i].Count. To get the value, it's: list[i][j]
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<List<int2>> GetRegions(IntGrid2D array, int value)
        {
            List<List<int2>> regions;
            regions = new List<List<int2>>();
            bool[,] mapFlag;
            mapFlag = new bool[array.Width, array.Height];
            for (int y = 0; y < array.Height; y++)
            {
                for (int x = 0; x < array.Width; x++)
                {
                    if (mapFlag[x, y] == false && array[x, y] == value)
                    {
                        List<int2> newRegion;
                        newRegion = GetRegion(array, x, y);
                        regions.Add(newRegion);
                        for (int i = 0; i < newRegion.Count; i++)
                        {
                            mapFlag[newRegion[i].x, newRegion[i].x] = true;
                        }
                    }
                }
            }
            return regions;
        }*/
    }
}
