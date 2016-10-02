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
    $result = [];
    for ($i = 0; $i < count($arr); $i++) {
        $tokens = array_map('trim', explode($delimiter, $arr[$i]));
        $key = $tokens[0];
        $value = $tokens[1];
        $result[$key] = $value;
    }
    if (array_key_exists($keyWord, $result)) {
        foreach ($result as $key => $value) {
            if ($key == $keyWord) {
                echo $value;
            }
        }
    } else {
        echo "None";
    }
}
?>
</body>
</html>