#!/usr/bin/ruby

CONST_N = 200

primes = Array.new
is_prime = Array.new(200, true)

for i in 0...200
	primes[i] = i;
    is_prime[i] = true;
end

for i in 2...200
    if is_prime[i]
        (i * i...CONST_N).step(i).each do |j|
            is_prime[j] = false
        end
    end
end

for i in 2...CONST_N
    if is_prime[i]
        puts(primes[i])
    end
end
