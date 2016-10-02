<form>
    num1: <input type="text" name="num"/>
    <input type="submit">
</form>

<?php
if (isset($_GET['num'])) {
    $n1 = htmlspecialchars($_GET['num']);
    $fact = 1;
    for ($x = (int)$n1; $x >= 1; $x--) {
        $fact *= $x;
    }
    echo $fact . "\n";
}
?>