var N = 200;
var primes = [];
var is_prime = [];

for (var i = 0; i < N; ++i) {
	primes.push(i);
	is_prime.push(true);
}

for (var i = 2; i < N; i++) {
	if (is_prime[i]) {
		for (var j = i+i; j < N; j += i)
			is_prime[j] = false;
	}
}

for (var i = 2; i < N; i++) {
    if (is_prime[i])
        console.log(primes[i]);
}
