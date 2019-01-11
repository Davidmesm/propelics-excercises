using System;

namespace Excercise8
{
    public class Matrix
    {
        public int[,] TransformZero(int[,] originalMatrix)
        {
            int[,] newMatrix = (int[,])originalMatrix.Clone();

            for (int x = 0; x < originalMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < originalMatrix.GetLength(1); y++)
                {
                    if (originalMatrix[x, y] == 0)
                    {
                        for (int i = 0; i < newMatrix.GetLength(0); i++)
                        {
                            newMatrix[i, y] = 0;
                        }
                        for (int j = 0; j < newMatrix.GetLength(1); j++)
                        {
                            newMatrix[x, j] = 0;
                        }
                    }
                }
            }

            return newMatrix;
        }
    }
}
