<form>
    num1: <input type="text" name="num"/>
    <input type="submit">
</form>

<?php
if (isset($_GET['num'])) {
    $n1 = htmlspecialchars($_GET['num']);
    for ($x = (int)$n1; $x >= 1; $x--) {
        echo $x."\n";
    }
}
?>