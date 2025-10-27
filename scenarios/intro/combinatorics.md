package MathFun;

/*
This file contains a class that provides operations in the mathematical field of combinatorics.
*/
public class Combinatorics {
    /*
    define a public method named 'fact' that takes an integer 'n' and returns the factorial of 'n' using recursion:
    Implementation details:

    if n is less than or equal to 1, return 1
    return n * fact(n - 1)
    */
    public static long fact(int n) {
        if (n <= 1) {
            return 1L;
        }
        return n * fact(n - 1);
    }

    /*
    Define a public method named 'perm' that takes two integers 'n' and 'r' and returns the permutation of 'n' and 'r':
    Implementation details:

    The permutation of 'n' and 'r' is defined as n! / (n - r)!
    */
    public static long perm(int n, int r) {
        return fact(n) / fact(n - r);
    }
}


