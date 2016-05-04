<?php

$inputNumber = 145;
$result = null;

if ($inputNumber > 999){
    $inputNumber = 999;
}

if ($inputNumber > 100) {

    for ($i = 100; $i <= $inputNumber; $i++) {
        $str = (string)$i;
        if($str[0] != $str[1] && $str[1] != $str[2] && $str[0] != $str[2]) {
            $result .= $str . ', ';
        }
    }
}

if ($result != null) {
    $result = substr($result, 0, -2);
    echo $result;
}
else {
    echo 'no';
}

?>