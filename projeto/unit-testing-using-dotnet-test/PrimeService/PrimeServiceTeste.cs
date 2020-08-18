﻿using System;

namespace PrimeServiceTeste
{
    public class PrimeServiceTeste
    {       
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
    }

}
