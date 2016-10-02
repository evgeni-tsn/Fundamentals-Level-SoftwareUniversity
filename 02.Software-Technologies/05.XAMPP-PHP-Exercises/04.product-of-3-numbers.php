<form>
    num1: <input type="text" name="num1"/>
    num2: <input type="text" name="num2"/>
    num3: <input type="text" name="num3"/>
    <input type="submit">
</form>

<?php
if (isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])) {
    $n1 = htmlspecialchars($_GET['num1']);
    $n2 = htmlspecialchars($_GET['num2']);
    $n3 = htmlspecialchars($_GET['num3']);
    $product = $n1*$n2*$n3;
    if ($product >= 0) {
        echo("positive");
    } else {
        echo("negative");
    }
}
?>