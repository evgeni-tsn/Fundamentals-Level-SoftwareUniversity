

<form>
    num1: <input type="text" name="num"/>
    <input type="submit">
</form>

<?php
function getFib($n)
{
    return round(pow((sqrt(5)+1)/2, $n) / sqrt(5));
}

if (isset($_GET['num'])) {
    $n1 = htmlspecialchars($_GET['num']);
    for ($x = 1; $x <= (int)$n1; $x++) {
        echo getFib($x)."\n";
    }

}
?>