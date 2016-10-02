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
    $lines = array_filter(array_map('trim', explode("\n", $_GET['input'])));
    $delimiter = $_GET['delimiter'];
    $students = [];
    foreach ($lines as $line) {
        $tokens = array_map('trim', explode($delimiter, $line));
        $name = $tokens[0];
        $age = $tokens[1];
        $grade = floatval($tokens[2]);
        $student = new Student($name, $age, $grade);
        $students[] = $student;
    }
    foreach ($students as $student) {
        echo "<ul>";
        echo "<li>" . "Name: " . $student->getName() . "</li>";
        echo "<li>" . "Age: " . $student->getAge() . "</li>";
        echo "<li>" . "Grade: " . $student->getGrade() . "</li>";
        echo "</ul>";
    }
}

class Student
{
    private $name;
    private $age;
    private $grade;

    function __construct($name, $age, $grade)
    {
        $this->name = $name;
        $this->age = $age;
        $this->grade = $grade;
    }

    function getName()
    {
        return $this->name;
    }

    function getAge()
    {
        return $this->age;
    }

    function getGrade()
    {
        return $this->grade;
    }
}

?>
</body>
</html>