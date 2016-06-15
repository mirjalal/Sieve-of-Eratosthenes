#include <iostream>

int main()
{
	const unsigned int N = 200;

	unsigned int primes[200];
	bool is_prime[200];

	for (unsigned int i = 0; i < N; i++)
	{
		primes[i] = i;
		is_prime[i] = true;
	}

	for (unsigned int i = 2; i < N; i++)
	{
		if (is_prime[i])
		{
			for (unsigned int j = i * i; j < N; j += i)
				is_prime[j] = false;
		}
	}

	for (unsigned int i = 2; i < N; i++)
	{
		if (is_prime[i])
			std::cout << primes[i] << std::endl;
	}

	return 0;
}
