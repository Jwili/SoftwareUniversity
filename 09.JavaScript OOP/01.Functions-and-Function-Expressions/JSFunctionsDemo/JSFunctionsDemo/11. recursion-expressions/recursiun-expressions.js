var factorial = function actorial(n) {
    if (n === 0) {
        return 1;
    }
    return n * actorial(n - 1);
};

console.log(factorial(5));

var fact = factorial;
console.log(fact(5));

factorial = function () {
    return 'NOT FACTORIAL';
};

console.log(fact(5));