using System;
using Xunit;
using QuadraticSolver;

namespace QuadraticSolver.Tests
{
    public class SolverTests
    {
        [Theory]
        [InlineData(1, 0, 1)] // Brak pierwiastków rzeczywistych (∆ < 0)
        public void Solve_NoRealRoots_ReturnsZeroRoots(double a, double b, double c)
        {
            var result = Solver.Solve(a, b, c);
            Assert.Equal(0, result.Item1); // Oczekiwane 0 pierwiastków
            Assert.Null(result.Item2);
            Assert.Null(result.Item3);
        }

        [Theory]
        [InlineData(1, -2, 1, 1)] // Jeden pierwiastek rzeczywisty (∆ = 0)
        public void Solve_OneRealRoot_ReturnsOneRoot(double a, double b, double c, double expectedRoot)
        {
            var result = Solver.Solve(a, b, c);
            Assert.Equal(1, result.Item1); // Oczekiwane 1 pierwiastek
            Assert.Equal(expectedRoot, result.Item2);
            Assert.Null(result.Item3);
        }

        [Theory]
        [InlineData(1, -3, 2, 2, 1)] // Dwa pierwiastki rzeczywiste (∆ > 0)
        public void Solve_TwoRealRoots_ReturnsTwoRoots(double a, double b, double c, double expectedRoot1, double expectedRoot2)
        {
            var result = Solver.Solve(a, b, c);
            Assert.Equal(2, result.Item1); // Oczekiwane 2 pierwiastki
            Assert.Equal(expectedRoot1, result.Item2);
            Assert.Equal(expectedRoot2, result.Item3);
        }
    }
}
