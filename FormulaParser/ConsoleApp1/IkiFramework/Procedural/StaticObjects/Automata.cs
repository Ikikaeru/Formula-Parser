using System;
using System.Collections.Generic;
using IkiCore.Core;
using IkiCore.Mathematics;
namespace IkiCore.Procedural
{
    public static partial class Automata
    {
        /// <summary>
        /// Create and fill an array with 0 or 1 randomly.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="fillPercent"></param>
        /// <param name="seed"></param>
        /// <returns></returns>
        public static int[,] FillRandomly2D(int2 size, int fillPercent, string seed = "", bool writeEdges = false)
        {
            int[,] map = new int[size.x, size.y];
            fillPercent = fillPercent < 0 ? 0 : fillPercent > 100 ? 100 : fillPercent;
            if (seed == "")
            {
                seed = (DateTime.Now.Millisecond * DateTime.Now.Ticks).ToString();
            }
            Random pseudoRandom = new Random(seed.GetHashCode());
            int x, y;
            for (x = 0; x < size.x; x = x + 1)
            {
                for (y = 0; y < size.y; y = y + 1)
                {
                    if (writeEdges)
                    {
                        map[x, y] = (x == 0 || x == size.x - 1 || y == 0 || y == size.y - 1) ? 1 : (pseudoRandom.Next(0, 101) < fillPercent) ? 0 : 1;
                    }
                    else if (!map.IsInEdge(x, y))
                    {
                        map[x, y] = (x == 0 || x == size.x - 1 || y == 0 || y == size.y - 1) ? 1 : (pseudoRandom.Next(0, 101) < fillPercent) ? 0 : 1;
                    }
                }
            }
            return map;
        }
        /// <summary>
        /// Create and fill an array with 0 or 1 randomly.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="fillPercent"></param>
        /// <param name="seed"></param>
        /// <param name="writeEdges"></param>
        /// <returns></returns>
        public static int[] FillRandomly(int2 size, int fillPercent, string seed = "", bool writeEdges = false)
        {
            int[] map = new int[size.x * size.y];
            fillPercent = fillPercent < 0 ? 0 : fillPercent > 100 ? 100 : fillPercent;
            if (seed == "")
            {
                seed = (DateTime.Now.Millisecond * DateTime.Now.Ticks).ToString();
            }
            Random pseudoRandom = new Random(seed.GetHashCode());
            int x, y;
            for (x = 0; x < size.x; x = x + 1)
            {
                for (y = 0; y < size.y; y = y + 1)
                {
                    if (writeEdges)
                    {
                        map[x.Convert2DTo1DPosition(y, size.x)] = (x == 0 || x == size.x - 1 || y == 0 || y == size.y - 1) ? 1 : (pseudoRandom.Next(0, 101) < fillPercent) ? 0 : 1;
                    }
                    else if (!map.IsInEdge2D(x, y, size.x))
                    {
                        map[x.Convert2DTo1DPosition(y, size.x)] = (x == 0 || x == size.x - 1 || y == 0 || y == size.y - 1) ? 1 : (pseudoRandom.Next(0, 101) < fillPercent) ? 0 : 1;
                    }
                }
            }
            return map;
        }
        /// <summary>
        /// Generate dungeon room with value between 0 ans 1.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="minRoomSize"></param>
        /// <param name="maxRoomSize"></param>
        /// <param name="maxGeneratedRooms"></param>
        /// <param name="seed"></param>
        /// <param name="writeOnBorder"></param>
        /// <returns></returns>
        public static int[,] MakeDungeonRoom2D(int2 size, int2 minRoomSize, int2 maxRoomSize, int maxGeneratedRooms, string seed = "", bool writeOnBorder = false, bool connectClosestRoom = false)
        {
            int[,] map = new int[size.x, size.y];
            int x, y, z;
            for (y = 0; y < size.y; y++)
            {
                for (x = 0; x < size.x; x++)
                {
                    map[x, y] = 0;
                }
            }
            List<RogueRoom> rooms = new List<RogueRoom>();
            if (seed == "")
            {
                seed = (DateTime.Now.Millisecond * DateTime.Now.Ticks).ToString();
            }
            Random pseudoRandom = new Random(seed.GetHashCode());
            int roomSizeX, roomSizeY;
            RogueRoom newRoom;
            bool roomOverlap;
            int i, j;
            for (i = 0; i < maxGeneratedRooms; i++)
            {
                roomSizeX = pseudoRandom.Next(minRoomSize.x, maxRoomSize.x + 1);
                roomSizeY = pseudoRandom.Next(minRoomSize.y, maxRoomSize.y + 1);
                if (writeOnBorder)
                {
                    newRoom = new RogueRoom(pseudoRandom.Next(0, size.x - roomSizeX), pseudoRandom.Next(0, size.y - roomSizeY), roomSizeX, roomSizeY);
                }
                else
                {
                    newRoom = new RogueRoom(pseudoRandom.Next(1, size.x - 1 - roomSizeX), pseudoRandom.Next(1, size.y - 1 - roomSizeY), roomSizeX, roomSizeY);
                }
                roomOverlap = false;
                for (j = 0; j < rooms.Count; j++)
                {
                    if (newRoom.IsOverlapping(rooms[j]))
                    {
                        roomOverlap = true;
                        break;
                    }
                }
                if (!roomOverlap)
                {
                    rooms.Add(newRoom);
                    for (z = newRoom.Top; z < newRoom.Bottom; z++)
                    {
                        for (x = newRoom.Left; x < newRoom.Right; x++)
                        {
                            map[x, z] = 1;
                        }
                    }
                }
            }
            int2 pos;
            if (connectClosestRoom)
            {
                int actualIndex;
                int closestIndex = -1;
                int2 sqrDist;
                float dist = float.MaxValue;
                for (i = 0; i < rooms.Count; i++)
                {
                    if (dist > rooms[i].Center.SqrMagnitude)
                    {
                        closestIndex = i;
                    }
                }
                if (closestIndex == -1)
                {
                    return map;
                }
                RogueRoom rr;
            NewCheck:
                rr = rooms[closestIndex];
                rr.SetConnected();
                rooms[closestIndex] = rr;
                actualIndex = closestIndex;
                closestIndex = -1;
                dist = float.MaxValue;
                for (i = 0; i < rooms.Count; i++)
                {
                    if (rooms[i].Center == rooms[actualIndex].Center || rooms[i].IsConnected)
                    {
                        continue;
                    }
                    sqrDist = rooms[actualIndex].Center - rooms[i].Center;
                    if (dist > sqrDist.SqrMagnitude)
                    {
                        dist = sqrDist.SqrMagnitude;
                        closestIndex = i;
                    }
                }
                if (closestIndex != -1)
                {
                    pos = rooms[actualIndex].Center;
                    while (pos.x != rooms[closestIndex].Center.x)
                    {
                        map[pos.x, pos.y] = 1;
                        pos.x += pos.x < rooms[closestIndex].Center.x ? 1 : -1;
                    }
                    while (pos.y != rooms[closestIndex].Center.y)
                    {
                        map[pos.x, pos.y] = 1;
                        pos.y += pos.y < rooms[closestIndex].Center.y ? 1 : -1;
                    }
                    goto NewCheck;
                }
            }
            else
            {
                for (i = 0; i < rooms.Count; i++)
                {
                    if (!rooms[i].IsConnected)
                    {
                    newJ:
                        j = pseudoRandom.Next(0, rooms.Count);
                        j = (i + j) % rooms.Count;
                        if (i == j)
                        {
                            goto newJ;
                        }
                        if (rooms[i].IsConnected && rooms[j].IsConnected)
                        {
                            if (i == rooms.Count - 1)
                            {
                                continue;
                            }
                            goto newJ;
                        }
                        pos = rooms[i].Center;
                        while (pos.x != rooms[j].Center.x)
                        {
                            map[pos.x, pos.y] = 1;
                            pos.x += pos.x < rooms[j].Center.x ? 1 : -1;
                        }
                        while (pos.y != rooms[j].Center.y)
                        {
                            map[pos.x, pos.y] = 1;
                            pos.y += pos.y < rooms[j].Center.y ? 1 : -1;
                        }
                        rooms[i].SetConnected();
                    }
                }
            }
            return map;
        }
        /// <summary>
        /// Generate dungeon room with value between 0 ans 1.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="minRoomSize"></param>
        /// <param name="maxRoomSize"></param>
        /// <param name="maxGeneratedRooms"></param>
        /// <param name="seed"></param>
        /// <param name="writeOnBorder"></param>
        /// <param name="connectClosestRoom"></param>
        /// <returns></returns>
        public static int[] MakeDungeonRoom(int2 size, int2 minRoomSize, int2 maxRoomSize, int maxGeneratedRooms, string seed = "", bool writeOnBorder = false, bool connectClosestRoom = false)
        {
            int[] map = new int[size.x * size.y];
            int x, y, z;
            for (y = 0; y < size.y; y++)
            {
                for (x = 0; x < size.x; x++)
                {
                    map[x.Convert2DTo1DPosition(y, size.x)] = 0;
                }
            }
            List<RogueRoom> rooms = new List<RogueRoom>();
            if (seed == "")
            {
                seed = (DateTime.Now.Millisecond * DateTime.Now.Ticks).ToString();
            }
            Random pseudoRandom = new Random(seed.GetHashCode());
            int roomSizeX, roomSizeY;
            RogueRoom newRoom;
            bool roomOverlap;
            int i, j;
            for (i = 0; i < maxGeneratedRooms; i++)
            {
                roomSizeX = pseudoRandom.Next(minRoomSize.x, maxRoomSize.x + 1);
                roomSizeY = pseudoRandom.Next(minRoomSize.y, maxRoomSize.y + 1);
                if (writeOnBorder)
                {
                    newRoom = new RogueRoom(pseudoRandom.Next(0, size.x - roomSizeX), pseudoRandom.Next(0, size.y - roomSizeY), roomSizeX, roomSizeY);
                }
                else
                {
                    newRoom = new RogueRoom(pseudoRandom.Next(1, size.x - 1 - roomSizeX), pseudoRandom.Next(1, size.y - 1 - roomSizeY), roomSizeX, roomSizeY);
                }
                roomOverlap = false;
                for (j = 0; j < rooms.Count; j++)
                {
                    if (newRoom.IsOverlapping(rooms[j]))
                    {
                        roomOverlap = true;
                        break;
                    }
                }
                if (!roomOverlap)
                {
                    rooms.Add(newRoom);
                    for (z = newRoom.Top; z < newRoom.Bottom; z++)
                    {
                        for (x = newRoom.Left; x < newRoom.Right; x++)
                        {
                            map[x.Convert2DTo1DPosition(z, size.x)] = 1;
                        }
                    }
                }
            }
            int2 pos;
            if (connectClosestRoom)
            {
                int actualIndex;
                int closestIndex = -1;
                int2 sqrDist;
                float dist = float.MaxValue;
                for (i = 0; i < rooms.Count; i++)
                {
                    if (dist > rooms[i].Center.SqrMagnitude)
                    {
                        closestIndex = i;
                    }
                }
                if (closestIndex == -1)
                {
                    return map;
                }
                RogueRoom rr;
            NewCheck:
                rr = rooms[closestIndex];
                rr.SetConnected();
                rooms[closestIndex] = rr;
                actualIndex = closestIndex;
                closestIndex = -1;
                dist = float.MaxValue;
                for (i = 0; i < rooms.Count; i++)
                {
                    if (rooms[i].Center == rooms[actualIndex].Center || rooms[i].IsConnected)
                    {
                        continue;
                    }
                    sqrDist = rooms[actualIndex].Center - rooms[i].Center;
                    if (dist > sqrDist.SqrMagnitude)
                    {
                        dist = sqrDist.SqrMagnitude;
                        closestIndex = i;
                    }
                }
                if (closestIndex != -1)
                {
                    pos = rooms[actualIndex].Center;
                    while (pos.x != rooms[closestIndex].Center.x)
                    {
                        map[pos.Convert2DTo1DPosition(size.x)] = 1;
                        pos.x += pos.x < rooms[closestIndex].Center.x ? 1 : -1;
                    }
                    while (pos.y != rooms[closestIndex].Center.y)
                    {
                        map[pos.Convert2DTo1DPosition(size.x)] = 1;
                        pos.y += pos.y < rooms[closestIndex].Center.y ? 1 : -1;
                    }
                    goto NewCheck;
                }
            }
            else
            {
                for (i = 0; i < rooms.Count; i++)
                {
                    if (!rooms[i].IsConnected)
                    {
                    newJ:
                        j = pseudoRandom.Next(0, rooms.Count);
                        j = (i + j) % rooms.Count;
                        if (i == j)
                        {
                            goto newJ;
                        }
                        if (rooms[i].IsConnected && rooms[j].IsConnected)
                        {
                            if (i == rooms.Count - 1)
                            {
                                continue;
                            }
                            goto newJ;
                        }
                        pos = rooms[i].Center;
                        while (pos.x != rooms[j].Center.x)
                        {
                            map[pos.Convert2DTo1DPosition(size.x)] = 1;
                            pos.x += pos.x < rooms[j].Center.x ? 1 : -1;
                        }
                        while (pos.y != rooms[j].Center.y)
                        {
                            map[pos.Convert2DTo1DPosition(size.x)] = 1;
                            pos.y += pos.y < rooms[j].Center.y ? 1 : -1;
                        }
                        rooms[i].SetConnected();
                    }
                }
            }
            return map;
        }
        /// <summary>
        /// Create and fill an array with only 1. Then, make a random shape of 0 equal to the percentage of fillPercent.
        /// FillPercent is supposed to be between 0 and 100.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="seed"></param>
        /// <returns></returns>
        public static int[,] DiffusionLimitedAggregation2D(int2 size, int fillPercent, string seed = "", bool orthogonally = false, bool writeEdges = false)
        {
            fillPercent = fillPercent < 0 ? 0 : fillPercent > 100 ? 100 : fillPercent;
            int[,] map = new int[size.x, size.y];
            int wall = 0;
            int i, j;
            for (i = 0; i < size.x; i = i + 1)
            {
                for (j = 0; j < size.y; j = j + 1)
                {
                    map[i, j] = 1;
                }
            }
            if (seed == "")
            {
                seed = (DateTime.Now.Millisecond * DateTime.Now.Ticks).ToString();
            }
            Random pseudoRandom = new Random(seed.GetHashCode());
            int randDir = pseudoRandom.Next(0, 4);
            int tmpX = (size.x / 2) - 1;
            int tmpY = (size.y / 2) - 1;
            int filled = 0;
            if (orthogonally)
            {
                bool horizontal = pseudoRandom.Next(0, 101) > 49;
                float a;
                while (filled < fillPercent)
                {
                    if (map[tmpX, tmpY] == 1)
                    {
                        map[tmpX, tmpY] = 0;
                        wall++;
                    }
                    randDir = pseudoRandom.Next(0, 16);
                    if (horizontal)
                    {
                        tmpX += randDir > 7 ? 1 : -1;
                        tmpX = tmpX.Clamp(writeEdges ? 0 : 1, writeEdges ? size.x - 1 : size.x - 2);
                    }
                    else
                    {
                        tmpY += randDir > 7 ? 1 : -1;
                        tmpY = tmpY.Clamp(writeEdges ? 0 : 1, writeEdges ? size.y - 1 : size.y - 2);
                    }
                    horizontal = pseudoRandom.Next(0, 101) > 49;
                    a = wall;
                    a /= (size.x - 2) * (size.y - 2);
                    a *= 100;
                    filled = (int)a;
                }
            }
            else
            {
                float a;
                while (filled < fillPercent)
                {
                    if (map[tmpX, tmpY] == 1)
                    {
                        map[tmpX, tmpY] = 0;
                        wall++;
                    }
                    randDir = pseudoRandom.Next(0, 16);
                    switch (randDir)
                    {
                        case 0:
                        case 4:
                        case 8:
                        case 12:
                            tmpX += 1;
                            break;
                        case 1:
                        case 5:
                        case 9:
                        case 13:
                            tmpX -= 1;
                            break;
                        case 2:
                        case 6:
                        case 10:
                        case 14:
                            tmpY += 1;
                            break;
                        case 3:
                        case 7:
                        case 11:
                        case 15:
                            tmpY -= 1;
                            break;
                    }
                    tmpX = tmpX.Clamp(writeEdges ? 0 : 1, writeEdges ? size.x - 1 : size.x - 2);
                    tmpY = tmpY.Clamp(writeEdges ? 0 : 1, writeEdges ? size.y - 1 : size.y - 2);
                    a = wall;
                    a /= (size.x - 2) * (size.y - 2);
                    a *= 100;
                    filled = (int)a;
                }
            }
            return map;
        }
        /// <summary>
        /// Create and fill an array with only 1. Then, make a random shape of 0 equal to the percentage of fillPercent.
        /// FillPercent is supposed to be between 0 and 100.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="fillPercent"></param>
        /// <param name="seed"></param>
        /// <param name="orthogonally"></param>
        /// <param name="writeEdges"></param>
        /// <returns></returns>
        public static int[] DiffusionLimitedAggregation(int2 size, int fillPercent, string seed = "", bool orthogonally = false, bool writeEdges = false)
        {
            fillPercent = fillPercent < 0 ? 0 : fillPercent > 100 ? 100 : fillPercent;
            int[] map = new int[size.x * size.y];
            int wall = 0;
            int i, j;
            for (i = 0; i < size.x; i = i + 1)
            {
                for (j = 0; j < size.y; j = j + 1)
                {
                    map[i.Convert2DTo1DPosition(j, size.x)] = 1;
                }
            }
            if (seed == "")
            {
                seed = (DateTime.Now.Millisecond * DateTime.Now.Ticks).ToString();
            }
            Random pseudoRandom = new Random(seed.GetHashCode());
            int randDir = pseudoRandom.Next(0, 4);
            int tmpX = (size.x / 2) - 1;
            int tmpY = (size.y / 2) - 1;
            int filled = 0;
            if (orthogonally)
            {
                bool horizontal = pseudoRandom.Next(0, 101) > 49;
                float a;
                while (filled < fillPercent)
                {
                    if (map[tmpX.Convert2DTo1DPosition(tmpY, size.x)] == 1)
                    {
                        map[tmpX.Convert2DTo1DPosition(tmpY, size.x)] = 0;
                        wall++;
                    }
                    randDir = pseudoRandom.Next(0, 16);
                    if (horizontal)
                    {
                        tmpX += randDir > 7 ? 1 : -1;
                        tmpX = tmpX.Clamp(writeEdges ? 0 : 1, writeEdges ? size.x - 1 : size.x - 2);
                    }
                    else
                    {
                        tmpY += randDir > 7 ? 1 : -1;
                        tmpY = tmpY.Clamp(writeEdges ? 0 : 1, writeEdges ? size.y - 1 : size.y - 2);
                    }
                    horizontal = pseudoRandom.Next(0, 101) > 49;
                    a = wall;
                    a /= (size.x - 2) * (size.y - 2);
                    a *= 100;
                    filled = (int)a;
                }
            }
            else
            {
                float a;
                while (filled < fillPercent)
                {
                    if (map[tmpX.Convert2DTo1DPosition(tmpY, size.x)] == 1)
                    {
                        map[tmpX.Convert2DTo1DPosition(tmpY, size.x)] = 0;
                        wall++;
                    }
                    randDir = pseudoRandom.Next(0, 16);
                    switch (randDir)
                    {
                        case 0:
                        case 4:
                        case 8:
                        case 12:
                            tmpX += 1;
                            break;
                        case 1:
                        case 5:
                        case 9:
                        case 13:
                            tmpX -= 1;
                            break;
                        case 2:
                        case 6:
                        case 10:
                        case 14:
                            tmpY += 1;
                            break;
                        case 3:
                        case 7:
                        case 11:
                        case 15:
                            tmpY -= 1;
                            break;
                    }
                    tmpX = tmpX.Clamp(writeEdges ? 0 : 1, writeEdges ? size.x - 1 : size.x - 2);
                    tmpY = tmpY.Clamp(writeEdges ? 0 : 1, writeEdges ? size.y - 1 : size.y - 2);
                    a = wall;
                    a /= (size.x - 2) * (size.y - 2);
                    a *= 100;
                    filled = (int)a;
                }
            }
            return map;
        }
        /// <summary>
        /// Execute a step of the automata algorithm or smooth the existing one.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="minSurrounding"></param>
        /// <param name="maxSurrounding"></param>
        /// <param name="replaceMinSurroundValue"></param>
        /// <param name="replaceMaxSurroundValue"></param>
        /// <returns></returns>
        public static void CellularSmoothStep(ref int[,] array, int minSurrounding, int maxSurrounding, int replaceMinSurroundValue = 1, int replaceMaxSurroundValue = 0)
        {
            int x, y, neighboursSurrounding;
            int2 p;
            for (y = 0; y < array.GetLength(1); y++)
            {
                for (x = 0; x < array.GetLength(0); x++)
                {
                    p.x = x;
                    p.y = y;
                    neighboursSurrounding = DifferentSurroundingCount(array, p);
                    array[x, y] = (neighboursSurrounding > minSurrounding) ? replaceMinSurroundValue : (neighboursSurrounding < maxSurrounding) ? replaceMaxSurroundValue : array[x, y];
                }
            }
        }
        /// <summary>
        /// Execute a step of the automata algorithm or smooth the existing one.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="width"></param>
        /// <param name="minSurrounding"></param>
        /// <param name="maxSurrounding"></param>
        /// <param name="replaceMinSurroundValue"></param>
        /// <param name="replaceMaxSurroundValue"></param>
        public static void CellularSmoothStep(ref int[] array, int width, int minSurrounding, int maxSurrounding, int replaceMinSurroundValue = 1, int replaceMaxSurroundValue = 0)
        {
            int x, y, neighboursSurrounding;
            int2 size;
            size.x = width;
            size.y = array.Length / width;
            int p;
            for (y = 0; y < size.y; y++)
            {
                for (x = 0; x < size.x; x++)
                {
                    p = y * width + x;
                    neighboursSurrounding = DifferentSurroundingCount(array, width, p);
                    array[p] = (neighboursSurrounding > minSurrounding) ? replaceMinSurroundValue : (neighboursSurrounding < maxSurrounding) ? replaceMaxSurroundValue : array[p];
                }
            }
        }
        /// <summary>
        /// Return the amount of surrounding value different than the original one.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static int DifferentSurroundingCount(int[,] array, int2 pos, bool ignoreDiagonal = false)
        {
            int surround = 0;
            int i, j, ix, jy;
            for (j = -1; j < 2; j++)
            {
                for (i = -1; i < 2; i++)
                {
                    if (j == 0 && i == 0)
                    {
                        continue;
                    }
                    if (ignoreDiagonal)
                    {
                        if (i.Abs() == j.Abs())
                        {
                            continue;
                        }
                    }
                    ix = i + pos.x;
                    jy = j + pos.y;
                    if (array.IsInRange(ix, jy))
                    {
                        if (array[ix, jy] != array[pos.x, pos.y])
                        {
                            surround++;
                        }
                    }
                    else
                    {
                        surround++;
                    }
                }
            }
            return surround;
        }
        /// <summary>
        /// Return the amount of surrounding value different than the original one.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="width"></param>
        /// <param name="index"></param>
        /// <param name="ignoreDiagonal"></param>
        /// <returns></returns>
        public static int DifferentSurroundingCount(int[] array, int index, int width, bool ignoreDiagonal = false)
        {
            int2 pos = index.Convert1DTo2DPosition(width);
            int surround = 0;
            int i, j, ix, jy;
            for (j = -1; j < 2; j++)
            {
                for (i = -1; i < 2; i++)
                {
                    if (j == 0 && i == 0)
                    {
                        continue;
                    }
                    if (ignoreDiagonal)
                    {
                        if (i.Abs() == j.Abs())
                        {
                            continue;
                        }
                    }
                    ix = i % pos.x;
                    jy = j + pos.y;
                    if (array.IsInRange2D(ix, jy, width))
                    {
                        if (array[ix.Convert2DTo1DPosition(jy, width)] != array[pos.Convert2DTo1DPosition(width)])
                        {
                            surround++;
                        }
                    }
                    else
                    {
                        surround++;
                    }
                }
            }
            return surround;
        }
        /// <summary>
        /// Return the amount of surrounding value different than the original one.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="pos"></param>
        /// <param name="width"></param>
        /// <param name="ignoreDiagonal"></param>
        /// <returns></returns>
        public static int DifferentSurroundingCount(int[] array, int2 pos, int width, bool ignoreDiagonal = false)
        {
            int surround = 0;
            int i, j, ix, jy;
            for (j = -1; j < 2; j++)
            {
                for (i = -1; i < 2; i++)
                {
                    if (j == 0 && i == 0)
                    {
                        continue;
                    }
                    if (ignoreDiagonal)
                    {
                        if (i.Abs() == j.Abs())
                        {
                            continue;
                        }
                    }
                    ix = i % pos.x;
                    jy = j + pos.y;
                    if (array.IsInRange2D(ix, jy, width))
                    {
                        if (array[ix.Convert2DTo1DPosition(jy, width)] != array[pos.Convert2DTo1DPosition(width)])
                        {
                            surround++;
                        }
                    }
                    else
                    {
                        surround++;
                    }
                }
            }
            return surround;
        }
        /// <summary>
        /// Return true if all the neighbours value are the tested value.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="pos"></param>
        /// <param name="value"></param>
        /// <param name="ignoreDiagonal"></param>
        /// <returns></returns>
        public static bool IsSurroundingValue(int[,] array, int2 pos, int value, bool ignoreDiagonal = false)
        {
            int i, j, ix, jy;
            for (j = -1; j < 2; j++)
            {
                for (i = -1; i < 2; i++)
                {
                    if (j == 0 && i == 0)
                    {
                        continue;
                    }
                    if (ignoreDiagonal)
                    {
                        if (i.Abs() == j.Abs())
                        {
                            continue;
                        }
                    }
                    ix = i + pos.x;
                    jy = j + pos.y;
                    if (array.IsInRange(ix, jy))
                    {
                        if (value != array[ix, jy])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Return true if all the neighbours value are the tested value.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="pos"></param>
        /// <param name="width"></param>
        /// <param name="value"></param>
        /// <param name="ignoreDiagonal"></param>
        /// <returns></returns>
        public static bool IsSurroundingValue(int[] array, int2 pos, int width, int value, bool ignoreDiagonal = false)
        {
            int i, j, ix, jy;
            for (j = -1; j < 2; j++)
            {
                for (i = -1; i < 2; i++)
                {
                    if (j == 0 && i == 0)
                    {
                        continue;
                    }
                    if (ignoreDiagonal)
                    {
                        if (i.Abs() == j.Abs())
                        {
                            continue;
                        }
                    }
                    ix = i + pos.x;
                    jy = j + pos.y;
                    if (array.IsInRange2D(ix, jy, width))
                    {
                        if (value != array[ix.Convert2DTo1DPosition(jy, width)])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Return true if all the neighbours value are the tested value.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        /// <param name="width"></param>
        /// <param name="value"></param>
        /// <param name="ignoreDiagonal"></param>
        /// <returns></returns>
        public static bool IsSurroundingValue(int[] array, int index, int width, int value, bool ignoreDiagonal = false)
        {
            int2 pos = index.Convert1DTo2DPosition(width);
            int i, j, ix, jy;
            for (j = -1; j < 2; j++)
            {
                for (i = -1; i < 2; i++)
                {
                    if (j == 0 && i == 0)
                    {
                        continue;
                    }
                    if (ignoreDiagonal)
                    {
                        if (i.Abs() == j.Abs())
                        {
                            continue;
                        }
                    }
                    ix = i + pos.x;
                    jy = j + pos.y;
                    if (array.IsInRange2D(ix, jy, width))
                    {
                        if (value != array[ix.Convert2DTo1DPosition(jy, width)])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Draw a circle on the grid from the center position. The circle need to have a radius, and the circle value will be the value attribute for the circle on the array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="centerX"></param>
        /// <param name="centerY"></param>
        /// <param name="radius"></param>
        /// <param name="circleValue"></param>
        public static void DrawCircleOnGrid(ref int[,] array, int2 center, int radius, int circleValue = 0)
        {
            int x, y, drawX, drawY;
            for (y = -radius; y <= radius; y++)
            {
                for (x = -radius; x <= radius; x++)
                {
                    if (x * x + y * y <= radius * radius)
                    {
                        drawX = center.x + x;
                        drawY = center.y + y;
                        if (array.IsInRange(drawX, drawY))
                        {
                            array[drawX, drawY] = circleValue;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Draw a circle on the grid from the center position. The circle need to have a radius, and the circle value will be the value attribute for the circle on the array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="center"></param>
        /// <param name="width"></param>
        /// <param name="radius"></param>
        /// <param name="circleValue"></param>
        public static void DrawCircleOnGrid(ref int[] array, int2 center, int width, int radius, int circleValue = 0)
        {
            int x, y, drawX, drawY;
            for (y = -radius; y <= radius; y++)
            {
                for (x = -radius; x <= radius; x++)
                {
                    if (x * x + y * y <= radius * radius)
                    {
                        drawX = center.x + x;
                        drawY = center.y + y;
                        if (array.IsInRange2D(drawX, drawY, width))
                        {
                            array[drawX.Convert2DTo1DPosition(drawY, width)] = circleValue;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Draw a circle on the grid from the center position. The circle need to have a radius, and the circle value will be the value attribute for the circle on the array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="centerPos"></param>
        /// <param name="width"></param>
        /// <param name="radius"></param>
        /// <param name="circleValue"></param>
        public static void DrawCircleOnGrid(ref int[] array, int centerPos, int width, int radius, int circleValue = 0)
        {
            int2 center = centerPos.Convert1DTo2DPosition(width);
            int x, y, drawX, drawY;
            for (y = -radius; y <= radius; y++)
            {
                for (x = -radius; x <= radius; x++)
                {
                    if (x * x + y * y <= radius * radius)
                    {
                        drawX = center.x + x;
                        drawY = center.y + y;
                        if (array.IsInRange2D(drawX, drawY, width))
                        {
                            array[drawX.Convert2DTo1DPosition(drawY, width)] = circleValue;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Draw a rectangle from the center position. The rectangle need a width and a height, and the rect value is the value that will be override at the position of the rectangle.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="centerX"></param>
        /// <param name="centerY"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="rectValue"></param>
        public static void DrawRectangleOnGrid(ref int[,] array, int2 center, int width, int height, int rectValue = 0)
        {
            int halfW = width / 2;
            int halfH = height / 2;
            int x, y, drawX, drawY;
            for (y = -halfH; y <= halfH; y++)
            {
                for (x = -halfW; x <= halfW; x++)
                {
                    drawX = center.x + x;
                    drawY = center.y + y;
                    if (array.IsInRange(drawX, drawY))
                    {
                        array[drawX, drawY] = rectValue;
                    }
                }
            }
        }
        /// <summary>
        /// Draw a rectangle from the center position. The rectangle need a width and a height, and the rect value is the value that will be override at the position of the rectangle.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="center"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="rectValue"></param>
        public static void DrawRectangleOnGrid(ref int[] array, int2 center, int width, int height, int rectValue = 0)
        {
            int halfW = width / 2;
            int halfH = height / 2;
            int x, y, drawX, drawY;
            for (y = -halfH; y <= halfH; y++)
            {
                for (x = -halfW; x <= halfW; x++)
                {
                    drawX = center.x + x;
                    drawY = center.y + y;
                    if (array.IsInRange2D(drawX, drawY, width))
                    {
                        array[drawX.Convert2DTo1DPosition(drawY, width)] = rectValue;
                    }
                }
            }
        }
        /// <summary>
        /// Draw a rectangle from the center position. The rectangle need a width and a height, and the rect value is the value that will be override at the position of the rectangle.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="centerPos"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="rectValue"></param>
        public static void DrawRectangleOnGrid(ref int[] array, int centerPos, int width, int height, int rectValue = 0)
        {
            int2 center = centerPos.Convert1DTo2DPosition(width);
            int halfW = width / 2;
            int halfH = height / 2;
            int x, y, drawX, drawY;
            for (y = -halfH; y <= halfH; y++)
            {
                for (x = -halfW; x <= halfW; x++)
                {
                    drawX = center.x + x;
                    drawY = center.y + y;
                    if (array.IsInRange2D(drawX, drawY, width))
                    {
                        array[drawX.Convert2DTo1DPosition(drawY, width)] = rectValue;
                    }
                }
            }
        }
        /// <summary>
        /// Draw a line on a grid.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="radius"></param>
        /// <param name="lineValue"></param>
        /// <param name="gridEdges"></param>
        public static void DrawLineOnGrid(ref int[,] array, int2 start, int2 end, int radius, int lineValue = 0, bool gridEdges = false)
        {
            int2 distance = end - start;
            int nx = distance.x.Abs();
            int ny = distance.y.Abs();
            int signX = nx > -1 ? 1 : -1;
            int signY = ny > -1 ? 1 : -1;
            int2 point;
            point.x = start.x;
            point.y = start.y;
            DrawCircleOnGrid(ref array, point, radius, lineValue);
            for (int ix = 0, iy = 0; ix < nx || iy < ny;)
            {
                if (gridEdges)
                {
                    if ((0.5f + ix) / nx < (0.5f + iy) / ny)
                    {
                        point.x += signX;
                        ix++;
                    }
                    else
                    {
                        point.y += signY;
                        iy++;
                    }
                }
                else
                {
                    if ((0.5f + ix) / nx == (0.5f + iy) / ny)
                    {
                        point.x += signX;
                        point.y += signY;
                        ix++;
                        iy++;
                    }
                    else if ((0.5f + ix) / nx < (0.5f + iy) / ny)
                    {
                        point.x += signX;
                        ix++;
                    }
                    else
                    {
                        point.y += signY;
                        iy++;
                    }
                }
                DrawCircleOnGrid(ref array, point, radius, lineValue);
            }
        }
        /// <summary>
        /// Draw a line on a grid.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="width"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="radius"></param>
        /// <param name="lineValue"></param>
        /// <param name="gridEdges"></param>
        public static void DrawLineOnGrid(ref int[] array, int width, int2 start, int2 end, int radius, int lineValue = 0, bool gridEdges = false)
        {
            int2 distance = end - start;
            int nx = distance.x.Abs();
            int ny = distance.y.Abs();
            int signX = nx > -1 ? 1 : -1;
            int signY = ny > -1 ? 1 : -1;
            int2 point;
            point.x = start.x;
            point.y = start.y;
            DrawCircleOnGrid(ref array, point, width, radius, lineValue);
            for (int ix = 0, iy = 0; ix < nx || iy < ny;)
            {
                if (gridEdges)
                {
                    if ((0.5f + ix) / nx < (0.5f + iy) / ny)
                    {
                        point.x += signX;
                        ix++;
                    }
                    else
                    {
                        point.y += signY;
                        iy++;
                    }
                }
                else
                {
                    if ((0.5f + ix) / nx == (0.5f + iy) / ny)
                    {
                        point.x += signX;
                        point.y += signY;
                        ix++;
                        iy++;
                    }
                    else if ((0.5f + ix) / nx < (0.5f + iy) / ny)
                    {
                        point.x += signX;
                        ix++;
                    }
                    else
                    {
                        point.y += signY;
                        iy++;
                    }
                }
                DrawCircleOnGrid(ref array, point, width, radius, lineValue);
            }
        }
        /// <summary>
        /// Draw on a bool array lines that are used as flag for drawing.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public static void DrawLineFlag(ref bool[,] array, int2 start, int2 end)
        {
            int2 distance = end - start;
            int nx = distance.x.Abs();
            int ny = distance.y.Abs();
            int signX = nx > -1 ? 1 : -1;
            int signY = ny > -1 ? 1 : -1;
            int2 point;
            point.x = start.x;
            point.y = start.y;
            array[point.x, point.y] = true;
            for (int ix = 0, iy = 0; ix < nx || iy < ny;)
            {
                if ((0.5f + ix) / nx < (0.5f + iy) / ny)
                {
                    point.x += signX;
                    ix++;
                }
                else
                {
                    point.y += signY;
                    iy++;
                }
                array[point.x, point.y] = true;
            }
        }
        /// <summary>
        /// Draw on a bool array lines that are used as flag for drawing.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="width"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public static void DrawLineFlag(ref bool[] array, int width, int2 start, int2 end)
        {
            int2 distance = end - start;
            int nx = distance.x.Abs();
            int ny = distance.y.Abs();
            int signX = nx > -1 ? 1 : -1;
            int signY = ny > -1 ? 1 : -1;
            int2 point;
            point.x = start.x;
            point.y = start.y;
            array[point.Convert2DTo1DPosition(width)] = true;
            for (int ix = 0, iy = 0; ix < nx || iy < ny;)
            {
                if ((0.5f + ix) / nx < (0.5f + iy) / ny)
                {
                    point.x += signX;
                    ix++;
                }
                else
                {
                    point.y += signY;
                    iy++;
                }
                array[point.Convert2DTo1DPosition(width)] = true;
            }
        }
        /// <summary>
        /// Draw an irregular shape on the grid.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="centerX"></param>
        /// <param name="centerY"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="maxPoints"></param>
        /// <param name="shapeValue"></param>
        /// <param name="pseudoRandom"></param>
        public static void DrawIrregularShape(ref int[,] array, int2 center, int2 size, int maxPoints = 3, int shapeValue = 0, string seed = "")
        {
            int halfW = size.x / 2;
            int halfH = size.y / 2;
            if (seed == "")
            {
                seed = (DateTime.Now.Millisecond * DateTime.Now.Ticks).ToString();
            }
            Random pseudoRandom = new Random(seed.GetHashCode());
            int points = pseudoRandom.Next(1, maxPoints + 1);
            List<int2> pointsPositions = new List<int2>();
            bool[,] mapFlag = new bool[array.GetLength(0), array.GetLength(1)];
            List<int2> tempPos;
            int2 p;
            int bestIndex;
            int i, j, k;
            for (i = 0; i < 4; i++)
            {
                tempPos = new List<int2>();
                for (j = 0; j < points; j++)
                {
                    switch (i)
                    {
                        case 0:
                            p.x = pseudoRandom.Next(center.x - halfW + 1, center.x + halfW - 1);
                            p.y = pseudoRandom.Next(center.y + halfH / 2, center.y + halfH - 1);
                            break;
                        case 1:
                            p.x = pseudoRandom.Next(center.x + halfW / 2, center.x + halfW - 1);
                            p.y = pseudoRandom.Next(center.y - halfH + 1, center.y + halfH - 1);
                            break;
                        case 2:
                            p.x = pseudoRandom.Next(center.x - halfW + 1, center.x + halfW - 1);
                            p.y = pseudoRandom.Next(center.y - halfH / 2, center.y - halfH + 1);
                            break;
                        default:
                            p.x = pseudoRandom.Next(center.x - halfW / 2, center.x - halfW + 1);
                            p.y = pseudoRandom.Next(center.y - halfH + 1, center.y + halfH - 1);
                            break;
                    }
                    if (array.IsInRange(p.x, p.y))
                    {
                        tempPos.Add(p);
                    }
                }
                while (tempPos.Count > 0)
                {
                    bestIndex = -1;
                    for (k = 0; k < tempPos.Count; k++)
                    {
                        if (bestIndex == -1)
                        {
                            bestIndex = k;
                            continue;
                        }
                        switch (i)
                        {
                            case 0:
                                if (tempPos[bestIndex].x < tempPos[k].x)
                                {
                                    bestIndex = k;
                                }
                                break;
                            case 1:
                                if (tempPos[bestIndex].y > tempPos[k].y)
                                {
                                    bestIndex = k;
                                }
                                break;
                            case 2:
                                if (tempPos[bestIndex].x > tempPos[k].x)
                                {
                                    bestIndex = k;
                                }
                                break;
                            case 3:
                                if (tempPos[bestIndex].y < tempPos[k].y)
                                {
                                    bestIndex = k;
                                }
                                break;
                        }
                    }
                    pointsPositions.Add(tempPos[bestIndex]);
                    tempPos.RemoveAt(bestIndex);
                }
            }
            for (i = 0; i < pointsPositions.Count; i++)
            {
                DrawLineFlag(ref mapFlag, pointsPositions[i], pointsPositions[(i + 1) % pointsPositions.Count]);
                DrawLineOnGrid(ref array, pointsPositions[i], pointsPositions[(i + 1) % pointsPositions.Count], 1, shapeValue, true);
            }
            pointsPositions = mapFlag.FloodFill(center.x, center.y);
            for (i = 0; i < pointsPositions.Count; i++)
            {
                array[pointsPositions[i].x, pointsPositions[i].y] = shapeValue;
            }
        }
        /// <summary>
        /// Compute the distance between every different value in a 2D array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="computeHeightFromOne"></param>
        /// <param name="computeDiagonalHeight"></param>
        /// <returns></returns>
        public static int[,] ComputeDistance(int[,] array, bool computeHeightFromOne, bool computeDiagonalHeight)
        {
            int[,] Distance = new int[array.GetLength(0), array.GetLength(1)];
            int maxDistance = array.GetLength(0) * array.GetLength(1);
            int[,] tmpDist;
            int changes;
            int2 pos;
            int i, x, z;
            for (i = 0; i < maxDistance; i++)
            {
                changes = 0;
                tmpDist = Distance.Clone() as int[,];
                for (z = 0; z < array.GetLength(1); z++)
                {
                    for (x = 0; x < array.GetLength(0); x++)
                    {
                        switch (i)
                        {
                            case 0:
                                tmpDist[x, z] = computeHeightFromOne ? 1 : 0;
                                changes++;
                                break;
                            case 1:
                                pos.x = x;
                                pos.y = z;
                                if (IsSurroundingValue(array, pos, array[pos.x, pos.y], !computeDiagonalHeight))
                                {
                                    tmpDist[pos.x, pos.y]++;
                                    changes++;
                                }
                                break;
                            default:
                                pos.x = x;
                                pos.y = z;
                                if (IsSurroundingValue(Distance, pos, computeHeightFromOne ? i : i - 1, !computeDiagonalHeight))
                                {
                                    tmpDist[pos.x, pos.y]++;
                                    changes++;
                                }
                                break;
                        }
                    }
                }
                Distance = tmpDist;
                if (changes == 0)
                {
                    break;
                }
            }
            return Distance;
        }
        /// <summary>
        /// Compute the distance between every different value in a 2D array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="width"></param>
        /// <param name="computeHeightFromOne"></param>
        /// <param name="computeDiagonalHeight"></param>
        /// <returns></returns>
        public static int[] ComputeDistance(int[] array, int width, bool computeHeightFromOne, bool computeDiagonalHeight)
        {
            int[] Distance = new int[array.Length];
            int[] tmpDist;
            int changes;
            int2 size;
            size.x = width;
            size.y = array.Length / width;
            int2 pos;
            int i, x, z;
            for (i = 0; i < array.Length; i++)
            {
                changes = 0;
                tmpDist = Distance.Clone() as int[];
                for (z = 0; z < size.y; z++)
                {
                    for (x = 0; x < size.x; x++)
                    {
                        switch (i)
                        {
                            case 0:
                                tmpDist[x.Convert2DTo1DPosition(z, width)] = computeHeightFromOne ? 1 : 0;
                                changes++;
                                break;
                            case 1:
                                pos.x = x;
                                pos.y = z;
                                if (IsSurroundingValue(array, pos, width, array[pos.x.Convert2DTo1DPosition(pos.y, width)], !computeDiagonalHeight))
                                {
                                    tmpDist[pos.Convert2DTo1DPosition(width)]++;
                                    changes++;
                                }
                                break;
                            default:
                                pos.x = x;
                                pos.y = z;
                                if (IsSurroundingValue(Distance, pos, width, computeHeightFromOne ? i : i - 1, !computeDiagonalHeight))
                                {
                                    tmpDist[pos.Convert2DTo1DPosition(width)]++;
                                    changes++;
                                }
                                break;
                        }
                    }
                }
                Distance = tmpDist;
                if (changes == 0)
                {
                    break;
                }
            }
            return Distance;
        }
        /// <summary>
        /// Compute erosion for a 2D map.
        /// </summary>
        /// <param name="map"></param>
        /// <param name="radius"></param>
        /// <param name="inertia"></param>
        /// <param name="sedimentCapacityFactor"></param>
        /// <param name="minSedimentCapacity"></param>
        /// <param name="velocity"></param>
        /// <param name="depositSpeed"></param>
        /// <param name="erodeSpeed"></param>
        /// <param name="evaporateSpeed"></param>
        /// <param name="waterVolume"></param>
        /// <param name="gravity"></param>
        /// <param name="maxDropletTime"></param>
        /// <param name="iterations"></param>
        /// <param name="seed"></param>
        /// <param name="randomnessOnCompute"></param>
        /// <returns></returns>
        public static float[,] Erosion(float[,] map, int radius, float inertia, float sedimentCapacityFactor, float minSedimentCapacity, float velocity, float depositSpeed, float erodeSpeed, float evaporateSpeed, float waterVolume, float gravity, int maxDropletTime, int iterations, int seed, bool randomnessOnCompute = true)
        {
            Random rng = new Random(seed);
            int[][] erosionBrushIndices = new int[map.GetLength(0) * map.GetLength(1)][];
            float[][] erosionBrushWeights = new float[map.GetLength(0) * map.GetLength(1)][];
            int[] xOffsets = new int[radius * radius * 4];
            int[] yOffsets = new int[radius * radius * 4];
            float[] weights = new float[radius * radius * 4];
            float weightSum = 0;
            int addIndex = 0;
            int sign = 1;
            int i, j, x, y, lifeTime, mapIndexArray;
            int2 center, coord, newPos, erodePos;
            float height, newHeight, sedimentCapacity, depositAmount, amountToErode, sediment, water, vel, weight, sqrDst, weighedErodeAmount, deltaSediment;
            float2 cellOffset, newCellOffset, gradient, pos, dir;
            for (i = 0; i < erosionBrushIndices.GetLength(0); i++)
            {
                center.x = i % map.GetLength(0);
                center.y = i / map.GetLength(1);
                if (center.y <= radius || center.y >= map.GetLength(1) - radius || center.x <= radius + 1 || center.x >= map.GetLength(0) - radius)
                {
                    weightSum = 0;
                    addIndex = 0;
                    for (y = -radius; y <= radius; y++)
                    {
                        for (x = -radius; x <= radius; x++)
                        {
                            sqrDst = x * x + y * y;
                            if (sqrDst < radius * radius)
                            {
                                coord.x = center.x + x;
                                coord.y = center.y + y;
                                if (coord.x >= 0 && coord.x < map.GetLength(0) && coord.y >= 0 && coord.y < map.GetLength(1))
                                {
                                    weight = 1 - Mathematics.Math.Sqrt(sqrDst) / radius;
                                    weightSum += weight;
                                    weights[addIndex] = weight;
                                    xOffsets[addIndex] = x;
                                    yOffsets[addIndex] = y;
                                    addIndex++;
                                }
                            }
                        }
                    }
                }
                erosionBrushIndices[i] = new int[addIndex];
                erosionBrushWeights[i] = new float[addIndex];
                for (j = 0; j < addIndex; j++)
                {
                    erosionBrushIndices[i][j] = (yOffsets[j] + center.y) * map.GetLength(1) + xOffsets[j] + center.x; // height? or height * width ?
                    erosionBrushWeights[i][j] = weights[j] / weightSum;
                }
            }
            for (i = 0; i < iterations; i++)
            {
                sediment = 0f;
                water = waterVolume;
                vel = velocity;
                pos.x = rng.Next(0, map.GetLength(0) - 1);
                pos.y = rng.Next(0, map.GetLength(1) - 1);
                dir.x = 0f;
                dir.y = 0f;
                for (lifeTime = 0; lifeTime < maxDropletTime; lifeTime++)
                {
                    newPos.x = (int)pos.x;
                    newPos.y = (int)pos.y;
                    if (randomnessOnCompute)
                    {
                        sign = rng.Next(0, 2) == 0 ? -1 : 1;
                    }
                    mapIndexArray = newPos.y * map.GetLength(0) + newPos.x;
                    cellOffset.x = pos.x - newPos.x;
                    cellOffset.y = pos.y - newPos.y;
                    if (!map.IsInRange(newPos.x + sign, newPos.y) || !map.IsInRange(newPos.x + sign, newPos.y + sign) || !map.IsInRange(newPos.x, newPos.y + sign))
                    {
                        break;
                    }
                    gradient.x = (map[newPos.x + sign, newPos.y] - map[newPos.x, newPos.y]) * (1f - cellOffset.y) + (map[newPos.x + sign, newPos.y + sign] - map[newPos.x, newPos.y + sign]) * cellOffset.y;
                    gradient.y = (map[newPos.x, newPos.y + sign] - map[newPos.x, newPos.y]) * (1f - cellOffset.x) + (map[newPos.x + sign, newPos.y + sign] - map[newPos.x + sign, newPos.y]) * cellOffset.x;
                    height = map[newPos.x, newPos.y] * (1f - cellOffset.x) * (1f - cellOffset.y) + map[newPos.x + sign, newPos.y] * cellOffset.x * (1f - cellOffset.y) + map[newPos.x, newPos.y + sign] * (1f - cellOffset.x) * cellOffset.y + map[newPos.x + sign, newPos.y + sign] * cellOffset.x * cellOffset.y;
                    dir.x = dir.x * inertia - gradient.x * (1f - inertia);
                    dir.y = dir.y * inertia - gradient.y * (1f - inertia);
                    dir.Normalize();
                    pos = pos + dir;
                    if ((dir.x == 0f && dir.y == 0f) || !map.IsInRange((int)pos.x, (int)pos.y))
                    {
                        break;
                    }
                    newCellOffset.x = pos.x - (int)pos.x;
                    newCellOffset.y = pos.y - (int)pos.y;
                    newHeight = map[newPos.x, newPos.y] * (1f - newCellOffset.x) * (1f - newCellOffset.y) + map[newPos.x + sign, newPos.y] * newCellOffset.x * (1f - newCellOffset.y) + map[newPos.x, newPos.y + sign] * (1f - newCellOffset.x) * newCellOffset.y + map[newPos.x + sign, newPos.y + sign] * newCellOffset.x * newCellOffset.y;
                    newHeight = newHeight - height;
                    sedimentCapacity = minSedimentCapacity.Max(-newHeight * vel * water * sedimentCapacityFactor);
                    if (sediment > sedimentCapacity || newHeight > 0f)
                    {
                        depositAmount = (newHeight > 0) ? newHeight.Min(sediment) : (sediment - sedimentCapacity) * depositSpeed;
                        sediment -= depositAmount;
                        map[newPos.x, newPos.y] += depositAmount * (1f - cellOffset.x) * (1f - cellOffset.y);
                        map[newPos.x + sign, newPos.y] += depositAmount * cellOffset.x * (1f - cellOffset.y);
                        map[newPos.x, newPos.y + sign] += depositAmount * (1f - cellOffset.x) * cellOffset.y;
                        map[newPos.x + sign, newPos.y + sign] += depositAmount * cellOffset.x * cellOffset.y;
                    }
                    else
                    {
                        amountToErode = (-newHeight).Min((sedimentCapacity - sediment) * erodeSpeed);
                        for (int brushPointIndex = 0; brushPointIndex < erosionBrushIndices[mapIndexArray].Length; brushPointIndex++)
                        {
                            erodePos.x = erosionBrushIndices[mapIndexArray][brushPointIndex] % map.GetLength(0);
                            erodePos.y = erosionBrushIndices[mapIndexArray][brushPointIndex] / map.GetLength(1);
                            weighedErodeAmount = amountToErode * erosionBrushWeights[mapIndexArray][brushPointIndex];
                            deltaSediment = (map[erodePos.x, erodePos.y] < weighedErodeAmount) ? map[erodePos.x, erodePos.y] : weighedErodeAmount;
                            map[erodePos.x, erodePos.y] -= deltaSediment;
                            sediment += deltaSediment;
                        }
                    }
                    vel = Mathematics.Math.Sqrt(vel * vel + newHeight * gravity);
                    water *= (1f - evaporateSpeed);
                }
            }
            return map;
        }
        /// <summary>
        /// Create and fill an array with 0 or 1 randomly.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="fillPercent"></param>
        /// <param name="seed"></param>
        /// <returns></returns>
        public static int[,,] FillRandomly(int3 size, int fillPercent, string seed = "", bool writeEdges = false)
        {
            int[,,] map = new int[size.x, size.y, size.z];
            fillPercent = fillPercent < 0 ? 0 : fillPercent > 100 ? 100 : fillPercent;
            if (seed == "")
            {
                seed = (DateTime.Now.Millisecond * DateTime.Now.Ticks).ToString();
            }
            System.Random pseudoRandom = new System.Random(seed.GetHashCode());
            int x, y, z;
            for (z = 0; z < size.z; z = z + 1)
            {
                for (x = 0; x < size.x; x = x + 1)
                {
                    for (y = 0; y < size.y; y = y + 1)
                    {
                        if (writeEdges)
                        {
                            map[x, y, z] = (x == 0 || x == size.x - 1 || y == 0 || y == size.y - 1 || z == 0 || z == size.z - 1) ? 1 : (pseudoRandom.Next(0, 101) < fillPercent) ? 0 : 1;
                        }
                        else if (!map.IsInEdge(x, y, z))
                        {
                            map[x, y, z] = (x == 0 || x == size.x - 1 || y == 0 || y == size.y - 1 || z == 0 || z == size.z - 1) ? 1 : (pseudoRandom.Next(0, 101) < fillPercent) ? 0 : 1;
                        }
                    }
                }
            }
            return map;
        }
        /// <summary>
        /// Create and fill an array with only 1. Then, make a random shape of 0 equal to the percentage of fillPercent.
        /// FillPercent is supposed to be between 0 and 100.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="seed"></param>
        /// <returns></returns>
        public static int[,,] DiffusionLimitedAggregation(int3 size, int fillPercent, string seed = "", bool orthogonally = false, bool writeEdges = false)
        {
            fillPercent = fillPercent < 0 ? 0 : fillPercent > 100 ? 100 : fillPercent;
            int[,,] map = new int[size.x, size.y, size.z];
            int wall = 0;
            int i, j, k;
            for (i = 0; i < size.x; i = i + 1)
            {
                for (j = 0; j < size.y; j = j + 1)
                {
                    for (k = 0; k < size.z; k = k + 1)
                    {
                        map[i, j, k] = 0;
                    }
                }
            }
            if (seed == "")
            {
                seed = (DateTime.Now.Millisecond * DateTime.Now.Ticks).ToString();
            }
            System.Random pseudoRandom = new System.Random(seed.GetHashCode());
            int randDir = pseudoRandom.Next(0, 4);
            int tmpX = (size.x / 2) - 1;
            int tmpY = (size.y / 2) - 1;
            int tmpZ = (size.z / 2) - 1;
            int filled = 0;
            if (orthogonally)
            {
                int hvo = pseudoRandom.Next(0, 67);
                float a;
                while (filled < fillPercent)
                {
                    if (map[tmpX, tmpY, tmpZ] == 0)
                    {
                        map[tmpX, tmpY, tmpZ] = 1;
                        wall++;
                    }
                    if (hvo < 22)
                    {
                        tmpX += pseudoRandom.Next(0, 16) > 7 ? 1 : -1;
                        tmpX = tmpX.Clamp(writeEdges ? 0 : 1, writeEdges ? size.x - 1 : size.x - 2);
                    }
                    else if (hvo < 44)
                    {
                        tmpY += pseudoRandom.Next(0, 16) > 7 ? 1 : -1;
                        tmpY = tmpY.Clamp(writeEdges ? 0 : 1, writeEdges ? size.y - 1 : size.y - 2);
                    }
                    else
                    {
                        tmpZ += pseudoRandom.Next(0, 16) > 7 ? 1 : -1;
                        tmpZ = tmpZ.Clamp(writeEdges ? 0 : 1, writeEdges ? size.z - 1 : size.z - 2);
                    }
                    hvo = pseudoRandom.Next(0, 67);
                    a = wall;
                    a /= (size.x - 2) * (size.y - 2) * (size.z - 2);
                    a *= 100;
                    filled = (int)a;
                }
            }
            else
            {
                float a;
                while (filled < fillPercent)
                {
                    if (map[tmpX, tmpY, tmpZ] == 0)
                    {
                        map[tmpX, tmpY, tmpZ] = 1;
                        wall++;
                    }
                    randDir = pseudoRandom.Next(0, 24);
                    switch (randDir)
                    {
                        case 0:
                        case 6:
                        case 12:
                        case 18:
                            tmpX += 1;
                            break;
                        case 1:
                        case 7:
                        case 13:
                        case 19:
                            tmpX += -1;
                            break;
                        case 2:
                        case 8:
                        case 14:
                        case 20:
                            tmpY += 1;
                            break;
                        case 3:
                        case 9:
                        case 15:
                        case 21:
                            tmpY += -1;
                            break;
                        case 4:
                        case 10:
                        case 16:
                        case 22:
                            tmpZ += 1;
                            break;
                        case 5:
                        case 11:
                        case 17:
                        case 23:
                            tmpZ += -1;
                            break;
                    }
                    tmpX = tmpX.Clamp(writeEdges ? 0 : 1, writeEdges ? size.x - 1 : size.x - 2);
                    tmpY = tmpY.Clamp(writeEdges ? 0 : 1, writeEdges ? size.y - 1 : size.y - 2);
                    tmpZ = tmpZ.Clamp(writeEdges ? 0 : 1, writeEdges ? size.z - 1 : size.z - 2);
                    a = wall;
                    a /= (size.x - 2) * (size.y - 2) * (size.z - 2);
                    a *= 100;
                    filled = (int)a;
                }
            }
            return map;
        }
        /// <summary>
        /// Execute a step of the automata algorithm or smooth the existing one.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="minSurrounding"></param>
        /// <param name="maxSurrounding"></param>
        /// <param name="replaceMinSurroundValue"></param>
        /// <param name="replaceMaxSurroundValue"></param>
        /// <returns></returns>
        public static void CellularSmoothStep(ref int[,,] array, int minSurrounding, int maxSurrounding, int replaceMinSurroundValue = 1, int replaceMaxSurroundValue = 0, bool ignoreDiagonals = false, bool ignoreFarDiagonals = false, bool ignoreNearDirections = false)
        {
            int x, y, z, neighboursSurrounding;
            int3 p;
            for (z = 0; z < array.GetLength(2); z++)
            {
                for (y = 0; y < array.GetLength(1); y++)
                {
                    for (x = 0; x < array.GetLength(0); x++)
                    {
                        p.x = x;
                        p.y = y;
                        p.z = z;
                        neighboursSurrounding = DifferentSurroundingCount(array, p, ignoreDiagonals, ignoreFarDiagonals, ignoreNearDirections);
                        array[x, y, z] = (neighboursSurrounding > minSurrounding) ? replaceMinSurroundValue : (neighboursSurrounding < maxSurrounding) ? replaceMaxSurroundValue : array[x, y, z];
                    }
                }
            }
        }
        /// <summary>
        /// Count the different surrouding values. There is 26 possible values in total, itself exclude.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="pos"></param>
        /// <param name="ignoreDiagonal"></param>
        /// <param name="ignoreFarDiagonals"></param>
        /// <param name="ignoreNearDirections"></param>
        /// <returns></returns>
        public static int DifferentSurroundingCount(int[,,] array, int3 pos, bool ignoreDiagonal = false, bool ignoreFarDiagonals = false, bool ignoreNearDirections = false)
        {
            int surround = 0;
            int i, j, k, ix, jy, kz;
            for (k = 0; k < 2; k++)
            {
                for (j = -1; j < 2; j++)
                {
                    for (i = -1; i < 2; i++)
                    {
                        switch (i * i + j * j + k * k)
                        {
                            case 0: // Itself
                                continue;
                            case 1: // Near directions
                                if (ignoreDiagonal)
                                {
                                    continue;
                                }
                                break;
                            case 2: // Near Diagonals
                                if (ignoreNearDirections)
                                {
                                    continue;
                                }
                                break;
                            case 3: // Far Diagonals
                                if (ignoreFarDiagonals)
                                {
                                    continue;
                                }
                                break;
                        }
                        ix = i + pos.x;
                        jy = j + pos.y;
                        kz = k + pos.z;
                        if (array.IsInRange(ix, jy, kz))
                        {
                            if (array[ix, jy, kz] != array[pos.x, pos.y, pos.z])
                            {
                                surround++;
                            }
                        }
                        else
                        {
                            surround++;
                        }
                    }
                }
            }
            return surround;
        }
    }
}
