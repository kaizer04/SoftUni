<?php

$firstNumber = 5;
$secondNumber = 2;
$formatSum = number_format(($firstNumber + $secondNumber), 2);
$output = '$firstNumber + $secondNumber = ' . $firstNumber . ' + ' . $secondNumber . ' = ' . $formatSum;

echo($output);

?>