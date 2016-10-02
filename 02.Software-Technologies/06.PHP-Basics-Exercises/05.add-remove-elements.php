<html>
<head>

</head>
<body>
<form>
    Delimiter: <input type="text" name="delimiter">
    Input: <textarea name="commands"></textarea>
    <input type="submit">
</form>
<?php
if (isset($_GET['delimiter']) && isset($_GET['commands'])) {
    $delimiter = $_GET['delimiter'];
    $arr = array_filter(array_map('trim', explode("\n", $_GET['commands'])));
    $result = [];
    for ($i = 0; $i < count($arr); $i++) {
        $tokens = array_map('trim', explode($delimiter, $arr[$i]));
        $command = $tokens[0];
        $index = $tokens[1];
        if ($command == "add") {
            $result[] = $tokens[1];
        } else {
            array_splice($result, $tokens[1], 1);
        }
    }
    foreach ($result as $item) {
        echo $item . "<br>";
    }
}
?>
</body>
</html>