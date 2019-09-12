function showPrimes(n) {
  for (let i = 2; i < n; i++) if (isPrime(i)) console.log(i);
}

function isPrime(n) {
  for (let i = 2; i < n; i++) if (n % i == 0) return false;
  return true;
}

showPrimes(20);

//https://pt.stackoverflow.com/q/408772/101
