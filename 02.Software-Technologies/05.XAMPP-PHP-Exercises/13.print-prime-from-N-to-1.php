<form>
    num1: <input type="text" name="num"/>
    <input type="submit">
</form>

<?php
if (isset($_GET['num'])) {
    $n1 = htmlspecialchars($_GET['num']);
    for ($x = (int)$n1; $x >= 1; $x--) {
        if (isPrime($x)){
            echo $x."\n";
        }
    }
}

function isPrime($num) {
//1 is not prime. See: http://en.wikipedia.org/wiki/Prime_number#Primality_of_one
    if($num == 1)
        return false;

//2 is prime (the only even number that is prime)
    if($num == 2)
        return false;

    /**
     * if the number is divisible by two, then it's not prime and it's no longer
     * needed to check other even numbers
     */
    if($num % 2 == 0) {
        return false;
    }

    /**
     * Checks the odd numbers. If any of them is a factor, then it returns false.
     * The sqrt can be an aproximation, hence just for the sake of
     * security, one rounds it to the next highest integer value.
     */
    for($i = 3; $i <= ceil(sqrt($num)); $i = $i + 2) {
        if($num % $i == 0)
            return false;
    }

    return true;
}
?>