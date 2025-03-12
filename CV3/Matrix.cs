using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Matrix
{
    private double[,] matice;

    public Matrix(double[,] matice)
    {
        this.matice = matice;
    }
    private int RowSize
    {
        get
        {
            return matice.GetLength(0);
        }
    }

    private int ColumnSize
    {
        get
        {
            return matice.GetLength(1);
        }
    }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.RowSize != b.ColumnSize || a.ColumnSize != b.RowSize)
        {
            throw new Exception("Incompatible matrix size");
        }
        double[,] resultMatrix = new double[a.RowSize, a.ColumnSize];
        for (int i = 0; i <a.RowSize; i++)
        {
            for(int j = 0; j <a.ColumnSize; j++)
            {
                resultMatrix[i,j]=a.matice[i,j]+b.matice[i,j];
            }
        }
        return new Matrix(resultMatrix);
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.RowSize != b.RowSize || a.ColumnSize != b.ColumnSize)
        {
            throw new Exception("Incompatible matrix size");
        }
        double[,] resultMatrix = new double[a.RowSize, a.ColumnSize];
        for (int i = 0; i < a.RowSize; i++)
        {
            for (int j = 0; j < a.ColumnSize; j++)
            {
                resultMatrix[i, j] = a.matice[i, j] - b.matice[i, j];
            }
        }
        return new Matrix(resultMatrix);
    }

    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.ColumnSize != b.RowSize)
        {
            throw new Exception("Incompatible matrix size for multiplication");
        }
        double[,] resultMatrix = new double[a.RowSize, b.ColumnSize];
        for (int i = 0; i < a.RowSize; i++)
        {
            for (int j = 0; j < b.ColumnSize; j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < a.ColumnSize; k++)  
                {
                    resultMatrix[i, j] += a.matice[i, k] * b.matice[k, j];
                }
            }
        }
        return new Matrix(resultMatrix);
    }

    public static bool operator ==(Matrix a, Matrix b)
    {
        if (a.RowSize != b.RowSize || a.ColumnSize != b.ColumnSize)
        {
            return false;
        }
        for (int i = 0; i < a.RowSize; i++)
        {
            for (int j = 0; j < a.ColumnSize; j++)
            {
                if (a.matice[i, j] != b.matice[i, j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static bool operator !=(Matrix a, Matrix b)
    {
        return !(a == b);
    }

    public static Matrix operator -(Matrix a)
    {
        double[,] resultMatrix = new double[a.RowSize, a.ColumnSize];
        for (int i = 0; i < a.RowSize; i++)
        {
            for (int j = 0; j < a.ColumnSize; j++)
            {
                resultMatrix[i, j] = -a.matice[i, j];
            }
        }
        return new Matrix(resultMatrix);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        for (int i = 0; i < RowSize; i++)
        {
            for (int j = 0; j < ColumnSize; j++)
            {
                sb.Append(matice[i, j].ToString("F2") + "\t"); 
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }

    
    public double Determinant()
    {
        if (RowSize != ColumnSize)
        {
            throw new Exception("Matrix must be square to calculate determinant.");
        }

        if (RowSize == 2)
        {
            
            return matice[0, 0] * matice[1, 1] - matice[0, 1] * matice[1, 0];
        }
        else if (RowSize == 3)
        {
            return matice[0, 0] * (matice[1, 1] * matice[2, 2] - matice[1, 2] * matice[2, 1]) -
                   matice[0, 1] * (matice[1, 0] * matice[2, 2] - matice[1, 2] * matice[2, 0]) +
                   matice[0, 2] * (matice[1, 0] * matice[2, 1] - matice[1, 1] * matice[2, 0]);
        }
        else
        {
            throw new Exception("Determinant can only be calculated for matrices up to 3x3.");
        }
    }


}

