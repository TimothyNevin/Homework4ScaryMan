using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IFactorialService
    {
        public int GenerateFactorial(int value) {

            int factorial = value;
            for (int i = value - 1; i >= 1; i--)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }
}
