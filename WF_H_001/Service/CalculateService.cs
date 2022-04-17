using System;
using WF_H_001.Models;

namespace WF_H_001.Service
{
    public class CalculateService
    {
        public InputVo inputVo { get; set; }

        //formula
        public double[,] C
        {
            get => new double[3, 3]
            {
                { Math.Cos(inputVo.CurrentC), Math.Sin(inputVo.CurrentC), 0 },
                { -Math.Sin(inputVo.CurrentC), Math.Cos(inputVo.CurrentC), 0 },
                { 0, 0, 1 }
            };
        }
        public double[,] A
        {
            get => new double[3, 3]
            {
                { 1, 0, 0 },
                { 0, Math.Cos(inputVo.CurrentA), Math.Sin(inputVo.CurrentA) },
                { 0, -Math.Sin(inputVo.CurrentA), Math.Cos(inputVo.CurrentA) }
            };
        }
        public double[,] P1
        {
            get => new double[3, 1]
            {
                { inputVo.x1 },
                { inputVo.y1 },
                { inputVo.z1 }
            };
        }
        public double[,] S
        {
            get => new double[3, 1]
            {
                { 0 },
                { inputVo.yoa },
                { 0 }
            };
        }
        public double[,] Q
        {
            get => new double[3, 1]
            {
                { inputVo.xoc },
                { inputVo.yoc },
                { 0 }
            };
        }
        public double[,] M
        {
            get => new double[3, 1]
            {
                { 0 },
                { inputVo.yoa },
                { inputVo.zoa + inputVo.L }
            };
        }

        public double[,] P2 { get => GetP2(); }
        private double[,] GetP2()
        {
            // var result = A * ((C * (P1 - (Q + S)) + (Q + S)) - M) + M;
            var result = Add(Multi(A, Sub(Multi(C, Add(Sub(P1, Add(Q, S)), Add(Q, S))), M)), M);
            return result;
        }

        public double[,] Sub(double[,] Left, double[,] Right)
        {
            var minus = new double[Left.GetLength(0), Left.GetLength(1)];

            for (var i = 0; i < minus.GetLength(0); i++)
            {
                for (var j = 0; j < minus.GetLength(1); j++)
                {
                    minus[i, j] = Left[i, j] - Right[i, j];
                }
            }

            return minus;
        }

        public double[,] Add(double[,] Left, double[,] Right)
        {
            var sum = new double[Left.GetLength(0), Left.GetLength(1)];

            for (var i = 0; i < sum.GetLength(0); i++)
            {
                for (var j = 0; j < sum.GetLength(1); j++)
                {
                    sum[i, j] = Left[i, j] + Right[i, j];
                }
            }

            return sum;
        }

        public double[,] Multi(double[,] M, double Scalar)
        {
            var RM = new double[M.GetLength(0), M.GetLength(1)];

            for (var i = 0; i < RM.GetLength(0); i++)
            {
                for (var j = 0; j < RM.GetLength(1); j++)
                {
                    RM[i, j] = M[i, j] * Scalar;
                }
            }

            return RM;
        }

        public static double[,] Multi(double Scalar, double[,] M)
        {
            var RM = new double[M.GetLength(0), M.GetLength(1)];

            for (var i = 0; i < RM.GetLength(0); i++)
            {
                for (var j = 0; j < RM.GetLength(1); j++)
                {
                    RM[i, j] = M[i, j] * Scalar;
                }
            }

            return RM;
        }

        public static double[,] Multi(double[,] Left, double[,] Right)
        {
            if (Left.GetLength(1) != Right.GetLength(0))
            {
                return null;
            }

            var product = new double[Left.GetLength(0), Right.GetLength(1)];

            for (var i = 0; i < product.GetLength(0); i++)
            {
                for (var j = 0; j < product.GetLength(1); j++)
                {
                    product[i, j] = 0;
                    for (int k = 0; k < Left.GetLength(1); k++)
                    {
                        product[i, j] += Left[i, k] * Right[k, j];
                    }
                }
            }

            return product;
        }
    }

    /*
	public class Matrix2D
	{
		public int Row { get; set; }
		public int Column { get; set; }
		public double[,] Data { get; set; }

		public double this[int row, int col]
		{
			get { return Data[row, col]; }
			set { Data[row, col] = value; }
		}

		public Matrix2D(int row, int col)
		{
			Row = row;
			Column = col;
			Data = new double[row, col];

			for (var i = 0; i < row; i++)
			{
				for (var j = 0; j < col; j++)
				{
					Data[i, j] = 0;
				}
			}
		}

		public static Matrix2D operator -(Matrix2D Left, Matrix2D Right)
		{
			var minus = new Matrix2D(Left.Row, Left.Column);

			for (var i = 0; i < minus.Row; i++)
			{
				for (var j = 0; j < minus.Column; j++)
				{
					minus[i, j] = Left[i, j] - Right[i, j];
				}
			}

			return minus;
		}

		public static Matrix2D operator +(Matrix2D Left, Matrix2D Right)
		{
			var sum = new Matrix2D(Left.Row, Left.Column);

			for (var i = 0; i < sum.Row; i++)
			{
				for (var j = 0; j < sum.Column; j++)
				{
					sum[i, j] = Left[i, j] + Right[i, j];
				}
			}

			return sum;
		}

		public static Matrix2D operator *(Matrix2D M, double Scalar)
		{
			var RM = new Matrix2D(M.Row, M.Column);

			for (var i = 0; i < RM.Row; i++)
			{
				for (var j = 0; j < RM.Column; j++)
				{
					RM[i, j] = M[i, j] * Scalar;
				}
			}

			return RM;
		}

		public static Matrix2D operator *(double Scalar, Matrix2D M)
		{
			var RM = new Matrix2D(M.Row, M.Column);

			for (var i = 0; i < RM.Row; i++)
			{
				for (var j = 0; j < RM.Column; j++)
				{
					RM[i, j] = M[i, j] * Scalar;
				}
			}

			return RM;
		}

		public static Matrix2D operator *(Matrix2D Left, Matrix2D Right)
		{
			if (Left.Column != Right.Row)
			{
				return null;
			}

			var product = new Matrix2D(Left.Row, Right.Column);

			for (var i = 0; i < product.Row; i++)
			{
				for (var j = 0; j < product.Column; j++)
				{
					product[i, j] = 0;
					for (int k = 0; k < Left.Column; k++)
					{
						product[i, j] += Left[i, k] * Right[k, j];
					}
				}
			}

			return product;
		}
	}
	*/
}
