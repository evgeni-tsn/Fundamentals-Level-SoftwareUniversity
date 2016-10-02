<html>
<head>

</head>
<body>
<form>
    Input:
    <br>
    <textarea name="input"></textarea>
    <br>
    Delimiter:
    <br>
    <input type="text" name="delimiter">
    <br>
    <input type="submit">
</form>
<?php
if (isset($_GET['input']) && isset($_GET['delimiter'])) {
    $delimiter = $_GET['delimiter'];
    $lines = array_filter(array_map('trim', explode("\n", $_GET['input'])));
    $nameTokens = explode($delimiter, $lines[0]);
    $name = $nameTokens[1];
    $surenameTokens = explode($delimiter, $lines[1]);
    $surname = $surenameTokens[1];
    $ageTokens = explode($delimiter, $lines[2]);
    $age = intval($ageTokens[1]);
    $gradeTokens = explode($delimiter, $lines[3]);
    $grade = floatval($gradeTokens[1]);
    $dateTokens = explode($delimiter, $lines[4]);
    $date = $dateTokens[1];
    $townTokens = explode($delimiter, $lines[5]);
    $town = $townTokens[1];
    $person = new Person($name, $surname, $age, $grade, $date, $town);
    $personJSON = objectToJSON($person);
    echo $personJSON;
}
function objectToJSON($person)
{
    echo json_encode($person, JSON_UNESCAPED_SLASHES);
}

class Person
{
    public $name;
    public $surname;
    public $age;
    public $grade;
    public $date;
    public $town;

    function __construct($name, $surname, $age, $grade, $date, $town)
    {
        $this->name = $name;
        $this->surname = $surname;
        $this->age = $age;
        $this->grade = $grade;
        $this->date = $date;
        $this->town = $town;
    }

    public function __toString()
    {
        return "name: $this->name; surname: $this->surname; age: $this->age; grade: $this->grade; date: $this->date; town: $this->town";
    }
}

?>
</body>
</html>