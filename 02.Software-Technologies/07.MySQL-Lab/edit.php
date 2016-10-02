<!DOCTYPE html>
<html>
<head>
    <title>Edit Existing Post from MySQL</title>
</head>
<body>

<a href='list-all.php'>[List All]</a>
<a href='create-new.php'>[Create New]</a>
<br><br>

<?php
$mysqli = new mysqli('localhost', 'root', '', 'blog');
if ($mysqli->connect_errno)
    die('Cannot connect to MySQL');
$mysqli->set_charset("utf8");

if (isset($_GET['title'])) {
    // The edit form was submitted -> save the changes in MySQL
    $statement = $mysqli->prepare(
        "UPDATE posts SET title = ?, content = ?, date = ? WHERE id = ?");
    $statement->bind_param("sssi",
        $_GET['title'], $_GET['content'], $_GET['date'], $_GET['id']);
    $statement->execute();
    session_start();
    if ($statement->affected_rows == 1)
        $_SESSION['msg'] = "Post edited.";
    else
        $_SESSION['msg'] = "Error: cannot edit post.";
    header("location: list-all.php");
}
else if (isset($_GET['id'])) {
    // Show the post to be edited in a HTML form
    $query = $mysqli->prepare(
        "SELECT id, title, content, date FROM posts WHERE id = ?");
    $query->bind_param("i", $_GET['id']);
    $query->execute();
    $post = $query->get_result()->fetch_assoc();
    session_start();
    if (!isset($post['id'])) {
        $_SESSION['msg'] = "Post not found.";
        header("location: list-all.php");
        die;
    }
    $id = htmlspecialchars($post['id']);
    $title = htmlspecialchars($post['title']);
    $content = htmlspecialchars($post['content']);
    $date = htmlspecialchars($post['date']);
?>
    <form>
        <input type="hidden" name="id" value="<?=$id?>" />
        <div>Title</div><input type="text" name="title" value="<?=$title?>" />
        <div>Content</div><textarea name="content"><?=$content?></textarea>
        <div>Date</div><input type="text" name="date" value="<?=$date?>" />
        <div><input type="submit" value="Edit"></div>
    </form>
<?php
} else {
    // Parameter 'id' not found --> redirect to the main page
    session_start();
    $_SESSION['msg'] = "Post not specified.";
    header("location: list-all.php");
}
?>

</body>
</html>
