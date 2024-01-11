using Services.Interfaces;

namespace Services.Services
{
    public class FactorialService : IFactorialService
    {
        public int GenerateFactorial(int value)
        {
            int factorial = value;
            for (int i = value - 1; i >= 1; i--)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }
}
