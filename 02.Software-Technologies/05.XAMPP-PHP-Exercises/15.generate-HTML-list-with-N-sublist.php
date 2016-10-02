<form>
    num1: <input type="text" name="num1"/>
    num2: <input type="text" name="num2"/>
    <input type="submit">
</form>

<?php
if (isset($_GET['num1']) && isset($_GET['num2'])) {
    $n1 = htmlspecialchars($_GET['num1']);
    $n2 = htmlspecialchars($_GET['num2']);
    echo "<ul>";
    for ($x = 1; $x <= (int)$n1; $x++) {
        echo "<li>List " . $x;
        echo "<ul>";
        for ($y = 1; $y <= (int)$n2; $y++) {
            echo '<li>Element ' . $x . "." . $y . "</li>";
        }
        echo "</ul>";
        echo "</li>";
    }
    echo "</ul>";
}
?>