<?php



?><!DOCTYPE html>
<html>
<head>
    <title>Car Randomizer</title>
    <link rel="stylesheet" href="CarRandomizer.css">
</head>

<body>

<form method="post">
    Enter cars<input type="text" name="cars" />
    <input type="submit" value="Show Result" />

</form>

<?php
if (isset($_POST['cars'])) :
    $carsList = $_POST['cars'];
    //$cars = explode(',', $carsList);
    $cars = preg_split('/[ ,]+/', $carsList);
?>
    <table>
        <tr>
            <th>Car</th>
            <th>Color</th>
            <th>Count</th>
        </tr>
<?php
    $colors = ['red', 'yellow', 'blue', 'black', 'orange', 'silver'];
    foreach ($cars as $carName) :
        $count = rand(1, 5);
        $randColor = array_rand($colors);
?>
        <tr>
            <td><?= $carName ?></td>
            <td><?= $colors[$randColor] ?></td>
            <td><?= $count ?></td>
        </tr>
<?php
endforeach;
?>
    </table>
<?php
endif;
?>
</body>
</html>