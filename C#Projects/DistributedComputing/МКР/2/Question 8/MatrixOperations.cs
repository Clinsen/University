public class MatrixOperations {
    public static double[,] GenerateMatrix(int rows, int columns) {
        double[,] matrix = new double[rows, columns];
        Random rand = new Random();

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                matrix[i, j] = rand.NextDouble() * 10;
            }
        }

        return matrix;
    }

    // по такій самій схемі це було зроблено в лабораторній, помилуйте грішного
    public static double[,] MultiplyMatricesBlock(double[,] A, double[,] B, int blockSize) {
        int m = A.GetLength(0);
        int n = A.GetLength(1);
        int l = B.GetLength(1);
        double[,] C = new double[m, l];

        for (int i = 0; i < m; i += blockSize) {
            for (int j = 0; j < l; j += blockSize) {
                for (int k = 0; k < n; k += blockSize) {
                    for (int ii = i; ii < Math.Min(i + blockSize, m); ii++) {
                        for (int jj = j; jj < Math.Min(j + blockSize, l); jj++) {
                            for (int kk = k; kk < Math.Min(k + blockSize, n); kk++) {
                                C[ii, jj] += A[ii, kk] * B[kk, jj];
                            }
                        }
                    }
                }
            }
        }

        return C;
    }

    public static void PrintMatrix(double[,] matrix) {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                Console.Write(matrix[i, j].ToString("F3") + "\t");
            }
            Console.WriteLine();
        }
    }
}