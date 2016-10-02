<form>
    num1: <input type="text" name="num"/>
    <input type="submit">
</form>

<?php
if (isset($_GET['num'])) {
    $n1 = htmlspecialchars($_GET['num']);
    for ($x = 1; $x <= (int)$n1; $x++) {
        echo "<button>".$x."</button>";
    }
}
?>