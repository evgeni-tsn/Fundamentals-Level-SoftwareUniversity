<form>
    num1: <input type="text" name="num"/>
    <input type="submit">
</form>

<?php
function getTribonacci($n)
{
    if ($n == 1) {
        return 1;
    } else if ($n == 2) {
        return 1;
    } else if ($n == 3) {
        return 2;
    } else {
        $sum = 0;
        $n1 = 1;
        $n2 = 1;
        $n3 = 2;
        for ($i = 4; $i <= $n; $i++) {
            $sum = $n1 + $n2 + $n3;
            $n1 = $n2;
            $n2 = $n3;
            $n3 = $sum;
        }
        return $sum;
    }
}

if (isset($_GET['num'])) {
    $n1 = htmlspecialchars($_GET['num']);
    for ($x = 1; $x <= (int)$n1; $x++) {
        echo getTribonacci($x) . "\n";
    }

}
?>

