using System;

namespace QuadraticSolver
{
    public class Solver
    {
        public static (int, double?, double?) Solve(double a, double b, double c)
        {
            if (a == 0)
                throw new ArgumentException("Parameter 'a' cannot be zero for a quadratic equation.");

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
                return (0, null, null); // Brak pierwiastków rzeczywistych
            if (discriminant == 0)
            {
                double root = -b / (2 * a);
                return (1, root, null); // Jeden pierwiastek rzeczywisty
            }
            else
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return (2, root1, root2); // Dwa pierwiastki rzeczywiste
            }
        }
    }
}
