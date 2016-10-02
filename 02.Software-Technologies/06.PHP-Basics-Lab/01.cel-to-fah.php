<form>
    cel: <input type="text" name="cel"/>
    fah: <input type="text" name="fah"/>
    <input type="submit">
</form>

<?php
if (isset($_GET['cel'])||isset($_GET['fah'])) {
    $cel = htmlspecialchars($_GET['cel']);
    $fah = htmlspecialchars($_GET['fah']);
    if ($cel != null) {
        $fahren = convertCelsiusToFahrenheit($cel);
        echo($cel . " deg c " . $fahren . " deg f");
    }
    else{
        $celsium = convertFahrenheitToCelsius($fah);
        echo($fah . " deg f " . $celsium . " deg c");
    }
}

function convertCelsiusToFahrenheit($cel)
{
    return ((9.0 / 5.0) * $cel) + 32;
}

function convertFahrenheitToCelsius($fah)
{
    return (5.0 / 9.0) * ($fah - 32);
}

?>