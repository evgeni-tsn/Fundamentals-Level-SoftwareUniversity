<html>
<head>

</head>
<body>
<form>
    Start Date:
    <br>
    <input type="text" name="date">

    <br>
    Output Format:
    <br>
    <input type="text" name="format">
    <br>
    Commands:
    <br>
    <textarea name="commands"></textarea>
    <br>
    <input type="submit">
</form>
<?php
if (isset($_GET['date']) && isset($_GET['format']) && isset($_GET['commands'])) {
    date_default_timezone_set('Europe/Sofia');
    $date = DateTime::createFromFormat("d/m/Y", $_GET['date']);
    $format = $_GET['format'];
    $lines = array_filter(array_map('trim', explode("\n", $_GET['commands'])));
    foreach ($lines as $line) {
        $tokens = explode(" ", $line);
        $command = $tokens[0];
        $value = $tokens[1];
        if ($command == "add") {
            $date->add(new DateInterval(("P" . $value . "D")));
        } else if ($command == "subtract") {
            $date->sub(new DateInterval("P" . $value . "D"));
        }
    }
    echo $date->format($format);
}
?>
</body>
</html>