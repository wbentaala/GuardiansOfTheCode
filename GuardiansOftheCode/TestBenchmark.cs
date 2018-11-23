using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOftheCode
{
    public class TestBenchmark
    {
        [Benchmark]
        public void Fibonacci(int n)
        {
            int b = 1;
            int a = 0, c = 0;
            
            if (n == 0 || n == 1)
                c = 1;
            else
            {
                for(int i=2; i<n; i++)
                {
                    a = b;
                    c = b + a;
                    b = c;
                }
                Console.WriteLine(c);
            }
        }
        
    }
}
