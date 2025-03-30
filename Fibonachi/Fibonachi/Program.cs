namespace Fibonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"F({n}) = {FibonacciMatrix.Fibonacci(n)}");
        }
    }
    public class FibonacciMatrix
    {
        static long[,] MatrixMultiply(long[,] A, long[,] B)
        {
            long[,] result = new long[2, 2];
            result[0, 0] = A[0, 0] * B[0, 0] + A[0, 1] * B[1, 0];
            result[0, 1] = A[0, 0] * B[0, 1] + A[0, 1] * B[1, 1];
            result[1, 0] = A[1, 0] * B[0, 0] + A[1, 1] * B[1, 0];
            result[1, 1] = A[1, 0] * B[0, 1] + A[1, 1] * B[1, 1];
            return result;
        }
        public static long Fibonacci(int n)
        {
            if (n == 0) return 0;
            long[,] mat = { { 1, 1 }, { 1, 0 } };
            long[,] matPow = MatrixPower(mat, n - 1);
            return matPow[0, 0];
        }
        static long[,] MatrixPower(long[,] mat, int power)
        {
            long[,] result = { { 1, 0 }, { 0, 1 } }; 
            while (power > 0)
            {
                if (power % 2 == 1)
                {
                    result = MatrixMultiply(result, mat);
                }
                mat = MatrixMultiply(mat, mat);
                power /= 2;
            }
            return result;
        }
    }
}
