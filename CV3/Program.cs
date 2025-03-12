using System.Numerics;

class Program
{
    public static void Main()
    {
        
        Matrix matrix1 = new Matrix(new double[,] { { 1, 2 }, { 3, 4 } });
        Matrix matrix2 = new Matrix(new double[,] { { 5, 6 }, { 7, 8 } });
        Matrix matrix3 = new Matrix(new double[,] { { 1, 2, 3 }, { 5, 6, 0 } });
        Matrix matrix4 = new Matrix(new double[,] { { 1, 2, 3 }, { 5, 6, 0 }, { 5, 7, 8 } });

        Console.WriteLine("Matrix 1:");
        Console.WriteLine(matrix1.ToString());

        Console.WriteLine("Matrix 2:");
        Console.WriteLine(matrix2.ToString());

        
        Matrix sum = matrix1 + matrix2;
        Console.WriteLine("Matrix 1 + Matrix 2:");
        Console.WriteLine(sum.ToString());

        
        Matrix difference = matrix1 - matrix2;
        Console.WriteLine("Matrix 1 - Matrix 2:");
        Console.WriteLine(difference.ToString());

        
        Matrix product = matrix1 * matrix3;
        Console.WriteLine("Matrix 1 * Matrix 3:");
        Console.WriteLine(product.ToString());

        
        bool areEqual = matrix1 == matrix2;
        Console.WriteLine("Matrix 1 == Matrix 2: " + areEqual);

        
        bool areNotEqual = matrix1 != matrix2;
        Console.WriteLine("Matrix 1 != Matrix 2: " + areNotEqual);

        
        Matrix negMatrix1 = -matrix1;
        Console.WriteLine("Unary minus of Matrix 1:");
        Console.WriteLine(negMatrix1.ToString());

        
        double det2x2 = matrix1.Determinant();
        Console.WriteLine("Determinant of Matrix 1 (2x2): " + det2x2);

      
        Console.WriteLine("Matrix 4:");
        Console.WriteLine(matrix4.ToString());

        double det3x3 = matrix4.Determinant();
        Console.WriteLine("Determinant of Matrix 4: " + det3x3);
    }
}