using System;
using MathNet.Numerics.LinearAlgebra;   // These guys must be downloaded from Nuget.
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.Optimization;
using MathNet.Numerics.Statistics.Mcmc;

namespace MathematicsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // A system of equations solver.
            Matrix<double> A = DenseMatrix.OfArray(new double[,] {
                {1,1,5},
                {1,2,3},
                {4,3,2}});

            var b = Vector<double>.Build.Dense(new double[] { 1, -2, Math.PI });
            var x = A.Solve(b);
            Console.WriteLine(x);


            // An example of computing correlation.
            var series = new double[10];

            for (int i = 0; i < 10; i++)
            { series[i] = Math.Cosh(i); }

            double result = MCMCDiagnostics.ACF(series, 10, x => x * x);

            Console.ReadKey();
        }
    }
}
