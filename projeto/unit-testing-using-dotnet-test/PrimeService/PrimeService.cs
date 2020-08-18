using System;

namespace PrimeService
{
    public class PrimeService
    {
        const string CO_TESTE = "Teste";
        const string teste1 = "Teste";
        //string teste = "teste";
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
    }

}
