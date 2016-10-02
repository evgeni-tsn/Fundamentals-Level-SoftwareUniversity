<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
    </style>
</head>
<body>
    <?php
//        $mainColor = 0;
//        for ($x = 1; $x <= 5; $x++) {
//            for ($y = 1; $y <= 10; $y++) {
//                    $background = 'background:rgb('.$mainColor.', .'.$mainColor.', '.$mainColor.')';
//                echo '<div style=$background></div>';
//                $mainColor += 5;
//            }
//            echo '</br>';
//            $mainColor = $x*51;
//        }
    ?>
    <?php
    $mainColor = 0;
    for ($x = 1; $x <= 5; $x++) {
        for ($y = 1; $y <= 10; $y++) {
            $color = "rgb($mainColor, $mainColor, $mainColor)";
            echo "<div style=\"background-color: $color;\"></div>";
            $mainColor += 5;
        }
        echo "<br>";
        $mainColor = $x*51;
    }
    ?>
</body>
</html>

