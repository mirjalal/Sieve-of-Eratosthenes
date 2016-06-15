<?php
	$N = 200;
    $primes = array();
    $is_prime = array();

    for ($i = 0; $i < $N; $i++) { 
        $primes[$i] = $i;
        $is_prime[$i] = true;
    }

    for ($i = 2; $i < $N; $i++) { 
        if ($is_prime[$i]) {
            for ($j = $i * $i; $j < $N; $j += $i) 
                $is_prime[$j] = false;
        }
    }

    for ($i = 2; $i < $N; $i++) { 
        if ($is_prime[$i])
            echo $primes[$i] . '<br>';
    }
?>
