<!DOCTYPE html>
<html>
<head>
    <title>Delete Post from MySQL</title>
</head>
<body>

<?php
$mysqli = new mysqli('localhost', 'root', '', 'blog');
if ($mysqli->connect_errno)
    die('Cannot connect to MySQL');
$mysqli->set_charset("utf8");

if (isset($_GET['id'])) {
    $statement = $mysqli->prepare("DELETE FROM posts WHERE id = ?");
    $statement->bind_param("i", $_GET['id']);
    $statement->execute();
    session_start();
    if ($statement->affected_rows == 1)
        $_SESSION['msg'] = "Post deleted.";
    else
        $_SESSION['msg'] = "Error: cannot delete post.";
}
header("location: list-all.php");
?>

</body>
</html>
