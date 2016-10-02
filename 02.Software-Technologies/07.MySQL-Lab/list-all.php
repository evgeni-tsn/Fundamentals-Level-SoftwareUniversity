<!DOCTYPE html>
<html>
<head>
    <title>All Posts from MySQL</title>
    <style>
        th, td { background: #DDD;}
        .msg {
            background: #dda531;
            margin: 10px;
            padding:5px;
            border-radius: 5px
        }
    </style>
</head>
<body>

<?php
session_start();
if (isset($_SESSION['msg']))
    echo "<div class='msg'>" . htmlspecialchars($_SESSION['msg']). "</div>";
unset($_SESSION['msg']);
?>

<a href='list-all.php'>[List All]</a>
<a href='create-new.php'>[Create New]</a>
<br><br>

<?php
$mysqli = new mysqli('localhost', 'root', '', 'blog');
if ($mysqli->connect_errno)
    die('Cannot connect to MySQL');
$mysqli->set_charset("utf8");
$result = $mysqli->query(
    'SELECT id, title, content, date FROM posts ORDER BY date DESC');
if (!$result)
    die('Cannot read `posts` table from MySQL');
echo "<table>\n";
echo "<tr><th>Title</th><th>Content</th><th>Date</th><th>Actions</th></tr>\n";
while ($row = $result->fetch_assoc()) {
    $id = htmlspecialchars($row['id']);
    $title = htmlspecialchars($row['title']);
    $content = htmlspecialchars($row['content']);
    $date = (new DateTime($row['date']))->format('d.m.Y');
    echo "<tr><td>$title</td><td>$content</td><td>$date</td><td>" .
        "<a href='delete.php?id=$id'>[Delete]</a> " .
        "<a href='edit.php?id=$id'>[Edit]</a></td></tr>\n";
}
echo "</table>\n";
?>
</body>
</html>
