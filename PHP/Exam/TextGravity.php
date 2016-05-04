<?php

$text = $_GET['text'];
$lineLength = $_GET['lineLength'];


$arrLenght = strlen($text) + $lineLength - strlen($text) % $lineLength;
//var_dump($arrLenght);
$textArr = array_fill(0, $arrLenght, " ");

for ($i = 0; $i < strlen($text); $i++) {
   $textArr[$i] = $text[$i];
}
//var_dump($textArr);

//for ($i = count($textArr) - 1; $i >= $lineLength; $i--) {
////    for ($j = count($textArr); $j < ) {
////
////    }
//    if ($textArr[$i] === " ") {
//        for ($j = $i; $j >= $lineLength; $j = $j - $lineLength) {
//            $textArr[$j] = $textArr[$j - $lineLength];
//            $textArr[$j - $lineLength] = " ";
//        }
//    }
//}

//for ($i = 0; $i < count($textArr) / $lineLength - 1; $i++) {
//    for ($j = count($textArr) - $i * $lineLength - 1; $j >= count($textArr) - ($i + 1) * $lineLength; $j--) {
//        if ($textArr[$j] === " ") {
//            for ($k = $j; $k >= $lineLength; $k = $k - $lineLength) {
//                $textArr[$k] = $textArr[$k - $lineLength];
//                $textArr[$k - $lineLength] = " ";
////                if (($textArr[$k - ($i + 1) * $lineLength] != " ") ) {
////                    break;
////                }
//            }
//        }
//    }
//
//}

for ($i = 0; $i < count($textArr) / $lineLength - 1; $i++) {
    for ($j = count($textArr) - $i * $lineLength - 1; $j >= count($textArr) - ($i + 1) * $lineLength; $j--) {
            $k = $j;
            while ($k >= $lineLength) {
                if ($textArr[$k] === " ") {
                    $textArr[$k] = $textArr[$k - $lineLength];
                    $textArr[$k - $lineLength] = " ";
                }
//                if (($textArr[$k - ($i + 1) * $lineLength] != " ") ) {
//                    break;
//                }
                $k = $k - $lineLength;
            }

    }

}

//var_dump($textArr);

$result = "<table>";
for ($i = 0; $i < count($textArr); $i++) {
    if ($i === 0) {
        $result .= "<tr>";
    }
    //var_dump($i + $lineLength);
    if ((($i + $lineLength) % $lineLength === 0) && $i > 0) {
        $result .= "</tr><tr>";
    }
    //var_dump(($i + $lineLength) % $lineLength == 0);
    $result .= "<td>" . htmlspecialchars($textArr[$i]) . "</td>";
    if ($i === count($textArr) - 1) {
        $result .= "</tr>";
    }
}

echo $result . "<table>";