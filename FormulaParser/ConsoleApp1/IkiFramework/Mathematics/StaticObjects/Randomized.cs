using IkiCore.Core;
using System.Collections.Generic;
namespace IkiCore.Mathematics
{
	public static class Randomized
	{
        public static List<float2> PoissonDiskSampling(float radius, float2 regionSize, int samplesBeforeReject = 25, int seed = 0)
        {
            System.Random rnd = new System.Random(seed);
            float cellSize = Geometry.SquareSideLengthFromRadius(radius);
            int[,] grid = new int[(int)Math.Ceil(regionSize.x / cellSize), (int)Math.Ceil(regionSize.y / cellSize)];
            List<float2> points = new List<float2>();
            List<float2> spawnPoints = new List<float2>
            {
                regionSize / 2f
            };
            int x, y, i, spawnIndex, cellX, cellY, searchStartX, searchEndX, searchEndY, pointIndex;
            float2 spawnCenter, dir, candidate;
            bool candidateAccepted, isValid;
            float angle;
            while (spawnPoints.Count > 0)
            {
                spawnIndex = rnd.Next(0, spawnPoints.Count);
                spawnCenter = spawnPoints[spawnIndex];
                candidateAccepted = false;
                for (i = 0; i < samplesBeforeReject; i++)
                {
                    angle = (float)rnd.NextDouble() * MathConstf.Tau;
                    dir.x = (float)System.Math.Sin(angle);
                    dir.y = (float)System.Math.Cos(angle);
                    candidate = spawnCenter + (dir * (MathConstf.Pi + MathConstf.Pi * (float)rnd.NextDouble()));
                    isValid = false;
                    if (candidate.x >= 0 && candidate.x < regionSize.x && candidate.y >= 0 && candidate.y < regionSize.y)
                    {
                        cellX = (int)(candidate.x / cellSize);
                        cellY = (int)(candidate.y / cellSize);
                        searchStartX = Math.Max(0, cellX - 2);
                        searchEndX = Math.Max(grid.GetLength(0) - 1, cellX + 2);
                        searchEndY = Math.Max(grid.GetLength(1) - 1, cellY + 2);
                        for (y = Math.Max(0, cellY - 2); y < searchEndY; y++)
                        {
                            for (x = searchStartX; x < searchEndX; x++)
                            {
                                pointIndex = grid[x, y] - 1;
                                if (pointIndex != -1)
                                {
                                    if ((candidate - points[pointIndex]).SqrMagnitude < radius * radius)
                                    {
                                        goto StopLoop;
                                    }
                                }
                            }
                        }
                        isValid = true;
                    }
                StopLoop:
                    if (isValid)
                    {
                        points.Add(candidate);
                        spawnPoints.Add(candidate);
                        grid[(int)(candidate.x / cellSize), (int)(candidate.y / cellSize)] = points.Count;
                        candidateAccepted = true;
                        break;
                    }
                }
                if (!candidateAccepted)
                {
                    spawnPoints.RemoveAt(spawnIndex);
                }
            }
            return points;
        }
    }
}
