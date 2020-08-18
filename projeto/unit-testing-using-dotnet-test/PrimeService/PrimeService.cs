using System;

namespace PrimeService
{
    public class PrimeService
    {
        // Remove the unused private field
        const string CO_TESTE = "Teste";

        // Remove this commented out code
        // const string COMENTARIO_DE_CODIGO = "Teste";

        public bool IsPrime(int candidate)
        {
            Console.Write(CO_TESTE);

            if (candidate < 2)
            {
                return false;
            }

            for (var divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private const string CODE = "bounteous";
        private int callCount = 0;

        public string GetCode()
        {
            callCount++;
            return CODE;
        }

        public string GetName()  // Noncompliant
        {
            callCount++;
            return CODE;
        }
    }
}
