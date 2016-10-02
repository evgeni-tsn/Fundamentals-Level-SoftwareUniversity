<?php
if (isset($_GET['lines'])) {
    $towns = htmlspecialchars($_GET['lines']);
    $towns = explode("\n", $towns);
    $towns = array_map('trim', $towns);
    sort($towns, SORT_STRING);
    echo implode(" ", $towns);
}
?>

<form>
    <textarea name="lines" cols="30" rows="10"
    ><?php if (isset($towns)) echo implode("\n", $towns);?></textarea>
    <input type="submit" value="Sort">
</form>
