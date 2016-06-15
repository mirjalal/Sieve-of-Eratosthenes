namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main()
        {
            const uint N = 200;

            uint[] primes = new uint[200];
            bool[] is_prime = new bool[200];

            for (uint i = 0; i < N; i++)
            {
                primes[i] = i;
                is_prime[i] = true;
            }

            for (uint i = 2; i < N; i++)
            {
                if (is_prime[i])
                {
                    for (uint j = i * i; j < N; j += i)
                        is_prime[j] = false;
                }
            }

            for (uint i = 2; i < N; i++)
            {
                if (is_prime[i])
                    System.Console.WriteLine(primes[i]);
            }
        }
    }
}
