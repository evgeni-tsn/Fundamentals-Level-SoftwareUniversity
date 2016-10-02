<?php
if (isset($_GET['towns'])&&isset($_GET['townsToExclude'])) {
    $towns = htmlspecialchars($_GET['towns']);
    $towns = explode("\n", $towns);
    $towns = array_map('trim', $towns);

    $excludeTowns = htmlspecialchars($_GET['townsToExclude']);
    $excludeTowns = explode("\n", $excludeTowns);
    $excludeTowns = array_map('trim', $excludeTowns);

    $result = arrayDiff($towns, $excludeTowns);
    printAsList($result);
}

function printAsList(array $arr){
    echo "<ul>\n";
    foreach ($arr as $item){
        echo "<li>$item</li>\n";
    }
    echo "</ul>\n";
}

function arrayDiff(array $array ,array $arrToExcl){
    $result = [];
    foreach ($array as $item){
        if (!in_array($item, $arrToExcl)){
            $result[] = $item;
        }
    }
    return $result;
}
?>

<form>
    Towns:
    <textarea name="towns" cols="30" rows="10"></textarea>
    To exclude:
    <textarea name="excludeTowns" cols="30" rows="10"></textarea>
    <input type="submit" value="Exclude">
</form>
