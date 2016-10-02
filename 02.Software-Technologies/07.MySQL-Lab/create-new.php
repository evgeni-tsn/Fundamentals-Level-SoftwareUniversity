<!DOCTYPE html>
<html>
<head>
    <title>Create New Post in MySQL</title>
</head>
<body>

<a href='list-all.php'>[List All]</a>
<br><br>

<form>
    <div>Title</div><input type="text" name="title">
    <div>Content</div><textarea name="content"></textarea>
    <div><input type="submit" value="Create"></div>
</form>

<?php
if (isset($_GET['title'])) {
    $mysqli = new mysqli('localhost', 'root', '', 'blog');
    if ($mysqli->connect_errno)
        die('Cannot connect to MySQL');
    $mysqli->set_charset("utf8");

    $statement = $mysqli->prepare(
        "INSERT INTO posts(title, content) VALUES (?, ?)");
    $statement->bind_param("ss", $_GET['title'], $_GET['content']);
    $statement->execute();
    session_start();
    if ($statement->affected_rows == 1)
        $_SESSION['msg'] = "Post created.";
    else
        $_SESSION['msg'] = "Error: cannot create post.";
    header("location: list-all.php");
}
?>

</body>
</html>
