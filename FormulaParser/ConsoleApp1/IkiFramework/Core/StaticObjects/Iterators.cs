using System;
namespace IkiCore
{
    public static class Iterators
    {
        public static void ForI<T>(int maxI, Action<int> actionToElement)
        {
            for (int i = 0; i < maxI; i++)
            {
                actionToElement(i);
            }
        }
        public static void ForIJ<T>(int maxI, int maxJ, Action<int, int> actionToElement)
        {
            for (int i = 0; i < maxI; i++)
            {
                for (int j = 0; j < maxJ; j++)
                {
                    actionToElement(j, i);
                }
            }
        }
        public static void ForIJK<T>(int maxI, int maxJ, int maxK, Action<int, int, int> actionToElement)
        {
            for (int i = 0; i < maxI; i++)
            {
                for (int j = 0; j < maxJ; j++)
                {
                    for (int k = 0; k < maxK; k++)
                    {
                        actionToElement(k, j, i);
                    }
                }
            }
        }
    }
}
