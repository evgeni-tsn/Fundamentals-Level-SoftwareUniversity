<html>
<head>

</head>
<body>
<form>
    Delimiter: <input type="text" name="delimiter">
    Input: <textarea name="key-value-pairs"></textarea>
    Target Key: <input type="text" name="target-key">
    <input type="submit">
</form>
<?php
if (isset($_GET['delimiter']) && isset($_GET['key-value-pairs']) && isset($_GET['target-key'])) {
    $delimiter = $_GET['delimiter'];
    $keyWord = $_GET['target-key'];
    $arr = array_filter(array_map('trim', explode("\n", $_GET['key-value-pairs'])));
    $tempArr = [];
    for ($i = 0; $i < count($arr); $i++) {
        $tempArr[] = $arr[$i];
    }
    $result = [];
    foreach ($tempArr as $item) {
        $tokens = array_map('trim', explode($delimiter, $item));
        $key = $tokens[0];
        $value = $tokens[1];
        if ($key == $keyWord) {
            $result[] = $value;
        }
    }
    if (intval(count($result) > 0)) {
        echo implode("<br>", $result);
    } else {
        echo "None";
    }
}
?>
</body>
</html>