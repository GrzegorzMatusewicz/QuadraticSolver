using System;
using Xunit;
using QuadraticSolver;

namespace QuadraticSolver.Tests
{
    public class SolverTests
    {
        [Theory]
        [InlineData(1, -2, 1, 1)] // Poprawione oczekiwanie wartości 1
        public void Solve_OneRealRoot_ReturnsOneRoot(double a, double b, double c, double expectedRoot)
        {
            var result = Solver.Solve(a, b, c);
            Assert.Equal(1, result.Item1); // Oczekiwano jednego pierwiastka
            Assert.Equal(expectedRoot, result.Item2); // Sprawdzenie wartości pierwiastka
            Assert.Null(result.Item3); // Oczekiwano braku drugiego pierwiastka
        }
    }
}
