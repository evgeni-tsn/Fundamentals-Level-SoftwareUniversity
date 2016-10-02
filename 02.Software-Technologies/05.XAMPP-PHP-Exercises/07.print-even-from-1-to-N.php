<form>
    num1: <input type="text" name="num"/>
    <input type="submit">
</form>

<?php
if (isset($_GET['num'])) {
    $n1 = htmlspecialchars($_GET['num']);
    for ($x = 2; $x <= (int)$n1; $x+=2) {
        echo $x."\n";
    }
}
?>