<html>
<body>
<form>
    Delimiter: <input type="text" name="delimiter">
    Array-size: <input type="text" name="array-size">
    Input: <textarea name="key-value-pairs"></textarea>
    <input type="submit">
</form>
</body>
</html>

<?php
if (isset($_GET['lines']) && isset($_GET['delimiter'])) {
    $delimiter = $_GET['delimiter'];
    $lines = $_GET['lines'];

    $arr = explode($delimiter, $lines);
    $arr = array_map('trim', $arr);
    for ($i = 0; $i < count($arr); $i++) {
        if ($arr[$i] == 'Stop') {
            break;
        }
        echo $arr[$i] . '<br>';
    }
}
?>