#!/usr/bin/python

from array import array

CONST_N = 200

primes = array("I")
is_prime = [] # Couldn't use array(), because the array() doesn't has constructor that accept `bool`

for i in range(0, CONST_N):
	primes.append(i)
	is_prime.append(True)

for i in range(2, CONST_N):
	if is_prime[i]:
		for j in range(i * i, CONST_N, i):
			is_prime[j] = False

for i in range(2, CONST_N):
	if is_prime[i]:
		print(primes[i], end='\n')
