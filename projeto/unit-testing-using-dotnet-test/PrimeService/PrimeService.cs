using System;

namespace PrimeService
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
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
        
        // --------------
        // Remove the unused private field
        const string CO_TESTE = "Teste";

        
        // --------------
        // Remove this commented out code
        // const string COMENTARIO_DE_CODIGO = "Teste";

        // --------------
        // Update this method so that its implementation is not identical
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

        // --------------
        public void GetTeste(string Teste)
        {
            Console.Write(Teste);
        }

        // --------------
        // Related "if/else if" statements should not have the same condition
        public void teste(int param)
        {
            if (param == 1)
            {
                Console.Write("Param 1");
            }
            else if (param == 2)
            {
                Console.Write("Param 2");
            }
            else if (param == 1) // Não conforme
            {
                Console.Write("Mesmo param");
            }
        }

        // --------------
        // Parameters should be passed in the correct order
        public double Divide(double divisor, double dividend)
        {
            return divisor / dividend;
        }

        public void DoTheThing()
        {
            double divisor = 15;
            double dividend = 5;

            double result = Divide(dividend, divisor);  // Noncompliant; operation succeeds, but result is unexpected
                                                        //...
        }

        // --------------
        // Unused method parameters should be removed
        void DoSomething(int a, int b) // "b" is unused
        {
            Console.Write(a);
        }

        void DoSomething2(int a) // value of "a" is unused
        {
            a = 10;
            Console.Write(a);
        }
    }
}
